using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class ProcessOrder
    {
        public ProcessOrder()
        {
            SupplyOrder = new HashSet<SupplyOrder>();
        }

        public int ProcessOrderId { get; set; }
        public string ProcessOrderCode { get; set; }
        public int? ProdId { get; set; }
        public string ProdCode { get; set; }
        public string ProdName { get; set; }
        public int? SuppId { get; set; }
        public int? ProdRequiredQty { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }

        public Supplier Prod { get; set; }
        public Supplier Supp { get; set; }
        public ICollection<SupplyOrder> SupplyOrder { get; set; }
    }
}
