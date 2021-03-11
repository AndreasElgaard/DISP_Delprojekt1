using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.DataBaseContext

{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=Andreas-Laptop;Initial Catalog=DISP_Delprojekt1;Integrated Security=True");
        //}

        public DbSet<Haandvaerker> Haandværkere { get; set; }
        public DbSet<Vaerktoej> Vaerktøjer { get; set; }
        public DbSet<Vaerktoejskasse> Vaerktoejskasser { get; set; }
    }
}
