using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Full Name")]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public string Gender { get; set; }
        public Department Dept { get; set; }
    }
}
