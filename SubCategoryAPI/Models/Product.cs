using System;
using System.Collections.Generic;

namespace SubCategoryAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            Inventory = new HashSet<Inventory>();
            OrderDetails = new HashSet<OrderDetails>();
            Status = new HashSet<Status>();
        }

        public int ProdId { get; set; }
        public int? CatId { get; set; }
        public string ProdCode { get; set; }
        public string ProdName { get; set; }
        public byte[] ProdImage { get; set; }
        public string ProdDesc { get; set; }
        public int? ProdQty { get; set; }
        public int? ProdPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? ReOrderlvl { get; set; }

        public Category Cat { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<Status> Status { get; set; }
    }
}
