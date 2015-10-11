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
    public class EmployeeRepository : IRepository<Employees>
    {
        private eTempleDbDB TempleDb;
        string strConn = ConfigurationManager.ConnectionStrings["eTempleDb"].ConnectionString;
        public EmployeeRepository()
        {
            TempleDb = new eTempleDbDB();
        }
        public void Add(Employees entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employees entity)
        {
            throw new NotImplementedException();
        }

        public Employees FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> GetAllAsQuerable()
        {
            return TempleDb.Query<Employees>("Select * From employees").ToList();
        }

        public void Update(Employees entity)
        {
            throw new NotImplementedException();
        }

        public Employees ValidateLogin(string loginId, string password)
        {
            using (var db = new eTempleDbDB())
            {
                var emp = db.SingleOrDefault<Employees>("Select * from Employees where LoginId=@0 and Password=@1", loginId, password);
                if (emp != null && emp.Name != null)
                {
                    return emp;
                }
                else
                {
                    return null;
                }
            }
        }

        public DataTable getEmpData()
        {
            return TempleDb.ExecuteReader("SELECT Id,Name,Role,LoginId,Password,CreatedBy,CreatedOn FROM employees order by Id;");
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeleteEmployee(string empId)
        {
            string deleteStatus = string.Empty;
            string commandText = "Delete from employees WHERE Id = @Id";

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
                            cmd.Parameters.AddWithValue("@Id", empId);
                            cmd.ExecuteNonQuery();
                            deleteStatus = "Success";
                        }

                        trans.Commit();

                    }
                    catch (MySqlException ex)
                    {
                        trans.Rollback();
                        conn.Close();
                        deleteStatus = ex.ToString();
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
            return deleteStatus;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public string InsertEmployee(Employees empDetials)
        {
            string insertStatus = string.Empty;
            string commandText = "INSERT INTO employees(Id,Name,Role,LoginId,Password,CreatedBy,CreatedOn)VALUES(@Id,@Name,@Role,@LoginId,@Password,@CreatedBy,@CreatedOn)";

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
                            cmd.Parameters.AddWithValue("@Id", empDetials.Id);
                            cmd.Parameters.AddWithValue("@Name", empDetials.Name);
                            cmd.Parameters.AddWithValue("@Role", empDetials.Role);
                            cmd.Parameters.AddWithValue("@LoginId", empDetials.LoginId);
                            cmd.Parameters.AddWithValue("@Password", empDetials.Password);
                            cmd.Parameters.AddWithValue("@CreatedBy", empDetials.CreatedBy);
                            cmd.Parameters.AddWithValue("@CreatedOn", empDetials.CreatedOn);
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

        public string updateEmployeeInformation(Employees employeeDetail)
        {
            string updateStatus = string.Empty;
            string commandText = "update roles set Name=@Name,Role=@Role,LoginId=@LoginId,Password=@Password,CreatedBy=@CreatedBy,CreatedOn=@CreatedOn WHERE Id = @Id";


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
                            cmd.Parameters.AddWithValue("@Id", employeeDetail.Id);
                            cmd.Parameters.AddWithValue("@Name", employeeDetail.Name);
                            cmd.Parameters.AddWithValue("@Role", employeeDetail.Role);
                            cmd.Parameters.AddWithValue("@LoginId", employeeDetail.LoginId);
                            cmd.Parameters.AddWithValue("@Password", employeeDetail.Password);
                            cmd.Parameters.AddWithValue("@CreatedBy", employeeDetail.CreatedBy);
                            cmd.Parameters.AddWithValue("@CreatedOn", employeeDetail.CreatedOn);

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
    }
}
