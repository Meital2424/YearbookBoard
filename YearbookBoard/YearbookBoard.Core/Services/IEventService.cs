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
        public IEnumerable<Event> GetAllEvents();

        public Event GetEventById(int id);

       

        public Event AddEvent(Event e);

        public Event PutEvent(int id, Event e);

        public void RemoveEvent(int id);

    }
}
