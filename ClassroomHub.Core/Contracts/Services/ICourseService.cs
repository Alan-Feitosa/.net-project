using System;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAll();
        void Add(Course course);        

        void Update(Course course);
        Course GetById(Guid id);

        void Delete(Guid id);
    }
}
