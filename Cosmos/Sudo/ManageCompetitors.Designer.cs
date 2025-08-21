namespace Cosmos.Sudo
{
    partial class ManageCompetitors
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
            this.lstCompetitors = new System.Windows.Forms.ListBox();
            this.btnNewCompetitor = new System.Windows.Forms.Button();
            this.btnDeleteCompetitor = new System.Windows.Forms.Button();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.nudIntelligence = new System.Windows.Forms.NumericUpDown();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.nudStamina = new System.Windows.Forms.NumericUpDown();
            this.lblStamina = new System.Windows.Forms.Label();
            this.nudLache = new System.Windows.Forms.NumericUpDown();
            this.lblLache = new System.Windows.Forms.Label();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.lblBalance = new System.Windows.Forms.Label();
            this.nudAgility = new System.Windows.Forms.NumericUpDown();
            this.lblAgility = new System.Windows.Forms.Label();
            this.nudEndurance = new System.Windows.Forms.NumericUpDown();
            this.lblEndurance = new System.Windows.Forms.Label();
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.lblStrength = new System.Windows.Forms.Label();
            this.nudGrip = new System.Windows.Forms.NumericUpDown();
            this.lblGrip = new System.Windows.Forms.Label();
            this.nudTech = new System.Windows.Forms.NumericUpDown();
            this.lblTech = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tlpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStamina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCompetitors
            // 
            this.lstCompetitors.FormattingEnabled = true;
            this.lstCompetitors.ItemHeight = 16;
            this.lstCompetitors.Location = new System.Drawing.Point(13, 40);
            this.lstCompetitors.Name = "lstCompetitors";
            this.lstCompetitors.Size = new System.Drawing.Size(139, 372);
            this.lstCompetitors.TabIndex = 1;
            this.lstCompetitors.SelectedIndexChanged += new System.EventHandler(this.lstCompetitors_SelectedIndexChanged);
            // 
            // btnNewCompetitor
            // 
            this.btnNewCompetitor.Location = new System.Drawing.Point(13, 436);
            this.btnNewCompetitor.Name = "btnNewCompetitor";
            this.btnNewCompetitor.Size = new System.Drawing.Size(138, 34);
            this.btnNewCompetitor.TabIndex = 2;
            this.btnNewCompetitor.Text = "New Competitor";
            this.btnNewCompetitor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCompetitor
            // 
            this.btnDeleteCompetitor.Enabled = false;
            this.btnDeleteCompetitor.Location = new System.Drawing.Point(13, 492);
            this.btnDeleteCompetitor.Name = "btnDeleteCompetitor";
            this.btnDeleteCompetitor.Size = new System.Drawing.Size(138, 34);
            this.btnDeleteCompetitor.TabIndex = 7;
            this.btnDeleteCompetitor.Text = "Delete Competitor";
            this.btnDeleteCompetitor.UseVisualStyleBackColor = true;
            // 
            // tlpInfo
            // 
            this.tlpInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpInfo.Controls.Add(this.lblInfo, 0, 0);
            this.tlpInfo.Controls.Add(this.nudIntelligence, 1, 15);
            this.tlpInfo.Controls.Add(this.lblIntelligence, 0, 15);
            this.tlpInfo.Controls.Add(this.nudStamina, 1, 14);
            this.tlpInfo.Controls.Add(this.lblStamina, 0, 14);
            this.tlpInfo.Controls.Add(this.nudLache, 1, 13);
            this.tlpInfo.Controls.Add(this.lblLache, 0, 13);
            this.tlpInfo.Controls.Add(this.nudBalance, 1, 12);
            this.tlpInfo.Controls.Add(this.lblBalance, 0, 12);
            this.tlpInfo.Controls.Add(this.nudAgility, 1, 11);
            this.tlpInfo.Controls.Add(this.lblAgility, 0, 11);
            this.tlpInfo.Controls.Add(this.nudEndurance, 1, 10);
            this.tlpInfo.Controls.Add(this.lblEndurance, 0, 10);
            this.tlpInfo.Controls.Add(this.nudStrength, 1, 9);
            this.tlpInfo.Controls.Add(this.lblStrength, 0, 9);
            this.tlpInfo.Controls.Add(this.nudGrip, 1, 8);
            this.tlpInfo.Controls.Add(this.lblGrip, 0, 8);
            this.tlpInfo.Controls.Add(this.nudTech, 1, 7);
            this.tlpInfo.Controls.Add(this.lblTech, 0, 7);
            this.tlpInfo.Controls.Add(this.nudSpeed, 1, 6);
            this.tlpInfo.Controls.Add(this.lblSpeed, 0, 6);
            this.tlpInfo.Controls.Add(this.lblStats, 0, 5);
            this.tlpInfo.Controls.Add(this.lblGender, 0, 4);
            this.tlpInfo.Controls.Add(this.cbGender, 1, 4);
            this.tlpInfo.Controls.Add(this.lblType, 0, 3);
            this.tlpInfo.Controls.Add(this.cbType, 1, 3);
            this.tlpInfo.Controls.Add(this.tbNationality, 1, 2);
            this.tlpInfo.Controls.Add(this.lblNationality, 0, 2);
            this.tlpInfo.Controls.Add(this.tbName, 1, 1);
            this.tlpInfo.Controls.Add(this.lblName, 0, 1);
            this.tlpInfo.Location = new System.Drawing.Point(194, 40);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 16;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249971F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249972F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.247472F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.252931F));
            this.tlpInfo.Size = new System.Drawing.Size(377, 439);
            this.tlpInfo.TabIndex = 8;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfo.AutoSize = true;
            this.tlpInfo.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(32, 16);
            this.lblInfo.TabIndex = 33;
            this.lblInfo.Text = "Info";
            // 
            // nudIntelligence
            // 
            this.nudIntelligence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudIntelligence.Enabled = false;
            this.nudIntelligence.Location = new System.Drawing.Point(116, 411);
            this.nudIntelligence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntelligence.Name = "nudIntelligence";
            this.nudIntelligence.Size = new System.Drawing.Size(120, 22);
            this.nudIntelligence.TabIndex = 32;
            this.nudIntelligence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntelligence.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(3, 414);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(75, 16);
            this.lblIntelligence.TabIndex = 31;
            this.lblIntelligence.Text = "Intelligence";
            // 
            // nudStamina
            // 
            this.nudStamina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudStamina.Enabled = false;
            this.nudStamina.Location = new System.Drawing.Point(116, 381);
            this.nudStamina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStamina.Name = "nudStamina";
            this.nudStamina.Size = new System.Drawing.Size(120, 22);
            this.nudStamina.TabIndex = 30;
            this.nudStamina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStamina.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblStamina
            // 
            this.lblStamina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStamina.AutoSize = true;
            this.lblStamina.Location = new System.Drawing.Point(3, 383);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(56, 16);
            this.lblStamina.TabIndex = 29;
            this.lblStamina.Text = "Stamina";
            // 
            // nudLache
            // 
            this.nudLache.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudLache.Enabled = false;
            this.nudLache.Location = new System.Drawing.Point(116, 354);
            this.nudLache.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLache.Name = "nudLache";
            this.nudLache.Size = new System.Drawing.Size(120, 22);
            this.nudLache.TabIndex = 28;
            this.nudLache.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLache.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblLache
            // 
            this.lblLache.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLache.AutoSize = true;
            this.lblLache.Location = new System.Drawing.Point(3, 356);
            this.lblLache.Name = "lblLache";
            this.lblLache.Size = new System.Drawing.Size(44, 16);
            this.lblLache.TabIndex = 27;
            this.lblLache.Text = "Lache";
            // 
            // nudBalance
            // 
            this.nudBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudBalance.Enabled = false;
            this.nudBalance.Location = new System.Drawing.Point(116, 327);
            this.nudBalance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(120, 22);
            this.nudBalance.TabIndex = 26;
            this.nudBalance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBalance.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(3, 329);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(57, 16);
            this.lblBalance.TabIndex = 25;
            this.lblBalance.Text = "Balance";
            // 
            // nudAgility
            // 
            this.nudAgility.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudAgility.Enabled = false;
            this.nudAgility.Location = new System.Drawing.Point(116, 300);
            this.nudAgility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAgility.Name = "nudAgility";
            this.nudAgility.Size = new System.Drawing.Size(120, 22);
            this.nudAgility.TabIndex = 24;
            this.nudAgility.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAgility.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblAgility
            // 
            this.lblAgility.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgility.AutoSize = true;
            this.lblAgility.Location = new System.Drawing.Point(3, 302);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(43, 16);
            this.lblAgility.TabIndex = 23;
            this.lblAgility.Text = "Agility";
            // 
            // nudEndurance
            // 
            this.nudEndurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudEndurance.Enabled = false;
            this.nudEndurance.Location = new System.Drawing.Point(116, 273);
            this.nudEndurance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEndurance.Name = "nudEndurance";
            this.nudEndurance.Size = new System.Drawing.Size(120, 22);
            this.nudEndurance.TabIndex = 22;
            this.nudEndurance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEndurance.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblEndurance
            // 
            this.lblEndurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndurance.AutoSize = true;
            this.lblEndurance.Location = new System.Drawing.Point(3, 275);
            this.lblEndurance.Name = "lblEndurance";
            this.lblEndurance.Size = new System.Drawing.Size(72, 16);
            this.lblEndurance.TabIndex = 21;
            this.lblEndurance.Text = "Endurance";
            // 
            // nudStrength
            // 
            this.nudStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudStrength.Enabled = false;
            this.nudStrength.Location = new System.Drawing.Point(116, 246);
            this.nudStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(120, 22);
            this.nudStrength.TabIndex = 20;
            this.nudStrength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStrength.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblStrength
            // 
            this.lblStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(3, 248);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(56, 16);
            this.lblStrength.TabIndex = 19;
            this.lblStrength.Text = "Strength";
            // 
            // nudGrip
            // 
            this.nudGrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudGrip.Enabled = false;
            this.nudGrip.Location = new System.Drawing.Point(116, 219);
            this.nudGrip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrip.Name = "nudGrip";
            this.nudGrip.Size = new System.Drawing.Size(120, 22);
            this.nudGrip.TabIndex = 18;
            this.nudGrip.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrip.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblGrip
            // 
            this.lblGrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGrip.AutoSize = true;
            this.lblGrip.Location = new System.Drawing.Point(3, 221);
            this.lblGrip.Name = "lblGrip";
            this.lblGrip.Size = new System.Drawing.Size(32, 16);
            this.lblGrip.TabIndex = 17;
            this.lblGrip.Text = "Grip";
            // 
            // nudTech
            // 
            this.nudTech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudTech.Enabled = false;
            this.nudTech.Location = new System.Drawing.Point(116, 192);
            this.nudTech.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTech.Name = "nudTech";
            this.nudTech.Size = new System.Drawing.Size(120, 22);
            this.nudTech.TabIndex = 16;
            this.nudTech.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTech.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblTech
            // 
            this.lblTech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTech.AutoSize = true;
            this.lblTech.Location = new System.Drawing.Point(3, 194);
            this.lblTech.Name = "lblTech";
            this.lblTech.Size = new System.Drawing.Size(38, 16);
            this.lblTech.TabIndex = 15;
            this.lblTech.Text = "Tech";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudSpeed.Enabled = false;
            this.nudSpeed.Location = new System.Drawing.Point(116, 165);
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 22);
            this.nudSpeed.TabIndex = 14;
            this.nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(3, 167);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(48, 16);
            this.lblSpeed.TabIndex = 13;
            this.lblSpeed.Text = "Speed";
            // 
            // lblStats
            // 
            this.lblStats.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStats.AutoSize = true;
            this.tlpInfo.SetColumnSpan(this.lblStats, 2);
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(3, 140);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(42, 16);
            this.lblStats.TabIndex = 12;
            this.lblStats.Text = "Stats";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(3, 113);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbGender.Enabled = false;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(116, 111);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(242, 24);
            this.cbGender.TabIndex = 10;
            this.cbGender.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbType.Enabled = false;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Unknown",
            "Ninja",
            "OCR",
            "Sportsman",
            "Climber",
            "Fictional"});
            this.cbType.Location = new System.Drawing.Point(116, 84);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(242, 24);
            this.cbType.TabIndex = 11;
            this.cbType.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // tbNationality
            // 
            this.tbNationality.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNationality.Enabled = false;
            this.tbNationality.Location = new System.Drawing.Point(116, 57);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(242, 22);
            this.tbNationality.TabIndex = 9;
            this.tbNationality.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblNationality
            // 
            this.lblNationality.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(3, 59);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(70, 16);
            this.lblNationality.TabIndex = 3;
            this.lblNationality.Text = "Nationality";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(116, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 22);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(222, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(396, 492);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 34);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ManageCompetitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 556);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tlpInfo);
            this.Controls.Add(this.btnDeleteCompetitor);
            this.Controls.Add(this.btnNewCompetitor);
            this.Controls.Add(this.lstCompetitors);
            this.Name = "ManageCompetitors";
            this.Text = "ManageCompetitors";
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStamina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCompetitors;
        private System.Windows.Forms.Button btnNewCompetitor;
        private System.Windows.Forms.Button btnDeleteCompetitor;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudTech;
        private System.Windows.Forms.Label lblTech;
        private System.Windows.Forms.NumericUpDown nudGrip;
        private System.Windows.Forms.Label lblGrip;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.NumericUpDown nudEndurance;
        private System.Windows.Forms.Label lblEndurance;
        private System.Windows.Forms.NumericUpDown nudAgility;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.NumericUpDown nudLache;
        private System.Windows.Forms.Label lblLache;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.NumericUpDown nudIntelligence;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.NumericUpDown nudStamina;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
    }
}