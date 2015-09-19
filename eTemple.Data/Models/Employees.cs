using eTemple.Data.Repositories;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Employees : IEntity
    {
        
        public string Name { get; set; }

        
        public int Designation { get; set; }

        
        public int Role { get; set; }

        
        public int AllowLogin { get; set; }

        
        public string LoginId { get; set; }

        
        public string Password { get; set; }

        
        public int IsDeleted { get; set; }

        
        public int CreatedBy { get; set; }

        
        public DateTime CreatedOn { get; set; }

        
        public DateTime ModifiedOn { get; set; }

        
        public int ModifiedBy { get; set; }
    }
}
