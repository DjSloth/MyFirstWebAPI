using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        // GET api/values
        [HttpGet]
        [Produces(typeof(Todo))]
        public IEnumerable<Todo> Get()
        {
            return new List<Todo>() { new Todo() { Id = 1, Caption = "Some todo title", Note = "do something" }, new Todo() { Id = 2, Caption = "Some todo title 2", Note = "do something" } };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(Todo))]
        public Todo Get(int id)
        {
            return new Todo() { Id = id, Caption = $"Some todo title {id}", Note = "do something" };
        }

        // POST api/values
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json", Type = typeof(Todo))]
        public IActionResult Post([FromBody]Todo value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            return CreatedAtAction("Get", new { id = value.Id }, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
