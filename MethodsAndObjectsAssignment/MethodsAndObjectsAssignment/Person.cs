using System;

namespace MethodsAndObjectsAssignment
{
    // This class represents a person.
    public class Person
    {
        // Property to store the first name.
        public string FirstName { get; set; }

        // Property to store the last name.
        public string LastName { get; set; }

        // This method displays the person's full name.
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}