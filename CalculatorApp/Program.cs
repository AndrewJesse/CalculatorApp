using System;
using System.Linq;
using System.Collections.Generic;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            Run();
        }
        public static void Run()
        {
            char userInput;

            do
            {
                Console.WriteLine("Please enter an algebraic expression to evaluate:");
                string? input = Console.ReadLine();
                Expr expression = Expr.Parse(input);
                Console.WriteLine("Input equation: " + expression.ToString());

                Console.WriteLine("Do you want to continue? (Y/N)");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (userInput != 'Y' && userInput != 'y' && userInput != 'N' && userInput != 'n')
                {
                    Console.WriteLine("Invalid input! Please enter Y or N.");
                }

            } while (userInput != 'N' && userInput != 'n');
        }
        public static void Greeting()
        {
            Console.WriteLine("Welcome to the Command Line Calculator\n");
            Console.WriteLine("https://github.com/AndrewJesse/CalculatorApp\n");
            Console.WriteLine(" _____________________");
            Console.WriteLine("|  _________________  |");
            Console.WriteLine("| |            80085| |");
            Console.WriteLine("| |_________________| |");
            Console.WriteLine("|  ___ ___ ___   ___  |");
            Console.WriteLine("| | 7 | 8 | 9 | | + | |");
            Console.WriteLine("| |___|___|___| |___| |");
            Console.WriteLine("| | 4 | 5 | 6 | | - | |");
            Console.WriteLine("| |___|___|___| |___| |");
            Console.WriteLine("| | 1 | 2 | 3 | | x | |");
            Console.WriteLine("| |___|___|___| |___| |");
            Console.WriteLine("| | . | 0 | = | | / | |");
            Console.WriteLine("| |___|___|___| |___| |");
            Console.WriteLine("|_____________________|\n");
        }
    }
}
