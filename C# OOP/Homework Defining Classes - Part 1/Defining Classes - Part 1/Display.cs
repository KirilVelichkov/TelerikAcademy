using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class Display
    {
        private decimal? size;
        private int? numberOfColors;


        public decimal? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Size can't be less than 1");
                }
                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Number of Colors can't be less than 1");
                }
                this.numberOfColors = value;
            }
        }

        public Display(decimal? size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            List<string> info = new List<string>();
            info.Add("--- Display Info --- ");
            info.Add($"Size: {this.Size}");
            info.Add($"Number of Colors: {this.NumberOfColors}");
            return base.ToString();
        }
    }
}
