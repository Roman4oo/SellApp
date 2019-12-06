using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SellerApp.Repositories.Concrete
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DbContext context) : base(context)
        {

        }
    }
}
