﻿namespace ConfigManiac
{
    partial class MainForm
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
            this.eclipseEngine1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ConfigManager = new System.Windows.Forms.TabControl();
            this.GCPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ScenePage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ClearCatButton = new System.Windows.Forms.Button();
            this.DelCatButton = new System.Windows.Forms.Button();
            this.AddCatButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.GCCatNameBox = new System.Windows.Forms.TextBox();
            this.StageDetailsBox = new System.Windows.Forms.GroupBox();
            this.GCStageModeNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.GCClearStgButton = new System.Windows.Forms.Button();
            this.GCDelStgButton = new System.Windows.Forms.Button();
            this.GCAddStgButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.GCStgIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GCStgFolderBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GCStgNameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CategoryListBox = new System.Windows.Forms.ComboBox();
            this.GCStageBox = new System.Windows.Forms.ListBox();
            this.ObjectsPage = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GCObjCFGBox = new System.Windows.Forms.TextBox();
            this.GCDelObjButton = new System.Windows.Forms.Button();
            this.GCObjListBox = new System.Windows.Forms.ListBox();
            this.GCAddObjButton = new System.Windows.Forms.Button();
            this.SoundFXPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GCMaxPlayNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GCSFXPathBox = new System.Windows.Forms.TextBox();
            this.GCRemoveSFXButton = new System.Windows.Forms.Button();
            this.GCSoundFXListBox = new System.Windows.Forms.ListBox();
            this.GCAddSFXButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.StartScnBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.StartCatBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.VersionBox = new System.Windows.Forms.TextBox();
            this.chat = new System.Windows.Forms.GroupBox();
            this.SubNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GameNameTxt = new System.Windows.Forms.TextBox();
            this.SCPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.SCObjectsPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LoadGlobalObjectsCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SCObjectNameBox = new System.Windows.Forms.TextBox();
            this.SCDelObjButton = new System.Windows.Forms.Button();
            this.SCObjectList = new System.Windows.Forms.ListBox();
            this.SCAddObjButton = new System.Windows.Forms.Button();
            this.SCSFXPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SCSFXMaxPlayNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SCSFXPathBox = new System.Windows.Forms.TextBox();
            this.SCDelSFXButton = new System.Windows.Forms.Button();
            this.SCSFXList = new System.Windows.Forms.ListBox();
            this.SCAddSFXButton = new System.Windows.Forms.Button();
            this.RCPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.VarValueBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.VarTypeBox = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.DelEntryButton = new System.Windows.Forms.Button();
            this.AddEntryButton = new System.Windows.Forms.Button();
            this.CMemEntryBox = new System.Windows.Forms.ListBox();
            this.ClearVarButton = new System.Windows.Forms.Button();
            this.DelVarButton = new System.Windows.Forms.Button();
            this.AddVarButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.VarNameBox = new System.Windows.Forms.TextBox();
            this.VarListBox = new System.Windows.Forms.ListBox();
            this.CMemValueNUD = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.ConfigManager.SuspendLayout();
            this.GCPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ScenePage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.StageDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCStageModeNUD)).BeginInit();
            this.ObjectsPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SoundFXPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCMaxPlayNUD)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.chat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SCPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SCObjectsPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SCSFXPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCSFXMaxPlayNUD)).BeginInit();
            this.RCPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CMemValueNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eclipseEngine1ToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // eclipseEngine1ToolStripMenuItem
            // 
            this.eclipseEngine1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.eclipseEngine1ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eclipseEngine1ToolStripMenuItem.Name = "eclipseEngine1ToolStripMenuItem";
            this.eclipseEngine1ToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.eclipseEngine1ToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveAsToolStripMenuItem.Text = "Save as....";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ConfigManager
            // 
            this.ConfigManager.Controls.Add(this.GCPage);
            this.ConfigManager.Controls.Add(this.SCPage);
            this.ConfigManager.Controls.Add(this.RCPage);
            this.ConfigManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigManager.Location = new System.Drawing.Point(0, 24);
            this.ConfigManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfigManager.Name = "ConfigManager";
            this.ConfigManager.SelectedIndex = 0;
            this.ConfigManager.Size = new System.Drawing.Size(897, 478);
            this.ConfigManager.TabIndex = 1;
            this.ConfigManager.SelectedIndexChanged += new System.EventHandler(this.ConfigManager_TabIndexChanged);
            this.ConfigManager.TabIndexChanged += new System.EventHandler(this.ConfigManager_TabIndexChanged);
            // 
            // GCPage
            // 
            this.GCPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.GCPage.Controls.Add(this.tabControl1);
            this.GCPage.Controls.Add(this.groupBox8);
            this.GCPage.Location = new System.Drawing.Point(4, 22);
            this.GCPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCPage.Name = "GCPage";
            this.GCPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCPage.Size = new System.Drawing.Size(889, 452);
            this.GCPage.TabIndex = 0;
            this.GCPage.Text = "Gameconfig Editor";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ScenePage);
            this.tabControl1.Controls.Add(this.ObjectsPage);
            this.tabControl1.Controls.Add(this.SoundFXPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(349, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 448);
            this.tabControl1.TabIndex = 49;
            // 
            // ScenePage
            // 
            this.ScenePage.Controls.Add(this.groupBox5);
            this.ScenePage.Location = new System.Drawing.Point(4, 22);
            this.ScenePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScenePage.Name = "ScenePage";
            this.ScenePage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScenePage.Size = new System.Drawing.Size(530, 422);
            this.ScenePage.TabIndex = 0;
            this.ScenePage.Text = "Scenes";
            this.ScenePage.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox5.Controls.Add(this.ClearCatButton);
            this.groupBox5.Controls.Add(this.DelCatButton);
            this.groupBox5.Controls.Add(this.AddCatButton);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.GCCatNameBox);
            this.groupBox5.Controls.Add(this.StageDetailsBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.CategoryListBox);
            this.groupBox5.Controls.Add(this.GCStageBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox5.Location = new System.Drawing.Point(2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(526, 418);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Category Details";
            // 
            // ClearCatButton
            // 
            this.ClearCatButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearCatButton.Location = new System.Drawing.Point(422, 102);
            this.ClearCatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearCatButton.Name = "ClearCatButton";
            this.ClearCatButton.Size = new System.Drawing.Size(51, 27);
            this.ClearCatButton.TabIndex = 59;
            this.ClearCatButton.Text = "Clear";
            this.ClearCatButton.UseVisualStyleBackColor = true;
            this.ClearCatButton.Click += new System.EventHandler(this.ClearCatButton_Click);
            // 
            // DelCatButton
            // 
            this.DelCatButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelCatButton.Location = new System.Drawing.Point(366, 102);
            this.DelCatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelCatButton.Name = "DelCatButton";
            this.DelCatButton.Size = new System.Drawing.Size(51, 27);
            this.DelCatButton.TabIndex = 58;
            this.DelCatButton.Text = "Del";
            this.DelCatButton.UseVisualStyleBackColor = true;
            this.DelCatButton.Click += new System.EventHandler(this.DelCatButton_Click);
            // 
            // AddCatButton
            // 
            this.AddCatButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddCatButton.Location = new System.Drawing.Point(310, 102);
            this.AddCatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCatButton.Name = "AddCatButton";
            this.AddCatButton.Size = new System.Drawing.Size(51, 27);
            this.AddCatButton.TabIndex = 57;
            this.AddCatButton.Text = "Add";
            this.AddCatButton.UseVisualStyleBackColor = true;
            this.AddCatButton.Click += new System.EventHandler(this.AddCatButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(308, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Category Name";
            // 
            // GCCatNameBox
            // 
            this.GCCatNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCCatNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCCatNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCCatNameBox.Location = new System.Drawing.Point(310, 76);
            this.GCCatNameBox.Name = "GCCatNameBox";
            this.GCCatNameBox.Size = new System.Drawing.Size(197, 20);
            this.GCCatNameBox.TabIndex = 53;
            this.GCCatNameBox.TextChanged += new System.EventHandler(this.GCCatNameBox_TextChanged);
            // 
            // StageDetailsBox
            // 
            this.StageDetailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StageDetailsBox.Controls.Add(this.GCStageModeNUD);
            this.StageDetailsBox.Controls.Add(this.label7);
            this.StageDetailsBox.Controls.Add(this.GCClearStgButton);
            this.StageDetailsBox.Controls.Add(this.GCDelStgButton);
            this.StageDetailsBox.Controls.Add(this.GCAddStgButton);
            this.StageDetailsBox.Controls.Add(this.label6);
            this.StageDetailsBox.Controls.Add(this.GCStgIDBox);
            this.StageDetailsBox.Controls.Add(this.label4);
            this.StageDetailsBox.Controls.Add(this.GCStgFolderBox);
            this.StageDetailsBox.Controls.Add(this.label3);
            this.StageDetailsBox.Controls.Add(this.GCStgNameBox);
            this.StageDetailsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StageDetailsBox.Location = new System.Drawing.Point(309, 134);
            this.StageDetailsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StageDetailsBox.Name = "StageDetailsBox";
            this.StageDetailsBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StageDetailsBox.Size = new System.Drawing.Size(213, 274);
            this.StageDetailsBox.TabIndex = 52;
            this.StageDetailsBox.TabStop = false;
            this.StageDetailsBox.Text = "Stage Details";
            // 
            // GCStageModeNUD
            // 
            this.GCStageModeNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCStageModeNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCStageModeNUD.Location = new System.Drawing.Point(8, 146);
            this.GCStageModeNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCStageModeNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GCStageModeNUD.Name = "GCStageModeNUD";
            this.GCStageModeNUD.Size = new System.Drawing.Size(197, 20);
            this.GCStageModeNUD.TabIndex = 59;
            this.GCStageModeNUD.ValueChanged += new System.EventHandler(this.GCStageModeNUD_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(5, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Stage Mode";
            // 
            // GCClearStgButton
            // 
            this.GCClearStgButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GCClearStgButton.Location = new System.Drawing.Point(118, 169);
            this.GCClearStgButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCClearStgButton.Name = "GCClearStgButton";
            this.GCClearStgButton.Size = new System.Drawing.Size(51, 27);
            this.GCClearStgButton.TabIndex = 56;
            this.GCClearStgButton.Text = "Clear";
            this.GCClearStgButton.UseVisualStyleBackColor = true;
            this.GCClearStgButton.Click += new System.EventHandler(this.ClearStgButton_Click);
            // 
            // GCDelStgButton
            // 
            this.GCDelStgButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GCDelStgButton.Location = new System.Drawing.Point(63, 169);
            this.GCDelStgButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCDelStgButton.Name = "GCDelStgButton";
            this.GCDelStgButton.Size = new System.Drawing.Size(51, 27);
            this.GCDelStgButton.TabIndex = 55;
            this.GCDelStgButton.Text = "Del";
            this.GCDelStgButton.UseVisualStyleBackColor = true;
            this.GCDelStgButton.Click += new System.EventHandler(this.DelStgButton_Click);
            // 
            // GCAddStgButton
            // 
            this.GCAddStgButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GCAddStgButton.Location = new System.Drawing.Point(8, 169);
            this.GCAddStgButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCAddStgButton.Name = "GCAddStgButton";
            this.GCAddStgButton.Size = new System.Drawing.Size(51, 27);
            this.GCAddStgButton.TabIndex = 54;
            this.GCAddStgButton.Text = "Add";
            this.GCAddStgButton.UseVisualStyleBackColor = true;
            this.GCAddStgButton.Click += new System.EventHandler(this.AddStgButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(5, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "StageID";
            // 
            // GCStgIDBox
            // 
            this.GCStgIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCStgIDBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCStgIDBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCStgIDBox.Location = new System.Drawing.Point(8, 108);
            this.GCStgIDBox.Name = "GCStgIDBox";
            this.GCStgIDBox.Size = new System.Drawing.Size(198, 20);
            this.GCStgIDBox.TabIndex = 52;
            this.GCStgIDBox.TextChanged += new System.EventHandler(this.StgIDBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(5, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Stage Folder";
            // 
            // GCStgFolderBox
            // 
            this.GCStgFolderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCStgFolderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCStgFolderBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCStgFolderBox.Location = new System.Drawing.Point(8, 70);
            this.GCStgFolderBox.Name = "GCStgFolderBox";
            this.GCStgFolderBox.Size = new System.Drawing.Size(198, 20);
            this.GCStgFolderBox.TabIndex = 50;
            this.GCStgFolderBox.TextChanged += new System.EventHandler(this.StgFolderBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Stage Name";
            // 
            // GCStgNameBox
            // 
            this.GCStgNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCStgNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCStgNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCStgNameBox.Location = new System.Drawing.Point(8, 32);
            this.GCStgNameBox.Name = "GCStgNameBox";
            this.GCStgNameBox.Size = new System.Drawing.Size(198, 20);
            this.GCStgNameBox.TabIndex = 48;
            this.GCStgNameBox.TextChanged += new System.EventHandler(this.StgNameBox_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(307, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Selected Category";
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Items.AddRange(new object[] {
            "Presentation Stages",
            "Regular Stages",
            "Special Stages",
            "Bonus Stages"});
            this.CategoryListBox.Location = new System.Drawing.Point(309, 37);
            this.CategoryListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(214, 21);
            this.CategoryListBox.TabIndex = 49;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // GCStageBox
            // 
            this.GCStageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.GCStageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GCStageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCStageBox.FormattingEnabled = true;
            this.GCStageBox.Location = new System.Drawing.Point(3, 16);
            this.GCStageBox.Name = "GCStageBox";
            this.GCStageBox.Size = new System.Drawing.Size(300, 399);
            this.GCStageBox.TabIndex = 0;
            this.GCStageBox.SelectedIndexChanged += new System.EventHandler(this.StageBox_SelectedIndexChanged);
            // 
            // ObjectsPage
            // 
            this.ObjectsPage.Controls.Add(this.groupBox7);
            this.ObjectsPage.Location = new System.Drawing.Point(4, 22);
            this.ObjectsPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ObjectsPage.Name = "ObjectsPage";
            this.ObjectsPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ObjectsPage.Size = new System.Drawing.Size(530, 422);
            this.ObjectsPage.TabIndex = 1;
            this.ObjectsPage.Text = "Objects";
            this.ObjectsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.GCObjCFGBox);
            this.groupBox7.Controls.Add(this.GCDelObjButton);
            this.groupBox7.Controls.Add(this.GCObjListBox);
            this.groupBox7.Controls.Add(this.GCAddObjButton);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox7.Location = new System.Drawing.Point(2, 2);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(526, 418);
            this.groupBox7.TabIndex = 47;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Object List";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(307, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Object Name";
            // 
            // GCObjCFGBox
            // 
            this.GCObjCFGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GCObjCFGBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCObjCFGBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCObjCFGBox.Location = new System.Drawing.Point(309, 32);
            this.GCObjCFGBox.Name = "GCObjCFGBox";
            this.GCObjCFGBox.Size = new System.Drawing.Size(213, 20);
            this.GCObjCFGBox.TabIndex = 69;
            this.GCObjCFGBox.TextChanged += new System.EventHandler(this.ObjCFGBox_TextChanged);
            // 
            // GCDelObjButton
            // 
            this.GCDelObjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GCDelObjButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GCDelObjButton.Location = new System.Drawing.Point(309, 92);
            this.GCDelObjButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCDelObjButton.Name = "GCDelObjButton";
            this.GCDelObjButton.Size = new System.Drawing.Size(213, 27);
            this.GCDelObjButton.TabIndex = 55;
            this.GCDelObjButton.Text = "Remove Object";
            this.GCDelObjButton.UseVisualStyleBackColor = true;
            this.GCDelObjButton.Click += new System.EventHandler(this.DelObjButton_Click);
            // 
            // GCObjListBox
            // 
            this.GCObjListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.GCObjListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GCObjListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCObjListBox.FormattingEnabled = true;
            this.GCObjListBox.Location = new System.Drawing.Point(2, 15);
            this.GCObjListBox.Name = "GCObjListBox";
            this.GCObjListBox.Size = new System.Drawing.Size(300, 401);
            this.GCObjListBox.TabIndex = 1;
            this.GCObjListBox.Click += new System.EventHandler(this.ObjListBox_SelectedIndexChanged);
            this.GCObjListBox.SelectedIndexChanged += new System.EventHandler(this.ObjListBox_SelectedIndexChanged);
            // 
            // GCAddObjButton
            // 
            this.GCAddObjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GCAddObjButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GCAddObjButton.Location = new System.Drawing.Point(309, 56);
            this.GCAddObjButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCAddObjButton.Name = "GCAddObjButton";
            this.GCAddObjButton.Size = new System.Drawing.Size(213, 27);
            this.GCAddObjButton.TabIndex = 54;
            this.GCAddObjButton.Text = "Add Object";
            this.GCAddObjButton.UseVisualStyleBackColor = true;
            this.GCAddObjButton.Click += new System.EventHandler(this.AddObjButton_Click);
            // 
            // SoundFXPage
            // 
            this.SoundFXPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SoundFXPage.Controls.Add(this.groupBox2);
            this.SoundFXPage.Location = new System.Drawing.Point(4, 22);
            this.SoundFXPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SoundFXPage.Name = "SoundFXPage";
            this.SoundFXPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SoundFXPage.Size = new System.Drawing.Size(530, 422);
            this.SoundFXPage.TabIndex = 2;
            this.SoundFXPage.Text = "SoundFX";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox2.Controls.Add(this.GCMaxPlayNUD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GCSFXPathBox);
            this.groupBox2.Controls.Add(this.GCRemoveSFXButton);
            this.groupBox2.Controls.Add(this.GCSoundFXListBox);
            this.groupBox2.Controls.Add(this.GCAddSFXButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(526, 418);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SoundFX List";
            // 
            // GCMaxPlayNUD
            // 
            this.GCMaxPlayNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCMaxPlayNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCMaxPlayNUD.Location = new System.Drawing.Point(309, 70);
            this.GCMaxPlayNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCMaxPlayNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GCMaxPlayNUD.Name = "GCMaxPlayNUD";
            this.GCMaxPlayNUD.Size = new System.Drawing.Size(213, 20);
            this.GCMaxPlayNUD.TabIndex = 72;
            this.GCMaxPlayNUD.ValueChanged += new System.EventHandler(this.GCMaxPlayNUD_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(307, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Max Concurrent Play";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(307, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "SFX Path";
            // 
            // GCSFXPathBox
            // 
            this.GCSFXPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GCSFXPathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCSFXPathBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCSFXPathBox.Location = new System.Drawing.Point(309, 32);
            this.GCSFXPathBox.Name = "GCSFXPathBox";
            this.GCSFXPathBox.Size = new System.Drawing.Size(214, 20);
            this.GCSFXPathBox.TabIndex = 67;
            this.GCSFXPathBox.TextChanged += new System.EventHandler(this.SFXPathBox_TextChanged);
            // 
            // GCRemoveSFXButton
            // 
            this.GCRemoveSFXButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GCRemoveSFXButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GCRemoveSFXButton.Location = new System.Drawing.Point(309, 124);
            this.GCRemoveSFXButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCRemoveSFXButton.Name = "GCRemoveSFXButton";
            this.GCRemoveSFXButton.Size = new System.Drawing.Size(213, 27);
            this.GCRemoveSFXButton.TabIndex = 55;
            this.GCRemoveSFXButton.Text = "Remove SFX";
            this.GCRemoveSFXButton.UseVisualStyleBackColor = true;
            this.GCRemoveSFXButton.Click += new System.EventHandler(this.RemoveSFXButton_Click);
            // 
            // GCSoundFXListBox
            // 
            this.GCSoundFXListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.GCSoundFXListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GCSoundFXListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GCSoundFXListBox.FormattingEnabled = true;
            this.GCSoundFXListBox.Location = new System.Drawing.Point(2, 15);
            this.GCSoundFXListBox.Name = "GCSoundFXListBox";
            this.GCSoundFXListBox.Size = new System.Drawing.Size(300, 401);
            this.GCSoundFXListBox.TabIndex = 1;
            this.GCSoundFXListBox.SelectedIndexChanged += new System.EventHandler(this.SoundFXListBox_SelectedIndexChanged);
            // 
            // GCAddSFXButton
            // 
            this.GCAddSFXButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GCAddSFXButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GCAddSFXButton.Location = new System.Drawing.Point(309, 93);
            this.GCAddSFXButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GCAddSFXButton.Name = "GCAddSFXButton";
            this.GCAddSFXButton.Size = new System.Drawing.Size(214, 27);
            this.GCAddSFXButton.TabIndex = 54;
            this.GCAddSFXButton.Text = "Add SFX";
            this.GCAddSFXButton.UseVisualStyleBackColor = true;
            this.GCAddSFXButton.TextChanged += new System.EventHandler(this.AddSFXButton_Click);
            this.GCAddSFXButton.Click += new System.EventHandler(this.AddSFXButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.chat);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox8.Location = new System.Drawing.Point(2, -2);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox8.Size = new System.Drawing.Size(355, 478);
            this.groupBox8.TabIndex = 48;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "General Data";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox9.Location = new System.Drawing.Point(2, 142);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(350, 335);
            this.groupBox9.TabIndex = 48;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Misc";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.StartScnBox);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.StartCatBox);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox11.Location = new System.Drawing.Point(2, 80);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(341, 115);
            this.groupBox11.TabIndex = 49;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Startup Scenes";
            // 
            // StartScnBox
            // 
            this.StartScnBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartScnBox.BackColor = System.Drawing.SystemColors.Window;
            this.StartScnBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartScnBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartScnBox.FormattingEnabled = true;
            this.StartScnBox.Location = new System.Drawing.Point(10, 75);
            this.StartScnBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartScnBox.Name = "StartScnBox";
            this.StartScnBox.Size = new System.Drawing.Size(320, 21);
            this.StartScnBox.TabIndex = 3;
            this.StartScnBox.SelectedIndexChanged += new System.EventHandler(this.StartScnBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Starting Scene";
            // 
            // StartCatBox
            // 
            this.StartCatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCatBox.BackColor = System.Drawing.SystemColors.Window;
            this.StartCatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartCatBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartCatBox.FormattingEnabled = true;
            this.StartCatBox.Location = new System.Drawing.Point(10, 36);
            this.StartCatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartCatBox.Name = "StartCatBox";
            this.StartCatBox.Size = new System.Drawing.Size(320, 21);
            this.StartCatBox.TabIndex = 1;
            this.StartCatBox.SelectedIndexChanged += new System.EventHandler(this.StartCatBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Starting Category";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.VersionBox);
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox10.Location = new System.Drawing.Point(2, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(341, 55);
            this.groupBox10.TabIndex = 48;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Game Version";
            // 
            // VersionBox
            // 
            this.VersionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VersionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VersionBox.Location = new System.Drawing.Point(7, 20);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Size = new System.Drawing.Size(324, 20);
            this.VersionBox.TabIndex = 0;
            this.VersionBox.Text = "1.06";
            this.VersionBox.TextChanged += new System.EventHandler(this.VersionBox_TextChanged);
            // 
            // chat
            // 
            this.chat.Controls.Add(this.SubNameTxt);
            this.chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chat.Location = new System.Drawing.Point(5, 80);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(341, 55);
            this.chat.TabIndex = 47;
            this.chat.TabStop = false;
            this.chat.Text = "Game Subname";
            // 
            // SubNameTxt
            // 
            this.SubNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubNameTxt.Location = new System.Drawing.Point(7, 20);
            this.SubNameTxt.Name = "SubNameTxt";
            this.SubNameTxt.Size = new System.Drawing.Size(324, 20);
            this.SubNameTxt.TabIndex = 0;
            this.SubNameTxt.Text = "This is a game dawg!";
            this.SubNameTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GameNameTxt);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 55);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Name";
            // 
            // GameNameTxt
            // 
            this.GameNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GameNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GameNameTxt.Location = new System.Drawing.Point(7, 20);
            this.GameNameTxt.Name = "GameNameTxt";
            this.GameNameTxt.Size = new System.Drawing.Size(324, 20);
            this.GameNameTxt.TabIndex = 0;
            this.GameNameTxt.Text = "RSDKv5 Game";
            this.GameNameTxt.TextChanged += new System.EventHandler(this.GameNameTxt_TextChanged);
            // 
            // SCPage
            // 
            this.SCPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SCPage.Controls.Add(this.tabControl2);
            this.SCPage.Location = new System.Drawing.Point(4, 22);
            this.SCPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCPage.Name = "SCPage";
            this.SCPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCPage.Size = new System.Drawing.Size(889, 453);
            this.SCPage.TabIndex = 1;
            this.SCPage.Text = "Stageconfig Editor";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.SCObjectsPage);
            this.tabControl2.Controls.Add(this.SCSFXPage);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(2, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(885, 449);
            this.tabControl2.TabIndex = 48;
            // 
            // SCObjectsPage
            // 
            this.SCObjectsPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SCObjectsPage.Controls.Add(this.groupBox4);
            this.SCObjectsPage.Location = new System.Drawing.Point(4, 22);
            this.SCObjectsPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCObjectsPage.Name = "SCObjectsPage";
            this.SCObjectsPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCObjectsPage.Size = new System.Drawing.Size(877, 423);
            this.SCObjectsPage.TabIndex = 1;
            this.SCObjectsPage.Text = "Objects";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox4.Controls.Add(this.LoadGlobalObjectsCB);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.SCObjectNameBox);
            this.groupBox4.Controls.Add(this.SCDelObjButton);
            this.groupBox4.Controls.Add(this.SCObjectList);
            this.groupBox4.Controls.Add(this.SCAddObjButton);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Location = new System.Drawing.Point(2, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(873, 419);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Object List";
            // 
            // LoadGlobalObjectsCB
            // 
            this.LoadGlobalObjectsCB.AutoSize = true;
            this.LoadGlobalObjectsCB.Location = new System.Drawing.Point(469, 121);
            this.LoadGlobalObjectsCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadGlobalObjectsCB.Name = "LoadGlobalObjectsCB";
            this.LoadGlobalObjectsCB.Size = new System.Drawing.Size(122, 17);
            this.LoadGlobalObjectsCB.TabIndex = 71;
            this.LoadGlobalObjectsCB.Text = "Load Global Objects";
            this.LoadGlobalObjectsCB.UseVisualStyleBackColor = true;
            this.LoadGlobalObjectsCB.CheckedChanged += new System.EventHandler(this.LoadGlobalObjectsCB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(463, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Object Name";
            // 
            // SCObjectNameBox
            // 
            this.SCObjectNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SCObjectNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SCObjectNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SCObjectNameBox.Location = new System.Drawing.Point(466, 32);
            this.SCObjectNameBox.Name = "SCObjectNameBox";
            this.SCObjectNameBox.Size = new System.Drawing.Size(403, 20);
            this.SCObjectNameBox.TabIndex = 69;
            this.SCObjectNameBox.TextChanged += new System.EventHandler(this.SCObjectNameBox_TextChanged);
            // 
            // SCDelObjButton
            // 
            this.SCDelObjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SCDelObjButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SCDelObjButton.Location = new System.Drawing.Point(466, 91);
            this.SCDelObjButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCDelObjButton.Name = "SCDelObjButton";
            this.SCDelObjButton.Size = new System.Drawing.Size(403, 27);
            this.SCDelObjButton.TabIndex = 55;
            this.SCDelObjButton.Text = "Remove Object";
            this.SCDelObjButton.UseVisualStyleBackColor = true;
            this.SCDelObjButton.Click += new System.EventHandler(this.SCDelObjButton_Click);
            // 
            // SCObjectList
            // 
            this.SCObjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SCObjectList.Dock = System.Windows.Forms.DockStyle.Left;
            this.SCObjectList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SCObjectList.FormattingEnabled = true;
            this.SCObjectList.Location = new System.Drawing.Point(2, 15);
            this.SCObjectList.Name = "SCObjectList";
            this.SCObjectList.Size = new System.Drawing.Size(458, 402);
            this.SCObjectList.TabIndex = 1;
            this.SCObjectList.SelectedIndexChanged += new System.EventHandler(this.SCObjectList_SelectedIndexChanged);
            // 
            // SCAddObjButton
            // 
            this.SCAddObjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SCAddObjButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SCAddObjButton.Location = new System.Drawing.Point(466, 55);
            this.SCAddObjButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCAddObjButton.Name = "SCAddObjButton";
            this.SCAddObjButton.Size = new System.Drawing.Size(403, 27);
            this.SCAddObjButton.TabIndex = 54;
            this.SCAddObjButton.Text = "Add Object";
            this.SCAddObjButton.UseVisualStyleBackColor = true;
            this.SCAddObjButton.Click += new System.EventHandler(this.SCAddObjButton_Click);
            // 
            // SCSFXPage
            // 
            this.SCSFXPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SCSFXPage.Controls.Add(this.groupBox6);
            this.SCSFXPage.Location = new System.Drawing.Point(4, 22);
            this.SCSFXPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCSFXPage.Name = "SCSFXPage";
            this.SCSFXPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCSFXPage.Size = new System.Drawing.Size(878, 427);
            this.SCSFXPage.TabIndex = 2;
            this.SCSFXPage.Text = "SoundFX";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox6.Controls.Add(this.SCSFXMaxPlayNUD);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.SCSFXPathBox);
            this.groupBox6.Controls.Add(this.SCDelSFXButton);
            this.groupBox6.Controls.Add(this.SCSFXList);
            this.groupBox6.Controls.Add(this.SCAddSFXButton);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox6.Location = new System.Drawing.Point(2, 2);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(874, 423);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SoundFX List";
            // 
            // SCSFXMaxPlayNUD
            // 
            this.SCSFXMaxPlayNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCSFXMaxPlayNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SCSFXMaxPlayNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SCSFXMaxPlayNUD.Location = new System.Drawing.Point(465, 70);
            this.SCSFXMaxPlayNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCSFXMaxPlayNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SCSFXMaxPlayNUD.Name = "SCSFXMaxPlayNUD";
            this.SCSFXMaxPlayNUD.Size = new System.Drawing.Size(404, 20);
            this.SCSFXMaxPlayNUD.TabIndex = 70;
            this.SCSFXMaxPlayNUD.ValueChanged += new System.EventHandler(this.SCSFXMaxPlayNUD_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(465, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Max Concurrent Play";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(465, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "SFX Path";
            // 
            // SCSFXPathBox
            // 
            this.SCSFXPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCSFXPathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SCSFXPathBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SCSFXPathBox.Location = new System.Drawing.Point(465, 32);
            this.SCSFXPathBox.Name = "SCSFXPathBox";
            this.SCSFXPathBox.Size = new System.Drawing.Size(405, 20);
            this.SCSFXPathBox.TabIndex = 67;
            this.SCSFXPathBox.TextChanged += new System.EventHandler(this.SCSFXPathBox_TextChanged);
            // 
            // SCDelSFXButton
            // 
            this.SCDelSFXButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCDelSFXButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SCDelSFXButton.Location = new System.Drawing.Point(464, 134);
            this.SCDelSFXButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCDelSFXButton.Name = "SCDelSFXButton";
            this.SCDelSFXButton.Size = new System.Drawing.Size(403, 27);
            this.SCDelSFXButton.TabIndex = 55;
            this.SCDelSFXButton.Text = "Remove SFX";
            this.SCDelSFXButton.UseVisualStyleBackColor = true;
            this.SCDelSFXButton.Click += new System.EventHandler(this.SCDelSFXButton_Click);
            // 
            // SCSFXList
            // 
            this.SCSFXList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SCSFXList.Dock = System.Windows.Forms.DockStyle.Left;
            this.SCSFXList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SCSFXList.FormattingEnabled = true;
            this.SCSFXList.Location = new System.Drawing.Point(2, 15);
            this.SCSFXList.Name = "SCSFXList";
            this.SCSFXList.Size = new System.Drawing.Size(458, 406);
            this.SCSFXList.TabIndex = 1;
            this.SCSFXList.SelectedIndexChanged += new System.EventHandler(this.SCSFXList_SelectedIndexChanged);
            // 
            // SCAddSFXButton
            // 
            this.SCAddSFXButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCAddSFXButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SCAddSFXButton.Location = new System.Drawing.Point(464, 102);
            this.SCAddSFXButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SCAddSFXButton.Name = "SCAddSFXButton";
            this.SCAddSFXButton.Size = new System.Drawing.Size(404, 27);
            this.SCAddSFXButton.TabIndex = 54;
            this.SCAddSFXButton.Text = "Add SFX";
            this.SCAddSFXButton.UseVisualStyleBackColor = true;
            this.SCAddSFXButton.Click += new System.EventHandler(this.SCAddSFXButton_Click);
            // 
            // RCPage
            // 
            this.RCPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.RCPage.Controls.Add(this.groupBox3);
            this.RCPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RCPage.Location = new System.Drawing.Point(4, 22);
            this.RCPage.Name = "RCPage";
            this.RCPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.RCPage.Size = new System.Drawing.Size(889, 452);
            this.RCPage.TabIndex = 2;
            this.RCPage.Text = "RSDKConfig Editor";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox3.Controls.Add(this.groupBox12);
            this.groupBox3.Controls.Add(this.VarListBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(883, 446);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Variable List";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label16);
            this.groupBox12.Controls.Add(this.VarValueBox);
            this.groupBox12.Controls.Add(this.label15);
            this.groupBox12.Controls.Add(this.VarTypeBox);
            this.groupBox12.Controls.Add(this.groupBox13);
            this.groupBox12.Controls.Add(this.ClearVarButton);
            this.groupBox12.Controls.Add(this.DelVarButton);
            this.groupBox12.Controls.Add(this.AddVarButton);
            this.groupBox12.Controls.Add(this.label19);
            this.groupBox12.Controls.Add(this.VarNameBox);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox12.Location = new System.Drawing.Point(417, 16);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox12.Size = new System.Drawing.Size(463, 427);
            this.groupBox12.TabIndex = 52;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Variable Details";
            this.groupBox12.Enter += new System.EventHandler(this.GroupBox12_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(6, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Variable Value";
            // 
            // VarValueBox
            // 
            this.VarValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VarValueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VarValueBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VarValueBox.Location = new System.Drawing.Point(9, 112);
            this.VarValueBox.Name = "VarValueBox";
            this.VarValueBox.Size = new System.Drawing.Size(448, 20);
            this.VarValueBox.TabIndex = 63;
            this.VarValueBox.TextChanged += new System.EventHandler(this.VarValueBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(6, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Variable Type";
            // 
            // VarTypeBox
            // 
            this.VarTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VarTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VarTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VarTypeBox.Location = new System.Drawing.Point(9, 72);
            this.VarTypeBox.Name = "VarTypeBox";
            this.VarTypeBox.Size = new System.Drawing.Size(448, 20);
            this.VarTypeBox.TabIndex = 61;
            this.VarTypeBox.TextChanged += new System.EventHandler(this.VarTypeBox_TextChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.CMemValueNUD);
            this.groupBox13.Controls.Add(this.label18);
            this.groupBox13.Controls.Add(this.ClearEntryButton);
            this.groupBox13.Controls.Add(this.DelEntryButton);
            this.groupBox13.Controls.Add(this.AddEntryButton);
            this.groupBox13.Controls.Add(this.CMemEntryBox);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox13.Location = new System.Drawing.Point(2, 169);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(459, 256);
            this.groupBox13.TabIndex = 60;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Entries";
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearEntryButton.Location = new System.Drawing.Point(116, 18);
            this.ClearEntryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.Size = new System.Drawing.Size(51, 27);
            this.ClearEntryButton.TabIndex = 67;
            this.ClearEntryButton.Text = "Clear";
            this.ClearEntryButton.UseVisualStyleBackColor = true;
            this.ClearEntryButton.Click += new System.EventHandler(this.ClearEntryButton_Click);
            // 
            // DelEntryButton
            // 
            this.DelEntryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelEntryButton.Location = new System.Drawing.Point(61, 18);
            this.DelEntryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelEntryButton.Name = "DelEntryButton";
            this.DelEntryButton.Size = new System.Drawing.Size(51, 27);
            this.DelEntryButton.TabIndex = 66;
            this.DelEntryButton.Text = "Del";
            this.DelEntryButton.UseVisualStyleBackColor = true;
            this.DelEntryButton.Click += new System.EventHandler(this.DelEntryButton_Click);
            // 
            // AddEntryButton
            // 
            this.AddEntryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEntryButton.Location = new System.Drawing.Point(6, 18);
            this.AddEntryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEntryButton.Name = "AddEntryButton";
            this.AddEntryButton.Size = new System.Drawing.Size(51, 27);
            this.AddEntryButton.TabIndex = 65;
            this.AddEntryButton.Text = "Add";
            this.AddEntryButton.UseVisualStyleBackColor = true;
            this.AddEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // CMemEntryBox
            // 
            this.CMemEntryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.CMemEntryBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CMemEntryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CMemEntryBox.FormattingEnabled = true;
            this.CMemEntryBox.Location = new System.Drawing.Point(3, 93);
            this.CMemEntryBox.Name = "CMemEntryBox";
            this.CMemEntryBox.Size = new System.Drawing.Size(453, 160);
            this.CMemEntryBox.TabIndex = 64;
            this.CMemEntryBox.SelectedIndexChanged += new System.EventHandler(this.CMemEntryBox_SelectedIndexChanged);
            // 
            // ClearVarButton
            // 
            this.ClearVarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearVarButton.Location = new System.Drawing.Point(118, 137);
            this.ClearVarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearVarButton.Name = "ClearVarButton";
            this.ClearVarButton.Size = new System.Drawing.Size(51, 27);
            this.ClearVarButton.TabIndex = 56;
            this.ClearVarButton.Text = "Clear";
            this.ClearVarButton.UseVisualStyleBackColor = true;
            this.ClearVarButton.Click += new System.EventHandler(this.ClearVarButton_Click);
            // 
            // DelVarButton
            // 
            this.DelVarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelVarButton.Location = new System.Drawing.Point(63, 137);
            this.DelVarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelVarButton.Name = "DelVarButton";
            this.DelVarButton.Size = new System.Drawing.Size(51, 27);
            this.DelVarButton.TabIndex = 55;
            this.DelVarButton.Text = "Del";
            this.DelVarButton.UseVisualStyleBackColor = true;
            this.DelVarButton.Click += new System.EventHandler(this.DelVarButton_Click);
            // 
            // AddVarButton
            // 
            this.AddVarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddVarButton.Location = new System.Drawing.Point(8, 137);
            this.AddVarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddVarButton.Name = "AddVarButton";
            this.AddVarButton.Size = new System.Drawing.Size(51, 27);
            this.AddVarButton.TabIndex = 54;
            this.AddVarButton.Text = "Add";
            this.AddVarButton.UseVisualStyleBackColor = true;
            this.AddVarButton.Click += new System.EventHandler(this.AddVarButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label19.Location = new System.Drawing.Point(5, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Variable Name";
            // 
            // VarNameBox
            // 
            this.VarNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VarNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VarNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VarNameBox.Location = new System.Drawing.Point(8, 32);
            this.VarNameBox.Name = "VarNameBox";
            this.VarNameBox.Size = new System.Drawing.Size(448, 20);
            this.VarNameBox.TabIndex = 48;
            this.VarNameBox.TextChanged += new System.EventHandler(this.VarNameBox_TextChanged);
            // 
            // VarListBox
            // 
            this.VarListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.VarListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.VarListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VarListBox.FormattingEnabled = true;
            this.VarListBox.Location = new System.Drawing.Point(3, 16);
            this.VarListBox.Name = "VarListBox";
            this.VarListBox.Size = new System.Drawing.Size(414, 427);
            this.VarListBox.TabIndex = 0;
            this.VarListBox.SelectedIndexChanged += new System.EventHandler(this.VarListBox_SelectedIndexChanged);
            // 
            // CMemValueNUD
            // 
            this.CMemValueNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMemValueNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CMemValueNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CMemValueNUD.Location = new System.Drawing.Point(7, 64);
            this.CMemValueNUD.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.CMemValueNUD.Name = "CMemValueNUD";
            this.CMemValueNUD.Size = new System.Drawing.Size(447, 20);
            this.CMemValueNUD.TabIndex = 70;
            this.CMemValueNUD.ValueChanged += new System.EventHandler(this.CMemValueNUD_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.Location = new System.Drawing.Point(4, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 69;
            this.label18.Text = "Variable Value";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(897, 502);
            this.Controls.Add(this.ConfigManager);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ConfigManiac";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ConfigManager.ResumeLayout(false);
            this.GCPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ScenePage.ResumeLayout(false);
            this.ScenePage.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.StageDetailsBox.ResumeLayout(false);
            this.StageDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCStageModeNUD)).EndInit();
            this.ObjectsPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.SoundFXPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCMaxPlayNUD)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.chat.ResumeLayout(false);
            this.chat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SCPage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.SCObjectsPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.SCSFXPage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCSFXMaxPlayNUD)).EndInit();
            this.RCPage.ResumeLayout(false);
            this.RCPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CMemValueNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eclipseEngine1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TabControl ConfigManager;
        private System.Windows.Forms.TabPage GCPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ScenePage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox StageDetailsBox;
        private System.Windows.Forms.Button GCClearStgButton;
        private System.Windows.Forms.Button GCDelStgButton;
        private System.Windows.Forms.Button GCAddStgButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GCStgIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GCStgFolderBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GCStgNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CategoryListBox;
        private System.Windows.Forms.ListBox GCStageBox;
        private System.Windows.Forms.TabPage ObjectsPage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GCObjCFGBox;
        private System.Windows.Forms.Button GCDelObjButton;
        private System.Windows.Forms.ListBox GCObjListBox;
        private System.Windows.Forms.Button GCAddObjButton;
        private System.Windows.Forms.TabPage SoundFXPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GCSFXPathBox;
        private System.Windows.Forms.Button GCRemoveSFXButton;
        private System.Windows.Forms.ListBox GCSoundFXListBox;
        private System.Windows.Forms.Button GCAddSFXButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox chat;
        private System.Windows.Forms.TextBox SubNameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox GameNameTxt;
        private System.Windows.Forms.TabPage SCPage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage SCObjectsPage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SCObjectNameBox;
        private System.Windows.Forms.Button SCDelObjButton;
        private System.Windows.Forms.ListBox SCObjectList;
        private System.Windows.Forms.Button SCAddObjButton;
        private System.Windows.Forms.TabPage SCSFXPage;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SCSFXPathBox;
        private System.Windows.Forms.Button SCDelSFXButton;
        private System.Windows.Forms.ListBox SCSFXList;
        private System.Windows.Forms.Button SCAddSFXButton;
        private System.Windows.Forms.NumericUpDown SCSFXMaxPlayNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox StartScnBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox StartCatBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox VersionBox;
        private System.Windows.Forms.NumericUpDown GCMaxPlayNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GCCatNameBox;
        private System.Windows.Forms.NumericUpDown GCStageModeNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClearCatButton;
        private System.Windows.Forms.Button DelCatButton;
        private System.Windows.Forms.Button AddCatButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TabPage RCPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button ClearVarButton;
        private System.Windows.Forms.Button DelVarButton;
        private System.Windows.Forms.Button AddVarButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox VarNameBox;
        private System.Windows.Forms.ListBox VarListBox;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button ClearEntryButton;
        private System.Windows.Forms.Button DelEntryButton;
        private System.Windows.Forms.Button AddEntryButton;
        private System.Windows.Forms.ListBox CMemEntryBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox VarValueBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox VarTypeBox;
        private System.Windows.Forms.CheckBox LoadGlobalObjectsCB;
        private System.Windows.Forms.NumericUpDown CMemValueNUD;
        private System.Windows.Forms.Label label18;
    }
}

