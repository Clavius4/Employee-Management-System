using EmployeeManagementSystem.DataAccess;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Services
{
    /*Implementation of EmployeeService is different now 
     because EmployeeService is what directly interacts
    with the DatabaseContext*/
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _dbContext;
        public EmployeeService()
        {
            _dbContext = new DatabaseContext();
            _dbContext.Database.EnsureCreated();  // Ensure the database is created on first run
        }

        public void AddEmployee(string name, string position, string department)
        {
            var employee = new Employee
            {
                Name = name,
                Position = position,
                Department = department
            };
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
        }     

        public void UpdateEmployee(int id, string name, string position, string department)
        {

            var employee = _dbContext.Employees.ToList().Where(x => x.Id == id);
            //if (employee != null)
            //{
            //    employee.Name = name;
            //    employee.Position = position;
            //    employee.Department = department;
            //    _dbContext.Employees.Update(employee);
            //    _dbContext.SaveChanges();
            //}
        }

        public void DeleteEmployee(int id)
        {
            var employee = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee is not null)
            _dbContext.Employees.Remove(employee);
            _dbContext.SaveChanges();
        }

    }
}
