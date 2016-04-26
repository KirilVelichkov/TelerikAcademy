using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BullsAndCows
{
   
    class BullsAndCows
    {
        static void Main()
        {
            int secretNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
          
            int countBulls = 0;
            int countCows = 0;

            int secret1 = 0;
            int secret2 = 0;
            int secret3 = 0;
            int secret4 = 0;

            int result1 = 0;
            int result2 = 0;
            int result3 = 0;
            int result4 = 0;

            bool bull1 = false;
            bool bull2 = false;
            bool bull3 = false;
            bool bull4 = false;

            bool foundNumber = false;
            string result = "";

            secret1 = secretNumber / 1000;
            secret2 = (secretNumber % 1000) / 100;
            secret3 = (secretNumber % 100) / 10;
            
            secret4 = secretNumber % 10;
           
            for (int i = 1000; i <= 9999; i++) 
            {
                countCows = 0;
                countBulls = 0;
                bull1 = false;
                bull2 = false;
                bull3 = false;
                bull4 = false;
                result1 = i / 1000;
                result2 = (i % 1000) / 100;
                result3 = (i % 100) / 10;
                result4 = i % 10;
               
                if (secret1 == result1)
                {
                    bull1 = true;
                    countBulls++;
                }
                
                if (secret2 == result2)
                {
                    bull2 = true;
                    countBulls++;
                }
                if (secret3 == result3)
                {
                    bull3 = true;
                    countBulls++;
                }
                if (secret4 == result4)
                {
                    bull4 = true;
                    countBulls++;
                }
                if (result1 == 0 || result2 == 0 || result3 == 0 || result4 == 0)
                {
                    continue;
                }
                else
                {
                    if (result1 == secret2 && !bull2 && !bull1) countCows++;
                    if (result1 == secret3 && !bull3 && !bull1) countCows++;
                    if (result1 == secret4 && !bull4 && !bull1) countCows++;

                    if (result2 == secret1 && !bull1 && !bull2) countCows++;
                    if (result2 == secret3 && !bull3 && !bull2) countCows++;
                    if (result2 == secret4 && !bull4 && !bull2) countCows++;

                    if (result3 == secret1 && !bull1 && !bull3) countCows++;
                    if (result3 == secret2 && !bull2 && !bull3) countCows++;
                    if (result3 == secret4 && !bull4 && !bull3) countCows++;

                    if (result4 == secret1 && !bull1 && !bull4) countCows++;
                    if (result4 == secret2 && !bull2 && !bull4) countCows++;
                    if (result4 == secret3 && !bull3 && !bull4) countCows++;
                    
                    if (bulls == countBulls && cows == countCows)
                    {
                        foundNumber = true;
                        result += i + " ";
                    }
                }
            }
            if (!foundNumber)
            {
                result = "No";
            }

            Console.WriteLine(result);
        }
    }
}
