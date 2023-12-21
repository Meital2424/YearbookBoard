using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;

namespace YearbookBoard.Core.Repositorys
{
    public interface IUpdatesRepository
    {
        public List<Updates> GetAllUpdates();

        public Updates GetUpdetes(int id);

        public void AddUpdetes(Updates updates);

        public void PutUpdetes(int id, Updates updates);

        public void RemoveUpdetes(int id);
    }
}
