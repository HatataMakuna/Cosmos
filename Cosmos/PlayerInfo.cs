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

        public PlayerInfo(Player player)
        {
            _currentPlayer = player;
            InitializeComponent();

            // Player Profile
            lblPlayerName.Text += _currentPlayer.name;
            lblPlayerLevel.Text += _currentPlayer.level.ToString();
            lblPlayerExperience.Text += _currentPlayer.experience.ToString();

            int expPercentage = (int)Math.Round(
                Convert.ToDecimal(_currentPlayer.GetExperiencePercentage())
            );
            //Console.WriteLine($"{_currentPlayer.experience / _currentPlayer.GetExperienceForNextLevel()}");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
