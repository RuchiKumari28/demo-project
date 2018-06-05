using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            ProcessOrder = new HashSet<ProcessOrder>();
        }

        public int SuppId { get; set; }
        public string SuppCode { get; set; }
        public string SuppName { get; set; }
        public string SuppAddress { get; set; }
        public string SuppPhone { get; set; }
        public string SuppPassword { get; set; }
        public string SuppEmailId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<ProcessOrder> ProcessOrder { get; set; }
    }
}
