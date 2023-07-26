using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _teacherRepository.GetFullTeachers();
        }

        public void Create(Teacher teacher)
        {
            _teacherRepository.Add(teacher);
        }
    }
}
