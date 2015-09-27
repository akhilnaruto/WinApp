using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data;
using eTemple.Data.Repositories;
using eTemple.Data.Models;
using System.Data;

namespace InternalTools
{
    public class Program
    {
        static void Main(string[] args)
        {
            InsertInToDonars();
        }

        public static void InsertInToDonars()
        {
            //var servceTypes = StubbServiceTypes().CopyToDataTable();
            //var donors = stubDonorTable();
            //var result = from x in donors.AsEnumerable()
            //             join y in servceTypes.AsEnumerable() on x["ServiceTypeId"] equals y["Id"] into DataGroup
            //             from item in DataGroup.DefaultIfEmpty()
            //             select new
            //             {
            //                 ID = x["ServiceTypeId"],
            //                 ColA = item["Name"]
            //             };


        }


        public static List<ServiceTypes> StubbServiceTypes()
        {
            var serviceTypes  = new List<ServiceTypes>();
            serviceTypes.Add(new ServiceTypes { Id = 1, Name = "Naruto" });
            serviceTypes.Add(new ServiceTypes { Id = 2, Name = "Naruto1" });
            serviceTypes.Add(new ServiceTypes { Id = 3, Name = "Naruto2" });
            serviceTypes.Add(new ServiceTypes { Id = 4, Name = "Naruto3"});
            serviceTypes.Add(new ServiceTypes { Id = 5, Name = "Naruto4" });
            serviceTypes.Add(new ServiceTypes { Id = 6, Name = "Naruto5" });
            serviceTypes.Add(new ServiceTypes { Id = 7, Name = "Naruto6" });
            return serviceTypes;
        }

        public static DataTable stubDonorTable()
        {
            var donorTable = new DataTable("DonorTable");
            donorTable.Columns.Add("donorId");
            donorTable.Columns.Add("ServiceTypeId");
            donorTable.Columns.Add("donorName");
            donorTable.Rows.Add("donor1", "1", "uzumaki1");
            donorTable.Rows.Add("donor2", "2", "uzumaki2");
            donorTable.Rows.Add("donor3", "3", "uzumaki3");
            donorTable.Rows.Add("donor4", "4", "uzumaki4");
            donorTable.Rows.Add("donor5", "4", "uzumaki5");
            donorTable.Rows.Add("donor6", "3", "uzumaki6");
            donorTable.Rows.Add("donor7", "2", "uzumaki7");
            return donorTable;
        }

    }
}
