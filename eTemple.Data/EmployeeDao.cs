using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class EmployeeDao
    {
        public Employee ValidateLogin(string loginId, string password)
        {
            using (var db = new eTempleDbDB())
            {
                var emp = db.SingleOrDefault<Employee>("Select * from Employees where LoginId=@0 and Password=@1", loginId, password);
                if (emp != null && emp.Name!= null)
                {
                    return emp;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Employee>(
                @"select e.*, r.Name as RoleName, d.Name as DesignationName from Employees e 
                    inner join Roles r on (e.Role = r.Id)
                    inner join Designations d on (e.Designation = d.Id) order by e.Name Asc").ToList();
            }
        }

        public List<Employee> GetLoginIds()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Employee>("Select Id, LoginId From Employees where AllowLogin=1 and IsDeleted=0 order by LoginId asc").ToList();
            }
        }

        public Employee GetEmployee(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<Employee>(Id);
            }
        }

        public void SaveEmployee(Employee emp)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(emp);
            }
        }

        public int UpdateEmployee(Employee emp)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(emp);
            }
        }
    }
}
