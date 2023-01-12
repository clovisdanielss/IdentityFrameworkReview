using Microsoft.AspNetCore.Identity;

namespace ComandaZap.Models
{
    public class User: IdentityUser, IEntity
    {
        public string? FullName { get; set; }
    }
}
