using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearbookBoard.Core.Entities
{
    public class TelephoneBoard
    {
        public int Id { get; set; }

        public String? Name { get; set; }

        public String? FamilyN { get; set; }

        public int NumClass { get; set; }

        public String? TelephoneNumber { get; set; }

        public String? AdditionalTelephone { get; set; }


        public List<Event> Events { get; set; } //האירועים של הבת הנוכחית


    }
}
