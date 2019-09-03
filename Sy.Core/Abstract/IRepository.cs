using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstract
{

    public interface  IRepository <TEntity, TKey> where  TEntity : IEntity<TKey>
    {
        TEntity GetById(TKey id);
        TKey Insert(TEntity entity);
        int UPdate(TEntity entity);
        int Delete(TEntity entity);
        int Save();
        IQueryable<TEntity> Query(Expression<Func<TEntity,bool>> predicate =null);//geriye entity tipinde değer döndürüyor,null default olarak atanıyor




    }
}
