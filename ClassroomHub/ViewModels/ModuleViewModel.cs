using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class ModuleViewModel
    {
        public Guid Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Nome do módulo obrigatório")]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Carga horária")]
        [Required(ErrorMessage = "Defina a carga horária")]
        public int Hours { get; set; }

        [DisplayName("Início")]
        [Required]
        [DisplayFormat(DataFormatString ="0:d")]
        public DateTime Start { get; set; }

        [DisplayName("Encerramento")]
        [Required]
        [DisplayFormat(DataFormatString ="0:d")]
        public DateTime End { get; set; }

        [Required(ErrorMessage = "Selecione o professor")]

        public Guid TeacherId { get; set; }

        [DisplayName("Professor")]        
        public string TeacherName { get; set; }
    }
}
