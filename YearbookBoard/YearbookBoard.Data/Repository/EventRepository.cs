using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Event> GetAllEvents()
        {
            return _eventRepository.Events.Include(e => e.TelephoneBoard); 
        }

        public Event GetEvent(int id)
        {
            return _eventRepository.Events.Find(id);
        }

        public Event AddEvent(Event e)
        {
            _eventRepository.Events.Add(e);
            _eventRepository.SaveChanges();
            return e;
        }

        public Event PutEvent(int id, Event e)
        {
            var ev = GetEvent(id);
            if(ev != null) {
            ev.Day = e.Day;
            ev.Date = e.Date;
            ev.Name = e.Name;
            ev.NumClass = e.NumClass;
            ev.EventType = e.EventType;
            ev.EventLocation = e.EventLocation;
            ev.Note = e.Note;
                _eventRepository.SaveChanges(); //עדכון מסד הנתונים
            }
            return ev;

        }

        public void RemoveEvent(int id)
        {
            var ev = GetEvent(id);
            if (ev != null)
                _eventRepository.Events.Remove(ev);
        }
    }
}
