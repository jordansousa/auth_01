using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Services
{
    public class AuthService : IAuthService
    {
        public bool ValidateLogin(string Username, string Password)
        {
            return Username == "admin" && Password == "password";
        }
    }
}