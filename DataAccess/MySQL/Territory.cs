using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.MySQL
{
    public partial class Territory
    {
        public Territory()
        {
            Employeeterritories = new HashSet<Employeeterritory>();
        }

        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Employeeterritory> Employeeterritories { get; set; }
    }
}
