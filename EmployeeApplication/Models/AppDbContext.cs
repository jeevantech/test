using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base()
        {   

        }
        
        public DbSet<EmployeeApplication.Models.Employee.Employee> Employees { get; set; }
        
    }
}
