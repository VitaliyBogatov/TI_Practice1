using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class Circle
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double GetDiametr()
        {
            return 2 * Radius;
        }
    }
}
