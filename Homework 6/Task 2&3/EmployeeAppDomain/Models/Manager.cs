using EmployeeAppDomain.Enums;

namespace EmployeeAppDomain.Models
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        public Manager (string firstName, string lastName, Role role, double salary) : base(firstName, lastName, role, salary) 
        {
            _bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
