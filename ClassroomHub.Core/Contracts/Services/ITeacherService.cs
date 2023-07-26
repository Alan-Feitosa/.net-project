using System.Collections.Generic;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAll();
        void Create(Teacher teacher);
    }
}
