using PruebaECOP.Api.Helpers;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaECOP.Api.Clients
{
    public class PedidoClient : IPedidoClient
    {
        private readonly HttpClient _httpClient;

        public PedidoClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreatePedido(PedidoRequest request)
        {
            try
            {
                await HttpHelper.PostAsync<PedidoResponse>(_httpClient, "/api/pedidos", request);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear pedido: {ex.Message}", ex);
            }
        }

        public async Task<PedidoResponsePaginatedResponse> GetPedidos(string busqueda, DateTime? fechaDesde, DateTime? fechaHasta, int pageNumber, int pageSize)
        {
            var url = "/api/pedidos?pageNumber=" + pageNumber + "&pageSize=" + pageSize;
            if (!string.IsNullOrEmpty(busqueda))
                url += "&busqueda=" + busqueda;
            if (fechaDesde.HasValue)
                url += "&fechaDesde=" + fechaDesde.Value.ToString("o");
            if (fechaHasta.HasValue)
                url += "&fechaHasta=" + fechaHasta.Value.ToString("o");
            return await HttpHelper.GetAsync<PedidoResponsePaginatedResponse>(_httpClient, url);
        }

        public async Task<PedidoResponse> GetPedidoById(int codigoPedido)
        {
            var url = "/api/pedidos/" + codigoPedido;
            return await HttpHelper.GetAsync<PedidoResponse>(_httpClient, url);
        }

        public async Task<PedidoResponse> AnularPedido(int codigoPedido, AnularPedidoRequest request)
        {
            var url = "/api/pedidos/" + codigoPedido + "/anular";
            return await HttpHelper.PutAsync<PedidoResponse>(_httpClient, url, request);
        }
    }
}