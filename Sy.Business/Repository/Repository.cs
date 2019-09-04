using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Sy.Core.Abstract;
using Sy.DataAccess;

namespace Sy.Business.Repository
{
    //repository oluşturuyorsun artık istediğin kadar class oluşturabilrsin
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> 
        where TEntity :class, IEntity<TKey>//Tentity i class yapabilmek için önüne class yazdık
    {
        private readonly StockDb _context;
        private readonly DbSet<TEntity> _table;
        public Repository()
        {
            _context = new StockDb();
            _table = _context.Set<TEntity>();
        }

        public int Delete(TEntity entity)
        {
            _table.Remove(entity);
            return this.Save();
        }

        public TEntity GetById(TKey id)
        {
            return _table.Find(id);
        }

        public TKey Insert(TEntity entity)
        {
            _table.Add(entity);
            this.Save();
            return entity.Id;
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null ? _table : _table.Where(predicate);
        }

        public int Save()
        {
            return _context.SaveChanges();        }

        public int UPdate(TEntity entity)
        {
            _table.AddOrUpdate(entity);
            return this.Save();
        }
    }
}
