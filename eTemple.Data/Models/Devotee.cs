using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Devotee
    {
        [ResultColumn]
        public int TokenIndex { get; set; }

        [ResultColumn]
        public string ServiceName { get; set; }

        [ResultColumn]
        public string PrefixName { get; set; }
    }
}
