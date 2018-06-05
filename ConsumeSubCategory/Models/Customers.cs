using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Customers
    {
        public Customers()
        {
            AddToCart = new HashSet<AddToCart>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerMailId { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerLocation { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerGender { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<AddToCart> AddToCart { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
