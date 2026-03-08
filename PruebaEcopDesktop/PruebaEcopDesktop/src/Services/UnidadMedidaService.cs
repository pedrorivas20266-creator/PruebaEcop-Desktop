using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Dtos;
using PruebaECOP.Services.Interfaces;

namespace PruebaECOP.Services
{
    public class UnidadMedidaService : IUnidadMedidaService
    {
        private readonly IUnidadMedidaClient _unidadMedidaClient;

        public UnidadMedidaService(IUnidadMedidaClient unidadMedidaClient)
        {
            _unidadMedidaClient = unidadMedidaClient;
        }

        public async Task<List<UnidadMedida>> GetUnidadesMedida(string busqueda = null, int? limite = null)
        {
            return await _unidadMedidaClient.GetUnidadesMedida(busqueda, limite);
        }

        public async Task<UnidadMedida> CreateUnidadMedida(UnidadMedida unidadMedida)
        {
            return await _unidadMedidaClient.CreateUnidadMedida(unidadMedida);
        }

        public async Task<List<UnidadMedida>> GetUnidadesMedidaActivas()
        {
            return await _unidadMedidaClient.GetUnidadesMedidaActivas();
        }

        public async Task<UnidadMedida> GetUnidadMedidaById(int codigoUnidadMedida)
        {
            return await _unidadMedidaClient.GetUnidadMedidaById(codigoUnidadMedida);
        }

        public async Task<UnidadMedida> UpdateUnidadMedida(int codigoUnidadMedida, UnidadMedida unidadMedida)
        {
            return await _unidadMedidaClient.UpdateUnidadMedida(codigoUnidadMedida, unidadMedida);
        }

        public async Task DeleteUnidadMedida(int codigoUnidadMedida)
        {
            await _unidadMedidaClient.DeleteUnidadMedida(codigoUnidadMedida);
        }
    }
}