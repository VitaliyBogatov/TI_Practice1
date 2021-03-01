using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Square
    {
        public Square(double val)
        {
            side = val;
        }

        readonly double side;
        double resp;

        public double GetArea()
        {
            resp = Math.Pow(side, 2);
            return resp;
        }

        public double GetDiagonal()
        {
            resp = Math.Sqrt(2 * Math.Pow(side, 2));
            return resp;
        }
    }
}
