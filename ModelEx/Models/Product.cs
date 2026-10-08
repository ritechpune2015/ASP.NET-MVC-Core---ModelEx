using System;

namespace ModelEx.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            this.ProductID = 121;
            this.ProductName = "Mouse";
            this.MfgName = "Intex";
            this.Price = 550;
        }
    }
}
