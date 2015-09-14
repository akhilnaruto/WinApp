using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class PattiIn
    {
        [ResultColumn]
        public string Entered_By { get; set; }

        [ResultColumn]
        public string ServiceName { get; set; }
    }
}
