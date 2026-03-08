using PruebaECOP.Api.Helpers;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Dtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaECOP.Api.Clients
{
    public class ClienteClient : IClienteClient
    {
        private readonly HttpClient _http;

        public ClienteClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Cliente>> GetClientes(string busqueda, int? limite)
        {
            var url = "/api/clientes?";
            if (!string.IsNullOrEmpty(busqueda))
                url += "busqueda=" + busqueda + "&";
            if (limite.HasValue)
                url += "limite=" + limite.Value;
            return await HttpHelper.GetAsync<List<Cliente>>(_http, url);
        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            var url = "/api/clientes";
            return await HttpHelper.PostAsync<Cliente>(_http, url, cliente);
        }

        public async Task<List<Cliente>> GetClientesActivos()
        {
            var url = "/api/clientes/activos";
            return await HttpHelper.GetAsync<List<Cliente>>(_http, url);
        }

        public async Task<Cliente> GetClienteById(int codigoCliente)
        {
            var url = "/api/clientes/" + codigoCliente;
            return await HttpHelper.GetAsync<Cliente>(_http, url);
        }

        public async Task<Cliente> UpdateCliente(int codigoCliente, Cliente cliente)
        {
            var url = "/api/clientes/" + codigoCliente;
            return await HttpHelper.PutAsync<Cliente>(_http, url, cliente);
        }

        public async Task DeleteCliente(int codigoCliente)
        {
            var url = "/api/clientes/" + codigoCliente;
            await HttpHelper.DeleteAsync(_http, url);
        }
    }
}