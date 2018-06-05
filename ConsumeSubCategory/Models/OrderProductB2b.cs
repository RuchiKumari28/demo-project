using System;
using System.Collections.Generic;

namespace ConsumeSubCategory.Models
{
    public partial class OrderProductB2b
    {
        public int OrderProdB2bid { get; set; }
        public string ProcessOrderCode { get; set; }
        public int? ProdId { get; set; }
        public int? RequiredQty { get; set; }

        public ProcessOrder ProcessOrderCodeNavigation { get; set; }
        public Product Prod { get; set; }
    }
}
