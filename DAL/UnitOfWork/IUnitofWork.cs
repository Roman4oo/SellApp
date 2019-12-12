using SellerApp.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        ProductRepository ProductRepository { get; }
        UserRepository UserRepository { get; }
        TransactionRepository TransactionRepository { get; }
        RoleRepository RoleRepository { get; }
        void Dispose();
        void Complete();

    }
}
