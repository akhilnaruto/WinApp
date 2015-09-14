using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Service
    {
        [ResultColumn]
        public string ServiceType { get; set; }

        [ResultColumn]
        public string Created_By { get; set; }

        [ResultColumn]
        public string Modified_By { get; set; }

        public string DisplayName
        {
            get
            {
                return string.Format("{0} - {1}", this.Id, this.Name);
            }
        }

        [ResultColumn]
        public int SoldQuantity { get; set; }

        [ResultColumn]
        public double TotalCollection { get; set; }

        [ResultColumn]
        public int StartingNumber { get; set; }

        [ResultColumn]
        public int EndingNumber { get; set; }

        
    }
}
