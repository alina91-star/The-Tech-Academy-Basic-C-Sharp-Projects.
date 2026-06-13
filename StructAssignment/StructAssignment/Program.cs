using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Number object.
            Number number = new Number();

            // Assign a decimal value to the Amount property.
            number.Amount = 100.50m;

            // Display the amount to the console.
            Console.WriteLine("Amount: " + number.Amount);

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}