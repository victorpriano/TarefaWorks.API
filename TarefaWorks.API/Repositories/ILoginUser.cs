using TarefaWorks.API.Models;

namespace TarefaWorks.API.Repositories
{
    public interface ILoginUser
    {
        void Login(User user);
        IEnumerable<User> GetUsers(string username, string password);
    }
}
