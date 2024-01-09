using Microsoft.AspNetCore.Mvc;
using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YearbookBoard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        //private readonly DataContext _context;
        private readonly IEventService _eventManager;


        public EventsController(IEventService eventManager)
        {
            this._eventManager = eventManager;
        }
      
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _eventManager.GetAllEvents();
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _eventManager.GetEventById(id);
            //var events = _._events.Find(e => e.NumClass == id);
            //if (events == null)
            //    return NotFound();
            //return Ok(events);
        }

        // POST api/<EventsController>
        [HttpPost]
        public ActionResult Post([FromBody] Event e)
        {
           return Ok( _eventManager.AddEvent(e));
            //_context.AddOne();
            //_context._events.Add(new Event
            //{
            //    Day = e.Day,
            //    Date = e.Date,
            //    Name = e.Name,
                
            //    EventType = e.EventType,
            //    EventLocation = e.EventLocation,
            //    Note = e.Note
            //}); 
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event e)
        {
            return Ok(_eventManager.PutEvent(id, e));
            //var events = _context._events.Find(e => e.NumClass == id);
            //if (events == null)
            //    return NotFound();
            //events.Day = e.Day;
            //events.Date = e.Date;
            //events.Name = e.Name;
            //events.EventType = e.EventType;
            //events.EventLocation = e.EventLocation;
            //events.Note = e.Note;
            //return Ok(events);
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _eventManager.RemoveEvent(id);
            //var events = _context._events.Find(e => e.NumClass == id);
            //if (events == null)
            //    return NotFound();
            //_context._events.Remove(events);
            //return Ok();
        }
    }
}
