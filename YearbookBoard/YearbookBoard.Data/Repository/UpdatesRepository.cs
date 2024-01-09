using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Repositorys;

namespace YearbookBoard.Data.Repository
{
    public class UpdatesRepository : IUpdatesRepository
    {
        private readonly DataContext _UpdatesRepository;

        public UpdatesRepository(DataContext UpdatesRepository)
        {
            _UpdatesRepository = UpdatesRepository;
        }

        public List<Updates> GetAllUpdates()
        {
            return _UpdatesRepository.Updates.ToList();
        }

        public Updates GetUpdetes(int id)
        {
            return _UpdatesRepository.Updates.Find(id);
        }

        public Updates AddUpdetes(Updates updates)
        {
            _UpdatesRepository.Updates.Add(updates);
            _UpdatesRepository.SaveChanges();
            return updates;
        }

        public Updates PutUpdetes(int id, Updates u)
        {
            var pu = GetUpdetes(id);
            if(pu != null)
            {
                pu.UpdateLevel = u.UpdateLevel;
                pu.Name = u.Name;
                pu.Detail = u.Detail;
            }
            return pu;
            
        }

        public void RemoveUpdetes(int id)
        {
            var pu = GetUpdetes(id);
            if (pu != null)
                _UpdatesRepository.Updates.Remove(pu);
        }
    }
}
