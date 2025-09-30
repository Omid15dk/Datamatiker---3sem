using Microsoft.AspNetCore.Mvc;
using CarsAPI.Model;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace CarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // GET: api/<CarController>
        [HttpGet]
        public IActionResult Get(
            [FromQuery] string? name = "%",
            [FromQuery] string? model = "%",
            [FromQuery] string? year = "%",
            [FromQuery] string? color = "%")
        {
            var cars = new Car().GetByFilter(
                name == "%" ? null : name,
                model == "%" ? null : model,
                year == "%" ? null : year,
                color == "%" ? null : color
            );
            return Ok(cars);
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new Car().Get(id).ToString());
        }

        // POST api/<CarController>
        [HttpPost]
        public IActionResult Post(string name, string model, string year, string color)
        {
            var car = new Car();
            car.Name = name;
            car.Model = model;
            car.Year = year;
            car.Color = color;
            return Ok(car.Create(car));
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
