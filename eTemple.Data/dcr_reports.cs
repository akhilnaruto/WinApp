using eTemple.Data;
using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data
{
    public class dcr_reports
    {


       public List<Service> get_dcr_reports()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Service>("select Services.Id, Services.Name, Tokens.Quantity, Tokens.TotalCost, Tokens.ServiceDailyNumber from Services, Tokens").ToList();
            }
        }



   



}
}
