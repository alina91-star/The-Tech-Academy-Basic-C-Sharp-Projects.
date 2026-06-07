using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                // Display the error message if the package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Ask the user to enter the package width
                Console.WriteLine("Please enter the package width:");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                // Ask the user to enter the package height
                Console.WriteLine("Please enter the package height:");
                decimal height = Convert.ToDecimal(Console.ReadLine());

                // Ask the user to enter the package length
                Console.WriteLine("Please enter the package length:");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                // Calculate the total dimensions of the package
                decimal totalDimensions = width + height + length;

                // Check if the package is too big
                if (totalDimensions > 50)
                {
                    // Display the error message if the package is too big
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Calculate the shipping quote
                    decimal quote = width * height * length * weight / 100;

                    // Display the shipping quote as a dollar amount
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

                    // Display the thank you message
                    Console.WriteLine("Thank you!");
                }
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
