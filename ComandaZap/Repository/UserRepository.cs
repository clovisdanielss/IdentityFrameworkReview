using ComandaZap.Data;
using ComandaZap.Models;

namespace ComandaZap.Repository
{
    public class UserRepository : IRepository<User>
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
