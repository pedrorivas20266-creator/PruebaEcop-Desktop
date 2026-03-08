using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Dtos;
using PruebaECOP.Services.Interfaces;

namespace PruebaECOP.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaClient _categoriaClient;

        public CategoriaService(ICategoriaClient categoriaClient)
        {
            _categoriaClient = categoriaClient;
        }

        public async Task<List<Categoria>> GetCategorias(string busqueda = null, int? limite = null)
        {
            return await _categoriaClient.GetCategorias(busqueda, limite);
        }

        public async Task<Categoria> CreateCategoria(Categoria categoria)
        {
            return await _categoriaClient.CreateCategoria(categoria);
        }

        public async Task<List<Categoria>> GetCategoriasActivas()
        {
            return await _categoriaClient.GetCategoriasActivas();
        }

        public async Task<Categoria> GetCategoriaById(int codigoCategoria)
        {
            return await _categoriaClient.GetCategoriaById(codigoCategoria);
        }

        public async Task<Categoria> UpdateCategoria(int codigoCategoria, Categoria categoria)
        {
            return await _categoriaClient.UpdateCategoria(codigoCategoria, categoria);
        }

        public async Task DeleteCategoria(int codigoCategoria)
        {
            await _categoriaClient.DeleteCategoria(codigoCategoria);
        }
    }
}