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
            return _UpdatesRepository.UpdatesList;
        }

        public Updates GetUpdetes(int id)
        {
            return _UpdatesRepository.UpdatesList.Find(u => u.Id == id);
        }

        public void AddUpdetes(Updates updates)
        {
            _UpdatesRepository.UpdatesList.Add(new Updates
            {
                Id = updates.Id,
                Detail = updates.Detail,
                Name = updates.Name,
            });
        }

        public void PutUpdetes(int id, Updates u)
        {
            var pu = _UpdatesRepository.UpdatesList.FirstOrDefault(u => u.Id == id);
            if(pu != null)
            {
                pu.UpdateLevel = u.UpdateLevel;
                pu.Name = u.Name;
                pu.Detail = u.Detail;
            }
            
        }

        public void RemoveUpdetes(int id)
        {
            var pu = _UpdatesRepository.UpdatesList.Find(pu => pu.Id == id);
            if (pu != null)
                _UpdatesRepository.UpdatesList.Remove(pu);
        }
    }
}
