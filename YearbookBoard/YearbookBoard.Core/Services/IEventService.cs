using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;

namespace YearbookBoard.Core.Services
{
    public interface IEventService
    {
        public List<Event> GetAllEvents();

        public Event GetEventById(int id);

        public List<Event> GetEvents();

        public void AddEvent(Event e);

        public void PutEvent(int id, Event e);

        public void RemoveEvent(int id);

    }
}
