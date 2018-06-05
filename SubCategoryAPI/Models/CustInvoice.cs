using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class CustInvoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceCode { get; set; }
        public int? OrderId { get; set; }
        public int? OrderDetailsId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public Ordered Order { get; set; }
        public OrderDetails OrderDetails { get; set; }
    }
}
