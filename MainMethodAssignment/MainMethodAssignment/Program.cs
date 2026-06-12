using System;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations math = new MathOperations();

            // Call the method that takes an integer
            int intResult = math.Calculate(10);

            // Display the result from the integer method
            Console.WriteLine("Integer result: " + intResult);

            // Call the method that takes a decimal
            int decimalResult = math.Calculate(10.5m);

            // Display the result from the decimal method
            Console.WriteLine("Decimal result: " + decimalResult);

            // Call the method that takes a string
            int stringResult = math.Calculate("20");

            // Display the result from the string method
            Console.WriteLine("String result: " + stringResult);

            // Keep the console window open
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }

    // Create a class to hold the math methods
    public class MathOperations
    {
        // This method takes an integer, adds 10 to it, and returns an integer
        public int Calculate(int number)
        {
            return number + 10;
        }

        // This method takes a decimal, multiplies it by 2, converts it to an integer, and returns it
        public int Calculate(decimal number)
        {
            return Convert.ToInt32(number * 2);
        }

        // This method takes a string, converts it to an integer, subtracts 5, and returns an integer
        public int Calculate(string numberText)
        {
            int number = Convert.ToInt32(numberText);
            return number - 5;
        }
    }
}