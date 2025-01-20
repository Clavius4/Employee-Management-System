// BusinessLogic/EmployeeService.cs
using EmployeeManagementSystem.DataAccess;
using EmployeeManagementSystem.Models;
using System.Collections.Generic;

namespace EmployeeManagementSystem.BusinessLogic
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public void AddEmployee(string name, string position, string department)
        {
            var employee = new Employee
            {
                Name = name,
                Position = position,
                Department = department
            };
            _employeeRepository.AddEmployee(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public void UpdateEmployee(int id, string name, string position, string department)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            if (employee != null)
            {
                employee.Name = name;
                employee.Position = position;
                employee.Department = department;
                _employeeRepository.UpdateEmployee(employee);
            }
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
        }
    }
}
