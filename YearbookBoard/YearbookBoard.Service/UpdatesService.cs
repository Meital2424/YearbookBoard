using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Repositorys;
using YearbookBoard.Core.Services;

namespace YearbookBoard.Service
{
    public class UpdatesService : IUpdatesServices
    {
        private readonly IUpdatesRepository _Updates;

        public UpdatesService(IUpdatesRepository Updates)
        {
            _Updates = Updates;
        }

        public List<Updates> GetAllUpdates()
        {
            return _Updates.GetAllUpdates();
        }

        public Updates GetUpdetes(int id)
        {
            return _Updates.GetUpdetes(id);
        }

        public Updates AddUpdetes(Updates updates)
        {
            return _Updates.AddUpdetes(updates);
        }

        public Updates PutUpdetes(int id, Updates updates)
        {
            return _Updates.PutUpdetes(id, updates);
        }

        public void RemoveUpdetes(int id)
        {
            _Updates.RemoveUpdetes(id);
        }
    }
}
