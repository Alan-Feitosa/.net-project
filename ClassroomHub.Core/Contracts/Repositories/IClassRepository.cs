using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Contracts.Repositories
{
    public interface IClassRepository : IBaseRepository<Class>
    {
        IEnumerable<Class> GetClassesByCourseId(Guid courseId);
    }
}
