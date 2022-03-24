using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.MySQL
{
    public partial class Customerdemographic
    {
        public Customerdemographic()
        {
            Customercustomerdemos = new HashSet<Customercustomerdemo>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<Customercustomerdemo> Customercustomerdemos { get; set; }
    }
}
