using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week:");

            try
            {
                // Read the user's input.
                string userInput = Console.ReadLine();

                // Parse the input into the DaysOfWeek enum.
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput);

                // Display the selected day.
                Console.WriteLine("Today is " + currentDay);
            }
            catch
            {
                // Display an error message if parsing fails.
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}