using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearbookBoard.Core.Entities;

namespace YearbookBoard.Core.Services
{
    public interface ITelephoneBoardServices
    {
        public List<TelephoneBoard> GetAllTelephoneBoard();

        public TelephoneBoard GetTelephoneBoard(int telephoneId);

        public TelephoneBoard AddTelephneBoard(TelephoneBoard t);

        public TelephoneBoard PutTelephneBoard(int id, TelephoneBoard t);

        public void RemoveTelephoneBoard(TelephoneBoard t);

        
    }
}
