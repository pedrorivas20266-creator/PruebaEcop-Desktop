using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Models.Dtos;

namespace PruebaECOP.Api.Interfaces
{
    public interface IUnidadMedidaClient
    {
        Task<List<UnidadMedida>> GetUnidadesMedida(string busqueda, int? limite);
        Task<UnidadMedida> CreateUnidadMedida(UnidadMedida unidadMedida);
        Task<List<UnidadMedida>> GetUnidadesMedidaActivas();
        Task<UnidadMedida> GetUnidadMedidaById(int codigoUnidadMedida);
        Task<UnidadMedida> UpdateUnidadMedida(int codigoUnidadMedida, UnidadMedida unidadMedida);
        Task DeleteUnidadMedida(int codigoUnidadMedida);
    }
}