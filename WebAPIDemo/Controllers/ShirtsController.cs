using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WebAPIDemo.Filters;
using WebAPIDemo.Models;
using WebAPIDemo.Models.Repositories;


namespace WebAPIDemo.Controllers
{
    [ApiController]                                 // api controller attribute to decorate the controller class
    [Route("api/[controller]")]                     // base url route template instead of typing it above every method
    public class ShirtsController : ControllerBase
    {

        [HttpGet]                                   // HTTP request
        public IActionResult GetShirts()            //Action Method
        {
            return Ok("Reading all the shirts");
        }

        [HttpGet("{id}")]                                               // parameters are provided through the verb Http
        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtById(int id)                              // You can specify where the data comes from using 
        {
            return Ok(ShirtRepository.GetShirtById(id));
        }

        [HttpPost]
        public IActionResult CreateShirt([FromBody]Shirt shirt)                // You can specify where more complex data comes from using 
        {                                                                  //  Body => form-date => [FromForm],      Body => raw (type = JSON) => [FromBody]
            return Ok("Creating a new shirt");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShirt(int id)
        {
            return Ok("Updating a shirt: {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok("Deleting a shirt with the ID: {id}");
        }
    }
}
