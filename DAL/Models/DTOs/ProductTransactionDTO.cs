using SellerApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DTOs
{
    public class ProductTransactionDTO
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? TransactionId { get; set; }
    }
}
