using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object.
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };

            // Call the inherited SayName method.
            employee.SayName();

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}