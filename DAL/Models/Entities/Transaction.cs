using System;
using System.Collections.Generic;

namespace SellerApp
{
    public partial class Transaction
    {
        public Transaction()
        {
            ProductsTransactions = new HashSet<ProductTransaction>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ProductTransaction> ProductsTransactions { get; set; }
    }
}
