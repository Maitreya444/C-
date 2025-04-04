using System;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.Domain;

namespace EntityFrameworkCore.Data
{
    public class FootballDBContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
