using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SellerApp.Repositories.Concrete
{
    public class ProductTransactionRepository : BaseRepository<ProductTransaction>
    {
        public ProductTransactionRepository(DbContext context) : base(context)
        {

        }
    }
}
