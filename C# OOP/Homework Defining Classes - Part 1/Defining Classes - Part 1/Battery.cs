using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class Battery
    {
        private BatteryType model;
        private int hoursIdle;
        private int hoursTalk;

        public BatteryType Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value != BatteryType.LiIon && value != BatteryType.NiMH && value != BatteryType.NiCd)
                {
                    throw new ArgumentException("Incorrect battery type");
                }
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Hours Idle can't be lass than 1");
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Hours Talk can't be lass than 1");
                }
                this.hoursTalk = value;
            }
        }


        public Battery(BatteryType model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public override string ToString()
        {
            List<string> info = new List<string>();

            info.Add("--- BATTERY INFO ---");
            info.Add("Model: " + this.Model);
            info.Add("Hours Idle: " + this.HoursIdle);
            info.Add("Hours Talk: " + this.HoursTalk);

            return string.Join(Environment.NewLine, info);
        }
    }
}

