using Cosmos.Model;
using Cosmos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmos
{
    public partial class ManageObstacles : Form
    {
        List<Obstacle> obstacles = new List<Obstacle>();
        private Obstacle originalObstacle = null;

        public ManageObstacles(List<Obstacle> obs)
        {
            InitializeComponent();

            obstacles = obs;
            lstObstacles.Items.Clear();
            foreach (var obstacle in obs)
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
                nudDifficulty.Text = currentObstacle.difficulty.ToString();
                nudRequiredLevel.Text = currentObstacle.requiredLevel.ToString();
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
                nudDifficulty.Text != originalObstacle.difficulty.ToString() ||
                nudRequiredLevel.Text != originalObstacle.requiredLevel.ToString() ||
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

        private void ntbBaseSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseTech_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseGrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseStrength_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseEndurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseAgility_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseLache_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseStamina_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void ntbBaseIntelligence_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
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
            LoadDetails(originalObstacle);
            CheckForChanges();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Apply changes to the selected obstacle
            int i = lstObstacles.SelectedIndex;
            if (i >= 0 && i < obstacles.Count)
            {
                obstacles[i].name = tbName.Text;
                obstacles[i].description = rtbDescription.Text;
                obstacles[i].difficulty = (int)nudDifficulty.Value;
                obstacles[i].requiredLevel = (int)nudRequiredLevel.Value;
                obstacles[i].speed = double.Parse(ntbBaseSpeed.Text);
                obstacles[i].tech = double.Parse(ntbBaseTech.Text);
                obstacles[i].grip = double.Parse(ntbBaseGrip.Text);
                obstacles[i].strength = double.Parse(ntbBaseStrength.Text);
                obstacles[i].endurance = double.Parse(ntbBaseEndurance.Text);
                obstacles[i].agility = double.Parse(ntbBaseAgility.Text);
                obstacles[i].balance = double.Parse(ntbBaseBalance.Text);
                obstacles[i].lache = double.Parse(ntbBaseLache.Text);
                obstacles[i].stamina = double.Parse(ntbBaseStamina.Text);
                obstacles[i].intelligence = double.Parse(ntbBaseIntelligence.Text);
                // Update tags
                obstacles[i].tags.Clear();
                foreach (var item in clbTags.CheckedItems)
                {
                    string tagToAdd = item.ToString().ToLower();
                    if (!obstacles[i].tags.Contains(tagToAdd))
                    {
                        obstacles[i].tags.Add(tagToAdd);
                    }
                }
                // Refresh the list box
                lstObstacles.Items[i] = obstacles[i].name;
                // Reset original obstacle to current state
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
                CheckForChanges();
                MessageBox.Show("Obstacle details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}