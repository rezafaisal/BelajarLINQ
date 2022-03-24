using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.MySQL
{
    public partial class SalesTotalsByAmount
    {
        public double? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
