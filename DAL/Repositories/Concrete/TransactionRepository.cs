using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SellerApp.Repositories.Concrete
{
    public class TransactionRepository : BaseRepository<Transaction>
    {
        public TransactionRepository(DbContext context) : base(context)
        {
            
        }
    }
}
