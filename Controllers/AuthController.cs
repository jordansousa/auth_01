using Microsoft.AspNetCore.Mvc;
using AuthenticationService.Services;
using AuthenticationService.Models;

namespace AuthenticationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            if (_authService.ValidateLogin(user.Username, user.Password))
            {
                // Usuário autenticado com sucesso
                return Ok("Login bem sucedido");
            }
            else
            {
                // Usuário nao autenticado.
                return Unauthorized("Usuário ou senha incorretos. Tente novamente.");
            }
        }
    }
}
