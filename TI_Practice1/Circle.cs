using System;

namespace Practice1
{
    public class Circle
    {
        public double Radius { get; private set; }

        public double Area => Math.PI * Math.Pow(Radius, 2);

        public double Diametr => 2 * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DrawCircle()
        {
            var thickness = 0.4;
            var symbol = "*";

            double rIn = Radius - thickness, rOut = Radius + thickness;

            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
