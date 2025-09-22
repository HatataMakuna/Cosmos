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
            this.lstObstaclesinStage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstObstacles
            // 
            this.lstObstacles.FormattingEnabled = true;
            this.lstObstacles.ItemHeight = 16;
            this.lstObstacles.Location = new System.Drawing.Point(192, 16);
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
            // 
            // btnNewCourse
            // 
            this.btnNewCourse.Location = new System.Drawing.Point(22, 342);
            this.btnNewCourse.Name = "btnNewCourse";
            this.btnNewCourse.Size = new System.Drawing.Size(138, 34);
            this.btnNewCourse.TabIndex = 3;
            this.btnNewCourse.Text = "New Course";
            this.btnNewCourse.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(22, 393);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(138, 34);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // btnManageObstacles
            // 
            this.btnManageObstacles.Location = new System.Drawing.Point(193, 342);
            this.btnManageObstacles.Name = "btnManageObstacles";
            this.btnManageObstacles.Size = new System.Drawing.Size(138, 34);
            this.btnManageObstacles.TabIndex = 5;
            this.btnManageObstacles.Text = "Manage Obstacles";
            this.btnManageObstacles.UseVisualStyleBackColor = true;
            // 
            // lstObstaclesinStage
            // 
            this.lstObstaclesinStage.FormattingEnabled = true;
            this.lstObstaclesinStage.ItemHeight = 16;
            this.lstObstaclesinStage.Location = new System.Drawing.Point(383, 16);
            this.lstObstaclesinStage.Name = "lstObstaclesinStage";
            this.lstObstaclesinStage.Size = new System.Drawing.Size(139, 308);
            this.lstObstaclesinStage.TabIndex = 6;
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstObstaclesinStage);
            this.Controls.Add(this.btnManageObstacles);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnNewCourse);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lstObstacles);
            this.Name = "ManageCourses";
            this.Text = "ManageCourses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstObstacles;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnNewCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnManageObstacles;
        private System.Windows.Forms.ListBox lstObstaclesinStage;
    }
}