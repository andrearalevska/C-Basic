
using EmployeeAppDomain.Enums;

namespace EmployeeAppDomain.Models
{
    public class CEO : Employee
    {
        public List<Employee> Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public CEO (string firstName, string lastName, Role role, double salary, List<Employee> employees, int shares) : base(firstName, lastName, role, salary)
        {
            Employees = employees;
            Shares = shares;
        }

        public double AddSharesPrice(double price) 
        {
            return _sharesPrice = price;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("List of employees in the company:");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary += Shares * _sharesPrice;
        }
    }
}
