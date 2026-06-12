using System;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class.
            MathOperations math = new MathOperations();

            // Call the void method by passing in two numbers.
            math.DoMath(10, 20);

            // Call the same void method again, this time specifying the parameters by name.
            math.DoMath(firstNumber: 30, secondNumber: 40);

            // Keep the console window open.
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }

    // Create a class to contain the void method.
    public class MathOperations
    {
        // Create a void method that takes two integers as parameters.
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer.
            int result = firstNumber * 2;

            // Display the result of the math operation.
            Console.WriteLine("First number multiplied by 2: " + result);

            // Display the second integer to the screen.
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}