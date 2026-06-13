using System;

namespace ClassMethodAssignment
{
    // This class contains math methods used by the program.
    public class MathOperations
    {
        // This void method takes an integer, divides it by 2, and displays the result.
        public void DivideByTwo(int number)
        {
            Console.WriteLine("Result: " + (number / 2));
        }

        // This method uses an output parameter.
        public void DivideByTwo(int number, out int result)
        {
            result = number / 2;
        }

        // This overloaded method accepts a double value.
        public void DivideByTwo(double number)
        {
            Console.WriteLine("Overloaded method result: " + (number / 2));
        }
    }
}