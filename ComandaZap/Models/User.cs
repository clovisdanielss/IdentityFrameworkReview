using Microsoft.AspNetCore.Identity;

namespace ComandaZap.Models
{
    public class User: IdentityUser
    {
        public string? FullName { get; set; }
    }
}
