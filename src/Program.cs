using Acme.AOP.Demo.Services.Employees;

namespace Acme.AOP.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeService employeeService = new EmployeeService();

            employeeService = EmployeeServiceDispatch<IEmployeeService>.Create(employeeService);

            employeeService.AddEmployee();
            employeeService.ModifyEmployee();
            employeeService.RemoveEmployee();
        }
    }
}