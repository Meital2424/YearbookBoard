using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;

namespace YearbookBoard.Core.Repositorys
{
    public interface ITelephoneBoardRepository
    {
        public List<TelephoneBoard> GetAllTelephoneBoard();

        public TelephoneBoard GetTelephoneBoard(int telephoneId);

        public void AddTelephneBoard(TelephoneBoard t);

        public void PutTelephneBoard(int id, TelephoneBoard t);

        public void RemoveTelephoneBoard(int telephoneId);

        void RemoveTelephoneBoard(TelephoneBoard t);
    }
}
