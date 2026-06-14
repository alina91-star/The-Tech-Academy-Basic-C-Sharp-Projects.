using System;

namespace ConstructorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a constant variable.
            const string assignmentName = "Constructor Assignment";

            // Display the constant variable.
            Console.WriteLine(assignmentName);

            // Ask the user to enter a name.
            Console.WriteLine("Please enter your name:");

            // Create a variable using the var keyword.
            var userName = Console.ReadLine();

            // Create a Person object using the constructor with one parameter.
            Person person = new Person(userName);

            // Display the person's information.
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}