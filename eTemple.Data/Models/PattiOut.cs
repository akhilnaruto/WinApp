using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class PattiOut
    {
        [ResultColumn]
        public string Entered_By { get; set; }

        [ResultColumn]
        public string ServiceName { get; set; }

        [ResultColumn]
        public string Informed_By { get; set; }
    }
}
