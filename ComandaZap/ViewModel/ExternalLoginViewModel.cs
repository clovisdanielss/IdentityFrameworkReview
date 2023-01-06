using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ComandaZap.ViewModel
{
    public class ExternalLoginViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("Nome Completo")]
        public string FullName { get; set; }
    }
}
