using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiaStore_BackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiaStore_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        // GET: api/ToDo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ToDo/5
        [HttpGet("{id}", Name = "Get")]
        public ToDo Get(int id)
        {
            return new ToDo() { Id = 5, Name = "GET", IsComplete = true };
        }

        // POST: api/ToDo
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ToDo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
