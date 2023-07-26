using ClassroomHub.Core.Entities;
using System.Collections.Generic;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        void Add(Student student);
    }
}
