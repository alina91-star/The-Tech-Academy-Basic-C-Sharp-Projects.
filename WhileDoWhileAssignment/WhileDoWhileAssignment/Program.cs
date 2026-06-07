using System;

namespace WhileDoWhileAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a boolean variable for the while loop
            bool isTrue = true;

            // Create an integer counter
            int count = 0;

            // While loop runs as long as isTrue is true
            while (isTrue)
            {
                // Display the current count value
                Console.WriteLine("While Loop Count: " + count);

                // Increase count by 1
                count++;

                // When count reaches 5, change isTrue to false
                if (count == 5)
                {
                    isTrue = false;
                }
            }

            // Create a boolean variable for the do while loop
            bool isFalse = false;

            // Create another counter variable
            int number = 0;

            // Do block executes at least once
            do
            {
                // Display the current number value
                Console.WriteLine("Do While Loop Count: " + number);

                // Increase number by 1
                number++;

                // When number reaches 5, change isFalse to true
                if (number == 5)
                {
                    isFalse = true;
                }

            } while (!isFalse);

            // Pause the console window
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}