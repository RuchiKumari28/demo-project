using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class Status
    {
        public int StatusId { get; set; }
        public int? ProdId { get; set; }
        public string StatusCode { get; set; }
        public string ProdStatus { get; set; }
        public string StatusDesc { get; set; }

        public Product Prod { get; set; }
    }
}
