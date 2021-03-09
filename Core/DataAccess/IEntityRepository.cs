using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T GetById(T entity);    
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        T Get(Expression<Func<T, bool>> filter);

        //void GetCarsByBrandId(T entity);
        T GetCarsByBrandId(Expression<Func<T, bool>> filter = null);
        T GetCarsByColorId(Expression<Func<T, bool>> filter);



    }
}
