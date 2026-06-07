using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the applicant's age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the applicant has ever had a DUI
            Console.WriteLine("Have you ever had a DUI?");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Ask how many speeding tickets the applicant has
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Check if the applicant qualifies for car insurance
            bool qualified = age > 15 && !hasDUI && speedingTickets <= 3;

            // Print the result
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);

            Console.ReadLine();
        }
    }
}
