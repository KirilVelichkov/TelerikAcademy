using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class Calls
    {
        private string date;
        private string time;
        private string dialledPhone;
        private int callDuration;

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Call date can't be empty");
                }
                this.date = value;

            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Call time can't be empty");
                }
                this.time = value;
            }
        }

        public string DialledPhone
        {
            get
            {
                return this.dialledPhone;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Dialled Phone can't be empty");
                }
                this.dialledPhone = value;
            }
        }

        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Call duration can't be less than 1");
                }
                this.callDuration = value;
            }
        }

        public Calls(string date, string time, string dialledPhone, int callDuration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhone = dialledPhone;
            this.CallDuration = callDuration;
        }

        public override string ToString()
        {
            List<string> info = new List<string>();
            info.Add($"--- Call Info ---");
            info.Add($"Date: {this.Date}");
            info.Add($"Time: {this.Time}");
            info.Add($"Dialled Phone: {this.DialledPhone}");
            info.Add($"Call Duration: {this.CallDuration}");

            return string.Join(Environment.NewLine, info);
        }
    }
}
