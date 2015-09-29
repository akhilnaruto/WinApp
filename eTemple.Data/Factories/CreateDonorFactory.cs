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
        public static Donors CreateDonor(int amount, string mrNo,int serviceTypeId,int serviceNameId,
           int dateTypeId,DateTime performDate,int month, string address,string name,
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
                PerformDate = performDate.ToString("dd-MM"),
                DonorMonth = month,
                Address = address,
                DonorName = name,
                City = city
            };

        }


        //public static Donors CreateDonor1(int id,int amount, int mr_no,DateTime date, DateTime performdate, string address=null,string surname=null,string name=null,
        //        string districtName=null,string city=null,int pin=0, string state=null,string country=null,string nameon=null,
        //        int star=0, string occasion=null,string gothram=null,string remarks=null,
        //        string phonenumber=null, int specialdayId=0,int serviceTypeId=0,int serviceNameId=0,int dateTypeId=0,
        //        string emailId=null,string paksha=null,int month=0,int thithi=0)
        //{
        //    return new Donors
        //    {
        //        Id = id,
        //        Address = address,
        //        Surname = surname,
        //        Name = name,
        //        DistrictName = districtName,
        //        City = city,
        //        Pin = pin,
        //        State = state,
        //        Country = country,
        //        NameOn = nameon,
        //        Star = star,
        //        Occassion = occasion,
        //        Gothram = gothram,
        //        Amount = amount,
        //        MR_No = mr_no,
        //        Remarks = remarks,
        //        PhoneNumber = phonenumber,
        //        SpecialDayId = specialdayId,
        //        ServiceTypeId = serviceTypeId,
        //        ServiceNameId = serviceNameId,
        //        DateTypeId = dateTypeId,
        //        PerformDate = performdate,
        //        EmailId = emailId,
        //        Paksha = paksha,
        //        Month = month,
        //        Thidhi = thithi
        //    };
        //}
    }
}
