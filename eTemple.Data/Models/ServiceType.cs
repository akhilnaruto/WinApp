using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class ServiceType
    {
        [ResultColumn]
        public int Id { get; set; }

        [ResultColumn]
        public string Name { get; set; }

        [ResultColumn]
        public int Status { get; set; }

        [ResultColumn]
        public DateTime CreatedOn { get; set; }

        [ResultColumn]
        public int CreatedBy { get; set; }

    }
}
