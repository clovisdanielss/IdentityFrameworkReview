using System.ComponentModel.DataAnnotations;

namespace ComandaZap.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres. ", MinimumLength = 6)]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage ="A senha está diferente.")]
        public string ConfirmPassword { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
