using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class HRDepartment : Department, IDepartmentOperations
    {
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("Handles employee relations and recruitment.");
        }

        public void Operate()
        {
            Console.WriteLine("HR Department is Functioning.");
        }
    }
}
