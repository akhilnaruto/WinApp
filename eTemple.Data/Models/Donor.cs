using eTemple.Data.Repositories;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Donor : IEntity
    {
        [ResultColumn]
        public int Id { get; set; }

        [ResultColumn]
        public DateTime date { get; set; }

        [ResultColumn]
        public string Address { get; set; }

        [ResultColumn]
        public string Surname { get; set; }

        [ResultColumn]
        public string Name { get; set; }

        [ResultColumn]
        public string DistrictName { get; set; }

        [ResultColumn]
        public string City { get; set; }

        [ResultColumn]
        public int Pin { get; set; }

        [ResultColumn]
        public string State { get; set; }

        [ResultColumn]
        public string Country { get; set; }

        [ResultColumn]
        public string NameOn { get; set; }

        [ResultColumn]
        public int Star { get; set; }

        [ResultColumn]
        public string Occassion { get; set; }

        [ResultColumn]
        public string Gothram { get; set; }

        [ResultColumn]
        public int Amount { get; set; }

        [ResultColumn]
        public int MR_No { get; set; }

        [ResultColumn]
        public string Remarks { get; set; }

        [ResultColumn]
        public string PhoneNumber { get; set; }

        [ResultColumn]
        public int SpecialDayId { get; set; }

        [ResultColumn]
        public int ServiceTypeId { get; set; }

        [ResultColumn]
        public int ServiceNameId { get; set; }

        [ResultColumn]
        public int DateTypeId { get; set; }

        [ResultColumn]
        public DateTime PerformDate { get; set; }

        [ResultColumn]
        public string EmailId { get; set; }

        [ResultColumn]
        public string Paksha { get; set; }

        [ResultColumn]
        public string Month { get; set; }

        [ResultColumn]
        public string Thidhi { get; set; }
    }
}


