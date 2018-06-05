using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public string InventoryCode { get; set; }
        public int? CatId { get; set; }
        public int? ProdId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public Category Cat { get; set; }
        public Product Prod { get; set; }
    }
}
