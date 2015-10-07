using eTemple.Data.Models;
using eTemple.Data.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace eTemple.Data.Repositories
{
    public class  TeluguCalendarRepository : IRepository<TeluguCalendar>
    {
    
        private eTempleDbDB TempleDb;
        private DataSet dsreturnObj;
        string strConn = ConfigurationManager.ConnectionStrings["eTempleDb"].ConnectionString;

        public TeluguCalendarRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(TeluguCalendar entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TeluguCalendar entity)
        {
            throw new NotImplementedException();
        }

        public TeluguCalendar FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeluguCalendar> GetAllAsQuerable()
        {
            return TempleDb.Query<TeluguCalendar>("Select * From telugucalendar order by Id asc").ToList();
        }

        public IEnumerable<TeluguCalendar> GetAllAsQuerable(int thithiId)
        {

            return TempleDb.Query<TeluguCalendar>("Select * From thidhi where Id = " + thithiId + " order by Name asc").ToList();

        }

        public DataSet getTeluguDate(string engDate)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                using (MySqlCommand cmd = new MySqlCommand("select masam,thidhi from telugucalendar where englishdate ='" + engDate + "'", conn))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        dsreturnObj = new DataSet();
                        da.Fill(dsreturnObj);
                    }
                }
            }
            return dsreturnObj;
        }
        public void Update(TeluguCalendar entity)
        {
            throw new NotImplementedException();
        }
    }
}
