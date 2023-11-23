using BakerySql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BakerySql.DataContext
{
    public class BakeryDbContext : DbContext
    {
        public DbSet<Employee> EMPLOYEE { get; set; } = null!;
        public DbSet<Post> POST { get; set; } = null!;
        public DbSet<WORKING_SHIFT> WORKING_SHIFT { get; set; } = null!;
        public DbSet<STORE> STORE { get; set; } = null!;
        public DbSet<UNITS> UNITS { get; set; } = null!;
        public DbSet<EQUIPMENT> EQUIPMENT { get; set; } = null!;
        public DbSet<RECIPE> RECIPE { get; set; } = null!;
        public DbSet<SHELF> SHELF { get; set; } = null!;
        public DbSet<COOKING_PRODUCT> COOKING_PRODUCT { get; set; } = null!;
        public DbSet<INGRIDIENTSINRESIPE> INGRIDIENTSINRESIPE { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\Local;Database=Bakery;Integrated Security=True;");

        }
    }
}
