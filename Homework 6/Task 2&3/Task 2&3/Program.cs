using EmployeeAppDomain.Enums;
using EmployeeAppDomain.Models;

Employee employee = new Employee("John", "Johnsky", Role.Other, 600);
employee.PrintInfo();
double employeeSalary = employee.GetSalary();
Console.WriteLine($"Calculated salary of {employee.Role} {employee.FirstName} {employee.LastName} is {employeeSalary}.");

Manager manager = new Manager("Bob", "Bobsky", Role.Manager, 1000);
manager.PrintInfo(); 
manager.AddBonus(100);
double managerSalary = manager.GetSalary();
Console.WriteLine($"Calculated salary of {manager.Role} {manager.FirstName} {manager.LastName} is {managerSalary}.");

Manager secondManager = new Manager("Elena", "Simonovska", Role.Manager, 3000);
secondManager.PrintInfo();
secondManager.AddBonus(200);
double secondManagerSalary = secondManager.GetSalary();
Console.WriteLine($"Calculated salary of {secondManager.Role} {secondManager.FirstName} {secondManager.LastName} is {secondManagerSalary}.");
SalesPerson salesPerson = new SalesPerson("Kate", "Katesky", 500);
salesPerson.PrintInfo();
salesPerson.AddSuccessRevenue(2000);
Console.WriteLine($"Calculated salary of {salesPerson.Role} {salesPerson.FirstName} {salesPerson.LastName} is {salesPerson.GetSalary()}.");

Contractor contractor = new Contractor("Petko", "Petkovski", Role.Contractor, 40, 10, manager);
contractor.PrintInfo();
contractor.CurrentPosition();
Console.WriteLine($"Calculated salary of {contractor.Role} {contractor.FirstName} {contractor.LastName} is {contractor.GetSalary()}.");

Contractor secondContractor = new Contractor("Lea", "Leova", Role.Contractor, 40, 30, secondManager);
secondContractor.PrintInfo();
secondContractor.CurrentPosition();
Console.WriteLine($"Calculated salary of {secondContractor.Role} {secondContractor.FirstName} {secondContractor.LastName} is {secondContractor.GetSalary()}.");

List<Employee> Company = new List<Employee>();
Company.Add(manager);
Company.Add(secondManager);
Company.Add(contractor);
Company.Add(secondContractor);
Company.Add(salesPerson);

CEO ceo = new CEO("Ron", "Ronsky", Role.CEO, 5000, Company, 20);
ceo.PrintInfo();
ceo.AddSharesPrice(100);
Console.WriteLine($"Calculated salary of {ceo.Role} {ceo.FirstName} {ceo.LastName} is {ceo.GetSalary()}.");
ceo.PrintEmployees();

