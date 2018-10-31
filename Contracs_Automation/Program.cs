using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Contracs_Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data:");
            Console.Write("Number: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            int D = int.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double C = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of installments: ");
            int I = int.Parse(Console.ReadLine());

            Value = C / I;
            Console.Write(Value);
        }
    }
}
