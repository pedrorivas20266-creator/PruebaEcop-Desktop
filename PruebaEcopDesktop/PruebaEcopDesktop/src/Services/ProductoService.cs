using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Dtos;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;
using PruebaECOP.Services.Interfaces;
using PruebaEcopDesktop.Presenters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaECOP.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoClient _productoClient;

        public ProductoService(IProductoClient productoClient)
        {
            _productoClient = productoClient;
        }

        public async Task<List<Producto>> GetProductos(string busqueda = null, int? limite = null)
        {
            return await _productoClient.GetProductos(busqueda, limite);
        }

        public async Task<ProductoConPrecioResponse> CreateProducto(ProductoRequest request)
        {
            return await _productoClient.CreateProducto(request);
        }

        public async Task<List<Producto>> GetProductosActivos()
        {
            return await _productoClient.GetProductosActivos();
        }

        public async Task<Producto> GetProductoById(int codigoProducto)
        {
            return await _productoClient.GetProductoById(codigoProducto);
        }

        public async Task<ProductoQuery> UpdateProducto(int codigoProducto, ProductoQuery producto)
        {
            return await _productoClient.UpdateProducto(codigoProducto, producto);
        }

        public async Task DeleteProducto(int codigoProducto)
        {
            await _productoClient.DeleteProducto(codigoProducto);
        }

        public async Task<ProductoConPrecioResponse> GetProductoConPrecios(int codigoProducto)
        {
            return await _productoClient.GetProductoConPrecios(codigoProducto);
        }

        public async Task<List<Precio>> GetProductoPrecios(int codigoProducto)
        {
            return await _productoClient.GetProductoPrecios(codigoProducto);
        }

        public async Task<List<Precio>> UpdateProductoPrecios(int codigoProducto, ActualizarPreciosRequest request)
        {
            return await _productoClient.UpdateProductoPrecios(codigoProducto, request);
        }

    }
}