using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object.
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith"
            };

            // Create the second Employee object.
            Employee employee2 = new Employee()
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe"
            };

            // Compare the Employee objects using the overloaded == operator.
            Console.WriteLine(employee1 == employee2);

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}