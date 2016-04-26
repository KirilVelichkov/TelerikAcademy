using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Coffee_Machine
{
    class CoffeeMachine
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine()) * 0.05; //0.05
            double n2 = double.Parse(Console.ReadLine()) * 0.1;  //0.10
            double n3 = double.Parse(Console.ReadLine()) * 0.2;  //0.20
            double n4 = double.Parse(Console.ReadLine()) * 0.5;  //0.50
            double n5 = double.Parse(Console.ReadLine());        //1.00
            double sum = n1 + n2 + n3 + n4 + n5;
            double devMoney = double.Parse(Console.ReadLine());
            double drinkPrice = double.Parse(Console.ReadLine());


            if (devMoney >= drinkPrice && sum > devMoney - drinkPrice)
            {
                Console.WriteLine("Yes {0:F2}", (sum + drinkPrice - devMoney));
            }

            if (devMoney < drinkPrice)
            {
                Console.WriteLine("More {0:F2}", (drinkPrice - devMoney));
            }
            if (devMoney >= drinkPrice && sum < devMoney - drinkPrice)
            {
                Console.WriteLine("No {0:F2}", (devMoney - drinkPrice - sum));
            }

        }
    }
}
