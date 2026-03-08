using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Models.Dtos;

namespace PruebaECOP.Services.Interfaces
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetClientes(string busqueda = null, int? limite = null);
        Task<Cliente> CreateCliente(Cliente cliente);
        Task<List<Cliente>> GetClientesActivos();
        Task<Cliente> GetClienteById(int codigoCliente);
        Task<Cliente> UpdateCliente(int codigoCliente, Cliente cliente);
        Task DeleteCliente(int codigoCliente);
    }
}