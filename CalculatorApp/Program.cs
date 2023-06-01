using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CL Calculator");


            string userInput = Console.ReadLine();
            string pattern = @"[\+]|(\d+(\.\d+)?)";

            List<float> numbers = new List<float>();

            foreach (Match m in Regex.Matches(userInput, pattern))
            {
                if (float.TryParse(m.Value, out float number))
                {
                    numbers.Add(number);
                }
            }
            float[] numbersArray = numbers.ToArray();

            Addition(numbersArray);

        }

        public static void Addition(params float[] numbers)
        {
            float sum = 0;

            foreach (float number in numbers)
            {
                sum += number;
            }
            Display(sum);
        }

        public static void Display(float result) => Console.WriteLine($"The sum is {result}");
    }
}