using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void Add(Course course)
        {
            _courseRepository.Add(course);
        }

        public IEnumerable<Course> GetAll() => _courseRepository.GetAll();

        public Course GetById(Guid id)
        {
            var courseBd = _courseRepository.GetById(id);
            if (courseBd is null)
            {
                return new Course();
            }

            return courseBd;
        }

        public void Update(Course course)
        {
            //ter ferramentas de validação
            _courseRepository.Update(course);
        }

        public void Delete(Guid id)
        {
            _courseRepository.Delete(id);
        }
    }
}
