using System;

namespace ClassroomHub.Core.Entities
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
