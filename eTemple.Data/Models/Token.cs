using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Token
    {
        [ResultColumn]
        public string ServiceName { get; set; }

        [ResultColumn]
        public int ServiceTypeID { get; set; }

        [ResultColumn]
        public string ServiceType { get; set; }

        [ResultColumn]
        public int TokenIndex { get; set; }

        [ResultColumn]
        public string DevoteeName { get; set; }

        [ResultColumn]
        public int PrefixId { get; set; }

        [ResultColumn]
        public string PrefixName { get; set; }

        [ResultColumn]
        public string PhoneNumber { get; set; }

        [ResultColumn]
        public string EmailId { get; set; }

        [ResultColumn]
        public string Gothram { get; set; }

        [ResultColumn]
        public string DoorNumber { get; set; }

        [ResultColumn]
        public string AreaName { get; set; }

        [ResultColumn]
        public string City { get; set; }

        [ResultColumn]
        public string MandalName { get; set; }

        [ResultColumn]
        public string StateName { get; set; }

        [ResultColumn]
        public string OtherDetails { get; set; }

        [ResultColumn]
        public string AdditionalNames { get; set; }

        [ResultColumn]
        public string AdditionalGothrams { get; set; }

        [ResultColumn]
        public string Created_By { get; set; }

        [ResultColumn]
        public string Entered_By { get; set; }

        [ResultColumn]
        public string DistrictName { get; set; }

        public string DevoteeFullName
        {
            get
            {
                return string.Format("{0}   {1}", this.PrefixName, this.DevoteeName);
            }
        }

        public string City_Mandal
        {
            get
            {
                return string.Format("{0} /  {1}", this.City, this.MandalName);
            }
        }

    }
}
