
namespace ProjectCool_BETA_v1._0
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CH = new System.Windows.Forms.Label();
            this.CT = new System.Windows.Forms.Label();
            this.LM = new System.Windows.Forms.Label();
            this.FS = new System.Windows.Forms.Label();
            this.Case_humidity_info = new System.Windows.Forms.Label();
            this.Case_temp__info = new System.Windows.Forms.Label();
            this.LED_mode_info = new System.Windows.Forms.Label();
            this.Fan_speed_info = new System.Windows.Forms.Label();
            this.Fan_mode_info = new System.Windows.Forms.Label();
            this.FM = new System.Windows.Forms.Label();
            this.PS = new System.Windows.Forms.Label();
            this.PortSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FanSpeed_manual_track = new System.Windows.Forms.TrackBar();
            this.Fan_mode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RefreshRate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColorGet = new System.Windows.Forms.Button();
            this.ColorPreview = new System.Windows.Forms.Panel();
            this.color_change_track = new System.Windows.Forms.TrackBar();
            this.Breathe_speed_track = new System.Windows.Forms.TrackBar();
            this.brightness_manual_track = new System.Windows.Forms.TrackBar();
            this.LED_mode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Commit = new System.Windows.Forms.Button();
            this.DevicePooling = new System.Windows.Forms.Timer(this.components);
            this.Summary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeed_manual_track)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_change_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Breathe_speed_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_manual_track)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Cool BETA v.10";
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Summary.Controls.Add(this.progressBar1);
            this.Summary.Controls.Add(this.CH);
            this.Summary.Controls.Add(this.CT);
            this.Summary.Controls.Add(this.LM);
            this.Summary.Controls.Add(this.FS);
            this.Summary.Controls.Add(this.Case_humidity_info);
            this.Summary.Controls.Add(this.Case_temp__info);
            this.Summary.Controls.Add(this.LED_mode_info);
            this.Summary.Controls.Add(this.Fan_speed_info);
            this.Summary.Controls.Add(this.Fan_mode_info);
            this.Summary.Controls.Add(this.FM);
            this.Summary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Summary.Location = new System.Drawing.Point(18, 63);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(651, 193);
            this.Summary.TabIndex = 1;
            this.Summary.TabStop = false;
            this.Summary.Text = "Summary";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(135, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(469, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // CH
            // 
            this.CH.AutoSize = true;
            this.CH.Location = new System.Drawing.Point(16, 154);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(109, 20);
            this.CH.TabIndex = 0;
            this.CH.Text = "Case humidity:";
            // 
            // CT
            // 
            this.CT.AutoSize = true;
            this.CT.Location = new System.Drawing.Point(16, 123);
            this.CT.Name = "CT";
            this.CT.Size = new System.Drawing.Size(86, 20);
            this.CT.TabIndex = 0;
            this.CT.Text = "Case temp:";
            // 
            // LM
            // 
            this.LM.AutoSize = true;
            this.LM.Location = new System.Drawing.Point(16, 94);
            this.LM.Name = "LM";
            this.LM.Size = new System.Drawing.Size(87, 20);
            this.LM.TabIndex = 0;
            this.LM.Text = "LED mode: ";
            // 
            // FS
            // 
            this.FS.AutoSize = true;
            this.FS.Location = new System.Drawing.Point(16, 65);
            this.FS.Name = "FS";
            this.FS.Size = new System.Drawing.Size(82, 20);
            this.FS.TabIndex = 0;
            this.FS.Text = "Fan speed:";
            // 
            // Case_humidity_info
            // 
            this.Case_humidity_info.AutoSize = true;
            this.Case_humidity_info.Location = new System.Drawing.Point(131, 154);
            this.Case_humidity_info.Name = "Case_humidity_info";
            this.Case_humidity_info.Size = new System.Drawing.Size(37, 20);
            this.Case_humidity_info.TabIndex = 0;
            this.Case_humidity_info.Text = "NaN";
            // 
            // Case_temp__info
            // 
            this.Case_temp__info.AutoSize = true;
            this.Case_temp__info.Location = new System.Drawing.Point(131, 123);
            this.Case_temp__info.Name = "Case_temp__info";
            this.Case_temp__info.Size = new System.Drawing.Size(37, 20);
            this.Case_temp__info.TabIndex = 0;
            this.Case_temp__info.Text = "NaN";
            // 
            // LED_mode_info
            // 
            this.LED_mode_info.AutoSize = true;
            this.LED_mode_info.Location = new System.Drawing.Point(131, 94);
            this.LED_mode_info.Name = "LED_mode_info";
            this.LED_mode_info.Size = new System.Drawing.Size(37, 20);
            this.LED_mode_info.TabIndex = 0;
            this.LED_mode_info.Text = "NaN";
            // 
            // Fan_speed_info
            // 
            this.Fan_speed_info.AutoSize = true;
            this.Fan_speed_info.Location = new System.Drawing.Point(608, 68);
            this.Fan_speed_info.Name = "Fan_speed_info";
            this.Fan_speed_info.Size = new System.Drawing.Size(37, 20);
            this.Fan_speed_info.TabIndex = 0;
            this.Fan_speed_info.Text = "NaN";
            // 
            // Fan_mode_info
            // 
            this.Fan_mode_info.AutoSize = true;
            this.Fan_mode_info.Location = new System.Drawing.Point(131, 33);
            this.Fan_mode_info.Name = "Fan_mode_info";
            this.Fan_mode_info.Size = new System.Drawing.Size(37, 20);
            this.Fan_mode_info.TabIndex = 0;
            this.Fan_mode_info.Text = "NaN";
            // 
            // FM
            // 
            this.FM.AutoSize = true;
            this.FM.Location = new System.Drawing.Point(16, 33);
            this.FM.Name = "FM";
            this.FM.Size = new System.Drawing.Size(81, 20);
            this.FM.TabIndex = 0;
            this.FM.Text = "Fan mode:";
            // 
            // PS
            // 
            this.PS.AutoSize = true;
            this.PS.Location = new System.Drawing.Point(301, 40);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(85, 20);
            this.PS.TabIndex = 0;
            this.PS.Text = "Port select:";
            // 
            // PortSelect
            // 
            this.PortSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PortSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PortSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PortSelect.FormattingEnabled = true;
            this.PortSelect.Location = new System.Drawing.Point(381, 37);
            this.PortSelect.Name = "PortSelect";
            this.PortSelect.Size = new System.Drawing.Size(121, 28);
            this.PortSelect.TabIndex = 2;
            this.PortSelect.SelectedIndexChanged += new System.EventHandler(this.PortSelect_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupBox1.Controls.Add(this.FanSpeed_manual_track);
            this.groupBox1.Controls.Add(this.Fan_mode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fans control";
            // 
            // FanSpeed_manual_track
            // 
            this.FanSpeed_manual_track.LargeChange = 10;
            this.FanSpeed_manual_track.Location = new System.Drawing.Point(135, 100);
            this.FanSpeed_manual_track.Maximum = 100;
            this.FanSpeed_manual_track.Name = "FanSpeed_manual_track";
            this.FanSpeed_manual_track.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FanSpeed_manual_track.Size = new System.Drawing.Size(469, 45);
            this.FanSpeed_manual_track.TabIndex = 3;
            this.FanSpeed_manual_track.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Fan_mode
            // 
            this.Fan_mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Fan_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fan_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fan_mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Fan_mode.FormattingEnabled = true;
            this.Fan_mode.Items.AddRange(new object[] {
            "Default",
            "Cool",
            "Quiet",
            "Fan off",
            "Manual fan",
            "Fan off"});
            this.Fan_mode.Location = new System.Drawing.Point(135, 30);
            this.Fan_mode.Name = "Fan_mode";
            this.Fan_mode.Size = new System.Drawing.Size(121, 28);
            this.Fan_mode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manual speed:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fan mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Refresh rate:";
            // 
            // RefreshRate
            // 
            this.RefreshRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RefreshRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RefreshRate.Location = new System.Drawing.Point(612, 37);
            this.RefreshRate.Name = "RefreshRate";
            this.RefreshRate.Size = new System.Drawing.Size(57, 25);
            this.RefreshRate.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupBox2.Controls.Add(this.ColorGet);
            this.groupBox2.Controls.Add(this.ColorPreview);
            this.groupBox2.Controls.Add(this.color_change_track);
            this.groupBox2.Controls.Add(this.Breathe_speed_track);
            this.groupBox2.Controls.Add(this.brightness_manual_track);
            this.groupBox2.Controls.Add(this.LED_mode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(18, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED ARGB control";
            // 
            // ColorGet
            // 
            this.ColorGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorGet.Location = new System.Drawing.Point(135, 116);
            this.ColorGet.Name = "ColorGet";
            this.ColorGet.Size = new System.Drawing.Size(82, 36);
            this.ColorGet.TabIndex = 5;
            this.ColorGet.Text = "Change";
            this.ColorGet.UseVisualStyleBackColor = true;
            this.ColorGet.Click += new System.EventHandler(this.ColorGet_Click);
            // 
            // ColorPreview
            // 
            this.ColorPreview.Location = new System.Drawing.Point(223, 115);
            this.ColorPreview.Name = "ColorPreview";
            this.ColorPreview.Size = new System.Drawing.Size(54, 37);
            this.ColorPreview.TabIndex = 4;
            // 
            // color_change_track
            // 
            this.color_change_track.LargeChange = 10;
            this.color_change_track.Location = new System.Drawing.Point(167, 221);
            this.color_change_track.Maximum = 100;
            this.color_change_track.Name = "color_change_track";
            this.color_change_track.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.color_change_track.Size = new System.Drawing.Size(437, 45);
            this.color_change_track.TabIndex = 3;
            this.color_change_track.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Breathe_speed_track
            // 
            this.Breathe_speed_track.LargeChange = 10;
            this.Breathe_speed_track.Location = new System.Drawing.Point(134, 162);
            this.Breathe_speed_track.Maximum = 40;
            this.Breathe_speed_track.Name = "Breathe_speed_track";
            this.Breathe_speed_track.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Breathe_speed_track.Size = new System.Drawing.Size(469, 45);
            this.Breathe_speed_track.TabIndex = 3;
            this.Breathe_speed_track.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // brightness_manual_track
            // 
            this.brightness_manual_track.LargeChange = 10;
            this.brightness_manual_track.Location = new System.Drawing.Point(135, 64);
            this.brightness_manual_track.Maximum = 100;
            this.brightness_manual_track.Name = "brightness_manual_track";
            this.brightness_manual_track.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brightness_manual_track.Size = new System.Drawing.Size(469, 45);
            this.brightness_manual_track.TabIndex = 3;
            this.brightness_manual_track.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // LED_mode
            // 
            this.LED_mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LED_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LED_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LED_mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LED_mode.FormattingEnabled = true;
            this.LED_mode.Items.AddRange(new object[] {
            "Solid color",
            "Color change",
            "Rainbow",
            "Color breathe",
            "Flame",
            "Fan speed display"});
            this.LED_mode.Location = new System.Drawing.Point(135, 30);
            this.LED_mode.Name = "LED_mode";
            this.LED_mode.Size = new System.Drawing.Size(121, 28);
            this.LED_mode.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Light color:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Color change speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Breathe speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Brightness:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "LED mode:";
            // 
            // Commit
            // 
            this.Commit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Commit.ForeColor = System.Drawing.Color.Lime;
            this.Commit.Location = new System.Drawing.Point(512, 727);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(157, 35);
            this.Commit.TabIndex = 4;
            this.Commit.Text = "Apply";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // DevicePooling
            // 
            this.DevicePooling.Interval = 1000;
            this.DevicePooling.Tick += new System.EventHandler(this.DevicePooling_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(681, 774);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.RefreshRate);
            this.Controls.Add(this.PortSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PS);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ProjectCool V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeed_manual_track)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_change_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Breathe_speed_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_manual_track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Summary;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label CH;
        private System.Windows.Forms.Label CT;
        private System.Windows.Forms.Label LM;
        private System.Windows.Forms.Label FS;
        private System.Windows.Forms.Label Case_humidity_info;
        private System.Windows.Forms.Label Case_temp__info;
        private System.Windows.Forms.Label LED_mode_info;
        private System.Windows.Forms.Label Fan_speed_info;
        private System.Windows.Forms.Label Fan_mode_info;
        private System.Windows.Forms.Label FM;
        private System.Windows.Forms.Label PS;
        private System.Windows.Forms.ComboBox PortSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar FanSpeed_manual_track;
        private System.Windows.Forms.ComboBox Fan_mode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RefreshRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar brightness_manual_track;
        private System.Windows.Forms.ComboBox LED_mode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ColorGet;
        private System.Windows.Forms.Panel ColorPreview;
        private System.Windows.Forms.TrackBar color_change_track;
        private System.Windows.Forms.TrackBar Breathe_speed_track;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Timer DevicePooling;
    }
}

