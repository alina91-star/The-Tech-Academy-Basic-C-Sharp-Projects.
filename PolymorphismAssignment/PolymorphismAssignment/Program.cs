using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object using polymorphism.
            IQuittable employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the Quit method through the interface.
            employee.Quit();

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}