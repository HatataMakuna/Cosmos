using Cosmos.Service;

namespace Cosmos
{
    partial class ManageObstacles
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
            this.btnNewObstacle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTags = new System.Windows.Forms.Label();
            this.nudRequiredLevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.nudDifficulty = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequiredLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // lstObstacles
            // 
            this.lstObstacles.FormattingEnabled = true;
            this.lstObstacles.ItemHeight = 16;
            this.lstObstacles.Location = new System.Drawing.Point(12, 12);
            this.lstObstacles.Name = "lstObstacles";
            this.lstObstacles.Size = new System.Drawing.Size(139, 212);
            this.lstObstacles.TabIndex = 0;
            // 
            // btnNewObstacle
            // 
            this.btnNewObstacle.Location = new System.Drawing.Point(13, 241);
            this.btnNewObstacle.Name = "btnNewObstacle";
            this.btnNewObstacle.Size = new System.Drawing.Size(138, 34);
            this.btnNewObstacle.TabIndex = 1;
            this.btnNewObstacle.Text = "New Obstacle";
            this.btnNewObstacle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lblTags, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudRequiredLevel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDifficulty, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudDifficulty, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(180, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.88878F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.76365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.39226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47766F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47766F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 176);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblTags
            // 
            this.lblTags.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(3, 151);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(39, 16);
            this.lblTags.TabIndex = 8;
            this.lblTags.Text = "Tags";
            // 
            // nudRequiredLevel
            // 
            this.nudRequiredLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudRequiredLevel.Location = new System.Drawing.Point(111, 117);
            this.nudRequiredLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRequiredLevel.Name = "nudRequiredLevel";
            this.nudRequiredLevel.Size = new System.Drawing.Size(120, 22);
            this.nudRequiredLevel.TabIndex = 7;
            this.nudRequiredLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Required Level";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(3, 91);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(56, 16);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(111, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(162, 22);
            this.tbName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rtbDescription.Enabled = false;
            this.rtbDescription.Location = new System.Drawing.Point(111, 30);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(197, 53);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // nudDifficulty
            // 
            this.nudDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudDifficulty.Location = new System.Drawing.Point(111, 89);
            this.nudDifficulty.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDifficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDifficulty.Name = "nudDifficulty";
            this.nudDifficulty.Size = new System.Drawing.Size(120, 22);
            this.nudDifficulty.TabIndex = 5;
            this.nudDifficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ManageObstacles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnNewObstacle);
            this.Controls.Add(this.lstObstacles);
            this.Name = "ManageObstacles";
            this.Text = "ManageObstacles";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequiredLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstObstacles;
        private System.Windows.Forms.Button btnNewObstacle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.NumericUpDown nudDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRequiredLevel;
        private System.Windows.Forms.Label lblTags;
    }
}