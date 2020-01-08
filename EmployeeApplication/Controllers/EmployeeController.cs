using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApplication.Models.Employee;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index(int id)
        {
            //if (id != 0)
            //    return (_employeeRepository.GetEmployee(id).Name);
            //else
            //    return "No Relevant records found";


            Employee emp = _employeeRepository.GetEmployee(id);
            //return View("EmployeeDetails", emp );

            ViewData["empl"] = emp;
            ViewBag.empdetailsTitle = "Employee Details New Page";
            return View("EmployeeDetails",emp);
        }

        //public ViewResult GetEmployee(int id)
        //{
        //    //if (id != 0)
        //    //    return View("Employ_employeeRepository.GetEmployee(id).Name);
        //    //else
        //    //    return "No Relevant records found";
        //}

        public ViewResult ListEmployees()
        {
            var model = _employeeRepository.ListEmployees();
            return View(model);
        }
    }
}