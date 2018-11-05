using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Contracs_Automation.Installments;
using Contracs_Automation.Services;

namespace Contracs_Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data:");
            Console.Write("Number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime D = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: $");
            double ContractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of installments: ");
            int Mounth = int.Parse(Console.ReadLine());
            Console.Write("Insert the Percent of Monthly and Payment fee: ");
            double PCent = double.Parse(Console.ReadLine());
            Contract C = new Contract(Mounth, ContractValue, PCent);
            PayPal P = new PayPal(C);
            for (int i = Mounth; i <= Mounth; i++)
            {
                Console.WriteLine("$" + P.Tax(P.CValue).ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}