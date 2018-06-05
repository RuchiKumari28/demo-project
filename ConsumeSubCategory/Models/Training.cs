using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Training
    {
        public int TrainingId { get; set; }
        public string TrainingCode { get; set; }
        public string TrainingType { get; set; }
        public string TrainingDuration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
