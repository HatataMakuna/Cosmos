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
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.nudRequiredLevel = new System.Windows.Forms.NumericUpDown();
            this.lblRequiredLevel = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.nudDifficulty = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpInfo = new System.Windows.Forms.TabPage();
            this.tbpBaseStats = new System.Windows.Forms.TabPage();
            this.lblBaseStatsHelp = new System.Windows.Forms.Label();
            this.tlpBaseStats = new System.Windows.Forms.TableLayoutPanel();
            this.ntbBaseIntelligence = new System.Windows.Forms.TextBox();
            this.ntbBaseStamina = new System.Windows.Forms.TextBox();
            this.ntbBaseLache = new System.Windows.Forms.TextBox();
            this.ntbBaseBalance = new System.Windows.Forms.TextBox();
            this.ntbBaseAgility = new System.Windows.Forms.TextBox();
            this.ntbBaseEndurance = new System.Windows.Forms.TextBox();
            this.ntbBaseStrength = new System.Windows.Forms.TextBox();
            this.ntbBaseGrip = new System.Windows.Forms.TextBox();
            this.ntbBaseTech = new System.Windows.Forms.TextBox();
            this.lblBaseSpeed = new System.Windows.Forms.Label();
            this.lblBaseTech = new System.Windows.Forms.Label();
            this.lblBaseGrip = new System.Windows.Forms.Label();
            this.lblBaseStrength = new System.Windows.Forms.Label();
            this.lblBaseEndurance = new System.Windows.Forms.Label();
            this.lblBaseAgility = new System.Windows.Forms.Label();
            this.lblBaseBalance = new System.Windows.Forms.Label();
            this.lblBaseLache = new System.Windows.Forms.Label();
            this.lblBaseStamina = new System.Windows.Forms.Label();
            this.lblBaseIntelligence = new System.Windows.Forms.Label();
            this.ntbBaseSpeed = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tlpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequiredLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbpInfo.SuspendLayout();
            this.tbpBaseStats.SuspendLayout();
            this.tlpBaseStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstObstacles
            // 
            this.lstObstacles.FormattingEnabled = true;
            this.lstObstacles.ItemHeight = 16;
            this.lstObstacles.Location = new System.Drawing.Point(13, 40);
            this.lstObstacles.Name = "lstObstacles";
            this.lstObstacles.Size = new System.Drawing.Size(139, 308);
            this.lstObstacles.TabIndex = 0;
            this.lstObstacles.SelectedIndexChanged += new System.EventHandler(this.lstObstacles_SelectedIndexChanged);
            // 
            // btnNewObstacle
            // 
            this.btnNewObstacle.Location = new System.Drawing.Point(13, 367);
            this.btnNewObstacle.Name = "btnNewObstacle";
            this.btnNewObstacle.Size = new System.Drawing.Size(138, 34);
            this.btnNewObstacle.TabIndex = 1;
            this.btnNewObstacle.Text = "New Obstacle";
            this.btnNewObstacle.UseVisualStyleBackColor = true;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpInfo.Controls.Add(this.clbTags, 1, 4);
            this.tlpInfo.Controls.Add(this.lblTags, 0, 4);
            this.tlpInfo.Controls.Add(this.nudRequiredLevel, 1, 3);
            this.tlpInfo.Controls.Add(this.lblRequiredLevel, 0, 3);
            this.tlpInfo.Controls.Add(this.lblDifficulty, 0, 2);
            this.tlpInfo.Controls.Add(this.lblDescription, 0, 1);
            this.tlpInfo.Controls.Add(this.tbName, 1, 0);
            this.tlpInfo.Controls.Add(this.lblName, 0, 0);
            this.tlpInfo.Controls.Add(this.rtbDescription, 1, 1);
            this.tlpInfo.Controls.Add(this.nudDifficulty, 1, 2);
            this.tlpInfo.Location = new System.Drawing.Point(15, 16);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 5;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.54753F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.29278F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30798F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.1673F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.68441F));
            this.tlpInfo.Size = new System.Drawing.Size(353, 263);
            this.tlpInfo.TabIndex = 2;
            // 
            // clbTags
            // 
            this.clbTags.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clbTags.Enabled = false;
            this.clbTags.FormattingEnabled = true;
            this.clbTags.Items.AddRange(new object[] {
            "Climbing",
            "Balance",
            "Endurance",
            "Grip",
            "Intelligence",
            "Lache",
            "Speed",
            "Strength",
            "Tech"});
            this.clbTags.Location = new System.Drawing.Point(108, 164);
            this.clbTags.Name = "clbTags";
            this.clbTags.Size = new System.Drawing.Size(242, 89);
            this.clbTags.TabIndex = 3;
            this.clbTags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbTags_ItemCheck);
            // 
            // lblTags
            // 
            this.lblTags.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(3, 201);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(39, 16);
            this.lblTags.TabIndex = 8;
            this.lblTags.Text = "Tags";
            // 
            // nudRequiredLevel
            // 
            this.nudRequiredLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudRequiredLevel.Enabled = false;
            this.nudRequiredLevel.Location = new System.Drawing.Point(108, 128);
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
            this.nudRequiredLevel.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblRequiredLevel
            // 
            this.lblRequiredLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRequiredLevel.AutoSize = true;
            this.lblRequiredLevel.Location = new System.Drawing.Point(3, 131);
            this.lblRequiredLevel.Name = "lblRequiredLevel";
            this.lblRequiredLevel.Size = new System.Drawing.Size(99, 16);
            this.lblRequiredLevel.TabIndex = 6;
            this.lblRequiredLevel.Text = "Required Level";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(3, 98);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(56, 16);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 53);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(108, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 22);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rtbDescription.Enabled = false;
            this.rtbDescription.Location = new System.Drawing.Point(108, 36);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(242, 50);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // nudDifficulty
            // 
            this.nudDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudDifficulty.Enabled = false;
            this.nudDifficulty.Location = new System.Drawing.Point(108, 95);
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
            this.nudDifficulty.ValueChanged += new System.EventHandler(this.AnyFieldChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpInfo);
            this.tabControl1.Controls.Add(this.tbpBaseStats);
            this.tabControl1.Location = new System.Drawing.Point(180, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 340);
            this.tabControl1.TabIndex = 3;
            // 
            // tbpInfo
            // 
            this.tbpInfo.Controls.Add(this.tlpInfo);
            this.tbpInfo.Location = new System.Drawing.Point(4, 25);
            this.tbpInfo.Name = "tbpInfo";
            this.tbpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInfo.Size = new System.Drawing.Size(412, 311);
            this.tbpInfo.TabIndex = 0;
            this.tbpInfo.Text = "Info";
            this.tbpInfo.UseVisualStyleBackColor = true;
            // 
            // tbpBaseStats
            // 
            this.tbpBaseStats.Controls.Add(this.lblBaseStatsHelp);
            this.tbpBaseStats.Controls.Add(this.tlpBaseStats);
            this.tbpBaseStats.Location = new System.Drawing.Point(4, 25);
            this.tbpBaseStats.Name = "tbpBaseStats";
            this.tbpBaseStats.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBaseStats.Size = new System.Drawing.Size(412, 311);
            this.tbpBaseStats.TabIndex = 1;
            this.tbpBaseStats.Text = "Base Stats";
            this.tbpBaseStats.UseVisualStyleBackColor = true;
            // 
            // lblBaseStatsHelp
            // 
            this.lblBaseStatsHelp.AutoSize = true;
            this.lblBaseStatsHelp.Location = new System.Drawing.Point(23, 8);
            this.lblBaseStatsHelp.MaximumSize = new System.Drawing.Size(370, 0);
            this.lblBaseStatsHelp.Name = "lblBaseStatsHelp";
            this.lblBaseStatsHelp.Size = new System.Drawing.Size(370, 32);
            this.lblBaseStatsHelp.TabIndex = 1;
            this.lblBaseStatsHelp.Text = "All base stats below are optional, but you must input at least 1 base stat.";
            // 
            // tlpBaseStats
            // 
            this.tlpBaseStats.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpBaseStats.ColumnCount = 2;
            this.tlpBaseStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70027F));
            this.tlpBaseStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.29973F));
            this.tlpBaseStats.Controls.Add(this.ntbBaseIntelligence, 1, 9);
            this.tlpBaseStats.Controls.Add(this.ntbBaseStamina, 1, 8);
            this.tlpBaseStats.Controls.Add(this.ntbBaseLache, 1, 7);
            this.tlpBaseStats.Controls.Add(this.ntbBaseBalance, 1, 6);
            this.tlpBaseStats.Controls.Add(this.ntbBaseAgility, 1, 5);
            this.tlpBaseStats.Controls.Add(this.ntbBaseEndurance, 1, 4);
            this.tlpBaseStats.Controls.Add(this.ntbBaseStrength, 1, 3);
            this.tlpBaseStats.Controls.Add(this.ntbBaseGrip, 1, 2);
            this.tlpBaseStats.Controls.Add(this.ntbBaseTech, 1, 1);
            this.tlpBaseStats.Controls.Add(this.lblBaseSpeed, 0, 0);
            this.tlpBaseStats.Controls.Add(this.lblBaseTech, 0, 1);
            this.tlpBaseStats.Controls.Add(this.lblBaseGrip, 0, 2);
            this.tlpBaseStats.Controls.Add(this.lblBaseStrength, 0, 3);
            this.tlpBaseStats.Controls.Add(this.lblBaseEndurance, 0, 4);
            this.tlpBaseStats.Controls.Add(this.lblBaseAgility, 0, 5);
            this.tlpBaseStats.Controls.Add(this.lblBaseBalance, 0, 6);
            this.tlpBaseStats.Controls.Add(this.lblBaseLache, 0, 7);
            this.tlpBaseStats.Controls.Add(this.lblBaseStamina, 0, 8);
            this.tlpBaseStats.Controls.Add(this.lblBaseIntelligence, 0, 9);
            this.tlpBaseStats.Controls.Add(this.ntbBaseSpeed, 1, 0);
            this.tlpBaseStats.Location = new System.Drawing.Point(26, 49);
            this.tlpBaseStats.Name = "tlpBaseStats";
            this.tlpBaseStats.RowCount = 10;
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBaseStats.Size = new System.Drawing.Size(367, 245);
            this.tlpBaseStats.TabIndex = 0;
            // 
            // ntbBaseIntelligence
            // 
            this.ntbBaseIntelligence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseIntelligence.Enabled = false;
            this.ntbBaseIntelligence.Location = new System.Drawing.Point(111, 219);
            this.ntbBaseIntelligence.Name = "ntbBaseIntelligence";
            this.ntbBaseIntelligence.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseIntelligence.TabIndex = 19;
            this.ntbBaseIntelligence.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseIntelligence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseIntelligence_KeyPress);
            // 
            // ntbBaseStamina
            // 
            this.ntbBaseStamina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseStamina.Enabled = false;
            this.ntbBaseStamina.Location = new System.Drawing.Point(111, 195);
            this.ntbBaseStamina.Name = "ntbBaseStamina";
            this.ntbBaseStamina.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseStamina.TabIndex = 18;
            this.ntbBaseStamina.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseStamina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseStamina_KeyPress);
            // 
            // ntbBaseLache
            // 
            this.ntbBaseLache.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseLache.Enabled = false;
            this.ntbBaseLache.Location = new System.Drawing.Point(111, 171);
            this.ntbBaseLache.Name = "ntbBaseLache";
            this.ntbBaseLache.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseLache.TabIndex = 17;
            this.ntbBaseLache.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseLache.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseLache_KeyPress);
            // 
            // ntbBaseBalance
            // 
            this.ntbBaseBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseBalance.Enabled = false;
            this.ntbBaseBalance.Location = new System.Drawing.Point(111, 147);
            this.ntbBaseBalance.Name = "ntbBaseBalance";
            this.ntbBaseBalance.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseBalance.TabIndex = 16;
            this.ntbBaseBalance.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseBalance_KeyPress);
            // 
            // ntbBaseAgility
            // 
            this.ntbBaseAgility.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseAgility.Enabled = false;
            this.ntbBaseAgility.Location = new System.Drawing.Point(111, 123);
            this.ntbBaseAgility.Name = "ntbBaseAgility";
            this.ntbBaseAgility.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseAgility.TabIndex = 15;
            this.ntbBaseAgility.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseAgility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseAgility_KeyPress);
            // 
            // ntbBaseEndurance
            // 
            this.ntbBaseEndurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseEndurance.Enabled = false;
            this.ntbBaseEndurance.Location = new System.Drawing.Point(111, 99);
            this.ntbBaseEndurance.Name = "ntbBaseEndurance";
            this.ntbBaseEndurance.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseEndurance.TabIndex = 14;
            this.ntbBaseEndurance.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseEndurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseEndurance_KeyPress);
            // 
            // ntbBaseStrength
            // 
            this.ntbBaseStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseStrength.Enabled = false;
            this.ntbBaseStrength.Location = new System.Drawing.Point(111, 75);
            this.ntbBaseStrength.Name = "ntbBaseStrength";
            this.ntbBaseStrength.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseStrength.TabIndex = 13;
            this.ntbBaseStrength.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseStrength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseStrength_KeyPress);
            // 
            // ntbBaseGrip
            // 
            this.ntbBaseGrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseGrip.Enabled = false;
            this.ntbBaseGrip.Location = new System.Drawing.Point(111, 51);
            this.ntbBaseGrip.Name = "ntbBaseGrip";
            this.ntbBaseGrip.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseGrip.TabIndex = 12;
            this.ntbBaseGrip.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseGrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseGrip_KeyPress);
            // 
            // ntbBaseTech
            // 
            this.ntbBaseTech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseTech.Enabled = false;
            this.ntbBaseTech.Location = new System.Drawing.Point(111, 27);
            this.ntbBaseTech.Name = "ntbBaseTech";
            this.ntbBaseTech.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseTech.TabIndex = 11;
            this.ntbBaseTech.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseTech.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseTech_KeyPress);
            // 
            // lblBaseSpeed
            // 
            this.lblBaseSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseSpeed.AutoSize = true;
            this.lblBaseSpeed.Location = new System.Drawing.Point(3, 4);
            this.lblBaseSpeed.Name = "lblBaseSpeed";
            this.lblBaseSpeed.Size = new System.Drawing.Size(48, 16);
            this.lblBaseSpeed.TabIndex = 0;
            this.lblBaseSpeed.Text = "Speed";
            // 
            // lblBaseTech
            // 
            this.lblBaseTech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseTech.AutoSize = true;
            this.lblBaseTech.Location = new System.Drawing.Point(3, 28);
            this.lblBaseTech.Name = "lblBaseTech";
            this.lblBaseTech.Size = new System.Drawing.Size(38, 16);
            this.lblBaseTech.TabIndex = 1;
            this.lblBaseTech.Text = "Tech";
            // 
            // lblBaseGrip
            // 
            this.lblBaseGrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseGrip.AutoSize = true;
            this.lblBaseGrip.Location = new System.Drawing.Point(3, 52);
            this.lblBaseGrip.Name = "lblBaseGrip";
            this.lblBaseGrip.Size = new System.Drawing.Size(32, 16);
            this.lblBaseGrip.TabIndex = 2;
            this.lblBaseGrip.Text = "Grip";
            // 
            // lblBaseStrength
            // 
            this.lblBaseStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseStrength.AutoSize = true;
            this.lblBaseStrength.Location = new System.Drawing.Point(3, 76);
            this.lblBaseStrength.Name = "lblBaseStrength";
            this.lblBaseStrength.Size = new System.Drawing.Size(56, 16);
            this.lblBaseStrength.TabIndex = 3;
            this.lblBaseStrength.Text = "Strength";
            // 
            // lblBaseEndurance
            // 
            this.lblBaseEndurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseEndurance.AutoSize = true;
            this.lblBaseEndurance.Location = new System.Drawing.Point(3, 100);
            this.lblBaseEndurance.Name = "lblBaseEndurance";
            this.lblBaseEndurance.Size = new System.Drawing.Size(72, 16);
            this.lblBaseEndurance.TabIndex = 4;
            this.lblBaseEndurance.Text = "Endurance";
            // 
            // lblBaseAgility
            // 
            this.lblBaseAgility.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseAgility.AutoSize = true;
            this.lblBaseAgility.Location = new System.Drawing.Point(3, 124);
            this.lblBaseAgility.Name = "lblBaseAgility";
            this.lblBaseAgility.Size = new System.Drawing.Size(43, 16);
            this.lblBaseAgility.TabIndex = 5;
            this.lblBaseAgility.Text = "Agility";
            // 
            // lblBaseBalance
            // 
            this.lblBaseBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseBalance.AutoSize = true;
            this.lblBaseBalance.Location = new System.Drawing.Point(3, 148);
            this.lblBaseBalance.Name = "lblBaseBalance";
            this.lblBaseBalance.Size = new System.Drawing.Size(57, 16);
            this.lblBaseBalance.TabIndex = 6;
            this.lblBaseBalance.Text = "Balance";
            // 
            // lblBaseLache
            // 
            this.lblBaseLache.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseLache.AutoSize = true;
            this.lblBaseLache.Location = new System.Drawing.Point(3, 172);
            this.lblBaseLache.Name = "lblBaseLache";
            this.lblBaseLache.Size = new System.Drawing.Size(44, 16);
            this.lblBaseLache.TabIndex = 7;
            this.lblBaseLache.Text = "Lache";
            // 
            // lblBaseStamina
            // 
            this.lblBaseStamina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseStamina.AutoSize = true;
            this.lblBaseStamina.Location = new System.Drawing.Point(3, 196);
            this.lblBaseStamina.Name = "lblBaseStamina";
            this.lblBaseStamina.Size = new System.Drawing.Size(56, 16);
            this.lblBaseStamina.TabIndex = 8;
            this.lblBaseStamina.Text = "Stamina";
            // 
            // lblBaseIntelligence
            // 
            this.lblBaseIntelligence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaseIntelligence.AutoSize = true;
            this.lblBaseIntelligence.Location = new System.Drawing.Point(3, 222);
            this.lblBaseIntelligence.Name = "lblBaseIntelligence";
            this.lblBaseIntelligence.Size = new System.Drawing.Size(75, 16);
            this.lblBaseIntelligence.TabIndex = 9;
            this.lblBaseIntelligence.Text = "Intelligence";
            // 
            // ntbBaseSpeed
            // 
            this.ntbBaseSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntbBaseSpeed.Enabled = false;
            this.ntbBaseSpeed.Location = new System.Drawing.Point(111, 3);
            this.ntbBaseSpeed.Name = "ntbBaseSpeed";
            this.ntbBaseSpeed.Size = new System.Drawing.Size(243, 22);
            this.ntbBaseSpeed.TabIndex = 10;
            this.ntbBaseSpeed.TextChanged += new System.EventHandler(this.AnyFieldChanged);
            this.ntbBaseSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntbBaseSpeed_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(226, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(399, 367);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 34);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ManageObstacles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 431);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnNewObstacle);
            this.Controls.Add(this.lstObstacles);
            this.Name = "ManageObstacles";
            this.Text = "ManageObstacles";
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequiredLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbpInfo.ResumeLayout(false);
            this.tbpBaseStats.ResumeLayout(false);
            this.tbpBaseStats.PerformLayout();
            this.tlpBaseStats.ResumeLayout(false);
            this.tlpBaseStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstObstacles;
        private System.Windows.Forms.Button btnNewObstacle;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.NumericUpDown nudDifficulty;
        private System.Windows.Forms.Label lblRequiredLevel;
        private System.Windows.Forms.NumericUpDown nudRequiredLevel;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.CheckedListBox clbTags;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInfo;
        private System.Windows.Forms.TabPage tbpBaseStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tlpBaseStats;
        private System.Windows.Forms.Label lblBaseStatsHelp;
        private System.Windows.Forms.Label lblBaseSpeed;
        private System.Windows.Forms.Label lblBaseTech;
        private System.Windows.Forms.Label lblBaseGrip;
        private System.Windows.Forms.Label lblBaseStrength;
        private System.Windows.Forms.Label lblBaseEndurance;
        private System.Windows.Forms.Label lblBaseAgility;
        private System.Windows.Forms.Label lblBaseBalance;
        private System.Windows.Forms.Label lblBaseLache;
        private System.Windows.Forms.Label lblBaseStamina;
        private System.Windows.Forms.Label lblBaseIntelligence;
        private System.Windows.Forms.TextBox ntbBaseSpeed;
        private System.Windows.Forms.TextBox ntbBaseTech;
        private System.Windows.Forms.TextBox ntbBaseGrip;
        private System.Windows.Forms.TextBox ntbBaseStrength;
        private System.Windows.Forms.TextBox ntbBaseEndurance;
        private System.Windows.Forms.TextBox ntbBaseAgility;
        private System.Windows.Forms.TextBox ntbBaseBalance;
        private System.Windows.Forms.TextBox ntbBaseLache;
        private System.Windows.Forms.TextBox ntbBaseStamina;
        private System.Windows.Forms.TextBox ntbBaseIntelligence;
    }
}