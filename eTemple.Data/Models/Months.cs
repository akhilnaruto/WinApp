using eTemple.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public class Months : IEntity
    {
        public int Id { get; set; }

        public string English { get; set; }

        public string Telugu { get; set; }
    }    
}
