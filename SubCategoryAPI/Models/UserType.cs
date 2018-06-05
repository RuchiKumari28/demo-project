using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class UserType
    {
        public int UserTypeId { get; set; }
        public string UserType1 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
