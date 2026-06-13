using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object.
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName method on the Employee object.
            employee.SayName();

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}