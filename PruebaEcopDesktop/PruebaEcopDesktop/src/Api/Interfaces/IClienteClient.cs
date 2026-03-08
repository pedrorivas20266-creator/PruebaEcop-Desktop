using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Models.Dtos;

namespace PruebaECOP.Api.Interfaces
{
    public interface IClienteClient
    {
        Task<List<Cliente>> GetClientes(string busqueda, int? limite);
        Task<Cliente> CreateCliente(Cliente cliente);
        Task<List<Cliente>> GetClientesActivos();
        Task<Cliente> GetClienteById(int codigoCliente);
        Task<Cliente> UpdateCliente(int codigoCliente, Cliente cliente);
        Task DeleteCliente(int codigoCliente);
    }
}