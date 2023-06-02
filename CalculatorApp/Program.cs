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
            string input;
            do
            {
                Console.Write(">");
                input = Console.ReadLine();
                try
                {
                    Expr expression = Expr.Parse(input);
                    Console.WriteLine(">Solution: " + expression.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine(">Invalid Expression");
                }
            } while (!input.ToLower().Equals("quit"));
        }
    }
}
