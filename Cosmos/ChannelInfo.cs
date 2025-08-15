using Cosmos.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cosmos
{
    public partial class ChannelInfo : Form
    {
        private Channel _currentChannel;
        public event EventHandler<Channel> ChannelUpdated;

        public ChannelInfo(Channel channel)
        {
            InitializeComponent();
            _currentChannel = channel;

            InitChannelInfo();
        }

        private void InitChannelInfo()
        {
            // Ensure the uniquePlayerIds HashSet is initialized
            if (_currentChannel.uniquePlayerIds == null)
            {
                _currentChannel.uniquePlayerIds = new HashSet<int>();
            }

            lblName.Text += _currentChannel.name;
            lblCurrentLevel.Text += _currentChannel.currentLevel.ToString();
            lblCurrentObstacle.Text += _currentChannel.currentObstacle?.name ?? "N/A";
            lblTotalAttempts.Text += _currentChannel.totalAttempts.ToString();
            lblUniquePlayers.Text += _currentChannel.uniquePlayerIds.Count.ToString();
            lblLastAttempted.Text += _currentChannel.lastAttempted == DateTime.MinValue 
                ? "Never" 
                : _currentChannel.lastAttempted.ToString("g");
        }

        private void btnEditChannel_Click(object sender, EventArgs e)
        {
            string newChannelName = Interaction.InputBox("Enter new channel name:", "Edit Channel", _currentChannel.name);
            if (newChannelName == "") return;

            _currentChannel.name = newChannelName;
            lblName.Text = "Name: " + _currentChannel.name;

            // Raise channel name edited event
            ChannelUpdated?.Invoke(this, _currentChannel);
        }
    }
}
