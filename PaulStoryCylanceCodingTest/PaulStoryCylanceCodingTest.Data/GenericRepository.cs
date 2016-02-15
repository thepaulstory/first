using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace PaulStoryCylanceCodingTest.Data
{
    public class GenericRepository<T> : IRepository<T>
        where T : class
    {
        #region Properties
        protected DbSet<T> DBSet { get; set; } = null;
        protected DbContext Context { get; set; } = null;
        #endregion

        #region Constructor
        public GenericRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.Context = context;
            this.DBSet = this.Context.Set<T>();
        }
        #endregion

        #region Methods
        public void Add(T entity)
        {
            var entry = this.Context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DBSet.Add(entity);
            }
        }

        public void Update(T entity)
        {
            var entry = this.Context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.DBSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            this.Delete(GetById(id));
        }

        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            var entry = Context.Entry(entity);

            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.DBSet.Attach(entity);
                this.DBSet.Remove(entity);
            }

        }

        public void Detach(T entity)
        {
            var entry = Context.Entry(entity);
            entry.State = EntityState.Detached;
        }

        public IQueryable<T> GetAll()
        {
            return this.DBSet;
        }

        public T GetById(int id)
        {
            return this.DBSet.Find(id);
        }

        #endregion
    }
}
