using System;

namespace Acme.AOP.Demo.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        public void AddEmployee()
        {
            System.Console.WriteLine("Add Employee");
        }

        public void RemoveEmployee()
        {
            System.Console.WriteLine("Remove Employee");
        }

        public void ModifyEmployee()
        {
            System.Console.WriteLine("Modify Employee");
        }
    }
}
