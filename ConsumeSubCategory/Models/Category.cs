using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Category
    {
        public Category()
        {
            Inventory = new HashSet<Inventory>();
            Product = new HashSet<Product>();
            SubCategory = new HashSet<SubCategory>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<SubCategory> SubCategory { get; set; }
    }
}
