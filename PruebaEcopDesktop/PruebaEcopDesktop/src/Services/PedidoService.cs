using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;
using PruebaECOP.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PruebaECOP.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoClient _pedidoClient;

        public PedidoService(IPedidoClient pedidoClient)
        {
            _pedidoClient = pedidoClient;
        }

        public async Task<PedidoResponsePaginatedResponse> GetPedidos(string busqueda = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null, int pageNumber = 1, int pageSize = 10)
        {
            return await _pedidoClient.GetPedidos(busqueda, fechaDesde, fechaHasta, pageNumber, pageSize);
        }

        public async Task<bool> CreatePedido(PedidoRequest request)
        {
            try
            {
                return await _pedidoClient.CreatePedido(request);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el servicio de pedidos: {ex.Message}", ex);
            }
        }

        public async Task<PedidoResponse> GetPedidoById(int codigoPedido)
        {
            return await _pedidoClient.GetPedidoById(codigoPedido);
        }

        public async Task<PedidoResponse> AnularPedido(int codigoPedido, AnularPedidoRequest request)
        {
            return await _pedidoClient.AnularPedido(codigoPedido, request);
        }
    }
}