using eTemple.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class DailyAnnaDanamModel : IEntity
    {        
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Gothram { get; set; }
        
        public string VillageName { get; set; }

        public string DonatedDate { get; set; }
    }
}
