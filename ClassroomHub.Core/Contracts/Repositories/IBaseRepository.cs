using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Core.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        void Add(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(Guid id);
        IQueryable<T> Get();
    }
}
