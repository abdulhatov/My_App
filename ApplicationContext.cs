using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace UsersApp
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = test.db");
            optionsBuilder.LogTo(Console.WriteLine);
           
        }
    }
}
