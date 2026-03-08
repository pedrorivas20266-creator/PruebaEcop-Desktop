using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Dtos;
using PruebaECOP.Services.Interfaces;

namespace PruebaECOP.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteClient _clienteClient;

        public ClienteService(IClienteClient clienteClient)
        {
            _clienteClient = clienteClient;
        }

        public async Task<List<Cliente>> GetClientes(string busqueda = null, int? limite = null)
        {
            return await _clienteClient.GetClientes(busqueda, limite);
        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            return await _clienteClient.CreateCliente(cliente);
        }

        public async Task<List<Cliente>> GetClientesActivos()
        {
            return await _clienteClient.GetClientesActivos();
        }

        public async Task<Cliente> GetClienteById(int codigoCliente)
        {
            return await _clienteClient.GetClienteById(codigoCliente);
        }

        public async Task<Cliente> UpdateCliente(int codigoCliente, Cliente cliente)
        {
            return await _clienteClient.UpdateCliente(codigoCliente, cliente);
        }

        public async Task DeleteCliente(int codigoCliente)
        {
            await _clienteClient.DeleteCliente(codigoCliente);
        }
    }
}