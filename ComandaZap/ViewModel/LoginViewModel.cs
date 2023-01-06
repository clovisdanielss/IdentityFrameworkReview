using System.ComponentModel.DataAnnotations;

namespace ComandaZap.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Lembrar de mim ?")]
        public bool RememberMe { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
