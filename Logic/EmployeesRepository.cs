using EmployeeManagementSystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Logic
{
    public class EmployeesRepository
    {
        private readonly EmployeeService employeeService;

        public EmployeesRepository()
        {
            employeeService = new EmployeeService();
        }




    }
}
