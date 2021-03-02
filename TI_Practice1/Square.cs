using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
   public class Square
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public double GetArea()
        {
            return Math.Pow(_side, 2);
        }

        public double GetDiagonal()
        {
            return Math.Sqrt(2 * Math.Pow(_side, 2));
        }
    }
}
