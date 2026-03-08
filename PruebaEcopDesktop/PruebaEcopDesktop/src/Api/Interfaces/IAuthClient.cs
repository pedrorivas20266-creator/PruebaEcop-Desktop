using System.Threading.Tasks;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;

namespace PruebaECOP.Api.Interfaces
{
    public interface IAuthClient
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}