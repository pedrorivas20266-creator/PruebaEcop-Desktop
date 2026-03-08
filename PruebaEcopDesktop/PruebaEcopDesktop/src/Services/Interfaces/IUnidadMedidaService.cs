using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Models.Dtos;

namespace PruebaECOP.Services.Interfaces
{
    public interface IUnidadMedidaService
    {
        Task<List<UnidadMedida>> GetUnidadesMedida(string busqueda = null, int? limite = null);
        Task<UnidadMedida> CreateUnidadMedida(UnidadMedida unidadMedida);
        Task<List<UnidadMedida>> GetUnidadesMedidaActivas();
        Task<UnidadMedida> GetUnidadMedidaById(int codigoUnidadMedida);
        Task<UnidadMedida> UpdateUnidadMedida(int codigoUnidadMedida, UnidadMedida unidadMedida);
        Task DeleteUnidadMedida(int codigoUnidadMedida);
    }
}