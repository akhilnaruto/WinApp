using eTemple.Data.Models;
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
    public class DonorRepository : IRepository<Donors>
    {
        private eTempleDbDB TempleDb;
        private DataSet dsreturnObj;
        string strConn = ConfigurationManager.ConnectionStrings["eTempleDb"].ConnectionString;
        public DonorRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public IEnumerable<Donors> GetAllAsQuerable()
        {
            return TempleDb.Query<Donors>("Select * From donors").ToList();
        }

        public DataSet getMaxIdFromDonor()
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT coalesce(MAX(Id), 0) AS donroId FROM donors", conn))
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

        public Donors checkModifyDonorIDExists(string chkId)
        {
            var donors = TempleDb.SingleOrDefault<Donors>("Select * from Donors where Id=@0", chkId);
            if (donors != null && donors.Id != null)
            {
                return donors;
            }
            else
            {
                return null;
            }
        }

        public Donors checkModifyDonorNameExists(string chkName)
        {
            var donors = TempleDb.SingleOrDefault<Donors>("Select * from Donors where DonorName=@0", chkName);
            if (donors != null && donors.DonorName != null)
            {
                return donors;
            }
            else
            {
                return null;
            }
        }

        public Donors checkModifyMRNoExists(string chkMRNo)
        {
            var donors = TempleDb.SingleOrDefault<Donors>("Select * from Donors where MR_No=@0", chkMRNo);
            if (donors != null && donors.MR_No != 0)
            {
                return donors;
            }
            else
            {
                return null;
            }
        }


        public string insertDonorInformation(Donors donor)
        {
            string insertStatus = string.Empty;
            string commandText = "INSERT INTO donors(Id,Donordate,Address,Surname,DonorName,DistrictName,City,Pin,State,Country,NameOn,Star,Occassion,Gothram,Amount,MR_No,Remarks,Landline,SpecialDayId,ServiceTypeId,ServiceNameId,DateTypeId,PerformDate,EmailId,DonorMonth,Thidhi,DonorDay,Mobile)VALUES(@Id, @Donordate,@Address,@Surname,@DonorName,@DistrictName,@City,@Pin,@State,@Country,@NameOn,@Star,@Occassion,@Gothram,@Amount,@MR_No,@Remarks,@Landline,@SpecialDayId,@ServiceTypeId,@ServiceNameId,@DateTypeId,@PerformDate,@EmailId,@DonorMonth,@Thidhi,@DonorDay,@Mobile)";

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
                            cmd.Parameters.AddWithValue("@Id", donor.Id);
                            cmd.Parameters.AddWithValue("@Donordate", donor.Donordate);
                            cmd.Parameters.AddWithValue("@Address", donor.Address);
                            cmd.Parameters.AddWithValue("@Surname", donor.Surname);
                            cmd.Parameters.AddWithValue("@DonorName", donor.DonorName);
                            cmd.Parameters.AddWithValue("@DistrictName", donor.DistrictName);
                            cmd.Parameters.AddWithValue("@City", donor.City);
                            cmd.Parameters.AddWithValue("@Pin", donor.Pin);
                            cmd.Parameters.AddWithValue("@State", donor.State);
                            cmd.Parameters.AddWithValue("@Country", donor.Country);
                            cmd.Parameters.AddWithValue("@NameOn", donor.NameOn);
                            cmd.Parameters.AddWithValue("@Star", donor.Star);
                            cmd.Parameters.AddWithValue("@Occassion", donor.Occassion);
                            cmd.Parameters.AddWithValue("@Gothram", donor.Gothram);
                            cmd.Parameters.AddWithValue("@Amount", donor.Amount);
                            cmd.Parameters.AddWithValue("@MR_No", donor.MR_No);
                            cmd.Parameters.AddWithValue("@Remarks", donor.Remarks);
                            cmd.Parameters.AddWithValue("@Landline", donor.Landline);
                            cmd.Parameters.AddWithValue("@SpecialDayId", donor.SpecialDayId);
                            cmd.Parameters.AddWithValue("@ServiceTypeId", donor.ServiceTypeId);
                            cmd.Parameters.AddWithValue("@ServiceNameId", donor.ServiceNameId);
                            cmd.Parameters.AddWithValue("@DateTypeId", donor.DateTypeId);
                            cmd.Parameters.AddWithValue("@PerformDate", donor.PerformDate);
                            cmd.Parameters.AddWithValue("@EmailId", donor.EmailId);
                            cmd.Parameters.AddWithValue("@DonorMonth", donor.DonorMonth);
                            cmd.Parameters.AddWithValue("@Thidhi", donor.Thidhi);
                            cmd.Parameters.AddWithValue("@DonorDay", donor.DonorDay);
                            cmd.Parameters.AddWithValue("@Mobile", donor.Mobile);

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



        public string updateDonorInformation(Donors donor)
        {
            string updateStatus = string.Empty;
            string commandText = "update donors set Donordate=@Donordate,Address=@Address,Surname=@Surname,DonorName=@DonorName,DistrictName=@DistrictName,City=@City,Pin=@Pin,State=@State,Country=@Country,NameOn=@NameOn,Star=@Star,Occassion=@Occassion,Gothram=@Gothram,Amount=@Amount,MR_No=@MR_No,Remarks=@Remarks,Landline=@Landline,SpecialDayId=@SpecialDayId,ServiceTypeId=@ServiceTypeId,ServiceNameId=@ServiceNameId,DateTypeId=@DateTypeId,PerformDate=@PerformDate,EmailId=@EmailId,DonorMonth=@DonorMonth,Thidhi=@Thidhi,DonorDay=@DonorDay,Mobile=@Mobile WHERE Id = @Id";


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
                            cmd.Parameters.AddWithValue("@Id", donor.Id);
                            cmd.Parameters.AddWithValue("@Donordate", donor.Donordate);
                            cmd.Parameters.AddWithValue("@Address", donor.Address);
                            cmd.Parameters.AddWithValue("@Surname", donor.Surname);
                            cmd.Parameters.AddWithValue("@DonorName", donor.DonorName);
                            cmd.Parameters.AddWithValue("@DistrictName", donor.DistrictName);
                            cmd.Parameters.AddWithValue("@City", donor.City);
                            cmd.Parameters.AddWithValue("@Pin", donor.Pin);
                            cmd.Parameters.AddWithValue("@State", donor.State);
                            cmd.Parameters.AddWithValue("@Country", donor.Country);
                            cmd.Parameters.AddWithValue("@NameOn", donor.NameOn);
                            cmd.Parameters.AddWithValue("@Star", donor.Star);
                            cmd.Parameters.AddWithValue("@Occassion", donor.Occassion);
                            cmd.Parameters.AddWithValue("@Gothram", donor.Gothram);
                            cmd.Parameters.AddWithValue("@Amount", donor.Amount);
                            cmd.Parameters.AddWithValue("@MR_No", donor.MR_No);
                            cmd.Parameters.AddWithValue("@Remarks", donor.Remarks);
                            cmd.Parameters.AddWithValue("@Landline", donor.Landline);
                            cmd.Parameters.AddWithValue("@SpecialDayId", donor.SpecialDayId);
                            cmd.Parameters.AddWithValue("@ServiceTypeId", donor.ServiceTypeId);
                            cmd.Parameters.AddWithValue("@ServiceNameId", donor.ServiceNameId);
                            cmd.Parameters.AddWithValue("@DateTypeId", donor.DateTypeId);
                            cmd.Parameters.AddWithValue("@PerformDate", donor.PerformDate);
                            cmd.Parameters.AddWithValue("@EmailId", donor.EmailId);
                            cmd.Parameters.AddWithValue("@DonorMonth", donor.DonorMonth);
                            cmd.Parameters.AddWithValue("@Thidhi", donor.Thidhi);
                            cmd.Parameters.AddWithValue("@DonorDay", donor.DonorDay);
                            cmd.Parameters.AddWithValue("@Mobile", donor.Mobile);

                            cmd.ExecuteNonQuery();
                            updateStatus = "Success";
                        }

                        trans.Commit();

                    }
                    catch (MySqlException ex)
                    {
                        trans.Rollback();
                        conn.Close();
                        updateStatus = ex.ToString();
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
            return updateStatus;
        }


        public DataTable GetAllasDataTable()
        {
            return TempleDb.ExecuteReader("Select * From donors order by DonorName asc");
        }

        public void Add(Donors entity)
        {
            //TempleDb.Save(entity);
            TempleDb.Insert("Donors", "Id", true, entity);
        }

        public void Delete(Donors entity)
        {
            throw new NotImplementedException();
        }

        public Donors FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Donors entity)
        {
            TempleDb.Update(entity);
        }
    }
}
