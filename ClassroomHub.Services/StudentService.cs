using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Add(Student student)
        {
            //outras validações
            _studentRepository.Add(student);
        }

        public IEnumerable<Student> GetAll() => _studentRepository.GetAll();

    }
}
