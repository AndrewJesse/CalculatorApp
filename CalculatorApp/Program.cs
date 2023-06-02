using System;
using System.Linq;
using System.Collections.Generic;
using MathNet.Symbolics;
using CalculatorApp.Helpers;
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetingHelpers.Greeting();
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

    }
}
