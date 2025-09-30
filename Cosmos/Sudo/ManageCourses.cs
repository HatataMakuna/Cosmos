using Cosmos.Model;
using Cosmos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cosmos.Sudo
{
    public partial class ManageCourses : Form
    {
        private List<Course> courses = new List<Course>();
        private List<Obstacle> obstacles = new List<Obstacle>();
        private Course originalCourse = null;

        public ManageCourses(List<Course> loadedCourses, List<Obstacle> loadedObstacles)
        {
            InitializeComponent();

            courses = loadedCourses ?? new List<Course>();
            obstacles = loadedObstacles ?? new List<Obstacle>();

            LoadCourses();
            LoadObstacles();
        }

        private void LoadCourses()
        {
            lstCourses.Items.Clear();
            foreach (var course in courses)
            {
                lstCourses.Items.Add(course.Name);
            }
        }

        private void LoadObstacles()
        {
            lstObstacles.Items.Clear();
            foreach (var obstacle in obstacles)
            {
                lstObstacles.Items.Add(obstacle.name);
            }
        }

        private void ToggleControls(bool enabled)
        {
            btnAddStage.Enabled = enabled;
            btnDeleteCourse.Enabled = enabled;
            btnAddObstacleToStage.Enabled = enabled;
            btnRemoveObstacleFromStage.Enabled = enabled;
            txtStageName.Enabled = enabled;
            btnEditStageName.Enabled = enabled;
            tabStages.Enabled = enabled;
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstCourses.SelectedIndex;
            if (index >= 0 && index < courses.Count)
            {
                originalCourse = courses[index];
                ToggleControls(true);

                // Load stages as tabs
                LoadStagesAsTabs(originalCourse);
            }
            else
            {
                tabStages.TabPages.Clear();
                ToggleControls(false);
                txtStageName.Clear();
            }
        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            string newCourseName = Microsoft.VisualBasic.Interaction.InputBox("Enter new course name:", "New Course");
            if (string.IsNullOrWhiteSpace(newCourseName))
            {
                MessageBox.Show("Course name cannot be empty.");
                return;
            }

            Course course = new Course(
                iD: courses.Count > 0 ? courses.Max(c => c.ID) + 1 : 1,
                name: newCourseName,
                stages: new List<Stage>()
            );

            courses.Add(course);
            lstCourses.Items.Add(course.Name);
            lstCourses.SelectedIndex = lstCourses.Items.Count - 1;

            MessageBox.Show("New course created. Please add stages and obstacles as needed.");
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = lstCourses.SelectedIndex;
                    courses.RemoveAt(index);
                    lstCourses.Items.RemoveAt(index);
                    originalCourse = null;

                    // Reset stages tab and controls
                    lstCourses.SelectedIndex = -1;
                    ToggleControls(false);
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }
        }

        private void btnManageObstacles_Click(object sender, EventArgs e)
        {
            ManageObstacles manageObstacles = new ManageObstacles(obstacles);
            manageObstacles.ShowDialog();
            LoadObstacles();
        }

        private void btnAddStage_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a course first.", "No Course Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Auto-generate stage name as "Stage X"
            int stageNumber = originalCourse.Stages.Count + 1;
            string stageName = $"Stage {stageNumber}";

            // Create new stage
            Stage newStage = new Stage(
                stageNumber.ToString(), // Using stage number as ID
                stageName,
                new List<Obstacle>(),
                false, 0 // Default time limit 0
            );

            // Add to course
            originalCourse.Stages.Add(newStage);

            // Create a new tab for this stage
            TabPage tabPage = new TabPage(stageName);
            tabPage.Tag = newStage;

            // Create a ListBox for obstacles in this stage
            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            listBox.Name = "lstObstacles_" + newStage.ID;

            tabPage.Controls.Add(listBox);
            tabStages.TabPages.Add(tabPage);
            tabStages.SelectedTab = tabPage;
            txtStageName.Text = stageName;

            MessageBox.Show($"Stage '{stageName}' added successfully! You can edit the name if needed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddObstacleToStage_Click(object sender, EventArgs e)
        {
            // Validate selections
            if (lstCourses.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a course first.", "No Course Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tabStages.TabPages.Count == 0)
            {
                MessageBox.Show("Please add a stage to the course first.", "No Stage Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstObstacles.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an obstacle to add.", "No Obstacle Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected stage from the current tab
            Stage selectedStage = tabStages.SelectedTab.Tag as Stage;
            if (selectedStage == null)
            {
                MessageBox.Show("Error accessing the selected stage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the selected obstacle to the stage
            Obstacle selectedObstacle = obstacles[lstObstacles.SelectedIndex];
            selectedStage.Obstacles.Add(selectedObstacle);

            DragDropListBox stageObstaclesListBox = tabStages.SelectedTab.Controls.OfType<DragDropListBox>().FirstOrDefault();
            if (stageObstaclesListBox != null)
            {
                stageObstaclesListBox.Items.Add(selectedObstacle.name);
            }

            //MessageBox.Show($"Obstacle '{selectedObstacle.name}' added to stage '{selectedStage.Name}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveObstacleFromStage_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex < 0 || tabStages.TabPages.Count == 0)
            {
                MessageBox.Show("Please select a course and a stage first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DragDropListBox stageObstaclesListBox = tabStages.SelectedTab.Controls.OfType<DragDropListBox>().FirstOrDefault();
            if (stageObstaclesListBox == null || stageObstaclesListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an obstacle in the stage to remove.", "No Obstacle Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected stage from the current tab
            Stage selectedStage = tabStages.SelectedTab.Tag as Stage;
            if (selectedStage == null)
            {
                MessageBox.Show("Error accessing the selected stage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected obstacle name
            string selectedObstacleName = stageObstaclesListBox.SelectedItem.ToString();

            // Find and remove the obstacle from the stage
            Obstacle obstacleToRemove = selectedStage.Obstacles.FirstOrDefault(o => o.name == selectedObstacleName);
            if (obstacleToRemove != null)
            {
                selectedStage.Obstacles.Remove(obstacleToRemove);
                stageObstaclesListBox.Items.RemoveAt(stageObstaclesListBox.SelectedIndex);
                MessageBox.Show($"Obstacle '{obstacleToRemove.name}' removed from stage '{selectedStage.Name}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error removing obstacle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStagesAsTabs(Course course)
        {
            tabStages.TabPages.Clear();

            if (course.Stages != null && course.Stages.Count > 0)
            {
                foreach (var stage in course.Stages)
                {
                    // Create a tab page for each stage
                    TabPage tabPage = new TabPage(stage.Name);
                    tabPage.Tag = stage; // Store the stage object in the tag property

                    // Create a ListBox for obstacles in this stage
                    DragDropListBox listBox = new DragDropListBox();
                    listBox.Dock = DockStyle.Fill;
                    listBox.Name = "lstObstacles_" + stage.ID;

                    listBox.ItemsReordered += (sender, args) =>
                    {
                        // Update the order of obstacles in the stage based on the new order in the ListBox
                        List<Obstacle> reorderedObstacles = new List<Obstacle>();
                        foreach (var item in listBox.Items)
                        {
                            Obstacle obs = stage.Obstacles.FirstOrDefault(o => o.name == item.ToString());
                            if (obs != null)
                            {
                                reorderedObstacles.Add(obs);
                            }
                        }
                        stage.Obstacles = reorderedObstacles;
                    };

                    // Populate the ListBox with obstacles
                    foreach (var obstacle in stage.Obstacles)
                    {
                        listBox.Items.Add(obstacle.name);
                    }

                    tabPage.Controls.Add(listBox);
                    tabStages.TabPages.Add(tabPage);
                }

                if (tabStages.TabPages.Count > 0)
                {
                    tabStages.SelectedIndex = 0;
                    // Update the stage name textbox with the selected stage name
                    Stage selectedStage = tabStages.SelectedTab.Tag as Stage;
                    txtStageName.Text = selectedStage?.Name ?? "";

                    if (selectedStage != null)
                    {
                        txtStageName.Text = selectedStage.Name;

                        // Set radio button based on HasTimeLimit
                        rbNoTimeLimit.Checked = !selectedStage.HasTimeLimit;
                        rbUseTimeLimit.Checked = selectedStage.HasTimeLimit;

                        // Set the time limit text
                        txtTimeLimit.Text = selectedStage.TimeLimit.ToString();
                    }
                }
            }
            else
            {
                txtStageName.Clear();
            }
        }

        private void tabStages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabStages.SelectedTab != null)
            {
                Stage selectedStage = tabStages.SelectedTab.Tag as Stage;
                if (selectedStage != null)
                {
                    txtStageName.Text = selectedStage.Name;

                    rbNoTimeLimit.Checked = !selectedStage.HasTimeLimit;
                    rbUseTimeLimit.Checked = selectedStage.HasTimeLimit;

                    txtTimeLimit.Text = selectedStage.TimeLimit.ToString();
                }
            }
            else
            {
                txtStageName.Clear();
                rbNoTimeLimit.Checked = true;
                rbUseTimeLimit.Checked = false;
                txtTimeLimit.Text = "0";
            }
        }

        private void btnEditStageName_Click(object sender, EventArgs e)
        {
            if (tabStages.SelectedTab != null && !string.IsNullOrWhiteSpace(txtStageName.Text))
            {
                Stage selectedStage = tabStages.SelectedTab.Tag as Stage;
                if (selectedStage != null)
                {
                    selectedStage.Name = txtStageName.Text;
                    tabStages.SelectedTab.Text = txtStageName.Text;
                    MessageBox.Show("Stage name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a stage and enter a valid name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbUseTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable textbox based on radio button selection
            txtTimeLimit.Enabled = rbUseTimeLimit.Checked;
        }

        private void btnApplyTimeLimit_Click(object sender, EventArgs e)
        {
            if (tabStages.SelectedTab != null)
            {
                Stage selectedStage = tabStages.SelectedTab.Tag as Stage;
                if (selectedStage != null)
                {
                    // Update stage properties
                    selectedStage.HasTimeLimit = rbUseTimeLimit.Checked;

                    // Safely parse the time limit value
                    int timeLimit = 0;
                    if (rbUseTimeLimit.Checked && int.TryParse(txtTimeLimit.Text, out timeLimit))
                    {
                        selectedStage.TimeLimit = timeLimit;
                    }
                    else
                    {
                        selectedStage.TimeLimit = 0;
                    }

                    MessageBox.Show("Time limit settings applied!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}