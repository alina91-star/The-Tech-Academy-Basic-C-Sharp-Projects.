using System;

namespace PolymorphismAssignment
{
    // Employee inherits from Person and implements IQuittable.
    public class Employee : Person, IQuittable
    {
        // This method implements the abstract SayName method.
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // This method implements the Quit method from the interface.
        public void Quit()
        {
            Console.WriteLine("Employee has quit.");
        }
    }
}