using PruebaECOP.Api.Helpers;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaECOP.Api.Clients
{
    public class AuthClient : IAuthClient
    {
        private readonly HttpClient _http;

        public AuthClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            var url = "/api/v1/auth/login";
            return await HttpHelper.PostAsync<LoginResponse>(_http, url, request);
        }
    }
}