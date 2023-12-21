using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Repositorys;

namespace YearbookBoard.Data.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly DataContext _eventRepository;

        public EventRepository(DataContext eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public List<Event> GetAllEvents()
        {
            return _eventRepository.EventList;
        }

        public Event GetEventById(int id)
        {
            return _eventRepository.EventList.First(u => u.Id == id);
        }

        public List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();
            return events;
        }

        public void AddEvent(Event e)
        {
            _eventRepository.EventList.Add(new Event
            {
                Id = e.Id,
                Name = e.Name,
                Date = e.Date,
                Day = e.Day,
                EventLocation = e.EventLocation,
                EventType = e.EventType,
                Note = e.Note
            });
        }

        public void PutEvent(int id, Event e)
        {
            var ev = _eventRepository.EventList.First(u => u.Id == id);
            ev.Day = e.Day;
            ev.Date = e.Date;
            ev.Name = e.Name;
            ev.NumClass = e.NumClass;
            ev.EventType = e.EventType;
            ev.EventLocation = e.EventLocation;
            ev.Note = e.Note;

        }

        public void RemoveEvent(int id)
        {
            var ev = _eventRepository.EventList.Find(u => u.Id == id);
            if (ev != null)
                _eventRepository.EventList.Remove(ev);
        }
    }
}
