using System;

namespace TriangleType
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2, side3;

            // Read the first side
            while (true)
            {
                Console.Write("Enter the length of the first side: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out side1) && side1 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            // Read the second side
            while (true)
            {
                Console.Write("Enter the length of the second side: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out side2) && side2 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            // Read the third side
            while (true)
            {
                Console.Write("Enter the length of the third side: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out side3) && side3 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            // Determine the type of triangle
            string triangleType;
            if (side1 == side2 && side2 == side3)
            {
                triangleType = "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                triangleType = "Isosceles";
            }
            else
            {
                triangleType = "Scalene";
            }

            // Display the type of triangle
            Console.WriteLine("The type of triangle is: " + triangleType);

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
