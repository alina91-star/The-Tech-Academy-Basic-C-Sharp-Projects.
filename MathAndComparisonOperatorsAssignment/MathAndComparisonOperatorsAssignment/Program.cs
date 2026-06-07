using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Person 1 information
            Console.WriteLine("Person 1");

            // Ask for hourly rate
            Console.WriteLine("Hourly Rate?");
            decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());

            // Ask for hours worked per week
            Console.WriteLine("Hours worked per week?");
            decimal person1HoursWorked = Convert.ToDecimal(Console.ReadLine());

            // Person 2 information
            Console.WriteLine("Person 2");

            // Ask for hourly rate
            Console.WriteLine("Hourly Rate?");
            decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());

            // Ask for hours worked per week
            Console.WriteLine("Hours worked per week?");
            decimal person2HoursWorked = Convert.ToDecimal(Console.ReadLine());

            // Calculate annual salaries
            decimal person1AnnualSalary = person1HourlyRate * person1HoursWorked * 52;
            decimal person2AnnualSalary = person2HourlyRate * person2HoursWorked * 52;

            // Print annual salary of Person 1
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(person1AnnualSalary);

            // Print annual salary of Person 2
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(person2AnnualSalary);

            // Compare salaries
            bool person1MakesMoreMoney = person1AnnualSalary > person2AnnualSalary;

            // Print comparison result
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(person1MakesMoreMoney);

            Console.ReadLine();
        }
    }
}
