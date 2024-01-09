using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Repositorys;

namespace YearbookBoard.Data.Repository
{
    public class TelephoneBoardRepository : ITelephoneBoardRepository
    {
        private readonly DataContext _telephoneBoardRepository;

        public TelephoneBoardRepository(DataContext telephoneBoardRepository)
        {
            _telephoneBoardRepository = telephoneBoardRepository;
        }

        public List<TelephoneBoard> GetAllTelephoneBoard()
        {
            return _telephoneBoardRepository.TelephoneBoards.ToList();
        }

        public TelephoneBoard GetTelephoneBoard(int telephoneId)
        {
            return _telephoneBoardRepository.TelephoneBoards.Find(telephoneId);
        }

        public TelephoneBoard AddTelephneBoard(TelephoneBoard t)
        {

            _telephoneBoardRepository.TelephoneBoards.Add(t);
            _telephoneBoardRepository.SaveChanges();
            return t;
        }

        public TelephoneBoard PutTelephneBoard(int id ,TelephoneBoard t)
        {
            var ptb = GetTelephoneBoard(id);
            if (ptb != null)
            {
                ptb.Name = t.Name;
                ptb.FamilyN = t.FamilyN;
                ptb.NumClass = t.NumClass;  
                ptb.TelephoneNumber = t.TelephoneNumber;
                ptb.AdditionalTelephone = t.AdditionalTelephone;
            }
            return ptb;
            
        }

        public void RemoveTelephoneBoard(int id)
        {
            var dtb = GetTelephoneBoard(id);
            if(dtb != null)
                _telephoneBoardRepository.TelephoneBoards.Remove(dtb);
        }

        public void RemoveTelephoneBoard(TelephoneBoard t)
        {
            var dtb = _telephoneBoardRepository.TelephoneBoards.ToList().Find(d => d.Id == t.Id);
            if (dtb != null)
                _telephoneBoardRepository.TelephoneBoards.Remove(dtb);
        }
    }
}
