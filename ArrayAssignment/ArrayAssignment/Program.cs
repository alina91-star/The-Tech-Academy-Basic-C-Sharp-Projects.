using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Orange", "Grape", "Peach" };

            // Ask the user to select an index for the string array
            Console.WriteLine("Select an index for the string array (0-4):");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index exists in the array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected index
                Console.WriteLine("You selected: " + stringArray[stringIndex]);
            }
            else
            {
                // Display an error message if the index does not exist
                Console.WriteLine("That index does not exist.");
            }

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index for the integer array
            Console.WriteLine("Select an index for the integer array (0-4):");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index exists in the array
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at the selected index
                Console.WriteLine("You selected: " + intArray[intIndex]);
            }
            else
            {
                // Display an error message if the index does not exist
                Console.WriteLine("That index does not exist.");
            }

            // Create a list of strings
            List<string> stringList = new List<string>()
            {
                "Dog",
                "Cat",
                "Rabbit",
                "Hamster",
                "Parrot"
            };

            // Ask the user to select an index for the list
            Console.WriteLine("Select an index for the string list (0-4):");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index exists in the list
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the item at the selected index
                Console.WriteLine("You selected: " + stringList[listIndex]);
            }
            else
            {
                // Display an error message if the index does not exist
                Console.WriteLine("That index does not exist.");
            }

            // Keep the console window open
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}