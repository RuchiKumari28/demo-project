using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            OrderedProductB2c = new HashSet<OrderedProductB2c>();
        }

        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string InvoiceNo { get; set; }

        public Customers Customer { get; set; }
        public ICollection<OrderedProductB2c> OrderedProductB2c { get; set; }
    }
}
