// BusinessLogic/IEmployeeService.cs
using EmployeeManagementSystem.Models;
using System.Collections.Generic;

namespace EmployeeManagementSystem.BusinessLogic
{
    public interface IEmployeeService
    {
        void AddEmployee(string name, string position, string department);
        List<Employee> GetAllEmployees();
        void UpdateEmployee(int id, string name, string position, string department);
        void DeleteEmployee(int id);
    }
}
