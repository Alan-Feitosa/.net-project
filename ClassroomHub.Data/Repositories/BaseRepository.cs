using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        private readonly Context _context;
        public BaseRepository(Context context)
        {
            this._context = context;
        }

        public void Add(T entity) 
        {
            var dbSet = this._context.Set<T>();
            dbSet.Add(entity);
            this._context.SaveChanges();
        }

        public T GetById(Guid id)
        {
            return this._context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<T> Get() => this._context.Set<T>(); 

        public IEnumerable<T> GetAll()
        {
            return this.Get();
        }
        public void Update(T entity) {
            this._context.Set<T>().Update(entity); 
            this._context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = this.GetById(id);
            if (entity != null)
            {
                this._context.Remove(entity);
                this._context.SaveChanges();
            }
        }

    }
}
