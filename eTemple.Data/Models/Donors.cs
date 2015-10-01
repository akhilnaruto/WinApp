using eTemple.Data.Repositories;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Donors : IEntity
    {
        
        public string Id { get; set; }

        
        public DateTime Donordate { get; set; }

        
        public string Address { get; set; }

        
        public string Surname { get; set; }

        
        public string DonorName { get; set; }

        
        public string DistrictName { get; set; }

        
        public string City { get; set; }

        
        public string Pin { get; set; }

        
        public string State { get; set; }

        
        public string Country { get; set; }

        
        public string NameOn { get; set; }

        
        public int Star { get; set; }

        
        public string Occassion { get; set; }

        
        public string Gothram { get; set; }

        
        public decimal Amount { get; set; }

        
        public string MR_No { get; set; }

        
        public string Remarks { get; set; }

        
        public string PhoneNumber { get; set; }

        
        public int SpecialDayId { get; set; }

        
        public int ServiceTypeId { get; set; }

        
        public int ServiceNameId { get; set; }

        
        public int DateTypeId { get; set; }


        public string PerformDate { get; set; }

        
        public string EmailId { get; set; }

        
        public int DonorMonth { get; set; }

        
        public int Thidhi { get; set; }



        public int DonorDay { get; set; }

        public string Landline { get; set; }


        public string Mobile { get; set; }

        public int DonorThithi { get; set; }
    }
}


