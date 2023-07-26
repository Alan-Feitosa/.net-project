using System;

namespace ClassroomHub.Web.ViewModels
{
    public class ActivityToStudentViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int ActivityScore { get; set; }
        public string TeacherName { get; set; }
        public string ModuleName { get; set; }
    }
}
