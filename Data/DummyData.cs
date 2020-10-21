using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Data
{
    public static class DummyData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData( //checks if we have any teams and populate it (if not
                Province.GetProvinces()
            );
            modelBuilder.Entity<City>().HasData( //checks if we have any players and populate it (if not)
                City.GetCities()
            );
        }
    }
}
