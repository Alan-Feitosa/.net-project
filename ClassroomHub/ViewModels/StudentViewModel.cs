namespace ClassroomHub.Web.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class StudentViewModel
    {
        public Guid Id { get; set; }

        [Display(Name= "Nome")]
        [Required(ErrorMessage ="Nome do aluno é obrigatório.")]
        public string Name { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        public string Surname { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime Birthday { get; set; }

        [DisplayName("Turma")]
        [Required(ErrorMessage = "Selecione uma turma")]
        public Guid ClassId { get; set; }

        [DisplayName("Usuário")]
        [Required(ErrorMessage ="Selecione um usuário")]
        public Guid UserId { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

    }
}
