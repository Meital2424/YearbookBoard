using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearbookBoard.Core.Entities
{
    public class Updates
    {
        public int Id { get; set; }

        public String? UpdateLevel { get; set; }

        public String? Name { get; set; }

        public String? Detail { get; set; }
    }
}
