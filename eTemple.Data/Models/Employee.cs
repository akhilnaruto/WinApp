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
        public string RoleName { get; set; }

        [ResultColumn]
        public string DesignationName { get; set; }
    }
}
