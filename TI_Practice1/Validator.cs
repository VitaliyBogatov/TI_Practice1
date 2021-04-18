using System;

namespace Practice1
{
    public class Validator
    {
        public int Attempts { get; set; }

        public double GetValueFromConsole()
        {
            int matchCount = 1;
            double val = 0;
            while (matchCount <= Attempts)
            {
                var input = Console.ReadLine();
                input = input.Replace(',', '.');

                if (double.TryParse(input, out val) && val > 0)
                {
                    val = Math.Round(val, 2);
                    break;
                }
                else if (matchCount < Attempts)
                {
                    Console.Write($"Only numbers greater than 0, comma or dot separators are allowed.\nPlease reenter a number. {(Attempts - matchCount)} attempt(s) left: ");
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
