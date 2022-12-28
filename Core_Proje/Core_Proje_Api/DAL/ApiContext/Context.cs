using Core_Proje_Api.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MERVE_KARATAS; database=CorePprojeDB2;integrated security=true");

        }

        public DbSet<Category> Categories { get; set; }
    }
}
