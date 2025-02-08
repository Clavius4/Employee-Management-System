// UI/EmployeeForm.cs
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using System;
using System.Linq;

namespace EmployeeManagementSystem.UI
{
    public class EmployeeForm
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeForm(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Employee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
        }

        public void AddEmployee()
        {
            Console.Write("Enter Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Position: ");
            var position = Console.ReadLine();
            Console.Write("Enter Department: ");
            var department = Console.ReadLine();

            _employeeService.AddEmployee(name, position, department);
            Console.WriteLine("Employee Added Successfully!");
        }

        public void ViewEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            if (employees.Any())
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}, Department: {employee.Department}");
                }
            }
            else
            {
                Console.WriteLine("No employees found.");
            }
        }

        public void UpdateEmployee()
        {
            Console.Write("Enter Employee ID to update: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Enter new Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter new Position: ");
            var position = Console.ReadLine();
            Console.Write("Enter new Department: ");
            var department = Console.ReadLine();

            _employeeService.UpdateEmployee(id, name, position, department);
            Console.WriteLine("Employee Updated Successfully!");
        }

        public void DeleteEmployee()
        {
            Console.Write("Enter Employee ID to delete: ");
            var id = int.Parse(Console.ReadLine());

            _employeeService.DeleteEmployee(id);
            Console.WriteLine("Employee Deleted Successfully!");
        }
    }
}
