
using System;
using System.Collections.Generic;
using System.Linq;
using FlightSystem.Data;
using FlightSystem.Data.Migrations;
using FlightSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ValuesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
      
        [HttpGet("{id}")]
        public ActionResult<Flight> Get(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var flight = _context.Flights.FirstOrDefault(z => z.FlightId == id.Value);

            if (flight == null)
            {
                return NotFound();
            }

            return Ok(flight);
        }


        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        
        //[HttpGet("{id}")]
        //public async Task<ActionResult> GetFlightById(int id)
        //{
        //    // Belirli bir uçuşu getiren bir LINQ sorgusu
        //    var flight = await _context.Flights.FindAsync(id);

        //    if (flight == null)
        //    {
        //        return NotFound();
        //    }

        //    return RedirectToAction("Index","Values");
        //}

    }
}

