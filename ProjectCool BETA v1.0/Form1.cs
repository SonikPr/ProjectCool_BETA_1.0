using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCool_BETA_v1._0
{
    //Cyberpunk Edgerunners
    //Like me and Dasha
    //This design and layout is an easter egg, is you know - you know
    public partial class ProjectCool : Form
    {
        public ProjectCool()
        {
            InitializeComponent();
        }
        SerialCommunicator DeviceSerial = new SerialCommunicator();
        LED sysleds = new LED();
        Fan sysfans = new Fan();
        int[] DeviceData = new int[13];
        string[] DeviceDataString = new string[13];
        bool update_all = true;
        byte connection = 0; //absent


        public struct DeviceTemp
        {
            private int _t;
            private int _h;

            public DeviceTemp(int t, int h)
            {
                this._t = t;
                this._h = h;
            }

            public int T
            {
                get { return this._t; }
                set { this._t = value; }
            }

            public int H
            {
                get { return this._h; }
                set { this._h = value; }
            }

        }

        DeviceTemp systemps = new DeviceTemp();
        private void ProjectCool_Load(object sender, EventArgs e)
        {
            PortSelect.Items.AddRange(DeviceSerial.AvailablePorts);
            sysleds.CreateLed();
            sysfans.CreateFans();
            GraphicsWatchdog.Start();
        }

        int MenuEnabled = 0;
        private void ChangeLocation(Control cntrl, Point location, Size size)
        {
            cntrl.Location = location;
            cntrl.Size = size;
        }

        private void ReverseColors(Control cntrl, Control reference, byte mode)
        {
            Color reverse = new Color();

            switch (mode) {
                case 0:
                    cntrl.BackColor = reference.BackColor;
                    cntrl.ForeColor = reference.ForeColor;
                    break;
                case 1:
                    reverse = cntrl.BackColor;
                    cntrl.BackColor = cntrl.ForeColor;
                    cntrl.ForeColor = reverse;
                    break;
            }
            
            
        }

        private void RenderMenu(byte menu)
        {
            if (menu != MenuEnabled)
            {
                switch (menu)
                {
                    case 0:
                        ChangeLocation(MainPanel, new Point(12, 453), new Size(86, 14));
                        ChangeLocation(FanControl, new Point(104, 453), new Size(86, 14));
                        ChangeLocation(LEDcontrol, new Point(203, 453), new Size(86, 14));
                        ReverseColors(Monitoring, DevicePortLabel, 0);
                        ReverseColors(FanTweak, DevicePortLabel, 0);
                        ReverseColors(LedTweak, DevicePortLabel, 0);
                        break;
                    case 1:
                        RenderMenu(0);
                        ChangeLocation(MainPanel, new Point(327, 12), new Size(873, 435));
                        ReverseColors(Monitoring, DevicePortLabel, 1);
                        break;
                    case 2:
                        RenderMenu(0);
                        ChangeLocation(FanControl, new Point(327, 12), new Size(873, 435));
                        ReverseColors(FanTweak, DevicePortLabel, 1);
                        break;
                    case 3:
                        RenderMenu(0);
                        ChangeLocation(LEDcontrol, new Point(327, 12), new Size(873, 435));
                        ReverseColors(LedTweak, DevicePortLabel, 1);
                        break;
                }
                if (connection == 3 && MenuEnabled != 0)
                {
                   
                    CommitChanges();
                }
                MenuEnabled = menu;

            }
        }

        private void RenderChart(int maximum)
        {
            Pen outline = new Pen(Color.FromArgb(255, 211, 98, 98));
            System.Drawing.SolidBrush bar = new SolidBrush(Color.FromArgb(255, 211, 132, 132));
            Bitmap Chart = new Bitmap(FanSpeed.Width, FanSpeed.Height); ;
            using (Graphics formGraphics = Graphics.FromImage(Chart))
            {
                formGraphics.DrawRectangle(outline, new Rectangle(0, 0, FanSpeed.Width - 1, FanSpeed.Height - 1));
                formGraphics.FillRectangle(bar, new Rectangle(4, 3, sysleds.map(maximum, 0, 100, 0, FanSpeed.Width - 3), FanSpeed.Height - 6));
                outline.Dispose();
                bar.Dispose();

                formGraphics.Dispose();
            }
            FanSpeed.Image = Chart;
        ;
        }


        //Stupid buttons
        private void FanTweak_Click(object sender, EventArgs e)
        {
            RenderMenu(2);
        }

        private void Monitoring_Click(object sender, EventArgs e)
        {
            RenderMenu(1);
        }

        private void LedTweak_Click(object sender, EventArgs e)
        {
            RenderMenu(3);
        }
        
        private void PortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        DeviceSerial.StopSerial();
        string result = DeviceSerial.CreateSerial(9600, PortSelect.Text);
            if (result != "OK")
            {
                MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DevicePooling.Start();
                connection = 1;
            }
        }   
        
        void UpdateInfo() {
        DeviceSerial.SendData("G");
            connection = 2;
            string data = "0";
            if (DeviceSerial.IncomingData())
            {
                connection = 3;
                data = DeviceSerial.ReceiveData();
                DeviceDataString = data.Split(';');

                try
                {
                    for (int i = 0; i < DeviceDataString.Length - 1; i++) //Converting each character into 
                    {
                        DeviceData[i] = Convert.ToInt32(DeviceDataString[i]);
                    }

                    sysfans.CurrentFanMode = DeviceData[0];
                    sysleds.Mode = (byte)DeviceData[2];
                    sysleds.setBrightnessFromDevice(DeviceData[3]);
                    sysleds.Hue = DeviceData[4];
                    sysleds.Sat = DeviceData[5];
                    sysleds.ColorChangeSpeed = DeviceData[6];
                    sysleds.BreatheSpeed = DeviceData[7];
                    sysfans.CurrentFanSpeed = DeviceData[8];
                    systemps.T = DeviceData[9];
                    systemps.H = DeviceData[10];
                    double hysteresis = DeviceData[11];




                    FanMode.Text = FansMode.Text;
                    FanMode_2.Text = FanMode.Text;
                    RenderChart(sysfans.CurrentFanSpeed);
                    LedMode.Text = NewLedMode.Text;
                    double systemps_t = systemps.T;
                    double systemps_h = systemps.H;
                    systemps_t = systemps_t / 10;
                    systemps_h = systemps_h / 10;
                    CaseTemp.Text = systemps_t.ToString();
                    CaseHumidity.Text = systemps_h.ToString();

                    if (update_all)
                    {
                        FansMode.SelectedIndex = sysfans.CurrentFanMode;
                        TempHysteresis.Value = Convert.ToDecimal(hysteresis / 10);
                        NewLedMode.SelectedIndex = sysleds.Mode;
                        brightness_manual_track.Value = sysleds.Brightness;
                        color_change_track.Value = sysleds.ColorChangeSpeed;
                        Breathe_speed_track.Value = sysleds.BreatheSpeed;
                        Light_color_track.Value = sysleds.Hue;
                        Saturation_track.Value = sysleds.Sat;
                        update_all = false;
                    }
                }
                catch (Exception EX)
                {

                    connection = 4;
                    DeviceSerial.ResetBuffer();
                    update_all = true;
                }
            }
            else connection = 4;
        }

        private void DevicePooling_Tick(object sender, EventArgs e)
        {
        DevicePooling.Interval = (int)poolingRate.Value;
        UpdateInfo();
        }

        int tick = 0;
        private void GraphicsWatchdog_Tick(object sender, EventArgs e)
        {
            switch (connection)
            {
                case 0:
                    Connection.Text = "NULL";
                    ReverseColors(Connection, DevicePortLabel, 1);
                    break;
                case 1:
                    Connection.Text = "STABLE";
                    ReverseColors(Connection, DevicePortLabel, 0);
                    break;
                case 2:
                    Connection.Text = "TRANSMIT";
                    if(tick++%2==0)
                    ReverseColors(Connection, DevicePortLabel, 1);
                    else
                        ReverseColors(Connection, DevicePortLabel, 0);
                    break;
                case 3:
                    Connection.Text = "RECEIVE";
                    if (tick++ % 2 != 0)
                        ReverseColors(Connection, DevicePortLabel, 1);
                    else
                        ReverseColors(Connection, DevicePortLabel, 0);
                    break;
                case 4:
                    Connection.Text = "ERROR";
                        ReverseColors(Connection, DevicePortLabel, 1);        
                    break;

            }
        }

        private void Commit_Click(object sender, EventArgs e)
        {
        CommitChanges();   
        }

        void CommitChanges()
        {
        DevicePooling.Stop();
        connection = 2;
        DeviceSerial.SendData(CreateQueue());
        if (DeviceSerial.ReceiveData() != "OK")
        {
        DevicePooling.Start();
        }
        else
        CommitChanges();
        }

        string CreateQueue()
        {
        sysfans.CurrentFanMode = FansMode.SelectedIndex;
        sysfans.TargetFanSpeed = FanSpeed_manual_track.Value;
        sysleds.Mode = (byte)NewLedMode.SelectedIndex;
        sysleds.Brightness = brightness_manual_track.Value;
        sysleds.Hue = Light_color_track.Value;
        sysleds.Sat = Saturation_track.Value;
        sysleds.ColorChangeSpeed = color_change_track.Value;
        sysleds.BreatheSpeed = Breathe_speed_track.Value;
        string queue = "";
        queue = sysfans.CurrentFanMode + ";" + sysfans.TargetFanSpeed + ";" + sysleds.Mode + ";" + sysleds.brightness255 + ";" + sysleds.Hue + ";" + sysleds.Sat + ";" + sysleds.ColorChangeSpeed + ";" + sysleds.BreatheSpeed + ";" + TempHysteresis.Value * 10 + ";" + "E";
        return queue;
        }

        private void MainPanel_Click(object sender, EventArgs e)
        {
            if(MenuEnabled != 1)
            {
                RenderMenu(1);
            }
        }

        private void FanControl_Click(object sender, EventArgs e)
        {
            if (MenuEnabled != 2)
            {
                RenderMenu(2);
            }
        }

        private void LEDcontrol_Click(object sender, EventArgs e)
        {
            if (MenuEnabled != 3)
            {
                RenderMenu(3);
            }
        }
    }
}
