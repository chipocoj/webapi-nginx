using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class MockCarRepo : ICarRepoRepo
    {
        public IEnumerable<Car> GetAllCars()
        {
            var cars = new List<Car>
            {
                new Car{Id = 0, VIN = "VIN0THING", Year = 1995, Make = "Tesla", Model = "S"},
                new Car{Id = 1, VIN = "VIN1THING", Year = 1999, Make = "Toyota", Model = "Camry"},
                new Car{Id = 2, VIN = "VIN2THING", Year = 2003, Make = "Honda", Model = "Civic"},
                new Car{Id = 3, VIN = "VIN3THING", Year = 2008, Make = "Chevy", Model = "Equinox"},
                new Car{Id = 4, VIN = "VIN4THING", Year = 2020, Make = "Nissan", Model = "Altima"}
            };

            return cars;
        }

        public Car GetCarById(int id)
        {
            if (id >= 0 && id < 4)
            {
                return new Car { Id = id, VIN = "VIN" + id + "THING", Year = 1995, Make = "Tesla", Model = "S" };
            }
            else
            {
                return new Car { Id = id, VIN = "VIN" + id * 7 + "THING", Year = 2020, Make = "Fiat", Model = "MockType" };
            }
        }
    }
}
