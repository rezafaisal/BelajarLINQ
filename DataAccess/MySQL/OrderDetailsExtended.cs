﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.MySQL
{
    public partial class OrderDetailsExtended
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public double? ExtendedPrice { get; set; }
    }
}
