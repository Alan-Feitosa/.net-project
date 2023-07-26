using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System.Runtime.CompilerServices;

namespace ClassroomHub.Data.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        
        public CourseRepository(Context context) : base(context)
        {            
        }

    }
}
