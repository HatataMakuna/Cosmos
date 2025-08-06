using Cosmos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cosmos
{
    public partial class ManageObstacles : Form
    {
        List<Obstacle> obstacles = new List<Obstacle>();
        private Obstacle originalObstacle = null;
        private bool isNewObstacle = false;

        public ManageObstacles(List<Obstacle> obs)
        {
            InitializeComponent();

            obstacles = obs;
            LoadObstaclesList();
        }

        private void LoadObstaclesList()
        {
            lstObstacles.Items.Clear();
            foreach (var obstacle in obstacles)
            {
                lstObstacles.Items.Add(obstacle.name);
            }
        }

        private void HandleNumericInput(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace)
            if (char.IsControl(e.KeyChar))
                return;
            // Allow digits and decimal point
            if (!Regex.IsMatch((sender as TextBox).Text + e.KeyChar, @"^[1-9]\d*[.]?(\d+)?$"))
                e.Handled = true;
        }

        private void LoadDetails(Obstacle currentObstacle)
        {
            if (currentObstacle != null)
            {
                tbName.Text = currentObstacle.name;
                rtbDescription.Text = currentObstacle.description;
                nudDifficulty.Value = currentObstacle.difficulty;
                nudRequiredLevel.Value = currentObstacle.requiredLevel;
                ntbBaseSpeed.Text = currentObstacle.speed.ToString();
                ntbBaseTech.Text = currentObstacle.tech.ToString();
                ntbBaseGrip.Text = currentObstacle.grip.ToString();
                ntbBaseStrength.Text = currentObstacle.strength.ToString();
                ntbBaseEndurance.Text = currentObstacle.endurance.ToString();
                ntbBaseAgility.Text = currentObstacle.agility.ToString();
                ntbBaseBalance.Text = currentObstacle.balance.ToString();
                ntbBaseLache.Text = currentObstacle.lache.ToString();
                ntbBaseStamina.Text = currentObstacle.stamina.ToString();
                ntbBaseIntelligence.Text = currentObstacle.intelligence.ToString();

                // Clear all checked items in the checked list box
                for (int j = 0; j < clbTags.Items.Count; j++)
                {
                    clbTags.SetItemChecked(j, false);
                }

                // Check the items that match the tags of the selected obstacle
                foreach (var tag in currentObstacle.tags)
                {
                    string tagToCheck = char.ToUpper(tag[0]) + tag.Substring(1);
                    int idx = clbTags.Items.IndexOf(tagToCheck);
                    if (idx >= 0)
                    {
                        clbTags.SetItemChecked(idx, true);
                    }
                }

                ToggleTextFields(true);
            }
            else
            {
                tbName.Clear();
                rtbDescription.Clear();
                nudDifficulty.Value = 1;
                nudRequiredLevel.Value = 1;
                ntbBaseSpeed.Clear();
                ntbBaseTech.Clear();
                ntbBaseGrip.Clear();
                ntbBaseStrength.Clear();
                ntbBaseEndurance.Clear();
                ntbBaseAgility.Clear();
                ntbBaseBalance.Clear();
                ntbBaseLache.Clear();
                ntbBaseStamina.Clear();
                ntbBaseIntelligence.Clear();
                // Uncheck all items in the checked list box
                for (int j = 0; j < clbTags.Items.Count; j++)
                {
                    clbTags.SetItemChecked(j, false);
                }
                ToggleTextFields(false);
            }
        }

        private void ToggleTextFields(bool enable)
        {
            tbName.Enabled = enable;
            rtbDescription.Enabled = enable;
            nudDifficulty.Enabled = enable;
            nudRequiredLevel.Enabled = enable;
            clbTags.Enabled = enable;
            ntbBaseSpeed.Enabled = enable;
            ntbBaseTech.Enabled = enable;
            ntbBaseGrip.Enabled = enable;
            ntbBaseStrength.Enabled = enable;
            ntbBaseEndurance.Enabled = enable;
            ntbBaseAgility.Enabled = enable;
            ntbBaseBalance.Enabled = enable;
            ntbBaseLache.Enabled = enable;
            ntbBaseStamina.Enabled = enable;
            ntbBaseIntelligence.Enabled = enable;
        }

        private void CheckForChanges()
        {
            if (originalObstacle == null)
            {
                btnSave.Enabled = false;
                btnReset.Enabled = false;
                return;
            }

            bool changed =
                tbName.Text != originalObstacle.name ||
                rtbDescription.Text != originalObstacle.description ||
                nudDifficulty.Value != originalObstacle.difficulty ||
                nudRequiredLevel.Value != originalObstacle.requiredLevel ||
                ntbBaseSpeed.Text != originalObstacle.speed.ToString() ||
                ntbBaseTech.Text != originalObstacle.tech.ToString() ||
                ntbBaseGrip.Text != originalObstacle.grip.ToString() ||
                ntbBaseStrength.Text != originalObstacle.strength.ToString() ||
                ntbBaseEndurance.Text != originalObstacle.endurance.ToString() ||
                ntbBaseAgility.Text != originalObstacle.agility.ToString() ||
                ntbBaseBalance.Text != originalObstacle.balance.ToString() ||
                ntbBaseLache.Text != originalObstacle.lache.ToString() ||
                ntbBaseStamina.Text != originalObstacle.stamina.ToString() ||
                ntbBaseIntelligence.Text != originalObstacle.intelligence.ToString() ||
                !TagsMatch();

            btnSave.Enabled = changed;
            btnReset.Enabled = changed;
        }

        private bool TagsMatch()
        {
            var checkedTags = clbTags.CheckedItems.Cast<string>().ToList();
            var originalTags = originalObstacle.tags ?? new List<string>();
            if (checkedTags.Count != originalTags.Count)
                return false;
            return !checkedTags.Except(originalTags, StringComparer.OrdinalIgnoreCase).Any() &&
                   !originalTags.Except(checkedTags, StringComparer.OrdinalIgnoreCase).Any();
        }

        private void SaveChanges()
        {
            var tags = clbTags.CheckedItems.Cast<string>();
            if (isNewObstacle)
            {
                // Add new obstacle using factory method
                var newObstacle = Obstacle.CreateFromForm(
                    obstacles.Count + 1,
                    tbName.Text,
                    rtbDescription.Text,
                    (int)nudDifficulty.Value,
                    (int)nudRequiredLevel.Value,
                    tags,
                    ntbBaseSpeed.Text,
                    ntbBaseTech.Text,
                    ntbBaseGrip.Text,
                    ntbBaseStrength.Text,
                    ntbBaseEndurance.Text,
                    ntbBaseAgility.Text,
                    ntbBaseBalance.Text,
                    ntbBaseLache.Text,
                    ntbBaseStamina.Text,
                    ntbBaseIntelligence.Text
                );
                obstacles.Add(newObstacle);

                lstObstacles.Items.Add(tbName.Text);
                lstObstacles.Enabled = true;
                MessageBox.Show("New obstacle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDetails(null);
            }
            else
            {
                int i = lstObstacles.SelectedIndex;
                if (i >= 0 && i < obstacles.Count)
                {
                    // Update existing obstacle using factory method
                    var updated = Obstacle.CreateFromForm(
                        obstacles[i].ID,
                        tbName.Text,
                        rtbDescription.Text,
                        (int)nudDifficulty.Value,
                        (int)nudRequiredLevel.Value,
                        tags,
                        ntbBaseSpeed.Text,
                        ntbBaseTech.Text,
                        ntbBaseGrip.Text,
                        ntbBaseStrength.Text,
                        ntbBaseEndurance.Text,
                        ntbBaseAgility.Text,
                        ntbBaseBalance.Text,
                        ntbBaseLache.Text,
                        ntbBaseStamina.Text,
                        ntbBaseIntelligence.Text,
                        obstacles[i].timeLimit
                    );
                    obstacles[i] = updated;
                    lstObstacles.Items[i] = updated.name;
                    originalObstacle = new Obstacle(
                        updated.ID,
                        updated.name,
                        updated.description,
                        updated.difficulty,
                        updated.requiredLevel,
                        new List<string>(updated.tags),
                        updated.timeLimit,
                        updated.speed,
                        updated.tech,
                        updated.grip,
                        updated.strength,
                        updated.endurance,
                        updated.agility,
                        updated.balance,
                        updated.lache,
                        updated.stamina,
                        updated.intelligence
                    );
                    MessageBox.Show("Obstacle details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            CheckForChanges();
        }

        private bool ValidateFields()
        {
            // Check if at least one stat field is filled
            if (string.IsNullOrWhiteSpace(ntbBaseSpeed.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseTech.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseGrip.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseStrength.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseEndurance.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseAgility.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseBalance.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseLache.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseStamina.Text) &&
                string.IsNullOrWhiteSpace(ntbBaseIntelligence.Text))
            {
                MessageBox.Show("Please fill at least one stat field before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            // Validation for info tab fields
            else if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Obstacle name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Obstacle description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false; // No validation errors
            }
        }

        private void lstObstacles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstObstacles.SelectedIndex;
            if (i >= 0 && i < lstObstacles.Items.Count)
            {
                LoadDetails(obstacles[i]);

                // Store the original obstacle for comparison later
                originalObstacle = new Obstacle(
                    obstacles[i].ID,
                    obstacles[i].name,
                    obstacles[i].description,
                    obstacles[i].difficulty,
                    obstacles[i].requiredLevel,
                    new List<string>(obstacles[i].tags),
                    obstacles[i].timeLimit,
                    obstacles[i].speed,
                    obstacles[i].tech,
                    obstacles[i].grip,
                    obstacles[i].strength,
                    obstacles[i].endurance,
                    obstacles[i].agility,
                    obstacles[i].balance,
                    obstacles[i].lache,
                    obstacles[i].stamina,
                    obstacles[i].intelligence
                );

                btnDeleteObstacle.Enabled = true;
            }
        }

        private void AnyFieldChanged(object sender, EventArgs e)
        {
            CheckForChanges();
        }

        private void clbTags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Delay check until after the item is checked/unchecked
            this.BeginInvoke((MethodInvoker)delegate { CheckForChanges(); });
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (isNewObstacle)
            {
                ToggleTextFields(false);
                lstObstacles.Enabled = true;
                btnNewObstacle.Enabled = true;
                isNewObstacle = false;
                originalObstacle = null;
                // Clear all fields
                LoadDetails(null);
            }
            else
            {
                // Reset to original obstacle details
                LoadDetails(originalObstacle);
            }
            CheckForChanges();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasValidationError = ValidateFields();
            if (hasValidationError)
            {
                return; // Stop saving if validation fails
            }
            // Apply changes to the selected obstacle
            SaveChanges();
        }

        private void btnNewObstacle_Click(object sender, EventArgs e)
        {
            // If an existing obstacle is selected, clear the selection and the form
            if (lstObstacles.SelectedIndex >= 0)
            {
                lstObstacles.ClearSelected();
                LoadDetails(null);
            }

            ToggleTextFields(true);
            lstObstacles.Enabled = false;
            btnNewObstacle.Enabled = false;
            originalObstacle = new Obstacle();
            isNewObstacle = true;
        }

        private void btnDeleteObstacle_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            if (MessageBox.Show("Are you sure to delete this obstacle?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                obstacles.RemoveAt(lstObstacles.SelectedIndex);
                MessageBox.Show("Obstacle deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the form fields
                LoadDetails(null);
                originalObstacle = null;
                CheckForChanges();

                // Update the list box
                LoadObstaclesList();
            }
        }
    }
}