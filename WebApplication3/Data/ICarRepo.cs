using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public interface ICarRepoRepo
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
    }
}
