using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Repositories;

namespace eTemple.Data.Models
{
    public partial class ServiceTypes : IEntity
    {
        
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public int IsDateRelated { get; set; }

    }
}
