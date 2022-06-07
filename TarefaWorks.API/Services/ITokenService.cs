using TarefaWorks.API.Models;

namespace TarefaWorks.API.Services
{
    public interface ITokenService
    {
        string GerarToken(User user);
    }
}
