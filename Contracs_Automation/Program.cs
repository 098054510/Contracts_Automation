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
        public static List<Contract> contracts = new List<Contract>();

        static void Main(string[] args)
        {
            Console.Clear();
            int option = 0;
            while (option == 0)
            {
                try
                {
                    Console.Clear();
                    Screen.MainScreen();
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Screen.CreateContract();
                            Console.Write("Press 'ENTER' to Continue");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("An Unexpected Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 2:
                            Screen.CreatedContracts();
                            Console.Write("Press 'ENTER' to Continue");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("An Unexpected Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 3:
                            Console.Write("Ending...");
                            break;

                        default:
                            Console.WriteLine("Option not valid");
                            Console.WriteLine("Please insert a valid Option");
                            Console.WriteLine("Press 'ENTER' to Continue");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An Unexpected Error Founded " + e.Message);
                    Console.Write("Press 'ENTER' to Continue");
                }
            }
        }
    }
}