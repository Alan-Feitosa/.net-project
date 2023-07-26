using ClassroomHub.Core.Entities;
using System.Collections.Generic;
namespace ClassroomHub.Core.Contracts.Repositories
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        IEnumerable<Teacher> GetFullTeachers();
    }
}
