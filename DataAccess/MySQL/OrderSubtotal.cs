using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.MySQL
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public double? Subtotal { get; set; }
    }
}
