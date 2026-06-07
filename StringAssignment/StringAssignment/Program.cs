using System;
using System.Text;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create three separate string variables
            string firstName = "Alina";
            string middleText = "is learning";
            string lastText = "C# programming.";

            // Concatenate the three strings into one sentence
            string fullSentence = firstName + " " + middleText + " " + lastText;

            // Display the concatenated string
            Console.WriteLine("Concatenated String:");
            Console.WriteLine(fullSentence);

            // Create a string variable
            string message = "this text will be converted to uppercase.";

            // Convert the string to uppercase
            string upperCaseMessage = message.ToUpper();

            // Display the uppercase string
            Console.WriteLine("\nUppercase String:");
            Console.WriteLine(upperCaseMessage);

            // Create a new StringBuilder object
            StringBuilder paragraph = new StringBuilder();

            // Add the first sentence to the paragraph
            paragraph.Append("Learning C# is an exciting journey. ");

            // Add the second sentence to the paragraph
            paragraph.Append("StringBuilder helps improve performance when working with large amounts of text. ");

            // Add the third sentence to the paragraph
            paragraph.Append("Practice and consistency are the keys to success.");

            // Display the completed paragraph
            Console.WriteLine("\nParagraph Created with StringBuilder:");
            Console.WriteLine(paragraph);

            // Keep the console window open
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}