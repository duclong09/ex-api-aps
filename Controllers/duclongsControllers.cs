using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class duclongsControllers : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all the duclongs"); 
        }

       

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading all the duclongs #{id}. ");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Create all the duclongs");
        }

        [HttpPut]
        
        public IActionResult Put()
        {
            return Ok("Updating duclongs");
        }


        [HttpDelete("{id}")]
      
        public IActionResult Delete(int id)
        {
            return Ok($"Updating duclongs #{id}");
        }
    }
}
