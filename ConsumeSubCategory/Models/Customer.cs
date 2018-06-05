using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Customer
    {
        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmailId { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public string UserLocation { get; set; }
        public string UserPermnntAddress { get; set; }
        public string UserCorrspndnceAddress { get; set; }
        public string UserGender { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
