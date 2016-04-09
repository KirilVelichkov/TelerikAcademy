using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Company_Info
{
    class CompanyInfo
    {
        static void Main()
        {
            //to do

            string companyName = Console.ReadLine();
            string companyAdress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            if (faxNumber == String.Empty) faxNumber = "Fax: (no fax)";
            string webSite = Console.ReadLine();
            string mFirstName = Console.ReadLine();
            string mLastName = Console.ReadLine();
            byte managerAge = byte.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Adress: {0}", companyAdress);
            Console.WriteLine("Tel. +{0}", phoneNumber);






        }
    }
}
