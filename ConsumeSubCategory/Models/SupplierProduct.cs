using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class SupplierProduct
    {
        public int SuppProdId { get; set; }
        public string ProdCode { get; set; }
        public string ProdName { get; set; }
        public string ProdDesc { get; set; }
        public int? ProdAvailableQty { get; set; }
        public string ProcessOrderCode { get; set; }
        public int? ProdPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
