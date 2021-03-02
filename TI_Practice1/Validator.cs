using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Practice1
{
    class Validator
    {
        private readonly int _attempts;

        public Validator(int attempts)
        {
            _attempts = attempts;
        }

        public double GetValueFromConsole()
        {
            int matchCount = 1;
            double val = 0;
            while (matchCount <= _attempts)
            {
                var input = Console.ReadLine();
                input = input.Replace(',', '.');
                //String pattern = @"^[1-9]\d*([\.|\,]\d+)?$$";
                //Match m = Regex.Match(input, pattern);

                //if (m.Success)
                if (double.TryParse(input, out val) && val > 0)
                {
                    val = Math.Round(val, 2);
                    break;
                }
                else if (matchCount < _attempts)
                {
                    Console.Write($"Only numbers greater than 0, comma or dot separators are allowed.\nPlease reenter a number. {(_attempts - matchCount)} attempt(s) left: ");
                }
                else
                {
                    val = GetDefaultValue();
                    Console.Write("\nValue is set on default to " + val);
                }
                matchCount++;
            }
            return val;
        }

        private double GetDefaultValue()
        {
            var random = new Random();
            const double min = 0.5;
            const double max = 5;
            
            return Math.Round((random.NextDouble() * (max - min) + min), 2);            
        }
    }
}
