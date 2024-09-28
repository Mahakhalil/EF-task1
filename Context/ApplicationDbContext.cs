using Createproduct.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Createproduct.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EF_Task;Trusted_connection=True;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
