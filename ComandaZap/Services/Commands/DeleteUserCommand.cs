using ComandaZap.Models;
using ComandaZap.Repository;
using ComandaZap.ViewModel;

namespace ComandaZap.Services.Commands
{
    public class DeleteUserCommand
    {
        private readonly IRepository<User> Repository;
        public DeleteUserCommand(IRepository<User> repository)
        {
            Repository= repository;
        }

        public Output<string> Handle(string userId)
        {
            var userFound = Repository.GetById(userId);
            if (userFound != null)
            {
                var result = Repository.Delete(userFound);
                if(result != null)
                {
                    return Output<string>.Success(userId);
                }
                return Output<string>.Failure(userId).AddMessage("Não foi possível deletar o usuário");
            }
            else
            {
                return Output<string>.Failure(userId).AddMessage("Usuário não encontrado");
            }
        }
    }
}
