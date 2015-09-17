using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Repositories;

namespace eTemple.Data.Models
{
    public partial class ServiceName : IEntity
    {
        [ResultColumn]
        public int Id { get; set; }

        [ResultColumn]
        public string Name { get; set; }

        [ResultColumn]
        public int ServiceTypeId { get; set; }
    }
}
