using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Input
{
    public class AlgebraicInput
    {
        private string value;

        public AlgebraicInput(string input)
        {
            if (!IsValid(input))
                throw new ArgumentException("Invalid algebraic input.");

            value = input;
        }

        public override string ToString()
        {
            return value;
        }

        // Add any additional validation logic as needed
        private static bool IsValid(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Check if the input contains only valid algebraic characters
            var validChars = new HashSet<char>("+-*/^()0123456789".ToCharArray());
            if (input.Any(c => !validChars.Contains(c)))
                return false;

            // Check if parentheses are balanced
            int parenthesesCount = 0;
            foreach (char c in input)
            {
                if (c == '(')
                    parenthesesCount++;
                else if (c == ')')
                {
                    parenthesesCount--;
                    if (parenthesesCount < 0)
                        return false;
                }
            }

            return parenthesesCount == 0;
        }
    }
}
