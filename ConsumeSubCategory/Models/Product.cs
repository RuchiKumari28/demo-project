using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Product
    {
        public Product()
        {
            AddToCart = new HashSet<AddToCart>();
            Inventory = new HashSet<Inventory>();
            OrderProductB2b = new HashSet<OrderProductB2b>();
            OrderedProductB2c = new HashSet<OrderedProductB2c>();
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
        public int? SubCatId { get; set; }

        public Category Cat { get; set; }
        public SubCategory SubCat { get; set; }
        public ICollection<AddToCart> AddToCart { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<OrderProductB2b> OrderProductB2b { get; set; }
        public ICollection<OrderedProductB2c> OrderedProductB2c { get; set; }
        public ICollection<Status> Status { get; set; }
    }
}
