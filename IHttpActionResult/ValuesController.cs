using _2509.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace _2509.Controllers
{
    public class ValuesController : ApiController
    {
        // just for demo
        private static List<Food> foods = new List<Food>();
        static ValuesController()
        {
            foods.Add(new Food() { Id = 1, Name = "Chips" });
            foods.Add(new Food() { Id = 2, Name = "Burger" });
            foods.Add(new Food() { Id = 3, Name = "Pizza" });
        }

        /// <summary>
        /// Get all food items - GET main route
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [ResponseType(typeof(Food))]
        [HttpGet]
        public IHttpActionResult Get()
        {
            if (foods.Count == 0)
            {
                return NotFound();
            }
            return Ok(foods);
        }

        [ResponseType(typeof(void))]
        [HttpPut]
        public IHttpActionResult PutFood(int id, [FromBody] Food food)
        {
            if (food.Id == 0)
            {
                return BadRequest(ModelState);
            }

            if (foods.FirstOrDefault(f => f.Id == id) == null)
            {
                return NotFound();
            }
            else
            {
                // update
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Foods
        [ResponseType(typeof(Food))]
        public IHttpActionResult PostFood([FromBody] Food food)
        {
            // after POST return the URL of the 
            //  use - return CreatedAtRoute( ... );

        }
    }
}
