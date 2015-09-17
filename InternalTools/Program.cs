using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data;
using eTemple.Data.Repositories;
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
            var donarRepository = new DonorRepository();
            for (int i = 0; i < 100000; i++)
            {
                var donar = CreateDonorFactory.CreateDonor(i + 100, i + 100, 2, 5, 1, DateTime.Now, "january", "konaha village"
                    , "Naruto" + i.ToString(), "Hyderabad");
                donarRepository.Add(donar);
            }
        }

    }
}
