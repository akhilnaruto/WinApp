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
                PerformDate = performDate,
                Month = month,
                Address = address,
                Name = name,
                City = city
            };

        }


        public static Donors CreateDonor1(DateTime date, string address,string surname,string name,
                string districtName,string city,int pin, string state,string country,string nameon,
                int star, string occasion,string gothram,int amount,int mr_no,string remarks,
                string phonenumber, int specialdayId,int serviceTypeId,int serviceNameId,int dateTypeId,DateTime performdate,
                string emailId,string paksha,int month,int thithi)
        {
            return new Donors
            {
                Address = address,
                Surname=surname,
                Name = name,
                DistrictName=districtName,
                City=city,
                Pin=pin,
                State=state,
                Country=country,
                NameOn=nameon,
                Star=star,
                Occassion=occasion,
                Gothram=gothram,
                Amount=amount,
                MR_No=mr_no,
                Remarks=remarks,
                PhoneNumber=phonenumber,
                SpecialDayId=specialdayId,
                ServiceTypeId=serviceTypeId,
                ServiceNameId=serviceNameId,
                DateTypeId=dateTypeId,
                PerformDate=performdate,
                EmailId=emailId,
                Paksha=paksha,
                Month=month,
                Thidhi=thithi
            };

        }
    }
}
