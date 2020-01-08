using EmployeeApplication.Models.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace EmployeeApplication.DataAccess
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        //public IMemoryCache _cache;
        //public void GetValues()
        //{
        //    _cache.Get<string>("key1");
        //}
        //public void SetValues()
        //{
        //    _cache.Set("key1", "Value of Key1");
        //}

    }

    
}
