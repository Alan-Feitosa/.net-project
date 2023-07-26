using ClassroomHub.Core.Entities;
using ClassroomHub.Core.Contracts.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClassroomHub.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        
        public StudentRepository(Context context) : base(context)
        {
        }

        public IEnumerable<Student> GetFullStudents()
        {
           return this.Get().Include(x => x.User);
        }
    }
}
