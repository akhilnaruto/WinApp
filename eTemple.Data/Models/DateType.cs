using eTemple.Data.Repositories;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class DateType : IEntity
    {        
        public int Id { get; set; }
     
        public string Name { get; set; }
    }
}
