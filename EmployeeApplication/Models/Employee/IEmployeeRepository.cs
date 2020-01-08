using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models.Employee
{
    public interface IEmployeeRepository
    {
        List<Employee> ListEmployees();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee employee);

    }
}
