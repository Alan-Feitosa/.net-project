using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    public class Student : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }        
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
