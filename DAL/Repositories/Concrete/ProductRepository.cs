using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SellerApp.Repositories.Concrete
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(DbContext context) : base(context)
        {

        }
    }
}
