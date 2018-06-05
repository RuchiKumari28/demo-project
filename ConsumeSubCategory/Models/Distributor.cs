using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Distributor
    {
        public int DistId { get; set; }
        public string DistPassword { get; set; }
        public string DistName { get; set; }
        public string DistAddress { get; set; }
        public int? DistPhone { get; set; }
        public string DistEmailId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
