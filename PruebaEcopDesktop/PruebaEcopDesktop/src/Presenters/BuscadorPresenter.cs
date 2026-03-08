using PruebaECOP.Services.Interfaces;
using PruebaEcopDesktop.Models.DTOs;
using PruebaEcopDesktop.Models.Enums;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEcopDesktop.Presenters
{
    public class BuscadorPresenter
    {
        private readonly IBuscadorView _view;
        private readonly BuscadorEntidad _entidad;

        private readonly IClienteService _clienteService;
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        private readonly IUnidadMedidaService _unidadMedidaService;
        private readonly IPedidoService _pedidoService;

        public BuscadorPresenter(
            IBuscadorView view,
            BuscadorEntidad entidad,
            IClienteService clienteService = null,
            IProductoService productoService = null,
            ICategoriaService categoriaService = null,
            IUnidadMedidaService unidadMedidaService = null,
            IPedidoService pedidoService = null)
        {
            _view = view;
            _entidad = entidad;
            _clienteService = clienteService;
            _productoService = productoService;
            _categoriaService = categoriaService;
            _unidadMedidaService = unidadMedidaService;
            _pedidoService = pedidoService;

            ConfigurarVista();
        }

        private void ConfigurarVista()
        {
            switch (_entidad)
            {
                case BuscadorEntidad.Pedido:
                    _view.HabilitarFecha = true;
                    break;
                default:
                    _view.HabilitarFecha = false;
                    break;
            }
        }

        public async Task BuscarAsync(string texto, int limite = 50)
        {
            try
            {
                List<BuscadorResultadoDTO> resultados = new List<BuscadorResultadoDTO>();

                switch (_entidad)
                {
                    case BuscadorEntidad.Cliente:
                        resultados = await BuscarClientes(texto, limite);
                        break;

                    case BuscadorEntidad.Producto:
                        resultados = await BuscarProductos(texto, limite);
                        break;

                    case BuscadorEntidad.Categoria:
                        resultados = await BuscarCategorias(texto, limite);
                        break;

                    case BuscadorEntidad.UnidadMedida:
                        resultados = await BuscarUnidadesMedida(texto, limite);
                        break;

                    default:
                        _view.MostrarError($"Entidad no implementada: {_entidad}");
                        return;
                }

                _view.MostrarResultados(resultados);
                _view.ActualizarCantidad(resultados.Count);
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al buscar: {ex.Message}");
            }
        }

        private async Task<List<BuscadorResultadoDTO>> BuscarClientes(string texto, int limite)
        {
            if (_clienteService == null)
                throw new InvalidOperationException("ClienteService no está configurado");

            var clientes = await _clienteService.GetClientes(texto, limite);

            return clientes.Select(c => new BuscadorResultadoDTO
            {
                CodigoOculto = c.CodCliente.ToString() ?? string.Empty,
                Codigo = c.NumCliente ?? string.Empty,
                Descripcion = c.Nombres + " " + c.Apellidos ?? string.Empty,
                Aux1 = c.NumeroTelefono ?? string.Empty,
                Aux2 = c.Direccion ?? string.Empty
            }).ToList();
        }

        private async Task<List<BuscadorResultadoDTO>> BuscarProductos(string texto, int limite)
        {
            if (_productoService == null)
                throw new InvalidOperationException("ProductoService no está configurado");

            var productos = await _productoService.GetProductos(texto, limite);

            return productos.Select(p => new BuscadorResultadoDTO
            {
                CodigoOculto = p.CodProducto.ToString() ?? string.Empty,
                Codigo = p.NumProducto ?? string.Empty,
                Descripcion = p.DesProducto ?? string.Empty,
                Aux1 = $"{p.CodCategoria}|{p.CodUnidadMedida}|{p.CodIva}",
                Aux2 = string.Empty
            }).ToList();
        }

        private async Task<List<BuscadorResultadoDTO>> BuscarCategorias(string texto, int limite)
        {
            if (_categoriaService == null)
                throw new InvalidOperationException("CategoriaService no está configurado");

            var categorias = await _categoriaService.GetCategorias(texto, limite);

            return categorias.Select(c => new BuscadorResultadoDTO
            {
                CodigoOculto = c.CodCategoria.ToString() ?? string.Empty,
                Codigo = c.NumCategoria ?? string.Empty,
                Descripcion = c.DesCategoria ?? string.Empty,
                Aux1 = string.Empty,
                Aux2 = string.Empty
            }).ToList();
        }

        private async Task<List<BuscadorResultadoDTO>> BuscarUnidadesMedida(string texto, int limite)
        {
            if (_unidadMedidaService == null)
                throw new InvalidOperationException("UnidadMedidaService no está configurado");

            var unidades = await _unidadMedidaService.GetUnidadesMedida(texto, limite);

            return unidades.Select(u => new BuscadorResultadoDTO
            {
                CodigoOculto = u.CodUnidadMedida.ToString() ?? string.Empty,
                Codigo = u.NumUnidadMedida ?? string.Empty,
                Descripcion = u.DesUnidadMedida ?? string.Empty,
                Aux1 = string.Empty,
                Aux2 = string.Empty
            }).ToList();
        }
    }
}