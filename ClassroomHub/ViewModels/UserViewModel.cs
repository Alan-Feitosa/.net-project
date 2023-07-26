using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome de usuário")]
        [Required(AllowEmptyStrings = false,ErrorMessage ="Nome de usuário obrigatório")]
        public string UserName { get; set; }

        [Display(Name ="Senha")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Senha obrigatória")]
        [PasswordPropertyText(true)]
        public string Password { get; set; }

        public bool IsTeacher { get; set; }
    }
}
