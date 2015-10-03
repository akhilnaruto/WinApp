using eTemple.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class TeluguCalendar : IEntity
    {
        public DateTime EnglishDate { get; set; }

        public int Masam { get; set; }

        public int Thidhi { get; set; }
    }
}
