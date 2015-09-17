using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Designations
    {
        [ResultColumn]
        public string Name { get; set; }
    }
}
