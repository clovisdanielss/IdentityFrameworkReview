using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ComandaZap.Controllers
{
    public class RegisterController: Controller
    {
        private UserManager<IdentityUser> UserManager;
        public RegisterController(UserManager<IdentityUser> userManager)
        {
            UserManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }
    }
}
