using System;

namespace OperatorsAssignment
{
    // This class represents an employee.
    public class Employee
    {
        // Property to store the employee ID.
        public int Id { get; set; }

        // Property to store the employee first name.
        public string FirstName { get; set; }

        // Property to store the employee last name.
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by Id.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        // Overload the != operator because comparison operators must be overloaded in pairs.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

        // Override Equals method.
        public override bool Equals(object obj)
        {
            Employee employee = obj as Employee;

            if (employee == null)
            {
                return false;
            }

            return this.Id == employee.Id;
        }

        // Override GetHashCode method.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}