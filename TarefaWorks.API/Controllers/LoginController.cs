using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarefaWorks.API.Data;
using TarefaWorks.API.Models;
using TarefaWorks.API.Repositories;
using TarefaWorks.API.Services;

namespace TarefaWorks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginUser _login;
        private readonly ITokenService _token;
        public LoginController(ILoginUser login, ITokenService token)
        {
            _login = login;
            _token = token;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<dynamic> Login([FromBody] User user)
        {
            var exists = _login.GetUsers(user.UserName, user.Password);

            if(exists != null)
            {
                var token = _token.GerarToken(user);

                return new { token = token };
            }
            else
            {
                return BadRequest("Login inválido!");
            }
        }
    }
}
