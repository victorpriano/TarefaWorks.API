using Microsoft.EntityFrameworkCore;
using TarefaWorks.API.Data;
using TarefaWorks.API.Models;

namespace TarefaWorks.API.Repositories
{
    public class LoginUser : ILoginUser
    {
        private readonly DataContext _context;
        public LoginUser(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers(string username, string password)
        {
            return _context.Users.AsNoTracking().Where(x => x.UserName == username && x.Password == password);
        }

        public void Login(User user)
        {
            _context.Add(user);
        }
    }
}
