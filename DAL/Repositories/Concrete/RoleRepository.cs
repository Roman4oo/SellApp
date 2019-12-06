using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SellerApp.Repositories.Concrete
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(DbContext context) : base(context)
        {

        }
    }
}
