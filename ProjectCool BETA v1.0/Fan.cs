using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCool_BETA_v1._0
{
    class Fan
    {
        private int fan_speed;
        private int fan_mode;
        private int tagret_fan_speed;

        public void CreateFans() { }

        public int CurrentFanSpeed
        {
            get { return map(fan_speed, 0, 255, 0, 100); }
            set { fan_speed = value; }
        }

        public int CurrentFanMode
        {
            get { return fan_mode; }
            set { fan_mode = value; }
        }

        public int TargetFanSpeed
        {
            get { return tagret_fan_speed; }
            set {tagret_fan_speed = map(value, 0, 100, 0, 255); }
        }


        private int map(int x, int in_min, int in_max, int out_min, int out_max)
        {
            return (x - in_min) * (out_max - out_min + 1) / (in_max - in_min + 1) + out_min;
        }
    }
}
