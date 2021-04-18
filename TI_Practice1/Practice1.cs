using System;

namespace Practice1
{
    public class Practice1
    {
        static void Main()
        {
            Console.WriteLine("***Practice1: Start***");

            int attempts = 3;
            double radius;
            double side;
            double result;

            Console.Write($"\nPlease enter a number used as a circle radius. You have {attempts} attempts: ");

            Validator validateRadius = new Validator();
            validateRadius.Attempts = attempts;
            radius = validateRadius.GetValueFromConsole();

            Circle circle = new Circle(radius);
            result = Math.Round(circle.Area, 2);
            Console.Write("\nCircle area: " + result);
            Console.WriteLine();
            circle.DrawCircle();

            Console.Write($"\nPlease enter a number used as a square side. You have {attempts} attempts: ");

            Validator validateSide = new Validator();
            validateSide.Attempts = attempts;
            side = validateSide.GetValueFromConsole();

            Square square = new Square(side);
            result = Math.Round(square.Area, 2);
            Console.Write("\nSquare area: " + result);
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
