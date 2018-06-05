using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class ProcessOrder
    {
        public ProcessOrder()
        {
            OrderProductB2b = new HashSet<OrderProductB2b>();
        }

        public int ProcessOrderId { get; set; }
        public string ProcessOrderCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? SuppId { get; set; }

        public Supplier Supp { get; set; }
        public ICollection<OrderProductB2b> OrderProductB2b { get; set; }
    }
}
