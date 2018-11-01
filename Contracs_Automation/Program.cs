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
            int I = int.Parse(Console.ReadLine());
            double FinalValue = 0.0;
            FinalValue = ContractValue / I;
            Console.WriteLine("$" + FinalValue.ToString("F2", CultureInfo.InvariantCulture));

            for (int i = 0; i<I; i++)
            {
                double Sub, Final;
                Sub = 1% + FinalValue * I;
                Final = 2% + Sub;
                Console.WriteLine("$" + Final.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.Write(D);
            Console.ReadLine();
        }
    }
}