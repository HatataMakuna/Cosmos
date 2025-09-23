namespace Cosmos.Sudo
{
    partial class ManageCourses
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
            this.lstObstacles = new System.Windows.Forms.ListBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.btnNewCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnManageObstacles = new System.Windows.Forms.Button();
            this.btnAddStage = new System.Windows.Forms.Button();
            this.btnAddObstacleToStage = new System.Windows.Forms.Button();
            this.btnRemoveObstacleFromStage = new System.Windows.Forms.Button();
            this.tabStages = new System.Windows.Forms.TabControl();
            this.btnEditStageName = new System.Windows.Forms.Button();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.lblStageName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstObstacles
            // 
            this.lstObstacles.FormattingEnabled = true;
            this.lstObstacles.ItemHeight = 16;
            this.lstObstacles.Location = new System.Drawing.Point(187, 16);
            this.lstObstacles.Name = "lstObstacles";
            this.lstObstacles.Size = new System.Drawing.Size(139, 308);
            this.lstObstacles.TabIndex = 1;
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 16;
            this.lstCourses.Location = new System.Drawing.Point(21, 16);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(139, 308);
            this.lstCourses.TabIndex = 2;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // btnNewCourse
            // 
            this.btnNewCourse.Location = new System.Drawing.Point(22, 342);
            this.btnNewCourse.Name = "btnNewCourse";
            this.btnNewCourse.Size = new System.Drawing.Size(138, 34);
            this.btnNewCourse.TabIndex = 3;
            this.btnNewCourse.Text = "New Course";
            this.btnNewCourse.UseVisualStyleBackColor = true;
            this.btnNewCourse.Click += new System.EventHandler(this.btnNewCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Enabled = false;
            this.btnDeleteCourse.Location = new System.Drawing.Point(22, 393);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(138, 34);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnManageObstacles
            // 
            this.btnManageObstacles.Location = new System.Drawing.Point(188, 342);
            this.btnManageObstacles.Name = "btnManageObstacles";
            this.btnManageObstacles.Size = new System.Drawing.Size(138, 34);
            this.btnManageObstacles.TabIndex = 5;
            this.btnManageObstacles.Text = "Manage Obstacles";
            this.btnManageObstacles.UseVisualStyleBackColor = true;
            this.btnManageObstacles.Click += new System.EventHandler(this.btnManageObstacles_Click);
            // 
            // btnAddStage
            // 
            this.btnAddStage.Enabled = false;
            this.btnAddStage.Location = new System.Drawing.Point(337, 117);
            this.btnAddStage.Name = "btnAddStage";
            this.btnAddStage.Size = new System.Drawing.Size(138, 34);
            this.btnAddStage.TabIndex = 7;
            this.btnAddStage.Text = "Add Stage";
            this.btnAddStage.UseVisualStyleBackColor = true;
            this.btnAddStage.Click += new System.EventHandler(this.btnAddStage_Click);
            // 
            // btnAddObstacleToStage
            // 
            this.btnAddObstacleToStage.Enabled = false;
            this.btnAddObstacleToStage.Location = new System.Drawing.Point(337, 16);
            this.btnAddObstacleToStage.Name = "btnAddObstacleToStage";
            this.btnAddObstacleToStage.Size = new System.Drawing.Size(138, 34);
            this.btnAddObstacleToStage.TabIndex = 8;
            this.btnAddObstacleToStage.Text = "Add Obstacle";
            this.btnAddObstacleToStage.UseVisualStyleBackColor = true;
            this.btnAddObstacleToStage.Click += new System.EventHandler(this.btnAddObstacleToStage_Click);
            // 
            // btnRemoveObstacleFromStage
            // 
            this.btnRemoveObstacleFromStage.Enabled = false;
            this.btnRemoveObstacleFromStage.Location = new System.Drawing.Point(337, 65);
            this.btnRemoveObstacleFromStage.Name = "btnRemoveObstacleFromStage";
            this.btnRemoveObstacleFromStage.Size = new System.Drawing.Size(138, 34);
            this.btnRemoveObstacleFromStage.TabIndex = 9;
            this.btnRemoveObstacleFromStage.Text = "Remove Obstacle";
            this.btnRemoveObstacleFromStage.UseVisualStyleBackColor = true;
            this.btnRemoveObstacleFromStage.Click += new System.EventHandler(this.btnRemoveObstacleFromStage_Click);
            // 
            // tabStages
            // 
            this.tabStages.Location = new System.Drawing.Point(481, 16);
            this.tabStages.Name = "tabStages";
            this.tabStages.SelectedIndex = 0;
            this.tabStages.Size = new System.Drawing.Size(313, 203);
            this.tabStages.TabIndex = 10;
            this.tabStages.SelectedIndexChanged += new System.EventHandler(this.tabStages_SelectedIndexChanged);
            // 
            // btnEditStageName
            // 
            this.btnEditStageName.Enabled = false;
            this.btnEditStageName.Location = new System.Drawing.Point(716, 236);
            this.btnEditStageName.Name = "btnEditStageName";
            this.btnEditStageName.Size = new System.Drawing.Size(55, 23);
            this.btnEditStageName.TabIndex = 13;
            this.btnEditStageName.Text = "Edit";
            this.btnEditStageName.UseVisualStyleBackColor = true;
            this.btnEditStageName.Click += new System.EventHandler(this.btnEditStageName_Click);
            // 
            // txtStageName
            // 
            this.txtStageName.Enabled = false;
            this.txtStageName.Location = new System.Drawing.Point(573, 236);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.Size = new System.Drawing.Size(137, 22);
            this.txtStageName.TabIndex = 12;
            // 
            // lblStageName
            // 
            this.lblStageName.AutoSize = true;
            this.lblStageName.Location = new System.Drawing.Point(481, 238);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(86, 16);
            this.lblStageName.TabIndex = 11;
            this.lblStageName.Text = "Stage Name:";
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.btnRemoveObstacleFromStage);
            this.Controls.Add(this.btnAddObstacleToStage);
            this.Controls.Add(this.btnAddStage);
            this.Controls.Add(this.btnManageObstacles);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnNewCourse);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lstObstacles);
            this.Controls.Add(this.lblStageName);
            this.Controls.Add(this.txtStageName);
            this.Controls.Add(this.btnEditStageName);
            this.Controls.Add(this.tabStages);
            this.Name = "ManageCourses";
            this.Text = "ManageCourses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstObstacles;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnNewCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnManageObstacles;
        private System.Windows.Forms.Button btnAddStage;
        private System.Windows.Forms.Button btnAddObstacleToStage;
        private System.Windows.Forms.Button btnRemoveObstacleFromStage;
        private System.Windows.Forms.TabControl tabStages;
        private System.Windows.Forms.Button btnEditStageName;
        private System.Windows.Forms.TextBox txtStageName;
        private System.Windows.Forms.Label lblStageName;
    }
}