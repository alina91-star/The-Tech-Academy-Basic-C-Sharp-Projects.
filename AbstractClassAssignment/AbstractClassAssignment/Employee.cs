using System;

namespace AbstractClassAssignment
{
    // Employee inherits from the abstract Person class.
    public class Employee : Person
    {
        // This method implements the abstract SayName method.
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}