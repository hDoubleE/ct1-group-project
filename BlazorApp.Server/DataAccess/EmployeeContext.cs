using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Server.DataAccess
{
    public class EmployeeContext : DbContext
    {
        public virtual DbSet<BlazorApp.Shared.Models.Employee> tblEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"INSERT YOUR CONNECTION STRING HERE WITH YOUR CREDENTIALS;");
            }
        }
    }
}