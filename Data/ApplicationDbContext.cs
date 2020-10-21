using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }

        public DbSet<Province> Provinces { get; set; } //this will tell the database to create 2 tables
        public DbSet<City> Cities { get; set; } //this will tell the database to create 2 tables
    }
}
