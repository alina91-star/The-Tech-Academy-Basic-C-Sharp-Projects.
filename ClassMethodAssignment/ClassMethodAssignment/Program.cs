using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class.
            MathOperations math = new MathOperations();

            // Ask the user to enter a number.
            Console.WriteLine("Please enter a number:");

            // Read the user's input.
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call the void method.
            math.DivideByTwo(userNumber);

            // Declare a variable for the output parameter.
            int result;

            // Call the method with the output parameter.
            math.DivideByTwo(userNumber, out result);

            // Display the result from the output parameter.
            Console.WriteLine("Output parameter result: " + result);

            // Call the overloaded method.
            math.DivideByTwo(30.5);

            // Call the static class method.
            StaticExample.ShowMessage();

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}