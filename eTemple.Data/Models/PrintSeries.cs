using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class PrintSeries
    {
        [ResultColumn]
        public string Given_By { get; set; }

        [ResultColumn]
        public string Given_To { get; set; }
        
        [ResultColumn]
        public string EmployeeName { get; set; }
        
        [ResultColumn]
        public string TotalGivenTokens { get; set; }
        
        [ResultColumn]
        public string Qty { get; set; }
        
        [ResultColumn]
        public string Balance { get; set; }
    }
}
