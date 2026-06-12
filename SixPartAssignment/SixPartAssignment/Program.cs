using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PART 1 - One-dimensional array of strings

            // Create an array of strings
            string[] animals = { "Dog", "Cat", "Rabbit", "Hamster", "Horse" };

            // Ask the user to enter some text
            Console.WriteLine("PART 1");
            Console.WriteLine("Enter some text:");
            string userText = Console.ReadLine();

            // Add the user's text to each array element
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i] + " " + userText;
            }

            // Display the updated array
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }


            // PART 2 - Infinite loop fixed

            // This loop was originally infinite.
            // It is fixed by incrementing the counter.
            int count = 0;

            while (count < 5)
            {
                Console.WriteLine("Loop count: " + count);
                count++;
            }


            // PART 3 - Loops using < and <= operators

            // Loop using the < operator
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Less than loop: " + i);
            }

            // Loop using the <= operator
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Less than or equal loop: " + i);
            }


            // PART 4 - Search a list of unique strings

            // Create a list of unique strings
            List<string> colors = new List<string>()
            {
                "Red",
                "Blue",
                "Green",
                "Yellow",
                "Purple"
            };

            // Ask the user to search for a color
            Console.WriteLine("\nPART 4");
            Console.WriteLine("Enter a color to search for:");
            string colorSearch = Console.ReadLine();

            bool colorFound = false;

            // Search the list
            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i].Equals(colorSearch, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Found at index: " + i);
                    colorFound = true;
                    break;
                }
            }

            // Display message if item not found
            if (!colorFound)
            {
                Console.WriteLine("That item is not on the list.");
            }


            // PART 5 - Find duplicate values

            // Create a list containing duplicate strings
            List<string> fruits = new List<string>()
            {
                "Apple",
                "Banana",
                "Orange",
                "Apple",
                "Pear",
                "Banana"
            };

            // Ask the user to search for a fruit
            Console.WriteLine("\nPART 5");
            Console.WriteLine("Enter a fruit to search for:");
            string fruitSearch = Console.ReadLine();

            bool fruitFound = false;

            // Display every matching index
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Equals(fruitSearch, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Match found at index: " + i);
                    fruitFound = true;
                }
            }

            // Display message if item not found
            if (!fruitFound)
            {
                Console.WriteLine("That item is not on the list.");
            }


            // PART 6 - Detect duplicate items

            // Create a list with duplicate strings
            List<string> letters = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "C",
                "B"
            };

            // Create a list to store already seen items
            List<string> seenLetters = new List<string>();

            Console.WriteLine("\nPART 6");

            // Check each item in the list
            foreach (string letter in letters)
            {
                if (seenLetters.Contains(letter))
                {
                    Console.WriteLine(letter + " - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine(letter + " - this item is unique");
                    seenLetters.Add(letter);
                }
            }

            // Keep the console window open
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}