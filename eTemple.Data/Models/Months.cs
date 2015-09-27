using eTemple.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Months : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

       //s public string Telugu { get; set; }
    }    
} 
