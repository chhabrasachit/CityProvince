using System.Collections.Generic;

namespace CityProvinceLab.Models
{
    public class City
    {
        public int CityId{ get; set; }
        
        public string CityName{ get; set; }
        
        public int Population{ get; set; }

        //foreign key
        public string ProvinceName{ get; set; }
        public Province Province{ get; set; }

        public static List<City> GetCities () {
            List<City> cities = new List<City> () {
            new City {
            CityId = 1,
            CityName = "Abbotsford",
            Population = 500000,
            ProvinceName = "British Columbia",
            },
            new City {
            CityId = 2,
            CityName = "Calgary",
            Population = 1500000,
            ProvinceName = "Alberta",
            },
            new City {
            CityId = 3,
            CityName = "Hamilton",
            Population = 1000000,
            ProvinceName = "Ontario",
            },
        };

        return cities;
        }

    }
}