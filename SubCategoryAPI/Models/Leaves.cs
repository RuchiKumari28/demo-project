using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class Leaves
    {
        public int LeaveId { get; set; }
        public string LeaveCode { get; set; }
        public string LeaveType { get; set; }
        public int? NumberOfLeaves { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
