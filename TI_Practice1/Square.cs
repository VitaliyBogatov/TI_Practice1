using System;

namespace Practice1
{
   public class Square
    {
        public double Side { get; private set; }

        public double Area => Math.Pow(Side, 2);

        public double Diagonal => Math.Sqrt(2 * Math.Pow(Side, 2));

        public Square(double side)
        {
            Side = side;
        }

        public void DrawSquare()
        {
            for (int i = 0; i <= Side; i++)
            {
                for (int j = 0; j <= Side; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            Console.Write('\u2554');
                        }
                        else if (j % Side != 0)
                        {
                            Console.Write('\u2550');
                            Console.Write('\u2550');
                        }
                        else if (j % Side == 0)
                        {
                            Console.WriteLine('\u2557');
                        }
                    }
                    else if (i < Side)
                    {
                        if (j == 0)
                        {
                            Console.Write('\u2551');
                        }
                        else if (j % Side != 0)
                        {
                            Console.Write(' ');
                            Console.Write(' ');
                        }
                        else if (j % Side == 0)
                        {
                            Console.WriteLine('\u2551');
                        }
                    }
                    else if (i == Side)
                    {
                        if (j == 0)
                        {
                            Console.Write('\u255A');
                        }
                        else if (j % Side != 0)
                        {
                            Console.Write('\u2550');
                            Console.Write('\u2550');
                        }
                        else if (j % Side == 0)
                        {
                            Console.WriteLine('\u255D');
                        }
                    }
                }
            }
        }
    }
}
