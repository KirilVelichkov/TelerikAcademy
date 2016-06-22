using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Subscriber : EventHandler
    {
        public void Print(string input)
        {
            Console.WriteLine(input);
            Trigger("Print");
        }
    }
}
