using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            try
            {
                // Ask the user for a number
                Console.WriteLine("Enter a number to divide each number in the list by:");

                // Convert the user's input to an integer
                int divisor = Convert.ToInt32(Console.ReadLine());

                // Loop through each number in the list
                foreach (int number in numbers)
                {
                    // Divide the number by the user's input
                    int result = number / divisor;

                    // Display the result
                    Console.WriteLine(number + " / " + divisor + " = " + result);
                }
            }
            catch (DivideByZeroException ex)
            {
                // Display an error message if the user enters zero
                Console.WriteLine("Error: You cannot divide by zero.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                // Display an error message if the user enters text
                Console.WriteLine("Error: Please enter a valid number.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Display any other unexpected error
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }

            // This message proves the program continued after the try/catch block
            Console.WriteLine("The program has emerged from the try/catch block and continued execution.");

            // Keep the console window open
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}