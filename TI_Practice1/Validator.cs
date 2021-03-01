using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Practice1
{
    class Validator
    {
        private int _attempts;

        public Validator(int attempts)
        {
            _attempts = attempts;
        }

        public double IsNumber()
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
                if (double.TryParse(input, out val) && val >0)
                {
                    val = Math.Round(val, 2);
                    break;
                }
                else
                {
                    if (matchCount < _attempts)
                    {
                        Console.Write($"Only numbers greater than 0, comma or dot separators are allowed.\nPlese reenter a number. {(_attempts - matchCount)} attempt(s) left: ");
                    }
                    else if (matchCount == 3)
                    {
                        var random = new Random();
                        const double min = 0.5;
                        const double max = 5;
                        val = Math.Round((random.NextDouble() * (max - min) + min), 2);
                        Console.Write("\nValue is set on default to " + val);
                    }

                    matchCount++;
                }
            }
            return val;
        }
     }
}
