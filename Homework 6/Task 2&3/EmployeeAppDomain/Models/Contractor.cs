using EmployeeAppDomain.Enums;

namespace EmployeeAppDomain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor (string firstName, string lastName, Role role, double workHours, int payPerHour, Manager responsible) : base(firstName, lastName, role, workHours*payPerHour)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            return Salary = WorkHours* PayPerHour;
        }

        public void CurrentPosition()
        {
            Console.WriteLine($"Responsible for contractor {FirstName} {LastName} is Manager {Responsible.FirstName} {Responsible.LastName}.");
        }
    }
}
