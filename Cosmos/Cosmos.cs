using Cosmos.Core;
using Cosmos.Data;
using Cosmos.Model;
using Cosmos.Service;
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

        private InitData initData = new InitData();
        private AttemptEvent _attemptEvent;

        public Cosmos()
        {
            InitializeComponent();

            // Initialize data
            initData.Initialize();
            _attemptEvent = new AttemptEvent(initData);
            LoadData();

            // Subscribe to the attempt event
            _attemptEvent.OnMessage += DisplayMessage;
            _attemptEvent.PropertyChanged += OnPropertyChanged;
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

        private void DisplayMessage(object sender, MessageEventArgs messageEventArgs)
        {
            rtbMessages.Text += messageEventArgs.Message + Environment.NewLine;
            if (messageEventArgs.AddExtraNewLine)
            {
                rtbMessages.Text += Environment.NewLine;
            }
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "currentObstacle")
            {
                lblObsLevelNo.Text = channels[lstChannels.SelectedIndex].currentLevel.ToString();
                lblObsName.Text = channels[lstChannels.SelectedIndex].currentObstacle?.name ?? "N/A";
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
                Player selectedPlayer = players[index];
            }
            btnPlayerInfo.Enabled = true;
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
                _attemptEvent.AttemptObstacle(players[lstPlayers.SelectedIndex], channels[lstChannels.SelectedIndex]);
            }
        }

        private void btnAboutThisObstacle_Click(object sender, EventArgs e)
        {

        }

        private void rtbMessages_TextChanged(object sender, EventArgs e)
        {
            // scroll to bottom
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        private void btnPlayerInfo_Click(object sender, EventArgs e)
        {
            // TODO: Show player info in a new form or dialog, also allow them to edit their stats
            // Open the PlayerInfo form with the selected player
            int index = lstPlayers.SelectedIndex;
            if (index >= 0 && index < players.Count)
            {
                Player selectedPlayer = players[index];
                PlayerInfo playerInfoForm = new PlayerInfo(selectedPlayer);
                playerInfoForm.ShowDialog(); // Show as a modal dialog
            }
            else
            {
                MessageBox.Show("Please select a player to view their information.");
            }
        }
    }
}
