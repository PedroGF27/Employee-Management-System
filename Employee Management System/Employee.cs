using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Employee
    {
        
            private string _employeeId = "003A";
            private string _firstName;
            private string _middleName;
            private string _lastName;
            private double _salary = 0;

            public string EmployeeId
            {
                get { return _employeeId; }
            }

            public string FirstName
            {
                get { return _firstName; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Please Enter a Name.");
                    }
                    _firstName = value;
                }
            }

            public string MiddleName
            {
                get { return _middleName; }
                set { _middleName = value; }
            }

            public string LastName
            {
                get { return _lastName; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Please enter a name.");
                    }
                    _lastName = value;
                }
            }

            public double Salary
            {
                get { return _salary; }
                set
                {
                    if (_salary <= 0)
                    {
                        throw new ArgumentException("Please enter a valid number.");
                    }
                }
            }

            public Employee(string FirstName, string MiddleName, string LastName, double Salary)
            {
                _firstName = FirstName;
                _middleName = MiddleName;
                _lastName = LastName;
                _salary = Salary;
            }

            public void PrintFullName()
            {
                Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
            }

            public void DisplayEmployeeInfo()
            {

                Console.WriteLine($"");
            }
        
    }
}
