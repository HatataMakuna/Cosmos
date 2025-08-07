namespace Cosmos
{
    partial class ChannelInfo
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCurrentLevel = new System.Windows.Forms.Label();
            this.lblCurrentObstacle = new System.Windows.Forms.Label();
            this.lblTotalAttempts = new System.Windows.Forms.Label();
            this.lblLastAttempted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblCurrentLevel
            // 
            this.lblCurrentLevel.AutoSize = true;
            this.lblCurrentLevel.Location = new System.Drawing.Point(17, 76);
            this.lblCurrentLevel.Name = "lblCurrentLevel";
            this.lblCurrentLevel.Size = new System.Drawing.Size(88, 16);
            this.lblCurrentLevel.TabIndex = 1;
            this.lblCurrentLevel.Text = "Current Level:";
            // 
            // lblCurrentObstacle
            // 
            this.lblCurrentObstacle.AutoSize = true;
            this.lblCurrentObstacle.Location = new System.Drawing.Point(17, 117);
            this.lblCurrentObstacle.Name = "lblCurrentObstacle";
            this.lblCurrentObstacle.Size = new System.Drawing.Size(109, 16);
            this.lblCurrentObstacle.TabIndex = 2;
            this.lblCurrentObstacle.Text = "Current Obstacle:";
            // 
            // lblTotalAttempts
            // 
            this.lblTotalAttempts.AutoSize = true;
            this.lblTotalAttempts.Location = new System.Drawing.Point(17, 158);
            this.lblTotalAttempts.Name = "lblTotalAttempts";
            this.lblTotalAttempts.Size = new System.Drawing.Size(96, 16);
            this.lblTotalAttempts.TabIndex = 3;
            this.lblTotalAttempts.Text = "Total Attempts:";
            // 
            // lblLastAttempted
            // 
            this.lblLastAttempted.AutoSize = true;
            this.lblLastAttempted.Location = new System.Drawing.Point(17, 199);
            this.lblLastAttempted.Name = "lblLastAttempted";
            this.lblLastAttempted.Size = new System.Drawing.Size(99, 16);
            this.lblLastAttempted.TabIndex = 4;
            this.lblLastAttempted.Text = "Last Attempted:";
            // 
            // ChannelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 455);
            this.Controls.Add(this.lblLastAttempted);
            this.Controls.Add(this.lblTotalAttempts);
            this.Controls.Add(this.lblCurrentObstacle);
            this.Controls.Add(this.lblCurrentLevel);
            this.Controls.Add(this.lblName);
            this.Name = "ChannelInfo";
            this.Text = "Channel Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCurrentLevel;
        private System.Windows.Forms.Label lblCurrentObstacle;
        private System.Windows.Forms.Label lblTotalAttempts;
        private System.Windows.Forms.Label lblLastAttempted;
    }
}