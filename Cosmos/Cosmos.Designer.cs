namespace Cosmos
{
    partial class Cosmos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.lblChannels = new System.Windows.Forms.Label();
            this.btnNewChannel = new System.Windows.Forms.Button();
            this.pnlObstacle = new System.Windows.Forms.Panel();
            this.btnAboutThisObstacle = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.lblObsName = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblObsLevelNo = new System.Windows.Forms.Label();
            this.lblObsLevel = new System.Windows.Forms.Label();
            this.btnAttempt = new System.Windows.Forms.Button();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.lstChannels = new System.Windows.Forms.ListBox();
            this.btnPlayerInfo = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlObstacle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(60, 15);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(60, 16);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Players";
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.Location = new System.Drawing.Point(23, 160);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(140, 32);
            this.btnNewPlayer.TabIndex = 2;
            this.btnNewPlayer.Text = "New Player";
            this.btnNewPlayer.UseVisualStyleBackColor = true;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // lblChannels
            // 
            this.lblChannels.AutoSize = true;
            this.lblChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannels.Location = new System.Drawing.Point(54, 238);
            this.lblChannels.Name = "lblChannels";
            this.lblChannels.Size = new System.Drawing.Size(71, 16);
            this.lblChannels.TabIndex = 4;
            this.lblChannels.Text = "Channels";
            // 
            // btnNewChannel
            // 
            this.btnNewChannel.Location = new System.Drawing.Point(23, 383);
            this.btnNewChannel.Name = "btnNewChannel";
            this.btnNewChannel.Size = new System.Drawing.Size(140, 32);
            this.btnNewChannel.TabIndex = 5;
            this.btnNewChannel.Text = "New Channel";
            this.btnNewChannel.UseVisualStyleBackColor = true;
            this.btnNewChannel.Click += new System.EventHandler(this.btnNewChannel_Click);
            // 
            // pnlObstacle
            // 
            this.pnlObstacle.Controls.Add(this.btnAboutThisObstacle);
            this.pnlObstacle.Controls.Add(this.rtbMessages);
            this.pnlObstacle.Controls.Add(this.lblObsName);
            this.pnlObstacle.Controls.Add(this.lblObs);
            this.pnlObstacle.Controls.Add(this.lblObsLevelNo);
            this.pnlObstacle.Controls.Add(this.lblObsLevel);
            this.pnlObstacle.Controls.Add(this.btnAttempt);
            this.pnlObstacle.Location = new System.Drawing.Point(231, 160);
            this.pnlObstacle.Name = "pnlObstacle";
            this.pnlObstacle.Size = new System.Drawing.Size(388, 233);
            this.pnlObstacle.TabIndex = 6;
            // 
            // btnAboutThisObstacle
            // 
            this.btnAboutThisObstacle.Location = new System.Drawing.Point(223, 171);
            this.btnAboutThisObstacle.Name = "btnAboutThisObstacle";
            this.btnAboutThisObstacle.Size = new System.Drawing.Size(153, 44);
            this.btnAboutThisObstacle.TabIndex = 6;
            this.btnAboutThisObstacle.Text = "About this Obstacle";
            this.btnAboutThisObstacle.UseVisualStyleBackColor = true;
            this.btnAboutThisObstacle.Click += new System.EventHandler(this.btnAboutThisObstacle_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(15, 44);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(361, 112);
            this.rtbMessages.TabIndex = 5;
            this.rtbMessages.Text = "";
            this.rtbMessages.TextChanged += new System.EventHandler(this.rtbMessages_TextChanged);
            // 
            // lblObsName
            // 
            this.lblObsName.AutoSize = true;
            this.lblObsName.Location = new System.Drawing.Point(231, 12);
            this.lblObsName.Name = "lblObsName";
            this.lblObsName.Size = new System.Drawing.Size(0, 16);
            this.lblObsName.TabIndex = 4;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(160, 12);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(64, 16);
            this.lblObs.TabIndex = 3;
            this.lblObs.Text = "Obstacle:";
            // 
            // lblObsLevelNo
            // 
            this.lblObsLevelNo.AutoSize = true;
            this.lblObsLevelNo.Location = new System.Drawing.Point(71, 12);
            this.lblObsLevelNo.Name = "lblObsLevelNo";
            this.lblObsLevelNo.Size = new System.Drawing.Size(0, 16);
            this.lblObsLevelNo.TabIndex = 2;
            // 
            // lblObsLevel
            // 
            this.lblObsLevel.AutoSize = true;
            this.lblObsLevel.Location = new System.Drawing.Point(12, 12);
            this.lblObsLevel.Name = "lblObsLevel";
            this.lblObsLevel.Size = new System.Drawing.Size(43, 16);
            this.lblObsLevel.TabIndex = 1;
            this.lblObsLevel.Text = "Level:";
            // 
            // btnAttempt
            // 
            this.btnAttempt.Location = new System.Drawing.Point(15, 171);
            this.btnAttempt.Name = "btnAttempt";
            this.btnAttempt.Size = new System.Drawing.Size(153, 44);
            this.btnAttempt.TabIndex = 0;
            this.btnAttempt.Text = "Attempt";
            this.btnAttempt.UseVisualStyleBackColor = true;
            this.btnAttempt.Click += new System.EventHandler(this.btnAttempt_Click);
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 16;
            this.lstPlayers.Location = new System.Drawing.Point(23, 34);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(140, 116);
            this.lstPlayers.TabIndex = 7;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // lstChannels
            // 
            this.lstChannels.FormattingEnabled = true;
            this.lstChannels.ItemHeight = 16;
            this.lstChannels.Location = new System.Drawing.Point(23, 257);
            this.lstChannels.Name = "lstChannels";
            this.lstChannels.Size = new System.Drawing.Size(140, 116);
            this.lstChannels.TabIndex = 8;
            this.lstChannels.SelectedIndexChanged += new System.EventHandler(this.lstChannels_SelectedIndexChanged);
            // 
            // btnPlayerInfo
            // 
            this.btnPlayerInfo.Enabled = false;
            this.btnPlayerInfo.Location = new System.Drawing.Point(23, 197);
            this.btnPlayerInfo.Name = "btnPlayerInfo";
            this.btnPlayerInfo.Size = new System.Drawing.Size(140, 32);
            this.btnPlayerInfo.TabIndex = 9;
            this.btnPlayerInfo.Text = "Player Info";
            this.btnPlayerInfo.UseVisualStyleBackColor = true;
            this.btnPlayerInfo.Click += new System.EventHandler(this.btnPlayerInfo_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 437);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // Cosmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 437);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlObstacle);
            this.Controls.Add(this.btnPlayerInfo);
            this.Controls.Add(this.lstChannels);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.btnNewChannel);
            this.Controls.Add(this.lblChannels);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.lblPlayer);
            this.Name = "Cosmos";
            this.Text = "Cosmos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.pnlObstacle.ResumeLayout(false);
            this.pnlObstacle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Label lblChannels;
        private System.Windows.Forms.Button btnNewChannel;
        private System.Windows.Forms.Panel pnlObstacle;
        private System.Windows.Forms.Button btnAttempt;
        private System.Windows.Forms.Label lblObsName;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblObsLevelNo;
        private System.Windows.Forms.Label lblObsLevel;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.ListBox lstChannels;
        private System.Windows.Forms.Button btnAboutThisObstacle;
        private System.Windows.Forms.Button btnPlayerInfo;
        private System.Windows.Forms.Splitter splitter1;
    }
}

