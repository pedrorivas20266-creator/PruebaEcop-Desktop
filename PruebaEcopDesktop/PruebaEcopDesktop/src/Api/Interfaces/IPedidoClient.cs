using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;
using System;
using System.Threading.Tasks;

namespace PruebaECOP.Api.Interfaces
{
    public interface IPedidoClient
    {
        Task<bool> CreatePedido(PedidoRequest request);
        Task<PedidoResponsePaginatedResponse> GetPedidos(string busqueda, DateTime? fechaDesde, DateTime? fechaHasta, int pageNumber, int pageSize);
        Task<PedidoResponse> GetPedidoById(int codigoPedido);
        Task<PedidoResponse> AnularPedido(int codigoPedido, AnularPedidoRequest request);
    }
}