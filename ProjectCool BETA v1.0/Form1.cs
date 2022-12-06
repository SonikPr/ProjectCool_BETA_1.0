using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjectCool_BETA_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialCommunicator DeviceSerial = new SerialCommunicator();
        LED sysleds = new LED();
        Fan sysfans = new Fan();
        int[] DeviceData = new int[12];
        string[] DeviceDataString = new string[12];
        bool update_all = true;


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
        private void Form1_Load(object sender, EventArgs e)
        {
            PortSelect.Items.AddRange(DeviceSerial.AvailablePorts);
            sysleds.CreateLed();
            sysfans.CreateFans();
            DevicePooling.Interval = (int)poolingRate.Value;
        }
        private void PortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = DeviceSerial.CreateSerial(9600, PortSelect.Text);
            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DevicePooling.Start();
        }

        void UpdateInfo() {
            DeviceSerial.SendData("G");
            string data = "0";
            if (DeviceSerial.IncomingData())
            {
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



                    Fan_mode_info.Text = Fan_mode.Text;
                    progressBar1.Value = sysfans.CurrentFanSpeed;
                    Fan_speed_info.Text = sysfans.CurrentFanSpeed.ToString() + "%";
                    LED_mode_info.Text = LED_mode.Text;
                    Case_temp__info.Text = (systemps.T / 10).ToString();
                    Case_humidity_info.Text = (systemps.H / 10).ToString();

                    if (update_all)
                    {
                        Fan_mode.SelectedIndex = sysfans.CurrentFanMode;
                        LED_mode.SelectedIndex = sysleds.Mode;
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
                    poolingRate.Value = 1000;
                }
            }
        }

        private void DevicePooling_Tick(object sender, EventArgs e)
        {
            DevicePooling.Interval = (int)poolingRate.Value;
            UpdateInfo();
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            DevicePooling.Stop();
            DeviceSerial.SendData(CreateQueue());
            DevicePooling.Start();
            
        }

        string CreateQueue()
        {
            sysfans.CurrentFanMode = Fan_mode.SelectedIndex;
            sysfans.TargetFanSpeed = FanSpeed_manual_track.Value;
            sysleds.Mode = (byte)LED_mode.SelectedIndex;
            sysleds.Brightness = brightness_manual_track.Value;
            sysleds.Hue = Light_color_track.Value;
            sysleds.Sat = Saturation_track.Value;
            sysleds.ColorChangeSpeed = color_change_track.Value;
            sysleds.BreatheSpeed = Breathe_speed_track.Value;
            string queue = "";
            queue = sysfans.CurrentFanMode + ";" + sysfans.TargetFanSpeed + ";" + sysleds.Mode + ";" + sysleds.brightness255 + ";" + sysleds.Hue + ";" + sysleds.Sat + ";" + sysleds.ColorChangeSpeed + ";" + sysleds.BreatheSpeed + ";" + "E";
            return queue;
        }

    }
}
