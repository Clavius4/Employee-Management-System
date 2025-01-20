// DataAccess/EmployeeRepository.cs
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.DataAccess
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=employees.db");
        }
    }

    public class EmployeeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository()
        {
            _context = new EmployeeContext();
            _context.Database.EnsureCreated();  // Ensure the database is created on first run
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
