using System;
using System.Xml.Linq;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Q to quit the program.");

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("You pressed Q. The program will now quit.");
                    break;
                }
                else
                {
                    Console.WriteLine("You pressed " + keyInfo.Key + ". Press Q to quit.");
                }
            }
            Console.Write("Enter a number: ");  // Prompt the user
            string? name = Console.ReadLine();

            Addition(1, 2, 3, 3, 4);

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

        public static float Display(float result) => result;
    }
}