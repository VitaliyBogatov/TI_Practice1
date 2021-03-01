using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Circle
    {
        public Circle(double val)
        {
            radius = val;
        }

        readonly double radius;
        double resp;

        public double GetArea()
        {
            resp = Math.PI * Math.Pow(radius, 2);
            return resp;
        }
        public double GetDiametr()
        {
            resp = 2 * radius;
            return resp;
        }
    }
}
