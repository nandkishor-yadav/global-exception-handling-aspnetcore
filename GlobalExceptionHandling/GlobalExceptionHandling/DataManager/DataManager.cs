using GlobalExceptionHandling.Models;
using System;
using System.Collections.Generic;

namespace GlobalExceptionHandling.DataManager
{
    public class DataManager
    {
        public static List<City> GetCities()
        {
            return new List<City>
            {
                new City {Id = Guid.NewGuid(), Name = "Dublin"},
                new City {Id = Guid.NewGuid(), Name = "Limeric"},
                new City {Id = Guid.NewGuid(), Name = "Cork"},
                new City {Id = Guid.NewGuid(), Name = "Galway"}
            };
        }

    }
}
