using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Models
{
    public partial class Employee
    {
        [ResultColumn]
        public string Name { get; set; }

        [ResultColumn]
        public int Designation { get; set; }

        [ResultColumn]
        public int Role { get; set; }

        [ResultColumn]
        public int AllowLogin { get; set; }

        [ResultColumn]
        public string LoginId { get; set; }

        [ResultColumn]
        public string Password { get; set; }

        [ResultColumn]
        public int IsDeleted { get; set; }

        [ResultColumn]
        public int CreatedBy { get; set; }

        [ResultColumn]
        public DateTime CreatedOn { get; set; }

        [ResultColumn]
        public DateTime ModifiedOn { get; set; }

        [ResultColumn]
        public int ModifiedBy { get; set; }
    }
}
