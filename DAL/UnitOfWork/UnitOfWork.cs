using Microsoft.EntityFrameworkCore;
using SellerApp;
using SellerApp.Repositories.Concrete;
using System;

namespace DAL.UnitOfWork
{
    public class UnitOfWork
    {

        private readonly DbContext _context;
        private bool _disposed = false;

        private ProductRepository _productRepository;
        private UserRepository _userRepository;
        private RoleRepository _roleRepository;
        private TransactionRepository _transactionRepository;
        private ProductTransactionRepository _productTransactionRepository;

        public UnitOfWork(SellAppContext sellAppContext)
        {
            _context = sellAppContext;
        }

        public ProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_context);

                return _productRepository;
            }
        }
        public UserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_context);

                return _userRepository;
            }

        }

        public RoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                    _roleRepository = new RoleRepository(_context);

                return _roleRepository;
            }

        }

        public TransactionRepository TransactionRepository
        {
            get
            {
                if (_transactionRepository == null)
                    _transactionRepository = new TransactionRepository(_context);

                return _transactionRepository;
            }

        }

        public ProductTransactionRepository ProductTransactionRepository
        {
            get
            {
                if (_productTransactionRepository == null)
                    _productTransactionRepository = new ProductTransactionRepository(_context);

                return _productTransactionRepository;
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Complete()
        {
            _context.SaveChanges();
        }

    }
}
