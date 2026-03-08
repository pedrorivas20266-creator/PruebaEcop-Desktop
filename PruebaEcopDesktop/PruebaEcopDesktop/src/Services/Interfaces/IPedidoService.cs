using PruebaECOP.Models.Requests;
using System.Threading.Tasks;

namespace PruebaECOP.Services.Interfaces
{
    public interface IPedidoService
    {
        Task<bool> CreatePedido(PedidoRequest request);
    }
}