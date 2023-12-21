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

        public List<Event> GetAllEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        public Event GetEventById(int id)
        {
            return _eventRepository.GetEventById(id);
        }

        public List<Event> GetEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        public void AddEvent(Event e)
        {
            _eventRepository.AddEvent(e);
        }

        public void PutEvent(int id, Event e)
        {
            _eventRepository.PutEvent(id, e);
        }

        public void RemoveEvent(int id)
        {
            _eventRepository.RemoveEvent(id);
        }

        
    }
}

