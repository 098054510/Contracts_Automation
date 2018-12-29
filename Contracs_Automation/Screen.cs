using System;
using System.Collections.Generic;
using System.Globalization;
using Contracs_Automation.Installments;
using Contracs_Automation.Services;

namespace Contracs_Automation
{
    class Screen
    {
        public static void MainScreen()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome to Contracts_Automation");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Make a Wise Choice: ");
            Console.WriteLine("1 - Create a Contract");
            Console.WriteLine("2 - See Created Contracts");
            Console.WriteLine("3 - Exit Program");
            Console.Write("Your Choice: ");
        }

        public static void CreateContract()
        {
            Console.WriteLine("Please, Enter Contract Data:");
            Console.WriteLine("Insert The Date: ");
            Console.Write("Contract Owner Name: ");
            string Name = Console.ReadLine();
            Console.Write("Day: ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("Contract Value: $");
            double ContractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the number of installments: ");
            int Installments = int.Parse(Console.ReadLine());
            double PCent = 0.03 * 100;
            Contract contract = new Contract(Name, Installments, ContractValue, PCent);
            PayPal paypal = new PayPal(contract);
            paypal.CValue = ContractValue / Installments;
            double A8;
            A8 = paypal.CValue + PCent;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("----------------Contract Info----------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Contract Owner Name: " + Name);
            Console.WriteLine("Contract Price: $" + ContractValue.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Installments Price: $" + paypal.CValue.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Monthly Simple Interest Price: $" + Percent.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Payment Fee Price: $" + S2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Current Date: " + Day + "/" + Month + " - " + "Current Value: $" + A8.ToString("F2", CultureInfo.InvariantCulture));
            int NextMounth;
            NextMounth = Month + 1;
            if (NextMounth == 13)
            {
                int NextMonth;
                double NextInstallment, Test, Test2;
                NextMonth = NextMounth - 12;
                //NextInstallment = paypal.CValue + S2 * NextMonth;
                //Test = NextInstallment * 0.02;
                //Test2 = Test + paypal.CValue;
                Console.WriteLine("Next Date of Installment: " + Day + "/" + NextMonth);
                //Console.WriteLine("Next Installment: $" + NextInstallment.ToString("F2", CultureInfo.InvariantCulture));
                //Console.WriteLine("Test: " + Test);
                //Console.WriteLine("Test 2: " + Test2);
            }
            if (NextMounth != 13)
            {
                int NextMonth;
                NextMonth = NextMounth++;
                Console.WriteLine("Next Date of Installment: " + Day + "/" + NextMonth);
                Console.WriteLine("Total Months of Installments: " + Installments);
            }
            //Console.WriteLine("Next Price of Installment: $" + S4.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Final Installment: " + Day + "/" + Installments);
            Console.WriteLine("Final Price; $" + A8.ToString("F2", CultureInfo.InvariantCulture));
            Contract C = new Contract(Name, Month, ContractValue, PCent);
            Program.contracts.Add(C);
        }


        public static void CreatedContracts()
        {
            Console.WriteLine("Created Contracts:");
            var Amount = 0;
            foreach (var contracts in Program.contracts)
            {
                Amount++;
                Console.WriteLine(Amount + "º " + contracts);
            }
        }
    }
}
