using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Logic
{
    public interface IEmployeesRepository
    {
       void AddEmployee(string name, string position, string department);
       List<Employee> GetAllEmployees();
       void UpdateEmployee(int id, string name, string position, string department);
       void DeleteEmployee(int id);
       
    }
}
