using System;
using System.Collections.Generic;

namespace ClassroomHub.Core.Entities
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Class> Classes { get; set; }        
    }
}
