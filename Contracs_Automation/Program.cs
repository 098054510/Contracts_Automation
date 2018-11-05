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
            Console.Write("How much Contracts will be registered: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; 1 <= N; i++)
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
                Contract contract = new Contract(Mounth, ContractValue);
                PayPal paypal = new PayPal(contract);
                paypal.CValue = ContractValue / Mounth;

                Console.WriteLine("$" + paypal.CValue.ToString("F2", CultureInfo.InvariantCulture));

                for (int ii = 0; ii < Mounth; ii++)
                {
                    double Sub, Final, Final2;
                    Sub = 1.01 + paypal.CValue * Mounth;
                    Final = 2 % +Sub;
                    Final2 = Final + Sub;
                    Console.WriteLine("$" + Final2.ToString("F2", CultureInfo.InvariantCulture));
                }
                Console.WriteLine(D);
            }
            Console.ReadLine();
        }
    }
}