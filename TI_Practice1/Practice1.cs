using System;

namespace Practice1
{
    public class Practice1
    {
        public static void Main()
        {
            Console.WriteLine("***Practice1: Start***");

            int attempts = 3;
            double radius;
            double side;

            Console.Write($"\nPlease enter a number used as a circle radius. You have {attempts} attempts: ");

            Validator validateRadius = new Validator
            {
                Attempts = attempts
            };

            radius = validateRadius.GetValueFromConsole();

            Circle circle = new Circle(radius);
            Console.Write("\nCircle area: " + Math.Round(circle.Area, 2));
            Console.WriteLine();
            circle.DrawCircle();

            Console.Write($"\nPlease enter a number used as a square side. You have {attempts} attempts: ");

            Validator validateSide = new Validator
            {
                Attempts = attempts
            };

            side = validateSide.GetValueFromConsole();

            Square square = new Square(side);
            Console.Write("\nSquare area: " + Math.Round(square.Area, 2));
            Console.WriteLine();
            square.DrawSquare();

            if (circle.Diametr >= square.Diagonal)
            {
                Console.Write("\n\nSquare can be put inside circle.");
            }
            else if (circle.Diametr <= square.Side)
            {
                Console.Write("\n\nCircle can be put inside square.");
            }
            else
            {
                Console.Write("\n\nFigures overlaps each other.");
            }

            Console.WriteLine("\n\nPress any button to finish....");
            Console.ReadKey();
        }
    }
}
