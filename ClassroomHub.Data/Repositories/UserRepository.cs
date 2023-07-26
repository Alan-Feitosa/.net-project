using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }
    }
}
