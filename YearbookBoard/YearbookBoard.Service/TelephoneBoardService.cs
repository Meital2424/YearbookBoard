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
    public class TelephoneBoardService : ITelephoneBoardServices
    {
        private readonly ITelephoneBoardRepository _TelephoneBoard;

        public TelephoneBoardService(ITelephoneBoardRepository TelephoneBoard)
        {
            _TelephoneBoard = TelephoneBoard;
        }

        public List<TelephoneBoard> GetAllTelephoneBoard()
        {
            return _TelephoneBoard.GetAllTelephoneBoard();
        }

        public TelephoneBoard GetTelephoneBoard(int id)
        {
            return _TelephoneBoard.GetTelephoneBoard(id);
        }

        public List<TelephoneBoard> GetTelephoneBoard()
        {
            return _TelephoneBoard.GetAllTelephoneBoard();
        }

        public TelephoneBoard AddTelephneBoard(TelephoneBoard t)
        {
           return _TelephoneBoard.AddTelephneBoard(t);
        }

        public TelephoneBoard PutTelephneBoard(int id, TelephoneBoard t)
        {
            return _TelephoneBoard.PutTelephneBoard(id, t);
        }

        public void RemoveTelephoneBoard(TelephoneBoard t)
        {
            _TelephoneBoard.RemoveTelephoneBoard(t);
        }


        

        

        
    }
}
