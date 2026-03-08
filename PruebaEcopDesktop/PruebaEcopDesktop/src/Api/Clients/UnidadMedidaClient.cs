using PruebaECOP.Api.Helpers;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Dtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaECOP.Api.Clients
{
    public class UnidadMedidaClient : IUnidadMedidaClient
    {
        private readonly HttpClient _http;

        public UnidadMedidaClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<UnidadMedida>> GetUnidadesMedida(string busqueda, int? limite)
        {
            var url = "/api/unidades-medida?";
            if (!string.IsNullOrEmpty(busqueda))
                url += "busqueda=" + busqueda + "&";
            if (limite.HasValue)
                url += "limite=" + limite.Value;
            return await HttpHelper.GetAsync<List<UnidadMedida>>(_http, url);
        }

        public async Task<UnidadMedida> CreateUnidadMedida(UnidadMedida unidadMedida)
        {
            var url = "/api/unidades-medida";
            return await HttpHelper.PostAsync<UnidadMedida>(_http, url, unidadMedida);
        }

        public async Task<List<UnidadMedida>> GetUnidadesMedidaActivas()
        {
            var url = "/api/unidades-medida/activos";
            return await HttpHelper.GetAsync<List<UnidadMedida>>(_http, url);
        }

        public async Task<UnidadMedida> GetUnidadMedidaById(int codigoUnidadMedida)
        {
            var url = "/api/unidades-medida/" + codigoUnidadMedida;
            return await HttpHelper.GetAsync<UnidadMedida>(_http, url);
        }

        public async Task<UnidadMedida> UpdateUnidadMedida(int codigoUnidadMedida, UnidadMedida unidadMedida)
        {
            var url = "/api/unidades-medida/" + codigoUnidadMedida;
            return await HttpHelper.PutAsync<UnidadMedida>(_http, url, unidadMedida);
        }

        public async Task DeleteUnidadMedida(int codigoUnidadMedida)
        {
            var url = "/api/unidades-medida/" + codigoUnidadMedida;
            await HttpHelper.DeleteAsync(_http, url);
        }
    }
}