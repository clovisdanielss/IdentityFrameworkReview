using ComandaZap.Data;
using ComandaZap.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ComandaZap.Repository
{
    public abstract class IRepository<T> where T : class, IEntity
    {
        protected DbContext Context;

        public IRepository(ApplicationContext context)
        {
            Context = context;
        }

        public virtual List<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> dbset = Context.Set<T>();
            if (includes.Length != 0)
            {
                foreach (var include in includes)
                {
                    dbset = dbset.Include(include);
                }
            }
            return dbset.ToList();
        }

        public virtual IQueryable<T> Query()
        {
            return Context.Set<T>();
        }

        public virtual bool Add(T item)
        {
            Context.Set<T>().Add(item);
            var anyChange = Context.SaveChanges() > 0;
            return anyChange;
        }

        public virtual T Delete(T item)
        {
            var itemDeleted = Context.Set<T>().Remove(item);
            Context.SaveChanges();
            return itemDeleted.Entity;
        }

        public virtual T? GetById(string id)
        {
            var dbset = Context.Set<T>();
            var item = dbset.FirstOrDefault(item => item.Id == id);
            return item;
        }

        public virtual void Update(T item)
        {
            var dbset = Context.Set<T>();
            dbset.Update(item);
            Context.SaveChanges();
        }

    }
}
