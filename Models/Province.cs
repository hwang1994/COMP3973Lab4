﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }

        public List<City> Cities { get; set; }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province> {
                new Province () {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta",
                },
                new Province () {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                },
                new Province () {
                    ProvinceCode = "QC",
                    ProvinceName = "Quebec",
                },
            };
            return provinces;
        }
    }
}
