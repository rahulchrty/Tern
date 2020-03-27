using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tern.Domain;

namespace Tern.Data
{
    public class TernContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<List> Lists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; database = TernDb; trusted_Connection = True;");
        }
        
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List>().HasMany(x => x.Tasks).WithOne(x => x.List);
        }
    }
}
