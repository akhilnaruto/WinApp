using eTemple.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{

    public class DailyAnnaDanamRepository : IRepository<DailyAnnaDanamModel>
    {
        private eTempleDbDB TempleDb;
        private DataSet dsreturnObj;
        string strConn = ConfigurationManager.ConnectionStrings["eTempleDb"].ConnectionString;
        public DailyAnnaDanamRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(DailyAnnaDanamModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(DailyAnnaDanamModel entity)
        {
            throw new NotImplementedException();
        }

        public DailyAnnaDanamModel FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public DataSet getTotalAmtperDate(string CollectionDate)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT count(1) as cnt  FROM dailyannadanam where donatedDAte='" + CollectionDate + "'", conn))
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

        public IEnumerable<DailyAnnaDanamModel> GetAllAsQuerable()
        {
            return TempleDb.Query<DailyAnnaDanamModel>("Select * From MonthlyAnnadanamtbl order by Id asc").ToList();
        }

        public string insertDonorInformation(DailyAnnaDanamModel dailyAnna)
        {
            string insertStatus = string.Empty;
            string commandText = "INSERT INTO dailyannadanam(Name,PhoneNumber,Gothram,VillageName,DonatedDate)VALUES(@Name,@PhoneNumber,@Gothram,@VillageName,@DonatedDate)";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(commandText, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Name", dailyAnna.Name);
                            cmd.Parameters.AddWithValue("@PhoneNumber", dailyAnna.PhoneNumber);
                            cmd.Parameters.AddWithValue("@Gothram", dailyAnna.Gothram);
                            cmd.Parameters.AddWithValue("@VillageName", dailyAnna.VillageName);
                            cmd.Parameters.AddWithValue("@DonatedDate", dailyAnna.DonatedDate);

                            cmd.ExecuteNonQuery();
                            insertStatus = "Success";
                        }

                        trans.Commit();

                    }
                    catch (MySqlException ex)
                    {
                        trans.Rollback();
                        conn.Close();
                        insertStatus = ex.ToString();
                    }

                    finally
                    {
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            return insertStatus;
        }




        public void Update(DailyAnnaDanamModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
