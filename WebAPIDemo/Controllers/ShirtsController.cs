using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WebAPIDemo.Models;


namespace WebAPIDemo.Controllers
{
    [ApiController]                 // api controller attribute
    [Route("api/[controller]")]     // base url route template instead of tryping it above every method
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        [HttpGet("{id}")]           // parameters are provided through the verb Http
        public string GetShirtById(int id)           // You can specify where the data comes from
        {
            return $"Reading shirt with id: {id}";
        }

        [HttpPost]
        public string CreateShirt([FromForm]Shirt shirt)
        {
            return $"Creating a new shirt";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating a shirt: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting a shirt with the ID: {id}";
        }
    }
}
