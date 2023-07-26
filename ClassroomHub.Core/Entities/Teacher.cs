using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    public class Teacher : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Especializacao { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<Module> Modules { get; set; }
    }
}
