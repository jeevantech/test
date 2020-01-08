using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models.Employee
{
    public class Department
    {
        public int DeptId { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
    }
}
