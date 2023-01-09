using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ComandaZap.Data
{
    public static class RolesInitializer
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            string[] roles = { "Customer", "Company" };
            foreach (string role in roles)
            {
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole(role));
            }
        }
    }
}
