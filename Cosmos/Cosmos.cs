using Cosmos.Core;
using Cosmos.Data;
using Cosmos.Model;
using Cosmos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Cosmos
{
    public partial class Cosmos : Form
    {
        private List<Player> players = new List<Player>();
        private List<Obstacle> obstacles = new List<Obstacle>();
        private List<Channel> channels = new List<Channel>();

        private InitData initData;
        private AttemptEvent _attemptEvent;
        private SaveLoadData saveLoad = new SaveLoadData();

        public Cosmos()
        {
            InitializeComponent();

            var (loadedPlayers, loadedChannels, loadedObstacles, isError) = saveLoad.LoadData();
            players = loadedPlayers;
            channels = loadedChannels;
            obstacles = loadedObstacles;

            // Notify the user if there was an error loading data
            if (isError)
            {
                MessageBox.Show("Error loading data. Initializing with default values.");
            }

            initData = new InitData(obstacles, channels, players);
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
            NewPlayer();
        }

        private void NewPlayer()
        {
            string newPlayerName = Interaction.InputBox("Enter new player name:", "New Player");
            if (newPlayerName == "") return;

            Player newPlayer = new Player
            {
                ID = players.Count + 1, name = newPlayerName, availablePoints = 0,
                speed = 10, tech = 10, grip = 10, strength = 10,
                balance = 10, lache = 10, stamina = 10, intelligence = 10
            };
            players.Add(newPlayer);

            // Update ListBox
            lstPlayers.Items.Add(newPlayer.name);
            lstPlayers.SelectedIndex = lstPlayers.Items.Count - 1; // Auto-select new player
        }

        private void btnNewChannel_Click(object sender, EventArgs e)
        {
            string newChannelName = Interaction.InputBox("Enter new channel name:", "New Channel");
            if (newChannelName == "") return;

            // Create a new channel
            if (obstacles.Count == 0)
            {
                MessageBox.Show("No obstacles available to assign to the new channel.");
                return;
            }
            else
            {
                Channel newChannel = new Channel(channels.Count + 1, newChannelName, 1, initData.GetRandomObstacle());
                channels.Add(newChannel);

                // Update ListBox
                lstChannels.Items.Add(newChannel.name);
                lstChannels.SelectedIndex = lstChannels.Items.Count - 1; // Auto-select new channel
            }
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
            // TODO: Show a dialog with information about the current obstacle
            int index = lstChannels.SelectedIndex;
            if (index >= 0 && index < channels.Count)
            {
                Channel selectedChannel = channels[index];
                if (selectedChannel.currentObstacle != null)
                {
                    MessageBox.Show($"Obstacle Name: {selectedChannel.currentObstacle.name}\n" +
                                    $"Description: {selectedChannel.currentObstacle.description}\n" +
                                    $"Difficulty: {selectedChannel.currentObstacle.difficulty}");
                }
                else
                {
                    MessageBox.Show("No obstacle selected for this channel.");
                }
            }
            else
            {
                MessageBox.Show("Please select a channel to view its obstacle.");
            }
        }

        private void rtbMessages_TextChanged(object sender, EventArgs e)
        {
            // scroll to bottom
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        private void btnPlayerInfo_Click(object sender, EventArgs e)
        {
            // Open the PlayerInfo form with the selected player
            int index = lstPlayers.SelectedIndex;
            if (index >= 0 && index < players.Count)
            {
                Player selectedPlayer = players[index];
                PlayerInfo playerInfoForm = new PlayerInfo(selectedPlayer);
                playerInfoForm.PlayerDeleted += PlayerInfoForm_PlayerDeleted;
                playerInfoForm.ShowDialog(); // Show as a modal dialog
            }
            else
            {
                MessageBox.Show("Please select a player to view their information.");
            }
        }

        private void PlayerInfoForm_PlayerDeleted(object sender, Player player)
        {
            players.Remove(player);
            lstPlayers.Items.Remove(player.name);
            saveLoad.SaveData(players, channels, obstacles);
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            saveLoad.SaveData(players, channels, obstacles);
        }

        private void btnDeleteChannel_Click(object sender, EventArgs e)
        {
            // Check if a channel is selected
            if (lstChannels.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a channel to delete.");
                return;
            }
            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this channel?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = lstChannels.SelectedIndex;
                channels.RemoveAt(index);
                lstChannels.Items.RemoveAt(index);
                if (channels.Count > 0)
                {
                    lstChannels.SelectedIndex = Math.Min(index, channels.Count - 1); // Select the next available channel
                }
                else
                {
                    lblObsLevelNo.Text = "N/A";
                    lblObsName.Text = "N/A";
                }
                saveLoad.SaveData(players, channels, obstacles);
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            saveLoad.SaveData(players, channels, obstacles);
            Close();
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
