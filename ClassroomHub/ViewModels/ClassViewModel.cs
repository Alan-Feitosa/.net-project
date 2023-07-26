using System;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class ClassViewModel
    {
        public Guid Id { get; set; }

        [Display(Name="Nome")]
        [Required(ErrorMessage = "Obrigatório definir um nome para a turma.")]
        public string Name { get; set; }

        [Display(Name="Inicio")]
        [DisplayFormat(DataFormatString ="{0:D}")]
        [Required(ErrorMessage = "Obrigatório definir o inicio da turma.")]
        public DateTime Start { get; set; }

        [Display(Name="Conclusão")]
        [DisplayFormat(DataFormatString = "{0:D}")]
        [Required(ErrorMessage = "Obrigatório definir o fim da turma.")]
        public DateTime End { get; set; }

        [Display(Name="Curso")]
        [Required(ErrorMessage ="Obrigatório selecionar uma opção de curso.")]
        public Guid CourseId { get; set; }
    }
}
