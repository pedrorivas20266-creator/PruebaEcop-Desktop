using System.Threading.Tasks;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;

namespace PruebaECOP.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}