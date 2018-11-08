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
            double PCent = 0.0;

            Contract contract = new Contract(Mounth, ContractValue, PCent);
            PayPal paypal = new PayPal(contract);
            paypal.CValue = ContractValue / Mounth;
            Console.WriteLine("$" + paypal.CValue.ToString("F2", CultureInfo.InvariantCulture));

            double Percent, S1, S2, S3, Final4;
            Percent = paypal.CValue / 100;
            S1 = paypal.CValue * 0.01;
            S2 = S1 + Percent;
            S3 = paypal.CValue + S2 + Percent;
            Final4 = S3 * Mounth;

            Console.WriteLine("$" + Percent.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("$" + S2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("$" + S3.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("$" + Final4.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(D);

            Console.ReadLine();
        }
    }
}