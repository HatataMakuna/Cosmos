namespace Cosmos
{
    partial class PlayerInfo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.btnAddSpeed = new System.Windows.Forms.Button();
            this.tlpPlayerStats = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTech = new System.Windows.Forms.Button();
            this.btnAddGrip = new System.Windows.Forms.Button();
            this.btnAddStrength = new System.Windows.Forms.Button();
            this.btnAddEndurance = new System.Windows.Forms.Button();
            this.btnAddAgility = new System.Windows.Forms.Button();
            this.btnAddBalance = new System.Windows.Forms.Button();
            this.btnAddLache = new System.Windows.Forms.Button();
            this.btnAddStamina = new System.Windows.Forms.Button();
            this.btnAddIntelligence = new System.Windows.Forms.Button();
            this.btnMinusSpeed = new System.Windows.Forms.Button();
            this.btnMinusTech = new System.Windows.Forms.Button();
            this.btnMinusGrip = new System.Windows.Forms.Button();
            this.btnMinusStrength = new System.Windows.Forms.Button();
            this.btnMinusEndurance = new System.Windows.Forms.Button();
            this.btnMinusAgility = new System.Windows.Forms.Button();
            this.btnMinusBalance = new System.Windows.Forms.Button();
            this.btnMinusLache = new System.Windows.Forms.Button();
            this.btnMinusStamina = new System.Windows.Forms.Button();
            this.btnMinusIntelligence = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTech = new System.Windows.Forms.Label();
            this.lblGrip = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblEndurance = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLache = new System.Windows.Forms.Label();
            this.lblStamina = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblSpeedStat = new System.Windows.Forms.Label();
            this.lblTechStat = new System.Windows.Forms.Label();
            this.lblGripStat = new System.Windows.Forms.Label();
            this.lblStrengthStat = new System.Windows.Forms.Label();
            this.lblEnduranceStat = new System.Windows.Forms.Label();
            this.lblAgilityStat = new System.Windows.Forms.Label();
            this.lblBalanceStat = new System.Windows.Forms.Label();
            this.lblLacheStat = new System.Windows.Forms.Label();
            this.lblStaminaStat = new System.Windows.Forms.Label();
            this.lblIntelligenceStat = new System.Windows.Forms.Label();
            this.lblAvailablePoints = new System.Windows.Forms.Label();
            this.gbPlayerProfile = new System.Windows.Forms.GroupBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerLevel = new System.Windows.Forms.Label();
            this.lblPlayerExperience = new System.Windows.Forms.Label();
            this.pbExpProgress = new System.Windows.Forms.ProgressBar();
            this.lblExpPercentage = new System.Windows.Forms.Label();
            this.lblNoAttemptedObstacles = new System.Windows.Forms.Label();
            this.lblNoCompletedObstacles = new System.Windows.Forms.Label();
            this.gbStats.SuspendLayout();
            this.tlpPlayerStats.SuspendLayout();
            this.gbPlayerProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(337, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(500, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.lblAvailablePoints);
            this.gbStats.Controls.Add(this.tlpPlayerStats);
            this.gbStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStats.Location = new System.Drawing.Point(311, 12);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(329, 373);
            this.gbStats.TabIndex = 3;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Player Stats";
            // 
            // btnAddSpeed
            // 
            this.btnAddSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSpeed.Enabled = false;
            this.btnAddSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpeed.Location = new System.Drawing.Point(239, 3);
            this.btnAddSpeed.Name = "btnAddSpeed";
            this.btnAddSpeed.Size = new System.Drawing.Size(30, 25);
            this.btnAddSpeed.TabIndex = 4;
            this.btnAddSpeed.Text = "+";
            this.btnAddSpeed.UseVisualStyleBackColor = true;
            // 
            // tlpPlayerStats
            // 
            this.tlpPlayerStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpPlayerStats.ColumnCount = 4;
            this.tlpPlayerStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPlayerStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPlayerStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPlayerStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPlayerStats.Controls.Add(this.lblIntelligenceStat, 1, 9);
            this.tlpPlayerStats.Controls.Add(this.lblStaminaStat, 1, 8);
            this.tlpPlayerStats.Controls.Add(this.lblLacheStat, 1, 7);
            this.tlpPlayerStats.Controls.Add(this.lblBalanceStat, 1, 6);
            this.tlpPlayerStats.Controls.Add(this.lblAgilityStat, 1, 5);
            this.tlpPlayerStats.Controls.Add(this.lblEnduranceStat, 1, 4);
            this.tlpPlayerStats.Controls.Add(this.lblStrengthStat, 1, 3);
            this.tlpPlayerStats.Controls.Add(this.lblGripStat, 1, 2);
            this.tlpPlayerStats.Controls.Add(this.lblTechStat, 1, 1);
            this.tlpPlayerStats.Controls.Add(this.btnAddSpeed, 3, 0);
            this.tlpPlayerStats.Controls.Add(this.btnAddTech, 3, 1);
            this.tlpPlayerStats.Controls.Add(this.btnAddGrip, 3, 2);
            this.tlpPlayerStats.Controls.Add(this.btnAddStrength, 3, 3);
            this.tlpPlayerStats.Controls.Add(this.btnAddEndurance, 3, 4);
            this.tlpPlayerStats.Controls.Add(this.btnAddAgility, 3, 5);
            this.tlpPlayerStats.Controls.Add(this.btnAddBalance, 3, 6);
            this.tlpPlayerStats.Controls.Add(this.btnAddLache, 3, 7);
            this.tlpPlayerStats.Controls.Add(this.btnAddStamina, 3, 8);
            this.tlpPlayerStats.Controls.Add(this.btnAddIntelligence, 3, 9);
            this.tlpPlayerStats.Controls.Add(this.btnMinusSpeed, 2, 0);
            this.tlpPlayerStats.Controls.Add(this.btnMinusTech, 2, 1);
            this.tlpPlayerStats.Controls.Add(this.btnMinusGrip, 2, 2);
            this.tlpPlayerStats.Controls.Add(this.btnMinusStrength, 2, 3);
            this.tlpPlayerStats.Controls.Add(this.btnMinusEndurance, 2, 4);
            this.tlpPlayerStats.Controls.Add(this.btnMinusAgility, 2, 5);
            this.tlpPlayerStats.Controls.Add(this.btnMinusBalance, 2, 6);
            this.tlpPlayerStats.Controls.Add(this.btnMinusLache, 2, 7);
            this.tlpPlayerStats.Controls.Add(this.btnMinusStamina, 2, 8);
            this.tlpPlayerStats.Controls.Add(this.btnMinusIntelligence, 2, 9);
            this.tlpPlayerStats.Controls.Add(this.lblSpeed, 0, 0);
            this.tlpPlayerStats.Controls.Add(this.lblTech, 0, 1);
            this.tlpPlayerStats.Controls.Add(this.lblGrip, 0, 2);
            this.tlpPlayerStats.Controls.Add(this.lblStrength, 0, 3);
            this.tlpPlayerStats.Controls.Add(this.lblEndurance, 0, 4);
            this.tlpPlayerStats.Controls.Add(this.lblAgility, 0, 5);
            this.tlpPlayerStats.Controls.Add(this.lblBalance, 0, 6);
            this.tlpPlayerStats.Controls.Add(this.lblLache, 0, 7);
            this.tlpPlayerStats.Controls.Add(this.lblStamina, 0, 8);
            this.tlpPlayerStats.Controls.Add(this.lblIntelligence, 0, 9);
            this.tlpPlayerStats.Controls.Add(this.lblSpeedStat, 1, 0);
            this.tlpPlayerStats.Location = new System.Drawing.Point(26, 51);
            this.tlpPlayerStats.Name = "tlpPlayerStats";
            this.tlpPlayerStats.RowCount = 10;
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPlayerStats.Size = new System.Drawing.Size(283, 310);
            this.tlpPlayerStats.TabIndex = 5;
            // 
            // btnAddTech
            // 
            this.btnAddTech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTech.Enabled = false;
            this.btnAddTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTech.Location = new System.Drawing.Point(239, 34);
            this.btnAddTech.Name = "btnAddTech";
            this.btnAddTech.Size = new System.Drawing.Size(30, 25);
            this.btnAddTech.TabIndex = 5;
            this.btnAddTech.Text = "+";
            this.btnAddTech.UseVisualStyleBackColor = true;
            // 
            // btnAddGrip
            // 
            this.btnAddGrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddGrip.Enabled = false;
            this.btnAddGrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrip.Location = new System.Drawing.Point(239, 65);
            this.btnAddGrip.Name = "btnAddGrip";
            this.btnAddGrip.Size = new System.Drawing.Size(30, 25);
            this.btnAddGrip.TabIndex = 6;
            this.btnAddGrip.Text = "+";
            this.btnAddGrip.UseVisualStyleBackColor = true;
            // 
            // btnAddStrength
            // 
            this.btnAddStrength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStrength.Enabled = false;
            this.btnAddStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStrength.Location = new System.Drawing.Point(239, 96);
            this.btnAddStrength.Name = "btnAddStrength";
            this.btnAddStrength.Size = new System.Drawing.Size(30, 25);
            this.btnAddStrength.TabIndex = 7;
            this.btnAddStrength.Text = "+";
            this.btnAddStrength.UseVisualStyleBackColor = true;
            // 
            // btnAddEndurance
            // 
            this.btnAddEndurance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddEndurance.Enabled = false;
            this.btnAddEndurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEndurance.Location = new System.Drawing.Point(239, 127);
            this.btnAddEndurance.Name = "btnAddEndurance";
            this.btnAddEndurance.Size = new System.Drawing.Size(30, 25);
            this.btnAddEndurance.TabIndex = 8;
            this.btnAddEndurance.Text = "+";
            this.btnAddEndurance.UseVisualStyleBackColor = true;
            // 
            // btnAddAgility
            // 
            this.btnAddAgility.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAgility.Enabled = false;
            this.btnAddAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAgility.Location = new System.Drawing.Point(239, 158);
            this.btnAddAgility.Name = "btnAddAgility";
            this.btnAddAgility.Size = new System.Drawing.Size(30, 25);
            this.btnAddAgility.TabIndex = 9;
            this.btnAddAgility.Text = "+";
            this.btnAddAgility.UseVisualStyleBackColor = true;
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBalance.Enabled = false;
            this.btnAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBalance.Location = new System.Drawing.Point(239, 189);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(30, 25);
            this.btnAddBalance.TabIndex = 10;
            this.btnAddBalance.Text = "+";
            this.btnAddBalance.UseVisualStyleBackColor = true;
            // 
            // btnAddLache
            // 
            this.btnAddLache.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddLache.Enabled = false;
            this.btnAddLache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLache.Location = new System.Drawing.Point(239, 220);
            this.btnAddLache.Name = "btnAddLache";
            this.btnAddLache.Size = new System.Drawing.Size(30, 25);
            this.btnAddLache.TabIndex = 11;
            this.btnAddLache.Text = "+";
            this.btnAddLache.UseVisualStyleBackColor = true;
            // 
            // btnAddStamina
            // 
            this.btnAddStamina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStamina.Enabled = false;
            this.btnAddStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStamina.Location = new System.Drawing.Point(239, 251);
            this.btnAddStamina.Name = "btnAddStamina";
            this.btnAddStamina.Size = new System.Drawing.Size(30, 25);
            this.btnAddStamina.TabIndex = 12;
            this.btnAddStamina.Text = "+";
            this.btnAddStamina.UseVisualStyleBackColor = true;
            // 
            // btnAddIntelligence
            // 
            this.btnAddIntelligence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddIntelligence.Enabled = false;
            this.btnAddIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIntelligence.Location = new System.Drawing.Point(239, 282);
            this.btnAddIntelligence.Name = "btnAddIntelligence";
            this.btnAddIntelligence.Size = new System.Drawing.Size(30, 25);
            this.btnAddIntelligence.TabIndex = 13;
            this.btnAddIntelligence.Text = "+";
            this.btnAddIntelligence.UseVisualStyleBackColor = true;
            // 
            // btnMinusSpeed
            // 
            this.btnMinusSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusSpeed.Enabled = false;
            this.btnMinusSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusSpeed.Location = new System.Drawing.Point(182, 3);
            this.btnMinusSpeed.Name = "btnMinusSpeed";
            this.btnMinusSpeed.Size = new System.Drawing.Size(30, 25);
            this.btnMinusSpeed.TabIndex = 14;
            this.btnMinusSpeed.Text = "-";
            this.btnMinusSpeed.UseVisualStyleBackColor = true;
            // 
            // btnMinusTech
            // 
            this.btnMinusTech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusTech.Enabled = false;
            this.btnMinusTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTech.Location = new System.Drawing.Point(182, 34);
            this.btnMinusTech.Name = "btnMinusTech";
            this.btnMinusTech.Size = new System.Drawing.Size(30, 25);
            this.btnMinusTech.TabIndex = 15;
            this.btnMinusTech.Text = "-";
            this.btnMinusTech.UseVisualStyleBackColor = true;
            // 
            // btnMinusGrip
            // 
            this.btnMinusGrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusGrip.Enabled = false;
            this.btnMinusGrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusGrip.Location = new System.Drawing.Point(182, 65);
            this.btnMinusGrip.Name = "btnMinusGrip";
            this.btnMinusGrip.Size = new System.Drawing.Size(30, 25);
            this.btnMinusGrip.TabIndex = 16;
            this.btnMinusGrip.Text = "-";
            this.btnMinusGrip.UseVisualStyleBackColor = true;
            // 
            // btnMinusStrength
            // 
            this.btnMinusStrength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusStrength.Enabled = false;
            this.btnMinusStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusStrength.Location = new System.Drawing.Point(182, 96);
            this.btnMinusStrength.Name = "btnMinusStrength";
            this.btnMinusStrength.Size = new System.Drawing.Size(30, 25);
            this.btnMinusStrength.TabIndex = 17;
            this.btnMinusStrength.Text = "-";
            this.btnMinusStrength.UseVisualStyleBackColor = true;
            // 
            // btnMinusEndurance
            // 
            this.btnMinusEndurance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusEndurance.Enabled = false;
            this.btnMinusEndurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusEndurance.Location = new System.Drawing.Point(182, 127);
            this.btnMinusEndurance.Name = "btnMinusEndurance";
            this.btnMinusEndurance.Size = new System.Drawing.Size(30, 25);
            this.btnMinusEndurance.TabIndex = 18;
            this.btnMinusEndurance.Text = "-";
            this.btnMinusEndurance.UseVisualStyleBackColor = true;
            // 
            // btnMinusAgility
            // 
            this.btnMinusAgility.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusAgility.Enabled = false;
            this.btnMinusAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusAgility.Location = new System.Drawing.Point(182, 158);
            this.btnMinusAgility.Name = "btnMinusAgility";
            this.btnMinusAgility.Size = new System.Drawing.Size(30, 25);
            this.btnMinusAgility.TabIndex = 19;
            this.btnMinusAgility.Text = "-";
            this.btnMinusAgility.UseVisualStyleBackColor = true;
            // 
            // btnMinusBalance
            // 
            this.btnMinusBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusBalance.Enabled = false;
            this.btnMinusBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusBalance.Location = new System.Drawing.Point(182, 189);
            this.btnMinusBalance.Name = "btnMinusBalance";
            this.btnMinusBalance.Size = new System.Drawing.Size(30, 25);
            this.btnMinusBalance.TabIndex = 20;
            this.btnMinusBalance.Text = "-";
            this.btnMinusBalance.UseVisualStyleBackColor = true;
            // 
            // btnMinusLache
            // 
            this.btnMinusLache.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusLache.Enabled = false;
            this.btnMinusLache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusLache.Location = new System.Drawing.Point(182, 220);
            this.btnMinusLache.Name = "btnMinusLache";
            this.btnMinusLache.Size = new System.Drawing.Size(30, 25);
            this.btnMinusLache.TabIndex = 21;
            this.btnMinusLache.Text = "-";
            this.btnMinusLache.UseVisualStyleBackColor = true;
            // 
            // btnMinusStamina
            // 
            this.btnMinusStamina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusStamina.Enabled = false;
            this.btnMinusStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusStamina.Location = new System.Drawing.Point(182, 251);
            this.btnMinusStamina.Name = "btnMinusStamina";
            this.btnMinusStamina.Size = new System.Drawing.Size(30, 25);
            this.btnMinusStamina.TabIndex = 22;
            this.btnMinusStamina.Text = "-";
            this.btnMinusStamina.UseVisualStyleBackColor = true;
            // 
            // btnMinusIntelligence
            // 
            this.btnMinusIntelligence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinusIntelligence.Enabled = false;
            this.btnMinusIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusIntelligence.Location = new System.Drawing.Point(182, 282);
            this.btnMinusIntelligence.Name = "btnMinusIntelligence";
            this.btnMinusIntelligence.Size = new System.Drawing.Size(30, 25);
            this.btnMinusIntelligence.TabIndex = 23;
            this.btnMinusIntelligence.Text = "-";
            this.btnMinusIntelligence.UseVisualStyleBackColor = true;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(3, 7);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(53, 16);
            this.lblSpeed.TabIndex = 24;
            this.lblSpeed.Text = "Speed";
            // 
            // lblTech
            // 
            this.lblTech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTech.AutoSize = true;
            this.lblTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTech.Location = new System.Drawing.Point(3, 38);
            this.lblTech.Name = "lblTech";
            this.lblTech.Size = new System.Drawing.Size(42, 16);
            this.lblTech.TabIndex = 25;
            this.lblTech.Text = "Tech";
            // 
            // lblGrip
            // 
            this.lblGrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGrip.AutoSize = true;
            this.lblGrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrip.Location = new System.Drawing.Point(3, 69);
            this.lblGrip.Name = "lblGrip";
            this.lblGrip.Size = new System.Drawing.Size(36, 16);
            this.lblGrip.TabIndex = 26;
            this.lblGrip.Text = "Grip";
            // 
            // lblStrength
            // 
            this.lblStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(3, 100);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(64, 16);
            this.lblStrength.TabIndex = 27;
            this.lblStrength.Text = "Strength";
            // 
            // lblEndurance
            // 
            this.lblEndurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndurance.AutoSize = true;
            this.lblEndurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndurance.Location = new System.Drawing.Point(3, 131);
            this.lblEndurance.Name = "lblEndurance";
            this.lblEndurance.Size = new System.Drawing.Size(81, 16);
            this.lblEndurance.TabIndex = 28;
            this.lblEndurance.Text = "Endurance";
            // 
            // lblAgility
            // 
            this.lblAgility.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgility.AutoSize = true;
            this.lblAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgility.Location = new System.Drawing.Point(3, 162);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(50, 16);
            this.lblAgility.TabIndex = 29;
            this.lblAgility.Text = "Agility";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(3, 193);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(64, 16);
            this.lblBalance.TabIndex = 30;
            this.lblBalance.Text = "Balance";
            // 
            // lblLache
            // 
            this.lblLache.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLache.AutoSize = true;
            this.lblLache.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLache.Location = new System.Drawing.Point(3, 224);
            this.lblLache.Name = "lblLache";
            this.lblLache.Size = new System.Drawing.Size(49, 16);
            this.lblLache.TabIndex = 31;
            this.lblLache.Text = "Lache";
            // 
            // lblStamina
            // 
            this.lblStamina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStamina.AutoSize = true;
            this.lblStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStamina.Location = new System.Drawing.Point(3, 255);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(63, 16);
            this.lblStamina.TabIndex = 32;
            this.lblStamina.Text = "Stamina";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligence.Location = new System.Drawing.Point(3, 286);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(87, 16);
            this.lblIntelligence.TabIndex = 33;
            this.lblIntelligence.Text = "Intelligence";
            // 
            // lblSpeedStat
            // 
            this.lblSpeedStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpeedStat.AutoSize = true;
            this.lblSpeedStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedStat.Location = new System.Drawing.Point(118, 7);
            this.lblSpeedStat.Name = "lblSpeedStat";
            this.lblSpeedStat.Size = new System.Drawing.Size(46, 17);
            this.lblSpeedStat.TabIndex = 34;
            this.lblSpeedStat.Text = "label1";
            // 
            // lblTechStat
            // 
            this.lblTechStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTechStat.AutoSize = true;
            this.lblTechStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechStat.Location = new System.Drawing.Point(118, 38);
            this.lblTechStat.Name = "lblTechStat";
            this.lblTechStat.Size = new System.Drawing.Size(46, 17);
            this.lblTechStat.TabIndex = 35;
            this.lblTechStat.Text = "label1";
            // 
            // lblGripStat
            // 
            this.lblGripStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGripStat.AutoSize = true;
            this.lblGripStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGripStat.Location = new System.Drawing.Point(118, 69);
            this.lblGripStat.Name = "lblGripStat";
            this.lblGripStat.Size = new System.Drawing.Size(46, 17);
            this.lblGripStat.TabIndex = 36;
            this.lblGripStat.Text = "label1";
            // 
            // lblStrengthStat
            // 
            this.lblStrengthStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStrengthStat.AutoSize = true;
            this.lblStrengthStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrengthStat.Location = new System.Drawing.Point(118, 100);
            this.lblStrengthStat.Name = "lblStrengthStat";
            this.lblStrengthStat.Size = new System.Drawing.Size(46, 17);
            this.lblStrengthStat.TabIndex = 37;
            this.lblStrengthStat.Text = "label1";
            // 
            // lblEnduranceStat
            // 
            this.lblEnduranceStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnduranceStat.AutoSize = true;
            this.lblEnduranceStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnduranceStat.Location = new System.Drawing.Point(118, 131);
            this.lblEnduranceStat.Name = "lblEnduranceStat";
            this.lblEnduranceStat.Size = new System.Drawing.Size(46, 17);
            this.lblEnduranceStat.TabIndex = 38;
            this.lblEnduranceStat.Text = "label1";
            // 
            // lblAgilityStat
            // 
            this.lblAgilityStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgilityStat.AutoSize = true;
            this.lblAgilityStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgilityStat.Location = new System.Drawing.Point(118, 162);
            this.lblAgilityStat.Name = "lblAgilityStat";
            this.lblAgilityStat.Size = new System.Drawing.Size(46, 17);
            this.lblAgilityStat.TabIndex = 39;
            this.lblAgilityStat.Text = "label1";
            // 
            // lblBalanceStat
            // 
            this.lblBalanceStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalanceStat.AutoSize = true;
            this.lblBalanceStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceStat.Location = new System.Drawing.Point(118, 193);
            this.lblBalanceStat.Name = "lblBalanceStat";
            this.lblBalanceStat.Size = new System.Drawing.Size(46, 17);
            this.lblBalanceStat.TabIndex = 40;
            this.lblBalanceStat.Text = "label1";
            // 
            // lblLacheStat
            // 
            this.lblLacheStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLacheStat.AutoSize = true;
            this.lblLacheStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLacheStat.Location = new System.Drawing.Point(118, 224);
            this.lblLacheStat.Name = "lblLacheStat";
            this.lblLacheStat.Size = new System.Drawing.Size(46, 17);
            this.lblLacheStat.TabIndex = 41;
            this.lblLacheStat.Text = "label1";
            // 
            // lblStaminaStat
            // 
            this.lblStaminaStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStaminaStat.AutoSize = true;
            this.lblStaminaStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaminaStat.Location = new System.Drawing.Point(118, 255);
            this.lblStaminaStat.Name = "lblStaminaStat";
            this.lblStaminaStat.Size = new System.Drawing.Size(46, 17);
            this.lblStaminaStat.TabIndex = 42;
            this.lblStaminaStat.Text = "label1";
            // 
            // lblIntelligenceStat
            // 
            this.lblIntelligenceStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIntelligenceStat.AutoSize = true;
            this.lblIntelligenceStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligenceStat.Location = new System.Drawing.Point(118, 286);
            this.lblIntelligenceStat.Name = "lblIntelligenceStat";
            this.lblIntelligenceStat.Size = new System.Drawing.Size(46, 17);
            this.lblIntelligenceStat.TabIndex = 43;
            this.lblIntelligenceStat.Text = "label1";
            // 
            // lblAvailablePoints
            // 
            this.lblAvailablePoints.AutoSize = true;
            this.lblAvailablePoints.Location = new System.Drawing.Point(26, 23);
            this.lblAvailablePoints.Name = "lblAvailablePoints";
            this.lblAvailablePoints.Size = new System.Drawing.Size(134, 17);
            this.lblAvailablePoints.TabIndex = 6;
            this.lblAvailablePoints.Text = "Available Points: ";
            // 
            // gbPlayerProfile
            // 
            this.gbPlayerProfile.Controls.Add(this.lblNoCompletedObstacles);
            this.gbPlayerProfile.Controls.Add(this.lblNoAttemptedObstacles);
            this.gbPlayerProfile.Controls.Add(this.lblExpPercentage);
            this.gbPlayerProfile.Controls.Add(this.pbExpProgress);
            this.gbPlayerProfile.Controls.Add(this.lblPlayerExperience);
            this.gbPlayerProfile.Controls.Add(this.lblPlayerLevel);
            this.gbPlayerProfile.Controls.Add(this.lblPlayerName);
            this.gbPlayerProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayerProfile.Location = new System.Drawing.Point(12, 12);
            this.gbPlayerProfile.Name = "gbPlayerProfile";
            this.gbPlayerProfile.Size = new System.Drawing.Size(277, 373);
            this.gbPlayerProfile.TabIndex = 7;
            this.gbPlayerProfile.TabStop = false;
            this.gbPlayerProfile.Text = "Player Profile";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(17, 35);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(53, 17);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Name: ";
            // 
            // lblPlayerLevel
            // 
            this.lblPlayerLevel.AutoSize = true;
            this.lblPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLevel.Location = new System.Drawing.Point(17, 76);
            this.lblPlayerLevel.Name = "lblPlayerLevel";
            this.lblPlayerLevel.Size = new System.Drawing.Size(50, 17);
            this.lblPlayerLevel.TabIndex = 1;
            this.lblPlayerLevel.Text = "Level: ";
            // 
            // lblPlayerExperience
            // 
            this.lblPlayerExperience.AutoSize = true;
            this.lblPlayerExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerExperience.Location = new System.Drawing.Point(17, 117);
            this.lblPlayerExperience.Name = "lblPlayerExperience";
            this.lblPlayerExperience.Size = new System.Drawing.Size(86, 17);
            this.lblPlayerExperience.TabIndex = 2;
            this.lblPlayerExperience.Text = "Experience: ";
            // 
            // pbExpProgress
            // 
            this.pbExpProgress.Location = new System.Drawing.Point(20, 158);
            this.pbExpProgress.Name = "pbExpProgress";
            this.pbExpProgress.Size = new System.Drawing.Size(192, 23);
            this.pbExpProgress.TabIndex = 3;
            // 
            // lblExpPercentage
            // 
            this.lblExpPercentage.AutoSize = true;
            this.lblExpPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpPercentage.Location = new System.Drawing.Point(219, 160);
            this.lblExpPercentage.Name = "lblExpPercentage";
            this.lblExpPercentage.Size = new System.Drawing.Size(20, 17);
            this.lblExpPercentage.TabIndex = 4;
            this.lblExpPercentage.Text = "%";
            // 
            // lblNoAttemptedObstacles
            // 
            this.lblNoAttemptedObstacles.AutoSize = true;
            this.lblNoAttemptedObstacles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAttemptedObstacles.Location = new System.Drawing.Point(17, 199);
            this.lblNoAttemptedObstacles.Name = "lblNoAttemptedObstacles";
            this.lblNoAttemptedObstacles.Size = new System.Drawing.Size(147, 17);
            this.lblNoAttemptedObstacles.TabIndex = 5;
            this.lblNoAttemptedObstacles.Text = "Obstacles Attempted: ";
            // 
            // lblNoCompletedObstacles
            // 
            this.lblNoCompletedObstacles.AutoSize = true;
            this.lblNoCompletedObstacles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCompletedObstacles.Location = new System.Drawing.Point(17, 240);
            this.lblNoCompletedObstacles.Name = "lblNoCompletedObstacles";
            this.lblNoCompletedObstacles.Size = new System.Drawing.Size(150, 17);
            this.lblNoCompletedObstacles.TabIndex = 6;
            this.lblNoCompletedObstacles.Text = "Obstacles Completed: ";
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPlayerProfile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbStats);
            this.Name = "PlayerInfo";
            this.Text = "PlayerInfo";
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            this.tlpPlayerStats.ResumeLayout(false);
            this.tlpPlayerStats.PerformLayout();
            this.gbPlayerProfile.ResumeLayout(false);
            this.gbPlayerProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.Button btnAddSpeed;
        private System.Windows.Forms.TableLayoutPanel tlpPlayerStats;
        private System.Windows.Forms.Button btnAddTech;
        private System.Windows.Forms.Button btnAddGrip;
        private System.Windows.Forms.Button btnAddStrength;
        private System.Windows.Forms.Button btnAddEndurance;
        private System.Windows.Forms.Button btnAddAgility;
        private System.Windows.Forms.Button btnAddBalance;
        private System.Windows.Forms.Button btnAddLache;
        private System.Windows.Forms.Button btnAddStamina;
        private System.Windows.Forms.Button btnAddIntelligence;
        private System.Windows.Forms.Button btnMinusSpeed;
        private System.Windows.Forms.Button btnMinusTech;
        private System.Windows.Forms.Button btnMinusGrip;
        private System.Windows.Forms.Button btnMinusStrength;
        private System.Windows.Forms.Button btnMinusEndurance;
        private System.Windows.Forms.Button btnMinusAgility;
        private System.Windows.Forms.Button btnMinusBalance;
        private System.Windows.Forms.Button btnMinusLache;
        private System.Windows.Forms.Button btnMinusStamina;
        private System.Windows.Forms.Button btnMinusIntelligence;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTech;
        private System.Windows.Forms.Label lblGrip;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblEndurance;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblLache;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblIntelligenceStat;
        private System.Windows.Forms.Label lblStaminaStat;
        private System.Windows.Forms.Label lblLacheStat;
        private System.Windows.Forms.Label lblBalanceStat;
        private System.Windows.Forms.Label lblAgilityStat;
        private System.Windows.Forms.Label lblEnduranceStat;
        private System.Windows.Forms.Label lblStrengthStat;
        private System.Windows.Forms.Label lblGripStat;
        private System.Windows.Forms.Label lblTechStat;
        private System.Windows.Forms.Label lblSpeedStat;
        private System.Windows.Forms.Label lblAvailablePoints;
        private System.Windows.Forms.GroupBox gbPlayerProfile;
        private System.Windows.Forms.Label lblPlayerLevel;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerExperience;
        private System.Windows.Forms.Label lblExpPercentage;
        private System.Windows.Forms.ProgressBar pbExpProgress;
        private System.Windows.Forms.Label lblNoAttemptedObstacles;
        private System.Windows.Forms.Label lblNoCompletedObstacles;
    }
}