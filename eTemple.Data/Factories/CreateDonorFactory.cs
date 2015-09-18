using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public static class CreateDonorFactory
    {
        public static Donors CreateDonor(int amount, int mrNo,int serviceTypeId,int serviceNameId,
           int dateTypeId,DateTime performDate,string month, string address,string name,
           string city,string state = null,string country =null,string surName = null, int pinCode =0,
           string districtName=null,string nameOn = null,int star =0,string occassion = null,
           string Gothram =null,string remarks =null,string phoneNumber=null,
            int specialDayId =0,string emailId = null,string paksha = null,string tithi =null)
        {
            return new Donors
            {
                Amount = amount,
                MR_No = mrNo,
                ServiceTypeId = serviceTypeId,
                ServiceNameId = serviceNameId,
                DateTypeId = dateTypeId,
                PerformDate = performDate,
                Month = month,
                Address = address,
                Name = name,
                City = city
            };

        }


    }
}
