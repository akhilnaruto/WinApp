using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace eTemple.Data.Repositories
{

    public class GothramsRepository : IRepository<Gothrams>
    {
        private eTempleDbDB TempleDb;
        string strConn = ConfigurationManager.ConnectionStrings["eTempleDb"].ConnectionString;

        public GothramsRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(Gothrams entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gothrams entity)
        {
            throw new NotImplementedException();
        }

        public Gothrams FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gothrams> GetAllAsQuerable()
        {
            return TempleDb.Query<Gothrams>("Select name From Gothrams").ToList();
        }

        public void Update(Gothrams entity)
        {
            throw new NotImplementedException();
        }

        public Gothrams checkIfGothramExists(string chkGothramExists)
        {
            var gothrams = TempleDb.SingleOrDefault<Gothrams>("Select * from gothrams where Name=@0", chkGothramExists);
            if (gothrams != null && gothrams.Name != null)
            {
                return gothrams;
            }
            else
            {
                return null;
            }
        }

        public string insertNewGothraName(string gothra)
        {
            string insertStatus = string.Empty;
            string commandText = "INSERT INTO gothrams(Name)VALUES(@Name)";

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
                            cmd.Parameters.AddWithValue("@Name", gothra);
                            
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
    }
}
