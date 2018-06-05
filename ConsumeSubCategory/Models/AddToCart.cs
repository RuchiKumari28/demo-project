using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class AddToCart
    {
        public int CartId { get; set; }
        public string OrderNumber { get; set; }
        public int? CustomerId { get; set; }
        public int? ProdId { get; set; }
        public int? PurchasedQuantity { get; set; }
        public DateTime? OrderDate { get; set; }

        public Customers Customer { get; set; }
        public Product Prod { get; set; }
    }
}
