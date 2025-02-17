using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class ITDepartment : Department
    {
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("Manages technical resources and infrastructure.");
        }

    }
}
