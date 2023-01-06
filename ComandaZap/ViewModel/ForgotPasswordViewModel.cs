using System.ComponentModel.DataAnnotations;

namespace ComandaZap.ViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
