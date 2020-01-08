using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        private readonly AppDbContext context;
        
        public EmployeeRepository(AppDbContext context)
        {
            this.context = context;
            _employeeList = new List<Employee>()
            {
                new Employee() {Id=1, Name="Rajadurai",Age=30, Gender="Male" },
                new Employee() {Id=2, Name="Arun", Age=25, Gender="Female"},
                new Employee() {Id=3, Name="Kumar", Age=40, Gender="Male"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public List<Employee> ListEmployees()
        {
            return _employeeList;
        }
    }
}
