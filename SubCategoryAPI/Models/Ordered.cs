using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class Ordered
    {
        public Ordered()
        {
            CustInvoice = new HashSet<CustInvoice>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public Customer User { get; set; }
        public ICollection<CustInvoice> CustInvoice { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
