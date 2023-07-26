using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClassroomHub.Data.Repositories
{
    public sealed class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(Context context) : base(context) { }

        public IEnumerable<Teacher> GetFullTeachers()
        {
            return this.Get().Include(x => x.User);
        }
    }
}
