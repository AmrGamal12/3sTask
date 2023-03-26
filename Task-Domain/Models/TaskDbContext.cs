using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Domain.Models
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Products> Product { get; set; }
        public DbSet<Categorys> Category { get; set; }
        public DbSet<Clients> Client { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-KAHL1GC\\SQLEXPRESS;Database=Test;TrustServerCertificate=True;User Id=sa;Password=123;");
        }

       
        
    }
}
