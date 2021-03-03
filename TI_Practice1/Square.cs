using System;

namespace Practice1
{
   public class Square
    {
        public double Side { get; private set; }

        public Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Math.Pow(Side, 2);
        }

        public double GetDiagonal()
        {
            return Math.Sqrt(2 * Math.Pow(Side, 2));
        }
    }
}
