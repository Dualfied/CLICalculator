using System;
using System.Threading;

namespace ConsoleCalculator
{
    internal class Program
    {
        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("_________        .__               .__          __                \r\n\\_   ___ \\_____  |  |   ____  __ __|  | _____ _/  |_  ___________ \r\n/    \\  \\/\\__  \\ |  | _/ ___\\|  |  \\  | \\__  \\\\   __\\/  _ \\_  __ \\\r\n\\     \\____/ __ \\|  |_\\  \\___|  |  /  |__/ __ \\|  | (  <_> )  | \\/\r\n \\______  (____  /____/\\___  >____/|____(____  /__|  \\____/|__|   \r\n        \\/     \\/          \\/                \\/                   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("                                   [COMMANDS]                                   ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("[1] 'CLEARLOGS' - Clears inputted text");
            Console.WriteLine("[2] 'TERMINATE' - Closes the Application");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

        public static bool HandleCommand(string input)
        {
            if (input == "CLEARLOGS")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[SUCCESS]: CLEARING CONSOLE");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Console.Clear();
                DisplayMenu();
                return true;
            }
            else if (input == "TERMINATE")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("[SUCCESS]: TERMINATING PROGRAM");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("PROGRAM TERMINATED");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            return false;
        }

        static void Main(string[] args)
        {
            DisplayMenu();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write("Input the First Number: ");
                string FirstNumber = Console.ReadLine();
                if (HandleCommand(FirstNumber)) continue;

                Console.WriteLine();
                Console.Write("Input one of the following operators: (+, -, *, /): ");
                string Operator = Console.ReadLine();
                if (HandleCommand(Operator)) continue;

                Console.WriteLine();
                Console.Write("Input the Second Number: ");
                string SecondNumber = Console.ReadLine();
                if (HandleCommand(SecondNumber)) continue;

                double Result = 0;

                if (double.TryParse(FirstNumber, out double num1) && double.TryParse(SecondNumber, out double num2))
                {
                    if (Operator == "+")
                    {
                        Result = num1 + num2;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(FirstNumber + " + " + SecondNumber + " = " + Result);
                    }

                    if (Operator == "-")
                    {
                        Result = num1 - num2;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(FirstNumber + " - " + SecondNumber + " = " + Result);
                    }

                    if (Operator == "*")
                    {
                        Result = num1 * num2;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(FirstNumber + " * " + SecondNumber + " = " + Result);
                    }

                    if (Operator == "/")
                    {
                        if (num2 != 0)
                        {
                            Result = num1 / num2;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(FirstNumber + " / " + SecondNumber + " = " + Result);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[ERROR] CALCULATION CANNOT BE COMPUTED AS SECOND NUMBER CANNOT BE 0");
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("[ERROR]: INVALID DATA INPUTTED");
                }
            }
        }
    }
}
