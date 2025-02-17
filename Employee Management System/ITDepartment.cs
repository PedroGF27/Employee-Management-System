using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class ITDepartment : Department, IDepartmentOperations
    {

        public override void GetDepartmentDetails()
        {
            Console.WriteLine("Department: IT");
            Console.WriteLine("Details: Manages technical resources and infrastructure.");
        }

        public void Operate()
        {
            Console.WriteLine("It Department Functioning.");
        }

    }
}
