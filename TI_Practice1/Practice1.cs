using System;

namespace Practice1
{
    class Practice1
    {
        static void Main()
        {
            Console.WriteLine("***Practice1: Start***");

            int attempts = 3;
            double radius;
            double side;
            double result;

            Console.Write($"\nPlease enter a number used as a circle radius. You have {attempts} attempts: ");

            Validator validateRadius = new Validator(attempts);
            radius = validateRadius.GetValueFromConsole();

            Circle circle = new Circle(radius);

            result = Math.Round(circle.GetArea(), 2);
            Console.Write("\nCircle area: " + result);

            Console.Write($"\nPlease enter a number used as a square side. You have {attempts} attempts: ");

            Validator validateSide = new Validator(attempts);
            side = validateSide.GetValueFromConsole();

            Square square = new Square(side);

            result = Math.Round(square.GetArea(), 2);
            Console.Write("\nSquare area: " + result);

            if (circle.GetDiametr() >= square.GetDiagonal())
            {
                Console.Write("\nSquare can be put inside circle.");
            }
            else if (circle.GetDiametr() <= square.Side)
            {
                Console.Write("\nCircle can be put inside square.");
            }
            else
            {
                Console.Write("\nFigures overlaps each other.");
            }

            Console.WriteLine("\n\nPress any button to finish....");
            Console.ReadKey();
        }
    }
}
