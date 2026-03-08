using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaECOP.Models.Dtos;

namespace PruebaECOP.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> GetCategorias(string busqueda = null, int? limite = null);
        Task<Categoria> CreateCategoria(Categoria categoria);
        Task<List<Categoria>> GetCategoriasActivas();
        Task<Categoria> GetCategoriaById(int codigoCategoria);
        Task<Categoria> UpdateCategoria(int codigoCategoria, Categoria categoria);
        Task DeleteCategoria(int codigoCategoria);
    }
}