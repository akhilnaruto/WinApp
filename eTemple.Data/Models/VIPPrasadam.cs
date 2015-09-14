using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class VIPPrasadam
    {
        [ResultColumn]
        public string ServiceName { get; set; }

        [ResultColumn]
        public string IssuedByName { get; set; }

        [ResultColumn]
        public string ReferenceByName { get; set; }
    }
}
