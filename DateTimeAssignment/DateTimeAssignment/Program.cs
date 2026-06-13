using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the current date and time.
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // Ask the user to enter a number.
            Console.WriteLine("Please enter a number:");

            // Store the user's input and convert it to an integer.
            int hours = Convert.ToInt32(Console.ReadLine());

            // Add the specified number of hours to the current time.
            DateTime futureTime = DateTime.Now.AddHours(hours);

            // Display the future date and time.
            Console.WriteLine("In " + hours + " hours it will be: " + futureTime);

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}