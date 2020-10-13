using CityProvinceLab.Models;
using Microsoft.EntityFrameworkCore;

namespace CityProvinceLab.Data
{
    public static class DummyData {
  // this is an extension method to the ModelBuilder class
        public static void Seed (this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Province>().HasData (
                Province.GetProvinces ()
            );
            modelBuilder.Entity<City>().HasData (
                City.GetCities ()
            );
        }
}
}