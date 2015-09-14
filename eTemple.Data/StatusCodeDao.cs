using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class StatusCodeDao
    {
        public List<StatusCode> GetAllStatusCode()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<StatusCode>("SELECT * FROM StatusCode").ToList();
            }
        }
    }
}
