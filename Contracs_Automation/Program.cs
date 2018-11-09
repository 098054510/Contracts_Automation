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
            Console.WriteLine("Date: ");
            Console.Write("Day: ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int Mounth = int.Parse(Console.ReadLine());
            Console.Write("Contract Value: $");
            double ContractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of installments: ");
            int Installments = int.Parse(Console.ReadLine());
            double PCent = 0.0;

            Contract contract = new Contract(Installments, ContractValue, PCent);
            PayPal paypal = new PayPal(contract);
            paypal.CValue = ContractValue / Installments;

            double Percent, S1, S2, S3;
            Percent = paypal.CValue / 100;
            S1 = paypal.CValue * 0.01;
            S2 = S1 + Percent;
            S3 = paypal.CValue + S2 + Percent;

            Console.WriteLine("Contract Price: $" + ContractValue);
            Console.WriteLine("Installments Price: $" + paypal.CValue.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Monthly Simple Interest Price: $" + Percent.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Payment Fee Price: $" + S2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Final Value of Mounth: $" + S3.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Current Date: " + Day + "/" + Mounth);

            int NextMounth;
            NextMounth = Mounth + 1;
            if (NextMounth == 13)
            {
                int NextMonth;
                double NextInstallment, Test, Test2;
                NextMonth = NextMounth - 12;
                NextInstallment = paypal.CValue + S2 * NextMonth;
                Test = NextInstallment * 0.02;
                Test2 = Test + paypal.CValue;
                Console.WriteLine("Next Date of Installment: " + Day + "/" + NextMonth);
                Console.WriteLine("Next Installment: $" + NextInstallment.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Test: " + Test);
                Console.WriteLine("Test 2: " + Test2);
            }

            if (NextMounth != 13)
            {
                int NextMonth;
                NextMonth = NextMounth++;
                Console.WriteLine("Next Date of Installment: " + Day + "/" + NextMonth);
            }

            Console.ReadLine();
        }
    }
}