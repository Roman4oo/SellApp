using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SellerApp.Repositories.Concrete
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(DbContext context) : base(context)
        {

        }
        public override IEnumerable<Product> GetAll()
        {
            return _entities.Include(ent => ent.ProductsTransactions).ToList();
        }
    }
}
