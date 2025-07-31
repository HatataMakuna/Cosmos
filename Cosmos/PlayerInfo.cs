using Cosmos.Core;
using Cosmos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmos
{
    public partial class PlayerInfo : Form
    {
        private Player _currentPlayer;
        private EditPlayerStats _editPlayerStats;

        public event EventHandler<Player> PlayerDeleted;

        public PlayerInfo(Player player)
        {
            _currentPlayer = player;
            InitializeComponent();
            _editPlayerStats = new EditPlayerStats(_currentPlayer);

            InitPlayerInfo();
            UpdateStatControls();

            _editPlayerStats.PropertyChanged += OnPropertyChanged;
        }

        private void InitPlayerInfo()
        {
            // Player Profile
            lblPlayerName.Text += _currentPlayer.name;
            lblPlayerLevel.Text += _currentPlayer.level.ToString();
            lblPlayerExperience.Text += _currentPlayer.experience.ToString();

            int expPercentage = (int)Math.Round(
                Convert.ToDecimal(_currentPlayer.GetExperiencePercentage())
            );
            pbExpProgress.Value = expPercentage;
            lblExpPercentage.Text = $"{expPercentage}%";
            lblNoAttemptedObstacles.Text += _currentPlayer.noAttemptedObstacles.ToString();
            lblNoCompletedObstacles.Text += _currentPlayer.noCompletedObstacles.ToString();

            UpdateStatLabels();
        }

        private void UpdateStatLabels()
        {
            lblAvailablePoints.Text = "Available Points: " + _editPlayerStats.EditedAvailablePoints.ToString();
            lblSpeedStat.Text = _editPlayerStats.GetEditedStat("Speed").ToString();
            lblTechStat.Text = _editPlayerStats.GetEditedStat("Tech").ToString();
            lblGripStat.Text = _editPlayerStats.GetEditedStat("Grip").ToString();
            lblStrengthStat.Text = _editPlayerStats.GetEditedStat("Strength").ToString();
            lblEnduranceStat.Text = _editPlayerStats.GetEditedStat("Endurance").ToString();
            lblAgilityStat.Text = _editPlayerStats.GetEditedStat("Agility").ToString();
            lblBalanceStat.Text = _editPlayerStats.GetEditedStat("Balance").ToString();
            lblLacheStat.Text = _editPlayerStats.GetEditedStat("Lache").ToString();
            lblStaminaStat.Text = _editPlayerStats.GetEditedStat("Stamina").ToString();
            lblIntelligenceStat.Text = _editPlayerStats.GetEditedStat("Intelligence").ToString();
        }

        private void UpdateStatControls()
        {
            // Add buttons
            btnAddSpeed.Enabled = _editPlayerStats.CanAddStat("Speed");
            btnAddTech.Enabled = _editPlayerStats.CanAddStat("Tech");
            btnAddGrip.Enabled = _editPlayerStats.CanAddStat("Grip");
            btnAddStrength.Enabled = _editPlayerStats.CanAddStat("Strength");
            btnAddEndurance.Enabled = _editPlayerStats.CanAddStat("Endurance");
            btnAddAgility.Enabled = _editPlayerStats.CanAddStat("Agility");
            btnAddBalance.Enabled = _editPlayerStats.CanAddStat("Balance");
            btnAddLache.Enabled = _editPlayerStats.CanAddStat("Lache");
            btnAddStamina.Enabled = _editPlayerStats.CanAddStat("Stamina");
            btnAddIntelligence.Enabled = _editPlayerStats.CanAddStat("Intelligence");

            // Minus buttons
            btnMinusSpeed.Enabled = _editPlayerStats.CanMinusStat("Speed");
            btnMinusTech.Enabled = _editPlayerStats.CanMinusStat("Tech");
            btnMinusGrip.Enabled = _editPlayerStats.CanMinusStat("Grip");
            btnMinusStrength.Enabled = _editPlayerStats.CanMinusStat("Strength");
            btnMinusEndurance.Enabled = _editPlayerStats.CanMinusStat("Endurance");
            btnMinusAgility.Enabled = _editPlayerStats.CanMinusStat("Agility");
            btnMinusBalance.Enabled = _editPlayerStats.CanMinusStat("Balance");
            btnMinusLache.Enabled = _editPlayerStats.CanMinusStat("Lache");
            btnMinusStamina.Enabled = _editPlayerStats.CanMinusStat("Stamina");
            btnMinusIntelligence.Enabled = _editPlayerStats.CanMinusStat("Intelligence");

            // Enable the save and reset button if there are changes
            btnReset.Enabled = _editPlayerStats.HasChanges();
            btnSaveStat.Enabled = _editPlayerStats.HasChanges();
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            UpdateStatLabels();
            UpdateStatControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddSpeed_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Speed");
        }

        private void btnAddTech_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Tech");
        }

        private void btnAddGrip_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Grip");
        }

        private void btnAddStrength_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Strength");
        }

        private void btnAddEndurance_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Endurance");
        }

        private void btnAddAgility_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Agility");
        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Balance");
        }

        private void btnAddLache_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Lache");
        }

        private void btnAddStamina_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Stamina");
        }

        private void btnAddIntelligence_Click(object sender, EventArgs e)
        {
            _editPlayerStats.AddStat("Intelligence");
        }

        private void btnMinusSpeed_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Speed");
        }

        private void btnMinusTech_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Tech");
        }

        private void btnMinusGrip_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Grip");
        }

        private void btnMinusStrength_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Strength");
        }

        private void btnMinusEndurance_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Endurance");
        }

        private void btnMinusAgility_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Agility");
        }

        private void btnMinusBalance_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Balance");
        }

        private void btnMinusLache_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Lache");
        }

        private void btnMinusStamina_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Stamina");
        }

        private void btnMinusIntelligence_Click(object sender, EventArgs e)
        {
            _editPlayerStats.MinusStat("Intelligence");
        }

        private void btnSaveStat_Click(object sender, EventArgs e)
        {
            _editPlayerStats.SaveStats();
            MessageBox.Show("Player stats saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateStatLabels();
            UpdateStatControls();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _editPlayerStats.ResetStats();
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete this player? This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Raise delete player event
                PlayerDeleted?.Invoke(this, _currentPlayer);

                MessageBox.Show("Player deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
