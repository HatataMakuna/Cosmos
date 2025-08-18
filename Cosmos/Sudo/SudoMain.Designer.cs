namespace Cosmos.Sudo
{
    partial class SudoMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageObstacles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageCompetitors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageObstacles,
            this.tsmiManageCourses,
            this.tsmiManageCompetitors,
            this.tsmiExit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmiManageObstacles
            // 
            this.tsmiManageObstacles.Name = "tsmiManageObstacles";
            this.tsmiManageObstacles.Size = new System.Drawing.Size(232, 26);
            this.tsmiManageObstacles.Text = "Manage Obstacles";
            this.tsmiManageObstacles.Click += new System.EventHandler(this.tsmiManageObstacles_Click);
            // 
            // tsmiManageCourses
            // 
            this.tsmiManageCourses.Name = "tsmiManageCourses";
            this.tsmiManageCourses.Size = new System.Drawing.Size(232, 26);
            this.tsmiManageCourses.Text = "Manage Courses";
            // 
            // tsmiManageCompetitors
            // 
            this.tsmiManageCompetitors.Name = "tsmiManageCompetitors";
            this.tsmiManageCompetitors.Size = new System.Drawing.Size(232, 26);
            this.tsmiManageCompetitors.Text = "Manage Competitors";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(232, 26);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "this button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SudoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SudoMain";
            this.Text = "Cosmos (Sudo Mode)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageObstacles;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageCourses;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageCompetitors;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Button button1;
    }
}