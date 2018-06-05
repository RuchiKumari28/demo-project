using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class SupplyOrder
    {
        public int SuppOrderId { get; set; }
        public string ProdCode { get; set; }
        public string ProdName { get; set; }
        public int? OrderQty { get; set; }
        public int? SuppliedQty { get; set; }
        public int? SuppliedProdPrice { get; set; }
        public string SuppliedStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
        public string SuppOrderCode { get; set; }
        public int? ProcessOrderId { get; set; }

        public ProcessOrder ProcessOrder { get; set; }
    }
}
