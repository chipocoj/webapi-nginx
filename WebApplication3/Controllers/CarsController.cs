using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly MockCarRepo _repository = new MockCarRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            var carItems = _repository.GetAllCars();

            return Ok(carItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            var carItem = _repository.GetCarById(id);

            return Ok(carItem);
        }
    }
}

