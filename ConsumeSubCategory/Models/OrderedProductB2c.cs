using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class OrderedProductB2c
    {
        public int OrderedProductId { get; set; }
        public int? OrderId { get; set; }
        public int? ProdId { get; set; }
        public int? PurchasedQty { get; set; }
        public decimal? TotalPrice { get; set; }

        public OrderDetails Order { get; set; }
        public Product Prod { get; set; }
    }
}
