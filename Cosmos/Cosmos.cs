using Cosmos.Model;
using Cosmos.Data;
using Cosmos.Core;
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
    public partial class Cosmos : Form
    {
        private List<Player> players = new List<Player>();
        private List<Obstacle> obstacles = new List<Obstacle>();
        private List<Channel> channels = new List<Channel>();

        private InitData initData;
        private AttemptEvent attemptEvent = new AttemptEvent();

        public Cosmos()
        {
            InitializeComponent();

            // Initialize data
            initData = new InitData();
            initData.Initialize();
            LoadData();
        }

        private void LoadData()
        {
            // Assign data from InitData
            players = initData.Players;
            obstacles = initData.Obstacles;
            channels = initData.Channels;

            // Populate ListBox with player names
            lstPlayers.Items.Clear(); // Clear existing items
            foreach (var player in players)
            {
                lstPlayers.Items.Add(player.name);
            }

            lstChannels.Items.Clear(); // Clear existing items
            foreach (var channel in channels)
            {
                lstChannels.Items.Add(channel.name);
            }
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player
            {
                ID = players.Count + 1,
                name = $"Player {players.Count + 1}",
                availablePoints = 0,
                speed = 10,
                tech = 10,
                grip = 10,
                strength = 10,
                balance = 10,
                lache = 10,
                stamina = 10,
                intelligence = 10
            };
            players.Add(newPlayer);

            // Update ListBox
            lstPlayers.Items.Add(newPlayer.name);
            lstPlayers.SelectedIndex = lstPlayers.Items.Count - 1; // Auto-select new player
        }

        private void btnNewChannel_Click(object sender, EventArgs e)
        {
            Channel newChannel = new Channel
            {
                ID = channels.Count + 1,
                name = $"Channel {channels.Count + 1}",
                currentLevel = 1,
                currentObstacle = obstacles.Count > 0 ? obstacles[0] : null // Assign first obstacle if available
            };
            channels.Add(newChannel);
            // Update ListBox
            lstChannels.Items.Add(newChannel.name);
            lstChannels.SelectedIndex = lstChannels.Items.Count - 1; // Auto-select new channel
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle player selection change
            int index = lstPlayers.SelectedIndex;
            if (index >= 0 && index < players.Count)
            {
                Model.Player selectedPlayer = players[index];
                // Display player info as needed
                //MessageBox.Show($"Selected: {selectedPlayer.name}, Level: {selectedPlayer.level}");
            }
        }

        private void lstChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle channel selection change
            int index = lstChannels.SelectedIndex;
            if (index >= 0 && index < channels.Count)
            {
                Channel selectedChannel = channels[index];
                lblObsLevelNo.Text = selectedChannel.currentLevel.ToString();
                lblObsName.Text = selectedChannel.currentObstacle?.name ?? "N/A";
                // Display channel info as needed
                // MessageBox.Show($"Selected: {selectedChannel.name}, Current Level: {selectedChannel.currentLevel}");
            }
        }

        private void btnAttempt_Click(object sender, EventArgs e)
        {
            // Check if a player and channel are selected, if no player or channel is selected, show a message box
            if (lstPlayers.SelectedIndex < 0 || lstChannels.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a player and a channel before attempting.");
                return;
            } else
            {
                attemptEvent.AttemptObstacle(
                    players[lstPlayers.SelectedIndex],
                    channels[lstChannels.SelectedIndex]
                );
            }
        }
    }
}
