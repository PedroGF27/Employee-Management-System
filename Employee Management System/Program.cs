namespace Employee_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID: ");
            string EmployeeId = Console.ReadLine();
            Console.WriteLine("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Middle Name: ");
            string MiddleName = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            if (!double.TryParse(Console.ReadLine(), out double Salary))
            {
                return;
            }

            Employee employeeInfo = new Employee(EmployeeId, FirstName, MiddleName, LastName, Salary);
            employeeInfo.DisplayEmployeeInfo();

            HRDepartment HRD = new HRDepartment();
            ITDepartment ITD = new ITDepartment();

            HRD.DisplayDepartmentInfo();
            HRD.Operate();
            HRD.GetDepartmentDetails();

            ITD.DisplayDepartmentInfo();
            ITD.Operate();
            ITD.GetDepartmentDetails();
        }
    }
}
