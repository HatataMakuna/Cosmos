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
            ToggleAllAddButtons();

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

            // Player Stats
            lblAvailablePoints.Text += _currentPlayer.availablePoints.ToString();
            lblSpeedStat.Text = _currentPlayer.speed.ToString();
            lblTechStat.Text = _currentPlayer.tech.ToString();
            lblGripStat.Text = _currentPlayer.grip.ToString();
            lblStrengthStat.Text = _currentPlayer.strength.ToString();
            lblEnduranceStat.Text = _currentPlayer.endurance.ToString();
            lblAgilityStat.Text = _currentPlayer.agility.ToString();
            lblBalanceStat.Text = _currentPlayer.balance.ToString();
            lblLacheStat.Text = _currentPlayer.lache.ToString();
            lblStaminaStat.Text = _currentPlayer.stamina.ToString();
            lblIntelligenceStat.Text = _currentPlayer.intelligence.ToString();
        }

        private void ToggleAllAddButtons()
        {
            bool hasAvailablePoints = _currentPlayer.availablePoints > 0;
            // Enable Add Buttons if player has available points
            btnAddSpeed.Enabled = hasAvailablePoints;
            btnAddTech.Enabled = hasAvailablePoints;
            btnAddGrip.Enabled = hasAvailablePoints;
            btnAddStrength.Enabled = hasAvailablePoints;
            btnAddEndurance.Enabled = hasAvailablePoints;
            btnAddAgility.Enabled = hasAvailablePoints;
            btnAddBalance.Enabled = hasAvailablePoints;
            btnAddLache.Enabled = hasAvailablePoints;
            btnAddStamina.Enabled = hasAvailablePoints;
            btnAddIntelligence.Enabled = hasAvailablePoints;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "speed")
            {
                lblSpeedStat.Text = _currentPlayer.speed.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "tech")
            {
                lblTechStat.Text = _currentPlayer.tech.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "grip")
            {
                lblGripStat.Text = _currentPlayer.grip.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "strength")
            {
                lblStrengthStat.Text = _currentPlayer.strength.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "endurance")
            {
                lblEnduranceStat.Text = _currentPlayer.endurance.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "agility")
            {
                lblAgilityStat.Text = _currentPlayer.agility.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "balance")
            {
                lblBalanceStat.Text = _currentPlayer.balance.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "lache")
            {
                lblLacheStat.Text = _currentPlayer.lache.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "stamina")
            {
                lblStaminaStat.Text = _currentPlayer.stamina.ToString();
            }
            else if (propertyChangedEventArgs.PropertyName == "intelligence")
            {
                lblIntelligenceStat.Text = _currentPlayer.intelligence.ToString();
            }
            lblAvailablePoints.Text = "Available Points: " + _currentPlayer.availablePoints.ToString();
            ToggleAllAddButtons();
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
