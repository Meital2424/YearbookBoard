using YearbookBoard.Core.Entities;

namespace YearbookBoard.Data
{
    public class DataContext
    {
        public List<Event> EventList { get; set; }

        public List<TelephoneBoard> TelephoneBoardList { get; set; }

        public List<Updates> UpdatesList { get; set; }

        public DataContext()
        {
            EventList = new List<Event>();

            TelephoneBoardList = new List<TelephoneBoard>();

            UpdatesList = new List<Updates>();
        }
    }
}