using ComandaZap.Models;
using ComandaZap.Repository;
using ComandaZap.ViewModel;
using System.Linq;

namespace ComandaZap.Services.Commands
{
    public class GetAllUsersCommand
    {
        private readonly IRepository<User> Repository;
        public GetAllUsersCommand(IRepository<User> repository)
        {
            Repository = repository;
        }

        public Output<IEnumerable<UserViewModel>> Handle()
        {
            var result = Repository.GetAll()
                .Select(user => new UserViewModel { Email = user.UserName ?? user.Email ?? "", Id = user.Id });
            return Output<IEnumerable<UserViewModel>>.Success(result);
        }
    }
}
