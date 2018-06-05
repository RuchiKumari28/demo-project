using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            CustInvoice = new HashSet<CustInvoice>();
        }

        public int OrderDetailsId { get; set; }
        public int? OrderId { get; set; }
        public int? ProdId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public string QtyPurchased { get; set; }

        public Ordered Order { get; set; }
        public Product Prod { get; set; }
        public ICollection<CustInvoice> CustInvoice { get; set; }
    }
}
