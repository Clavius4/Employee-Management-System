﻿// Program.cs
using EmployeeManagementSystem.Logic;
using EmployeeManagementSystem.UI;
using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //The main program is what consumes the repository
            var employeesRepository = new EmployeesRepository();
            var employeeForm = new EmployeeForm(employeesRepository);

            while (true)
            {
                employeeForm.ShowMenu();
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        employeeForm.AddEmployee();
                        break;
                    case "2":
                        employeeForm.ViewEmployees();
                        break;
                    case "3":
                        employeeForm.UpdateEmployee();
                        break;
                    case "4":
                        employeeForm.DeleteEmployee();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option! Try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
