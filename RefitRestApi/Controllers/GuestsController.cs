using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using RefitRestApi.Models;

namespace RefitRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<Guest> _guests = new()
        {
            new Guest{Id = 1, FirstName = "Zhang", LastName = "San"},
            new Guest{Id = 2, FirstName = "Li", LastName = "Si"},
            new Guest{Id = 3, FirstName = "Wang", LastName = "Wu"},
        };

        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<Guest> Get()
        {
            return _guests;
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public Guest? Get(int id)
        {
            return _guests.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] Guest value)
        {
            _guests.Add(value);
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guest value)
        {
            _guests.Remove(_guests.FirstOrDefault(x => x.Id == id));
            _guests.Add(value);
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _guests.Remove(_guests.FirstOrDefault(x => x.Id == id));
        }
    }
}
