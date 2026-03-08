using PruebaECOP.Models.Dtos;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;
using PruebaEcopDesktop.Presenters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaECOP.Services.Interfaces
{
    public interface IProductoService
    {
        Task<List<Producto>> GetProductos(string busqueda = null, int? limite = null);
        Task<ProductoConPrecioResponse> CreateProducto(ProductoRequest request);
        Task<List<Producto>> GetProductosActivos();
        Task<Producto> GetProductoById(int codigoProducto);
        Task<ProductoQuery> UpdateProducto(int codigoProducto, ProductoQuery producto);
        Task DeleteProducto(int codigoProducto);
        Task<ProductoConPrecioResponse> GetProductoConPrecios(int codigoProducto);
        Task<List<Precio>> GetProductoPrecios(int codigoProducto);
        Task<List<Precio>> UpdateProductoPrecios(int codigoProducto, ActualizarPreciosRequest request);
    }
}