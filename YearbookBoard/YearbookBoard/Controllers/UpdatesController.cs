using Microsoft.AspNetCore.Mvc;
using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YearbookBoard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdatesController : ControllerBase
    {
        private readonly IUpdatesServices _updatesServices;

        
        public UpdatesController(IUpdatesServices updatesServices)
        {
            _updatesServices=updatesServices;
        }
        // GET: api/<UpdatesController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_updatesServices.GetAllUpdates());
        }

        // GET api/<UpdatesController>/5
        [HttpGet("{id}")]
        public Updates Get(int id)
        {
            return _updatesServices.GetUpdetes(id);
            //var update = _context._updates.Find(u => u.Name == name);
            //if (update == null)
            //    return NotFound();
            //return Ok(update);
        }

        // POST api/<UpdatesController>
        [HttpPost]
        public ActionResult Post([FromBody] Updates u )
        {

            return Ok( _updatesServices.AddUpdetes(u));
        }

        // PUT api/<UpdatesController>/5
        [HttpPut("{id}")]
         public ActionResult Put(int id, [FromBody] Updates u)
        {
            return Ok( _updatesServices.PutUpdetes(id, u));
            // var update = _context._updates.Find(u => u.Name == name);
            //if (update == null)
            //    return NotFound();
            //update.Name = u.Name;
            //update.Detail = u.Detail;
            //update.UpdateLevel = u.UpdateLevel;
            
            //return Ok(update);
        }

        // DELETE api/<UpdatesController>/5
        [HttpDelete("{id}")]
         public void Delete(int id)
        {
            _updatesServices.RemoveUpdetes(id);
            //var update = _context._updates.First(u => u.Id == id);
            //if (update == null)
            //    return NotFound();
            //_context._updates.Remove(update);
            //return Ok();
        }
    }
}
