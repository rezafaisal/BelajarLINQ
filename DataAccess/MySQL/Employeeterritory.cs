using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.MySQL
{
    public partial class Employeeterritory
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
