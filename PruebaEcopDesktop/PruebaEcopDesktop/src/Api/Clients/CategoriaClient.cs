using PruebaECOP.Api.Helpers;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Dtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaECOP.Api.Clients
{
    public class CategoriaClient : ICategoriaClient
    {
        private readonly HttpClient _http;

        public CategoriaClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Categoria>> GetCategorias(string busqueda, int? limite)
        {
            var url = "/api/categorias?";
            if (!string.IsNullOrEmpty(busqueda))
                url += "busqueda=" + busqueda + "&";
            if (limite.HasValue)
                url += "limite=" + limite.Value;
            return await HttpHelper.GetAsync<List<Categoria>>(_http, url);
        }

        public async Task<Categoria> CreateCategoria(Categoria categoria)
        {
            var url = "/api/categorias";
            return await HttpHelper.PostAsync<Categoria>(_http, url, categoria);
        }

        public async Task<List<Categoria>> GetCategoriasActivas()
        {
            var url = "/api/categorias/activos";
            return await HttpHelper.GetAsync<List<Categoria>>(_http, url);
        }

        public async Task<Categoria> GetCategoriaById(int codigoCategoria)
        {
            var url = "/api/categorias/" + codigoCategoria;
            return await HttpHelper.GetAsync<Categoria>(_http, url);
        }

        public async Task<Categoria> UpdateCategoria(int codigoCategoria, Categoria categoria)
        {
            var url = "/api/categorias/" + codigoCategoria;
            return await HttpHelper.PutAsync<Categoria>(_http, url, categoria);
        }

        public async Task DeleteCategoria(int codigoCategoria)
        {
            var url = "/api/categorias/" + codigoCategoria;
            await HttpHelper.DeleteAsync(_http, url);
        }
    }
}