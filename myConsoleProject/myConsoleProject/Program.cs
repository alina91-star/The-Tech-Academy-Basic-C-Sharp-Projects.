using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print school name
            Console.WriteLine("Academy of Learning Career College");

            // Print report title
            Console.WriteLine("Student Daily Report");

            // Ask for student name
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            // Ask for course name
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            // Ask for page number
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if help is needed
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask for positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Ask for additional feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Ask for study hours
            Console.WriteLine("How many hours did you study today?");
            double studyHours = Convert.ToDouble(Console.ReadLine());

            // Print closing message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
