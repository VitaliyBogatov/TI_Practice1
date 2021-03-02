using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class Circle
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        public double GetDiametr()
        {
            return 2 * _radius;
        }
    }
}
