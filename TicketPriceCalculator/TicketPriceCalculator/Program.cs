using System;

namespace MovieTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                string ageInput = Console.ReadLine(); // Read input as string

                try
                {
                    age = int.Parse(ageInput); // Attempt to parse the input

                    // Ensure the age is a positive integer
                    if (age >= 0)
                    {
                        break; // Exit the loop if the input is a valid age
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Determine the ticket price
            int ticketPrice;
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7; // Discounted price for children and senior citizens
            }
            else
            {
                ticketPrice = 10; // Regular price
            }

            // Display the ticket price
            Console.WriteLine("The ticket price is: GHC" + ticketPrice);

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
