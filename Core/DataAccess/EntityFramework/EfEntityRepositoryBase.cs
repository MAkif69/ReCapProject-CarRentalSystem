using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext rentalDBContex = new TContext())
            {
                var addedEntity = rentalDBContex.Entry(entity);
                addedEntity.State = EntityState.Added;
                rentalDBContex.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext rentalDBContex = new TContext())
            {
                var deletedEntity = rentalDBContex.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                rentalDBContex.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            };
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(TEntity entity)
        {
            throw new NotImplementedException();
        }

        //public List<TEntity> GetById(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        public TEntity GetCarsByBrandId(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public TEntity GetCarsByColorId(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            using (TContext rentalDBContex = new TContext())
            {
                var updatedEntity = rentalDBContex.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                rentalDBContex.SaveChanges();
            }
        }
    }
}
