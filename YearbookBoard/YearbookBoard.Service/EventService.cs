using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Repositorys;
using YearbookBoard.Core.Services;

namespace YearbookBoard.Service
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public Event AddEvent(Event e)
        { 
               return _eventRepository.AddEvent(e);           
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        public Event GetEventById(int id)
        {
            return _eventRepository.GetEvent(id);
        }

        public Event PutEvent(int id, Event e)
        {
            return _eventRepository.PutEvent(id, e);
        }

        public void RemoveEvent(int id)
        {
            _eventRepository.RemoveEvent(id);
        }       
    }
}

