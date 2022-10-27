using Microsoft.AspNetCore.Mvc;
using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Common.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TelegramBot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableController : ControllerBase
    {
        private readonly ITimetableService _timetableService;

        public TimetableController(ITimetableService timetableService)
        {
            _timetableService = timetableService;
        }

        // GET: api/<TimetableController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_timetableService.GetAll());
        }

        // GET api/<TimetableController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_timetableService.Get(id));
        }

        // POST api/<TimetableController>
        [HttpPost]
        public IActionResult Post([FromBody] TimetableViewModel model)
        {
            _timetableService.Create(model);
            return Ok();
        }

        // PUT api/<TimetableController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TimetableViewModel model)
        {
            _timetableService.Edit(id, model);
            return Ok();
        }

        // DELETE api/<TimetableController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _timetableService.Delete(id);
            return Ok();
        }
    }
}
