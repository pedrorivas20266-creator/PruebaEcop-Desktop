using System.Threading.Tasks;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;
using PruebaECOP.Services.Interfaces;

namespace PruebaECOP.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthClient _authClient;

        public AuthService(IAuthClient authClient)
        {
            _authClient = authClient;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            return await _authClient.Login(request);
        }
    }
}