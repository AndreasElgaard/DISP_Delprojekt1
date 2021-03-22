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

        public DbSet<Haandvaerker> Haandværkere { get; set; }
        public DbSet<Vaerktoej> Vaerktøjer { get; set; }
        public DbSet<Vaerktoejskasse> Vaerktoejskasser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         

            modelBuilder.Entity<Haandvaerker>()
                .Property(p => p.HaandvaerkerId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Vaerktoejskasse>()
                .Property(p => p.VTKId)
                .ValueGeneratedOnAdd(); ;

            modelBuilder.Entity<Vaerktoej>()
                .Property(p => p.VTId)
                .ValueGeneratedOnAdd();

        }
    }
}
