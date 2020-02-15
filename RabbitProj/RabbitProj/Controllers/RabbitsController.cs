using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitProj.Models;

namespace RabbitProj.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RabbitsController : ControllerBase
    {
        // GET: Rabbits
        [HttpGet]
        public IEnumerable<Rabbit> Get()
        {
            Rabbit rabbit1 = new Rabbit("Gica", 2, Rabbit.FurColors.Brown, Rabbit.EyeColors.Black, Rabbit.Genders.Female);

            Rabbit rabbit2 = new Rabbit("Gigi", 4, Rabbit.FurColors.Grey, Rabbit.EyeColors.Blue, Rabbit.Genders.Male);

            List<Rabbit> rabbits = new List<Rabbit>();
            rabbits.Add(rabbit1);
            rabbits.Add(rabbit2);
            return rabbits;
        }

        // GET: Rabbits/5
        [HttpGet("{id}", Name = "Get")]
        public Rabbit Get(int id)
        {
            Rabbit rabbit1 = new Rabbit("Gica", 2, Rabbit.FurColors.Brown, Rabbit.EyeColors.Black, Rabbit.Genders.Female);

            Rabbit rabbit2 = new Rabbit("Gigi", 4, Rabbit.FurColors.Grey, Rabbit.EyeColors.Blue, Rabbit.Genders.Male);

            List<Rabbit> rabbits = new List<Rabbit>();
            rabbits.Add(rabbit1);
            rabbits.Add(rabbit2);

            foreach (var rabbit in rabbits)
            {
                if (rabbit.Id == id)
                {
                    return rabbit;
                }
            }
            return rabbit1; //UNFINISHED (trebuie sa retuneze NotFound() )
        }

        // POST: Rabbits
        [HttpPost]
        public IActionResult Post([FromBody] Rabbit model)
        {
            if (ModelState.IsValid)
            {
                //save in database
                return Ok();
            }

            return BadRequest();
        }

        // PUT: Rabbits/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
