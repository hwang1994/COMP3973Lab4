using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }

        public string ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        public Province Province { get; set; }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City> {
                new City () {
                    CityId = 1,
                    CityName = "Calgary",
                    Population = 1239220,
                    ProvinceCode = "AB",
                },
                new City () {
                    CityId = 2,
                    CityName = "Edmonton",
                    Population = 932546,
                    ProvinceCode = "AB",
                },
                new City () {
                    CityId = 3,
                    CityName = "Red Deer",
                    Population = 100418,
                    ProvinceCode = "AB",
                },
                new City () {
                    CityId = 4,
                    CityName = "Burnaby",
                    Population = 232755,
                    ProvinceCode = "BC",
                },
                new City () {
                    CityId = 5,
                    CityName = "Richmond",
                    Population = 198309,
                    ProvinceCode = "BC",
                },
                new City () {
                    CityId = 6,
                    CityName = "Vancouver",
                    Population = 631486,
                    ProvinceCode = "BC",
                },
                new City () {
                    CityId = 7,
                    CityName = "Montreal",
                    Population = 1704694,
                    ProvinceCode = "QC",
                },
                new City () {
                    CityId = 8,
                    CityName = "Mont-Tremblant",
                    Population = 9646,
                    ProvinceCode = "QC",
                },
                new City () {
                    CityId = 9,
                    CityName = "Saguenay",
                    Population = 145949,
                    ProvinceCode = "QC",
                },
            };
            return cities;
        }
    }
}
