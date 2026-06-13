using System;

namespace PolymorphismAssignment
{
    // This abstract class represents a person.
    public abstract class Person
    {
        // Property to store the first name.
        public string FirstName { get; set; }

        // Property to store the last name.
        public string LastName { get; set; }

        // Abstract method that must be implemented by derived classes.
        public abstract void SayName();
    }
}