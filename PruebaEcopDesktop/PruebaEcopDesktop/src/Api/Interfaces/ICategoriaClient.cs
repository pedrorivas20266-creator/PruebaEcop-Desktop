using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Models.Dtos;

namespace PruebaECOP.Api.Interfaces
{
    public interface ICategoriaClient
    {
        Task<List<Categoria>> GetCategorias(string busqueda, int? limite);
        Task<Categoria> CreateCategoria(Categoria categoria);
        Task<List<Categoria>> GetCategoriasActivas();
        Task<Categoria> GetCategoriaById(int codigoCategoria);
        Task<Categoria> UpdateCategoria(int codigoCategoria, Categoria categoria);
        Task DeleteCategoria(int codigoCategoria);
    }
}