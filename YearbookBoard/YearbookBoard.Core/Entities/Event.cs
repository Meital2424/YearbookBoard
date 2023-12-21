using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearbookBoard.Core.Entities
{
    public class Event
    {
        public int Id { get; set; }

        public String? Day { get; set; }

        public DateTime Date { get; set; }

        public String? Name { get; set; }

        public int NumClass { get; set; }

        public String? EventType { get; set; }

        public String? EventLocation { get; set; }

        public String? Note { get; set; }
    }
}
