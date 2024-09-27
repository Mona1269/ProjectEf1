using Microsoft.EntityFrameworkCore;
using ProjectEf1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEf1.DAL.DataBase
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=InStockDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=t");
}
        public DbSet<Employee> Employees { get; set; }
    }
}
