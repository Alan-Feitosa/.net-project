using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    public class Class : EntityBase
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Student> Students { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
