using System;
using System.Collections.Generic;

namespace SellerApp
{
    public partial class Product
    {
        public Product()
        {
            ProductsTransactions = new HashSet<ProductTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public bool IsSold { get; set; }

        public virtual ICollection<ProductTransaction> ProductsTransactions { get; set; }
    }
}
