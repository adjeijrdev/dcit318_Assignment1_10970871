using System;

namespace GradeToLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;
            while (true)
            {
                Console.Write("Enter a numerical grade between 0 and 100: ");
                string gradeInput = Console.ReadLine(); // Read input as string

                try
                {
                    grade = int.Parse(gradeInput); // Attempt to parse the input

                    // Ensure the grade is within the valid range
                    if (grade >= 0 && grade <= 100)
                    {
                        break; // Exit the loop if the input is a valid grade
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Determine the letter grade using a switch statement
            string letterGrade;
            switch (grade / 10)
            {
                case 10:
                case 9:
                    letterGrade = "A";
                    break;
                case 8:
                    letterGrade = "B";
                    break;
                case 7:
                    letterGrade = "C";
                    break;
                case 6:
                    letterGrade = "D";
                    break;
                default:
                    letterGrade = "F";
                    break;
            }

            // Display the letter grade
            Console.WriteLine("The letter grade is: " + letterGrade);

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
