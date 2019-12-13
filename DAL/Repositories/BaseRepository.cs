using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SellerApp.Repositories
{
    abstract public class BaseRepository<TEntity> where TEntity: class
    {
        private readonly DbContext _context;
        protected readonly DbSet<TEntity> _entities;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public virtual TEntity Add(TEntity entity)
        {
            return _entities.Add(entity).Entity;
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            _entities.AddRange(entities);
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return _entities.Where(expression).ToList();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public virtual TEntity Get(int id)
        {
            return _entities.Find(id);
        }

        public virtual void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }
        public virtual TEntity Remove(params object[] keys)
        {
            var model = _entities.Find(keys);
            if (model != null)
            {
                model = _entities.Remove(model).Entity;
            }

            return model;
        }

        public void RemoveRange(IEnumerable<TEntity> range)
        {
            _entities.RemoveRange(range);
        }

        public virtual IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> expression)
        {
            return  _entities.Where(expression).ToList();
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            return _entities.SingleOrDefault(expression);
        }

        public virtual void Update(TEntity entity)
        {
            _entities.Update(entity);
        }
    }
}
