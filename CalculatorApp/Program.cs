using System;
using System.Collections.Generic;
using MathNet.Symbolics;
using CalculatorApp.Helpers;
using CalculatorApp.Input;
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
                string input = Console.ReadLine();
                try
                {
                    AlgebraicInput algebraicInput = new AlgebraicInput(input);
                    Expr expression = Expr.Parse(algebraicInput.ToString());
                    Console.WriteLine("Input equation: " + expression.ToString());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid Operation");
                }

                Console.WriteLine("Do you want to continue? (Y/N)");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();

                List<char> validInputs = new List<char> { 'Y', 'y', 'N', 'n' };
                if (!validInputs.Contains(userInput))
                {
                    Console.WriteLine("Invalid input! Please enter Y or N.");
                }

            } while (userInput != 'N' && userInput != 'n');
        }
    }
}
