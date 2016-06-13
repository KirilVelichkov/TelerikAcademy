using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class GSMtest
    {
        public static void GSMTest()
        {
            Console.WriteLine("---- GSM TEST ---- ");
            GSM[] testGSMs = new GSM[3];
            testGSMs[0] = new GSM("3310", "NOKIA", 5, "Pesho", new Battery(BatteryType.LiIon, 100, 10), new Display(3, 100));
            testGSMs[1] = new GSM("c50", "Siemens", 10, "Gosho", new Battery(BatteryType.NiCd, 50, 5), new Display(4, 500));
            testGSMs[2] = new GSM("5s", "Apple", 15, "Petkan", new Battery(BatteryType.NiMH, 10, 1), new Display(5, 1000));

            Console.WriteLine(testGSMs[0]);
            Console.WriteLine(testGSMs[1]);
            Console.WriteLine(testGSMs[2]);
            Console.WriteLine(GSM.Iphone4s);
        }

    }
}
