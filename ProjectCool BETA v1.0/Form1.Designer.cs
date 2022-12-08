
namespace ProjectCool_BETA_v1._0
{
    partial class ProjectCool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectCool));
            this.DevicePooling = new System.Windows.Forms.Timer(this.components);
            this.MainMenu = new System.Windows.Forms.Panel();
            this.LedTweak = new System.Windows.Forms.Button();
            this.FanTweak = new System.Windows.Forms.Button();
            this.Monitoring = new System.Windows.Forms.Button();
            this.poolingRate = new System.Windows.Forms.NumericUpDown();
            this.PortSelect = new System.Windows.Forms.ComboBox();
            this.Connection = new System.Windows.Forms.Label();
            this.ButtonInfo = new System.Windows.Forms.Label();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.UpdateRateLabel = new System.Windows.Forms.Label();
            this.DevicePortLabel = new System.Windows.Forms.Label();
            this.FanControl = new System.Windows.Forms.Panel();
            this.FanMode_2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempHys = new System.Windows.Forms.Label();
            this.NewFanMode = new System.Windows.Forms.Label();
            this.TempHysteresis = new System.Windows.Forms.NumericUpDown();
            this.ActiveFanMode = new System.Windows.Forms.Label();
            this.FansMode = new System.Windows.Forms.ComboBox();
            this.FanSpeed_manual_track = new System.Windows.Forms.TrackBar();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.FanSpeed = new System.Windows.Forms.PictureBox();
            this.CaseHumidity_label = new System.Windows.Forms.Label();
            this.CaseHumidity = new System.Windows.Forms.Label();
            this.CaseTemp = new System.Windows.Forms.Label();
            this.CaseTemp_label = new System.Windows.Forms.Label();
            this.perc = new System.Windows.Forms.Label();
            this.deg = new System.Windows.Forms.Label();
            this.LedMode = new System.Windows.Forms.Label();
            this.FanMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LedMode_label = new System.Windows.Forms.Label();
            this.FanMode_label = new System.Windows.Forms.Label();
            this.NewLedMode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LEDcontrol = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Breathe_speed_track = new System.Windows.Forms.TrackBar();
            this.color_change_track = new System.Windows.Forms.TrackBar();
            this.Saturation_track = new System.Windows.Forms.TrackBar();
            this.Light_color_track = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.brightness_manual_track = new System.Windows.Forms.TrackBar();
            this.GraphicsWatchdog = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poolingRate)).BeginInit();
            this.FanControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempHysteresis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeed_manual_track)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeed)).BeginInit();
            this.LEDcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Breathe_speed_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_change_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturation_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light_color_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_manual_track)).BeginInit();
            this.SuspendLayout();
            // 
            // DevicePooling
            // 
            this.DevicePooling.Interval = 1000;
            this.DevicePooling.Tick += new System.EventHandler(this.DevicePooling_Tick);
            // 
            // MainMenu
            // 
            this.MainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainMenu.BackgroundImage")));
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenu.Controls.Add(this.LedTweak);
            this.MainMenu.Controls.Add(this.FanTweak);
            this.MainMenu.Controls.Add(this.Monitoring);
            this.MainMenu.Controls.Add(this.poolingRate);
            this.MainMenu.Controls.Add(this.PortSelect);
            this.MainMenu.Controls.Add(this.Connection);
            this.MainMenu.Controls.Add(this.ButtonInfo);
            this.MainMenu.Controls.Add(this.ConnectionStatusLabel);
            this.MainMenu.Controls.Add(this.UpdateRateLabel);
            this.MainMenu.Controls.Add(this.DevicePortLabel);
            this.MainMenu.Location = new System.Drawing.Point(12, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(309, 435);
            this.MainMenu.TabIndex = 1;
            // 
            // LedTweak
            // 
            this.LedTweak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LedTweak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LedTweak.Font = new System.Drawing.Font("Technos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedTweak.Location = new System.Drawing.Point(23, 337);
            this.LedTweak.Name = "LedTweak";
            this.LedTweak.Size = new System.Drawing.Size(259, 37);
            this.LedTweak.TabIndex = 3;
            this.LedTweak.Text = "ARGB LEDS TWEAK";
            this.LedTweak.UseVisualStyleBackColor = true;
            this.LedTweak.Click += new System.EventHandler(this.LedTweak_Click);
            // 
            // FanTweak
            // 
            this.FanTweak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FanTweak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FanTweak.Font = new System.Drawing.Font("Technos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanTweak.Location = new System.Drawing.Point(23, 294);
            this.FanTweak.Name = "FanTweak";
            this.FanTweak.Size = new System.Drawing.Size(259, 37);
            this.FanTweak.TabIndex = 3;
            this.FanTweak.Text = "FAN SYSTEM TWEAK";
            this.FanTweak.UseVisualStyleBackColor = true;
            this.FanTweak.Click += new System.EventHandler(this.FanTweak_Click);
            // 
            // Monitoring
            // 
            this.Monitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Monitoring.Font = new System.Drawing.Font("Technos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitoring.Location = new System.Drawing.Point(24, 251);
            this.Monitoring.Name = "Monitoring";
            this.Monitoring.Size = new System.Drawing.Size(259, 37);
            this.Monitoring.TabIndex = 3;
            this.Monitoring.Text = "MONITORING";
            this.Monitoring.UseVisualStyleBackColor = true;
            this.Monitoring.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Monitoring_Click);
            // 
            // poolingRate
            // 
            this.poolingRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.poolingRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poolingRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poolingRate.Font = new System.Drawing.Font("Technos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poolingRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.poolingRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.poolingRate.Location = new System.Drawing.Point(175, 142);
            this.poolingRate.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.poolingRate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.poolingRate.Name = "poolingRate";
            this.poolingRate.Size = new System.Drawing.Size(107, 18);
            this.poolingRate.TabIndex = 2;
            this.poolingRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // PortSelect
            // 
            this.PortSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PortSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PortSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortSelect.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.PortSelect.FormattingEnabled = true;
            this.PortSelect.Items.AddRange(new object[] {
            "N/A"});
            this.PortSelect.Location = new System.Drawing.Point(175, 108);
            this.PortSelect.Name = "PortSelect";
            this.PortSelect.Size = new System.Drawing.Size(108, 21);
            this.PortSelect.TabIndex = 1;
            this.PortSelect.Text = "N/A";
            this.PortSelect.SelectedIndexChanged += new System.EventHandler(this.PortSelect_SelectedIndexChanged);
            // 
            // Connection
            // 
            this.Connection.AutoSize = true;
            this.Connection.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection.Location = new System.Drawing.Point(170, 171);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(85, 13);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "ABSENT";
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.AutoSize = true;
            this.ButtonInfo.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInfo.Location = new System.Drawing.Point(73, 218);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(161, 13);
            this.ButtonInfo.TabIndex = 0;
            this.ButtonInfo.Text = "DEVICE ACTIONS";
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(21, 171);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(130, 13);
            this.ConnectionStatusLabel.TabIndex = 0;
            this.ConnectionStatusLabel.Text = "CONNECTION:";
            // 
            // UpdateRateLabel
            // 
            this.UpdateRateLabel.AutoSize = true;
            this.UpdateRateLabel.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRateLabel.Location = new System.Drawing.Point(21, 143);
            this.UpdateRateLabel.Name = "UpdateRateLabel";
            this.UpdateRateLabel.Size = new System.Drawing.Size(145, 13);
            this.UpdateRateLabel.TabIndex = 0;
            this.UpdateRateLabel.Text = "UPDATE RATE:";
            // 
            // DevicePortLabel
            // 
            this.DevicePortLabel.AutoSize = true;
            this.DevicePortLabel.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevicePortLabel.Location = new System.Drawing.Point(21, 111);
            this.DevicePortLabel.Name = "DevicePortLabel";
            this.DevicePortLabel.Size = new System.Drawing.Size(135, 13);
            this.DevicePortLabel.TabIndex = 0;
            this.DevicePortLabel.Text = "DEVICE PORT:";
            // 
            // FanControl
            // 
            this.FanControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FanControl.BackgroundImage = global::ProjectCool_BETA_v1._0.Properties.Resources.Background_plate_fan;
            this.FanControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FanControl.Controls.Add(this.FanMode_2);
            this.FanControl.Controls.Add(this.label4);
            this.FanControl.Controls.Add(this.label3);
            this.FanControl.Controls.Add(this.label2);
            this.FanControl.Controls.Add(this.TempHys);
            this.FanControl.Controls.Add(this.NewFanMode);
            this.FanControl.Controls.Add(this.TempHysteresis);
            this.FanControl.Controls.Add(this.ActiveFanMode);
            this.FanControl.Controls.Add(this.FansMode);
            this.FanControl.Controls.Add(this.FanSpeed_manual_track);
            this.FanControl.Location = new System.Drawing.Point(104, 453);
            this.FanControl.Name = "FanControl";
            this.FanControl.Size = new System.Drawing.Size(86, 14);
            this.FanControl.TabIndex = 0;
            // 
            // FanMode_2
            // 
            this.FanMode_2.AutoSize = true;
            this.FanMode_2.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanMode_2.Location = new System.Drawing.Point(308, 113);
            this.FanMode_2.Name = "FanMode_2";
            this.FanMode_2.Size = new System.Drawing.Size(120, 16);
            this.FanMode_2.TabIndex = 0;
            this.FanMode_2.Text = "Unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Technos", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(757, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 11);
            this.label4.TabIndex = 0;
            this.label4.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Technos", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 11);
            this.label3.TabIndex = 0;
            this.label3.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manual fan speed";
            // 
            // TempHys
            // 
            this.TempHys.AutoSize = true;
            this.TempHys.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempHys.Location = new System.Drawing.Point(63, 232);
            this.TempHys.Name = "TempHys";
            this.TempHys.Size = new System.Drawing.Size(342, 16);
            this.TempHys.TabIndex = 0;
            this.TempHys.Text = "Temperature hysteresis:";
            // 
            // NewFanMode
            // 
            this.NewFanMode.AutoSize = true;
            this.NewFanMode.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFanMode.Location = new System.Drawing.Point(63, 168);
            this.NewFanMode.Name = "NewFanMode";
            this.NewFanMode.Size = new System.Drawing.Size(130, 16);
            this.NewFanMode.TabIndex = 0;
            this.NewFanMode.Text = "FAN MODE:";
            // 
            // TempHysteresis
            // 
            this.TempHysteresis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TempHysteresis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TempHysteresis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TempHysteresis.DecimalPlaces = 1;
            this.TempHysteresis.Font = new System.Drawing.Font("Technos", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempHysteresis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.TempHysteresis.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TempHysteresis.Location = new System.Drawing.Point(425, 224);
            this.TempHysteresis.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TempHysteresis.Name = "TempHysteresis";
            this.TempHysteresis.Size = new System.Drawing.Size(107, 30);
            this.TempHysteresis.TabIndex = 2;
            this.TempHysteresis.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ActiveFanMode
            // 
            this.ActiveFanMode.AutoSize = true;
            this.ActiveFanMode.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveFanMode.Location = new System.Drawing.Point(63, 113);
            this.ActiveFanMode.Name = "ActiveFanMode";
            this.ActiveFanMode.Size = new System.Drawing.Size(220, 16);
            this.ActiveFanMode.TabIndex = 0;
            this.ActiveFanMode.Text = "ACTIVE FAN MODE:";
            // 
            // FansMode
            // 
            this.FansMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FansMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FansMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FansMode.Font = new System.Drawing.Font("Technos", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FansMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.FansMode.FormattingEnabled = true;
            this.FansMode.Items.AddRange(new object[] {
            "Default",
            "Cool",
            "Quiet",
            "Fan off",
            "Manual fan",
            "Fan 100%"});
            this.FansMode.Location = new System.Drawing.Point(209, 159);
            this.FansMode.Name = "FansMode";
            this.FansMode.Size = new System.Drawing.Size(591, 32);
            this.FansMode.TabIndex = 1;
            this.FansMode.Text = "N/A";
            // 
            // FanSpeed_manual_track
            // 
            this.FanSpeed_manual_track.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.FanSpeed_manual_track.LargeChange = 10;
            this.FanSpeed_manual_track.Location = new System.Drawing.Point(66, 337);
            this.FanSpeed_manual_track.Maximum = 100;
            this.FanSpeed_manual_track.Name = "FanSpeed_manual_track";
            this.FanSpeed_manual_track.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FanSpeed_manual_track.Size = new System.Drawing.Size(734, 45);
            this.FanSpeed_manual_track.SmallChange = 5;
            this.FanSpeed_manual_track.TabIndex = 3;
            this.FanSpeed_manual_track.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.FanSpeed);
            this.MainPanel.Controls.Add(this.CaseHumidity_label);
            this.MainPanel.Controls.Add(this.CaseHumidity);
            this.MainPanel.Controls.Add(this.CaseTemp);
            this.MainPanel.Controls.Add(this.CaseTemp_label);
            this.MainPanel.Controls.Add(this.perc);
            this.MainPanel.Controls.Add(this.deg);
            this.MainPanel.Controls.Add(this.LedMode);
            this.MainPanel.Controls.Add(this.FanMode);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.LedMode_label);
            this.MainPanel.Controls.Add(this.FanMode_label);
            this.MainPanel.Location = new System.Drawing.Point(12, 453);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(86, 14);
            this.MainPanel.TabIndex = 0;
            // 
            // FanSpeed
            // 
            this.FanSpeed.Location = new System.Drawing.Point(215, 171);
            this.FanSpeed.Name = "FanSpeed";
            this.FanSpeed.Size = new System.Drawing.Size(581, 16);
            this.FanSpeed.TabIndex = 1;
            this.FanSpeed.TabStop = false;
            // 
            // CaseHumidity_label
            // 
            this.CaseHumidity_label.AutoSize = true;
            this.CaseHumidity_label.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseHumidity_label.Location = new System.Drawing.Point(534, 272);
            this.CaseHumidity_label.Name = "CaseHumidity_label";
            this.CaseHumidity_label.Size = new System.Drawing.Size(182, 16);
            this.CaseHumidity_label.TabIndex = 0;
            this.CaseHumidity_label.Text = "CASE HUMIDITY";
            // 
            // CaseHumidity
            // 
            this.CaseHumidity.AutoSize = true;
            this.CaseHumidity.Font = new System.Drawing.Font("Technos", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseHumidity.Location = new System.Drawing.Point(556, 310);
            this.CaseHumidity.Name = "CaseHumidity";
            this.CaseHumidity.Size = new System.Drawing.Size(145, 48);
            this.CaseHumidity.TabIndex = 0;
            this.CaseHumidity.Text = "N/A";
            // 
            // CaseTemp
            // 
            this.CaseTemp.AutoSize = true;
            this.CaseTemp.Font = new System.Drawing.Font("Technos", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseTemp.Location = new System.Drawing.Point(177, 310);
            this.CaseTemp.Name = "CaseTemp";
            this.CaseTemp.Size = new System.Drawing.Size(145, 48);
            this.CaseTemp.TabIndex = 0;
            this.CaseTemp.Text = "N/A";
            // 
            // CaseTemp_label
            // 
            this.CaseTemp_label.AutoSize = true;
            this.CaseTemp_label.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseTemp_label.Location = new System.Drawing.Point(192, 272);
            this.CaseTemp_label.Name = "CaseTemp_label";
            this.CaseTemp_label.Size = new System.Drawing.Size(142, 16);
            this.CaseTemp_label.TabIndex = 0;
            this.CaseTemp_label.Text = "CASE TEMP";
            // 
            // perc
            // 
            this.perc.AutoSize = true;
            this.perc.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perc.Location = new System.Drawing.Point(707, 337);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(76, 16);
            this.perc.TabIndex = 0;
            this.perc.Text = "perc.";
            // 
            // deg
            // 
            this.deg.AutoSize = true;
            this.deg.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deg.Location = new System.Drawing.Point(349, 335);
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(60, 16);
            this.deg.TabIndex = 0;
            this.deg.Text = "deg.";
            // 
            // LedMode
            // 
            this.LedMode.AutoSize = true;
            this.LedMode.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedMode.Location = new System.Drawing.Point(308, 218);
            this.LedMode.Name = "LedMode";
            this.LedMode.Size = new System.Drawing.Size(120, 16);
            this.LedMode.TabIndex = 0;
            this.LedMode.Text = "Unknown";
            // 
            // FanMode
            // 
            this.FanMode.AutoSize = true;
            this.FanMode.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanMode.Location = new System.Drawing.Point(308, 113);
            this.FanMode.Name = "FanMode";
            this.FanMode.Size = new System.Drawing.Size(120, 16);
            this.FanMode.TabIndex = 0;
            this.FanMode.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAN SPEED:";
            // 
            // LedMode_label
            // 
            this.LedMode_label.AutoSize = true;
            this.LedMode_label.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedMode_label.Location = new System.Drawing.Point(63, 218);
            this.LedMode_label.Name = "LedMode_label";
            this.LedMode_label.Size = new System.Drawing.Size(220, 16);
            this.LedMode_label.TabIndex = 0;
            this.LedMode_label.Text = "ACTIVE LED MODE:";
            // 
            // FanMode_label
            // 
            this.FanMode_label.AutoSize = true;
            this.FanMode_label.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanMode_label.Location = new System.Drawing.Point(63, 113);
            this.FanMode_label.Name = "FanMode_label";
            this.FanMode_label.Size = new System.Drawing.Size(220, 16);
            this.FanMode_label.TabIndex = 0;
            this.FanMode_label.Text = "ACTIVE FAN MODE:";
            // 
            // NewLedMode
            // 
            this.NewLedMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NewLedMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewLedMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewLedMode.Font = new System.Drawing.Font("Technos", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLedMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.NewLedMode.FormattingEnabled = true;
            this.NewLedMode.Items.AddRange(new object[] {
            "Solid color",
            "Color change",
            "Rainbow",
            "Color breathe",
            "Flame",
            "Fan speed display"});
            this.NewLedMode.Location = new System.Drawing.Point(188, 103);
            this.NewLedMode.Name = "NewLedMode";
            this.NewLedMode.Size = new System.Drawing.Size(591, 27);
            this.NewLedMode.TabIndex = 1;
            this.NewLedMode.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Technos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "LED MODE:";
            // 
            // LEDcontrol
            // 
            this.LEDcontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LEDcontrol.BackgroundImage = global::ProjectCool_BETA_v1._0.Properties.Resources.Background_plate_RGB;
            this.LEDcontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDcontrol.Controls.Add(this.label16);
            this.LEDcontrol.Controls.Add(this.label15);
            this.LEDcontrol.Controls.Add(this.label14);
            this.LEDcontrol.Controls.Add(this.label13);
            this.LEDcontrol.Controls.Add(this.label12);
            this.LEDcontrol.Controls.Add(this.label11);
            this.LEDcontrol.Controls.Add(this.pictureBox2);
            this.LEDcontrol.Controls.Add(this.pictureBox1);
            this.LEDcontrol.Controls.Add(this.Breathe_speed_track);
            this.LEDcontrol.Controls.Add(this.color_change_track);
            this.LEDcontrol.Controls.Add(this.Saturation_track);
            this.LEDcontrol.Controls.Add(this.Light_color_track);
            this.LEDcontrol.Controls.Add(this.label9);
            this.LEDcontrol.Controls.Add(this.label8);
            this.LEDcontrol.Controls.Add(this.label7);
            this.LEDcontrol.Controls.Add(this.label6);
            this.LEDcontrol.Controls.Add(this.label5);
            this.LEDcontrol.Controls.Add(this.label10);
            this.LEDcontrol.Controls.Add(this.NewLedMode);
            this.LEDcontrol.Controls.Add(this.brightness_manual_track);
            this.LEDcontrol.Location = new System.Drawing.Point(203, 453);
            this.LEDcontrol.Name = "LEDcontrol";
            this.LEDcontrol.Size = new System.Drawing.Size(86, 14);
            this.LEDcontrol.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Technos", 5F);
            this.label16.Location = new System.Drawing.Point(761, 377);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 7);
            this.label16.TabIndex = 0;
            this.label16.Text = "100%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Technos", 5F);
            this.label15.Location = new System.Drawing.Point(185, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 7);
            this.label15.TabIndex = 0;
            this.label15.Text = "0%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Technos", 5F);
            this.label14.Location = new System.Drawing.Point(761, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 7);
            this.label14.TabIndex = 0;
            this.label14.Text = "100%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Technos", 5F);
            this.label13.Location = new System.Drawing.Point(185, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 7);
            this.label13.TabIndex = 0;
            this.label13.Text = "0%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Technos", 5F);
            this.label12.Location = new System.Drawing.Point(761, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 7);
            this.label12.TabIndex = 0;
            this.label12.Text = "100%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Technos", 5F);
            this.label11.Location = new System.Drawing.Point(185, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 7);
            this.label11.TabIndex = 0;
            this.label11.Text = "0%";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(188, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(591, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Breathe_speed_track
            // 
            this.Breathe_speed_track.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Breathe_speed_track.Location = new System.Drawing.Point(188, 348);
            this.Breathe_speed_track.Maximum = 100;
            this.Breathe_speed_track.Name = "Breathe_speed_track";
            this.Breathe_speed_track.Size = new System.Drawing.Size(591, 45);
            this.Breathe_speed_track.TabIndex = 2;
            this.Breathe_speed_track.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // color_change_track
            // 
            this.color_change_track.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.color_change_track.Location = new System.Drawing.Point(188, 306);
            this.color_change_track.Maximum = 100;
            this.color_change_track.Name = "color_change_track";
            this.color_change_track.Size = new System.Drawing.Size(591, 45);
            this.color_change_track.TabIndex = 2;
            this.color_change_track.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Saturation_track
            // 
            this.Saturation_track.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Saturation_track.Location = new System.Drawing.Point(188, 237);
            this.Saturation_track.Maximum = 255;
            this.Saturation_track.Name = "Saturation_track";
            this.Saturation_track.Size = new System.Drawing.Size(591, 45);
            this.Saturation_track.TabIndex = 2;
            this.Saturation_track.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Light_color_track
            // 
            this.Light_color_track.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Light_color_track.Location = new System.Drawing.Point(188, 186);
            this.Light_color_track.Maximum = 255;
            this.Light_color_track.Name = "Light_color_track";
            this.Light_color_track.Size = new System.Drawing.Size(591, 45);
            this.Light_color_track.TabIndex = 2;
            this.Light_color_track.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Technos", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 11);
            this.label9.TabIndex = 0;
            this.label9.Text = "BR. SPEED:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Technos", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 11);
            this.label8.TabIndex = 0;
            this.label8.Text = "COLOR SPEED:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "SATURATION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "HUE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Technos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "BRIGHTNESS:";
            // 
            // brightness_manual_track
            // 
            this.brightness_manual_track.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.brightness_manual_track.Location = new System.Drawing.Point(188, 143);
            this.brightness_manual_track.Maximum = 100;
            this.brightness_manual_track.Name = "brightness_manual_track";
            this.brightness_manual_track.Size = new System.Drawing.Size(591, 45);
            this.brightness_manual_track.TabIndex = 2;
            this.brightness_manual_track.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // GraphicsWatchdog
            // 
            this.GraphicsWatchdog.Interval = 500;
            this.GraphicsWatchdog.Tick += new System.EventHandler(this.GraphicsWatchdog_Tick);
            // 
            // ProjectCool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1211, 472);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.LEDcontrol);
            this.Controls.Add(this.FanControl);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectCool";
            this.Text = "ProjectCool V1.6";
            this.Load += new System.EventHandler(this.ProjectCool_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poolingRate)).EndInit();
            this.FanControl.ResumeLayout(false);
            this.FanControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempHysteresis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeed_manual_track)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeed)).EndInit();
            this.LEDcontrol.ResumeLayout(false);
            this.LEDcontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Breathe_speed_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_change_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturation_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light_color_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_manual_track)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer DevicePooling;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Label DevicePortLabel;
        private System.Windows.Forms.ComboBox PortSelect;
        private System.Windows.Forms.NumericUpDown poolingRate;
        private System.Windows.Forms.Label Connection;
        private System.Windows.Forms.Label ButtonInfo;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Label UpdateRateLabel;
        private System.Windows.Forms.Button LedTweak;
        private System.Windows.Forms.Button FanTweak;
        private System.Windows.Forms.Button Monitoring;
        private System.Windows.Forms.Label FanMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FanMode_label;
        private System.Windows.Forms.PictureBox FanSpeed;
        private System.Windows.Forms.Label CaseHumidity_label;
        private System.Windows.Forms.Label CaseHumidity;
        private System.Windows.Forms.Label CaseTemp;
        private System.Windows.Forms.Label CaseTemp_label;
        private System.Windows.Forms.Label perc;
        private System.Windows.Forms.Label deg;
        private System.Windows.Forms.Label LedMode;
        private System.Windows.Forms.Label LedMode_label;
        private System.Windows.Forms.Label ActiveFanMode;
        private System.Windows.Forms.Label FanMode_2;
        private System.Windows.Forms.Panel FanControl;
        private System.Windows.Forms.Label NewFanMode;
        private System.Windows.Forms.ComboBox FansMode;
        private System.Windows.Forms.Label TempHys;
        private System.Windows.Forms.NumericUpDown TempHysteresis;
        private System.Windows.Forms.TrackBar FanSpeed_manual_track;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox NewLedMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel LEDcontrol;
        private System.Windows.Forms.TrackBar brightness_manual_track;
        private System.Windows.Forms.TrackBar Light_color_track;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar Saturation_track;
        private System.Windows.Forms.TrackBar Breathe_speed_track;
        private System.Windows.Forms.TrackBar color_change_track;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer GraphicsWatchdog;
    }
}

