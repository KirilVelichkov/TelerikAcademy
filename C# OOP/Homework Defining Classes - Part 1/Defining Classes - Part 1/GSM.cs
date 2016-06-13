using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static readonly GSM iphone4s = new GSM(
            "Iphone 4S",
            "Apple inc",
            300,
            "Ddad",
            new Battery(BatteryType.LiIon, 5, 1),
            new Display(4, 10000));

        public static GSM Iphone4s
        {
            get
            {
                return iphone4s;
            }
        }
   
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Model name can't be empty");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Manufcaturer name can't be empty");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be less than 0");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Owner name can't be empty");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Calls> CallsHistory{ get; private set; }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            CallsHistory = new List<Calls>();
    }

    public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {

        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {

        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null, null, null)
        {

        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {

        }

        public override string ToString()
        {
            List<string> fullInfo = new List<string>();
            fullInfo.Add("--- FULL PHONE INFO ---");
            fullInfo.Add($"Model: {this.Model}");
            fullInfo.Add($"Manufacturer: {this.Manufacturer}");

            if(this.Price != null)
            {
                fullInfo.Add($"Price: {this.Price}");
            }
            if(this.Owner != null)
            {
                fullInfo.Add($"Owner: {this.Owner}");

            }
            if (this.Battery != null)
            {
                fullInfo.Add($"Battery: {this.Battery.Model}, Hours Idle = {this.Battery.HoursIdle}, Hours Talk = {this.Battery.HoursTalk}");
            }
            if (this.Display != null)
            {
                fullInfo.Add($"Display: size = {this.Display.Size} , Colors = {this.Display.NumberOfColors}");
            }

            return string.Join(Environment.NewLine, fullInfo);
        }

        public void AddCalls(Calls call)
        {
            CallsHistory.Add(call);
        }

        public void DeleteCalls(Calls call)
        {
            CallsHistory.Remove(call);
        }

        public void DeleteHistory(int callIndex)
        {
            CallsHistory.RemoveAt(callIndex);
        }

        public void ClearCallHistory()
        {
            CallsHistory.Clear();
        }

        public decimal CalculateCallPrice(decimal callPrice)
        {
            decimal AllCalls = (decimal)(this.CallsHistory.Select(x => x.CallDuration).Sum());
            return AllCalls * callPrice;
        }
    }
}
