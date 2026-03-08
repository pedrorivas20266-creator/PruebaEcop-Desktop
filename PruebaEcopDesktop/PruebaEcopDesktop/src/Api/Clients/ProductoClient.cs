using PruebaECOP.Api.Helpers;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Dtos;
using PruebaECOP.Models.Requests;
using PruebaECOP.Models.Responses;
using PruebaEcopDesktop.Presenters;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaECOP.Api.Clients
{
    public class ProductoClient : IProductoClient
    {
        private readonly HttpClient _http;

        public ProductoClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Producto>> GetProductos(string busqueda, int? limite)
        {
            var url = "/api/productos?";
            if (!string.IsNullOrEmpty(busqueda))
                url += "busqueda=" + busqueda + "&";
            if (limite.HasValue)
                url += "limite=" + limite.Value;
            var productos = await HttpHelper.GetAsync<List<Producto>>(_http, url);
            return productos;
        }

        public async Task<ProductoConPrecioResponse> CreateProducto(ProductoRequest request)
        {
            var url = "/api/productos";
            return await HttpHelper.PostAsync<ProductoConPrecioResponse>(_http, url, request);
        }

        public async Task<List<Producto>> GetProductosActivos()
        {
            var url = "/api/productos/activos";
            return await HttpHelper.GetAsync<List<Producto>>(_http, url);
        }

        public async Task<Producto> GetProductoById(int codigoProducto)
        {
            var url = "/api/productos/" + codigoProducto;
            return await HttpHelper.GetAsync<Producto>(_http, url);
        }

        public async Task<ProductoQuery> UpdateProducto(int codigoProducto, ProductoQuery producto)
        {
            var url = "/api/productos/" + codigoProducto;
            return await HttpHelper.PutAsync<ProductoQuery>(_http, url, producto);
        }

        public async Task DeleteProducto(int codigoProducto)
        {
            var url = "/api/productos/" + codigoProducto;
            await HttpHelper.DeleteAsync(_http, url);
        }

        public async Task<ProductoConPrecioResponse> GetProductoConPrecios(int codigoProducto)
        {
            var url = "/api/productos/" + codigoProducto + "/con-precios";
            return await HttpHelper.GetAsync<ProductoConPrecioResponse>(_http, url);
        }

        public async Task<List<Precio>> GetProductoPrecios(int codigoProducto)
        {
            var url = "/api/productos/" + codigoProducto + "/precios";
            return await HttpHelper.GetAsync<List<Precio>>(_http, url);
        }

        public async Task<List<Precio>> UpdateProductoPrecios(int codigoProducto, ActualizarPreciosRequest request)
        {
            var url = "/api/productos/" + codigoProducto + "/precios";
            return await HttpHelper.PutAsync<List<Precio>>(_http, url, request);
        }
    }
}