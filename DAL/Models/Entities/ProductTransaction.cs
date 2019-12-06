using System;
using System.Collections.Generic;

namespace SellerApp
{
    public partial class ProductTransaction
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? TransactionId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
