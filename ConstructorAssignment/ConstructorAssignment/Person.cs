using System;

namespace ConstructorAssignment
{
    // This class demonstrates constructor chaining.
    public class Person
    {
        // Property to store the person's name.
        public string Name { get; set; }

        // Property to store the person's age.
        public int Age { get; set; }

        // Default constructor.
        public Person() : this("Unknown", 0)
        {
        }

        // Constructor with one parameter.
        public Person(string name) : this(name, 0)
        {
        }

        // Main constructor.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}