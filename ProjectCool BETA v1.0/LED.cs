using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace ProjectCool_BETA_v1._0
{
    class LED
    {
        private int BRIGHTNESS;
        private int LIGHT_COLOR;
        private int LIGHT_SAT;
        private int BREATHE_SPEED;
        private int COLOR_CHANGE_SPEED;
        private byte MODE;


        public void CreateLed() { }

        public void setBrightnessFromDevice(int brightness)
        {
            BRIGHTNESS = brightness;
        }

        public int Brightness
        {
            get { return map(BRIGHTNESS, 0, 255, 0, 100); }
            set { BRIGHTNESS = map(value, 0, 100, 0, 255);  }
        }

        public int Hue
        {
            get { return LIGHT_COLOR; }
            set { LIGHT_COLOR = value; }
        }

        public int Sat
        {
            get { return LIGHT_SAT; }
            set { LIGHT_SAT = value; }
        }
 

        public int BreatheSpeed
        {
            get { return BREATHE_SPEED; }
            set { BREATHE_SPEED = value; }
        }

        public int ColorChangeSpeed
        {
            get { return COLOR_CHANGE_SPEED; }
            set { COLOR_CHANGE_SPEED = value; }
        }

		public byte Mode
		{
			get { return MODE; }
			set { MODE = value; }
		}

        /*
        private int constrain(int x, int min, int max)
        {
            if (x < min) return min;
            else
                if (x > max) return max;
            else
                return x;
        }
        */
        private int map(int x, int in_min, int in_max, int out_min, int out_max)
        {
            return (x - in_min) * (out_max - out_min + 1) / (in_max - in_min + 1) + out_min;
        }

    }
}
