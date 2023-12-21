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
            return _telephoneBoardRepository.TelephoneBoardList;
        }

        public TelephoneBoard GetTelephoneBoard(int telephoneId)
        {
            return _telephoneBoardRepository.TelephoneBoardList.Find(t => t.TelephoneId == telephoneId);
        }

        public void AddTelephneBoard(TelephoneBoard t)
        {
            _telephoneBoardRepository.TelephoneBoardList.Add(new TelephoneBoard
            {
                TelephoneId = t.TelephoneId,
                Name = t.Name,
                FamilyN = t.FamilyN,
                NumClass = t.NumClass,
                TelephoneNumber = t.TelephoneNumber,
                AdditionalTelephone = t.AdditionalTelephone
            });
        }

        public void PutTelephneBoard(int id ,TelephoneBoard t)
        {
            var ptb = _telephoneBoardRepository.TelephoneBoardList.Find(tb => tb.TelephoneId == id);
            if (ptb != null)
            {
                ptb.Name = t.Name;
                ptb.FamilyN = t.FamilyN;
                ptb.NumClass = t.NumClass;  
                ptb.TelephoneNumber = t.TelephoneNumber;
                ptb.AdditionalTelephone = t.AdditionalTelephone;
            }
            
        }

        public void RemoveTelephoneBoard(int id)
        {
            var dtb = _telephoneBoardRepository.TelephoneBoardList.Find(d => d.TelephoneId == id);
            if(dtb != null)
                _telephoneBoardRepository.TelephoneBoardList.Remove(dtb);
        }

        public void RemoveTelephoneBoard(TelephoneBoard t)
        {
            var dtb = _telephoneBoardRepository.TelephoneBoardList.Find(d => d.TelephoneId == t.TelephoneId);
            if (dtb != null)
                _telephoneBoardRepository.TelephoneBoardList.Remove(dtb);
        }
    }
}
