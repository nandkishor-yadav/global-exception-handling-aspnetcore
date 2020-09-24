using System;
using Microsoft.AspNetCore.Mvc;

namespace GlobalExceptionHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cities : ControllerBase
    {

        // GET: api/<Cities>
        [HttpGet]
        public IActionResult Get()
        {

            var cities = DataManager.DataManager.GetCities();

            throw new Exception("Exception while fetching list of cities.");

            return Ok(cities);
        }
    }
}
