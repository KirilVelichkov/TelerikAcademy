using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            //Task 7
            GSMtest.GSMTest();

            //Task 12
            //Create an instance of the GSM class.
            var battery = new Battery(BatteryType.LiIon, 100, 10);
            var display = new Display(2.5m, 5000);
            var gsm = new GSM("3310", "NOKIA", 25.5m, "Pencho", battery, display);
            
            //Add few calls.
            var call1 = new Calls("06/12/2016", "13:41", "0888 12 34 56", 10);
            var call2 = new Calls("06/12/2016", "15:41", "0888 12 34 56", 20);
            var call3 = new Calls("06/12/2016", "17:41", "0888 12 34 56", 30);
             
            gsm.AddCalls(call1);
            gsm.AddCalls(call2);
            gsm.AddCalls(call3);

            //Display the information about the calls.
            Console.WriteLine(call1);
            Console.WriteLine(call2);
            Console.WriteLine(call3);
            
            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine($"Total calls price = {gsm.CalculateCallPrice(0.37m)}");

            //Remove the longest call from the history and calculate the total price again.
            Calls longest = gsm.CallsHistory[0];
            foreach(var call in gsm.CallsHistory)
            {
                if(call.CallDuration > longest.CallDuration)
                {
                    longest = call;
                }
            }
            gsm.DeleteCalls(longest);
            Console.WriteLine($"Total calls price after the longest call is removed = {gsm.CalculateCallPrice(0.37m)}");

            //Finally clear the call history and print it.
            gsm.ClearCallHistory();
            
            Console.WriteLine($"Calls history cleared");
        }
  
    }
}
