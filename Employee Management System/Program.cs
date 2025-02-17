namespace Employee_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID: ");
            string EmployeeId = Console.ReadLine();
            Console.WriteLine("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Middle Name: ");
            string MiddleName = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            while (!double.TryParse(Console.ReadLine(), out double Salary))
            {
                return;
            }

            HRDepartment HRD = new HRDepartment();
            ITDepartment ITD = new ITDepartment();


        }
    }
}
