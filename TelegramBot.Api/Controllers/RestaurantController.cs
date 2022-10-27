using Microsoft.AspNetCore.Mvc;
using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Common.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TelegramBot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        // GET: api/<RestaurantController>
        [HttpGet]
        public IActionResult Get()
        {
             return Ok(_restaurantService.GetRestaurants());
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_restaurantService.Get(id));
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public IActionResult Post([FromBody] RestaurantViewModel model)
        {
            _restaurantService.Create(model);
            return  Ok();
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, RestaurantViewModel model)
        {
            _restaurantService.Edit(id, model);
            return Ok();
        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _restaurantService.Delete(id);
            return Ok();
        }
    }
}
