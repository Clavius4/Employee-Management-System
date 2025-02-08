using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Logic
{
    /*The repository is essentially what consumes the service*/
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly EmployeeService employeeService;

        public EmployeesRepository()
        {
            employeeService = new EmployeeService();
        }

        public void AddEmployee(string name, string position, string department)
        {

            employeeService.AddEmployee(name, position, department);
        }

        public void DeleteEmployee(int id)
        {
            employeeService.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeService.GetAllEmployees();
        }

        public void UpdateEmployee(int id, string name, string position, string department)
        {
           employeeService.UpdateEmployee(id, name, position, department);
        }
    }
}
