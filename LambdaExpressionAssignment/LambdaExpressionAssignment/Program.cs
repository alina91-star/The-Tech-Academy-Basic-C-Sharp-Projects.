using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees.
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 2, FirstName = "Joe", LastName = "Johnson" },
                new Employee() { Id = 3, FirstName = "Mary", LastName = "Brown" },
                new Employee() { Id = 4, FirstName = "John", LastName = "Davis" },
                new Employee() { Id = 5, FirstName = "Sarah", LastName = "Wilson" },
                new Employee() { Id = 6, FirstName = "Michael", LastName = "Taylor" },
                new Employee() { Id = 7, FirstName = "Emma", LastName = "Moore" },
                new Employee() { Id = 8, FirstName = "James", LastName = "Anderson" },
                new Employee() { Id = 9, FirstName = "Olivia", LastName = "Thomas" },
                new Employee() { Id = 10, FirstName = "Daniel", LastName = "Jackson" }
            };

            // Create a list for employees named Joe using a foreach loop.
            List<Employee> joeEmployees = new List<Employee>();

            // Loop through all employees.
            foreach (Employee employee in employees)
            {
                // Check if the first name is Joe.
                if (employee.FirstName == "Joe")
                {
                    // Add employee to the Joe list.
                    joeEmployees.Add(employee);
                }
            }

            // Display employees named Joe.
            Console.WriteLine("Employees named Joe (foreach):");

            foreach (Employee employee in joeEmployees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            // Create a list of employees named Joe using a lambda expression.
            List<Employee> joeLambda =
                employees.Where(x => x.FirstName == "Joe").ToList();

            // Display employees found with lambda.
            Console.WriteLine("\nEmployees named Joe (lambda):");

            foreach (Employee employee in joeLambda)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            // Create a list of employees with ID greater than 5.
            List<Employee> idGreaterThanFive =
                employees.Where(x => x.Id > 5).ToList();

            // Display employees with ID greater than 5.
            Console.WriteLine("\nEmployees with ID greater than 5:");

            foreach (Employee employee in idGreaterThanFive)
            {
                Console.WriteLine(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
            }

            // Keep console open.
            Console.ReadLine();
        }
    }
}