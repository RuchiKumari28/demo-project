
using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class SubCategory
    {
        public int SubCatId { get; set; }
        
        public string SubCatName { get; set; }
        public int? CatId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }

        public Category Cat { get; set; }
    }
}
