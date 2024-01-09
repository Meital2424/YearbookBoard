using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;

namespace YearbookBoard.Core.Services
{
    public interface IUpdatesServices
    {
        public List<Updates> GetAllUpdates();

        public Updates GetUpdetes(int id);

        public Updates AddUpdetes(Updates updates);

        public Updates PutUpdetes(int id, Updates updates);

        public void RemoveUpdetes(int id);
    }
}
