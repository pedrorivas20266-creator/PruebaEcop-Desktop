using PruebaECOP.Models.Requests;
using PruebaECOP.Services.Interfaces;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEcopDesktop.Presenters
{
    public class SolicitudPedidosPresenter
    {
        private readonly ISolicitudPedidosView _view;
        private readonly IClienteService _clienteService;
        private readonly IProductoService _productoService;
        private readonly IPedidoService _pedidoService;

        public SolicitudPedidosPresenter(
            ISolicitudPedidosView view,
            IClienteService clienteService,
            IProductoService productoService,
            IPedidoService pedidoService = null)
        {
            _view = view;
            _clienteService = clienteService;
            _productoService = productoService;
            _pedidoService = pedidoService;
        }

        public IClienteService ObtenerClienteService() => _clienteService;
        public IProductoService ObtenerProductoService() => _productoService;

        public async Task<bool> GuardarPedido()
        {
            try
            {
                if (_pedidoService == null)
                {
                    _view.MostrarError("El servicio de pedidos no está disponible");
                    return false;
                }

                var detalles = _view.ObtenerDetallesPedido();

                if (detalles == null || !detalles.Any())
                {
                    _view.MostrarError("Debe agregar al menos un producto al pedido");
                    return false;
                }

                var pedidoRequest = new PedidoRequest
                {
                    NumPedido = GenerarNumeroPedido(),
                    Fecha = _view.FechaPedido,
                    CodUsuario = 1,
                    CodCliente = int.Parse(_view.ClienteId),
                    CodMoneda = 1,
                    Detalles = detalles.Select((d, index) => new PedidoDetalleRequest
                    {
                        CodProducto = d.ProductoId,
                        Cantidad = Convert.ToDouble(d.Cantidad),
                        PrecioUnitario = Convert.ToDouble(d.PrecioUnitario),
                        LineaNumero = index + 1
                    }).ToList()
                };

                bool resultado = await _pedidoService.CreatePedido(pedidoRequest);

                if (resultado)
                {
                    _view.MostrarInformacion("Pedido guardado correctamente", "Éxito");
                }
                else
                {
                    _view.MostrarError("No se pudo guardar el pedido");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al guardar pedido: {ex.Message}");
                return false;
            }
        }

        private string GenerarNumeroPedido()
        {
            var ahora = DateTime.Now;
            return string.Format("PED-{0:yyyyMMdd}-{0:HHmmss}", ahora);
        }

        public void ClienteSeleccionado(string id, string codigo, string nombre)
        {
            _view.EstablecerCliente(id, codigo, nombre);
        }

        public async Task ProductoSeleccionado(string id, string codigo, string descripcion)
        {
            _view.EstablecerProducto(id, codigo, descripcion);
            await CargarPrecioProducto(id);
        }

        public async Task<bool> ValidarClientePorCodigo(string codigoCliente)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codigoCliente))
                    return false;

                var clientes = await _clienteService.GetClientes(codigoCliente, 1);
                var cliente = clientes?.FirstOrDefault();

                if (cliente == null)
                {
                    _view.MostrarError($"No se encontró el cliente con código: {codigoCliente}");
                    return false;
                }

                _view.EstablecerCliente(
                    cliente.CodCliente.ToString(),
                    cliente.NumCliente,
                    $"{cliente.Nombres} {cliente.Apellidos}"
                );

                return true;
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al validar cliente: {ex.Message}");
                return false;
            }
        }

        public async Task ValidarProductoPorCodigo(string codigoProducto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codigoProducto))
                    return;

                var productos = await _productoService.GetProductos(codigoProducto, 1);
                var producto = productos?.FirstOrDefault();

                if (producto == null)
                {
                    _view.MostrarError($"No se encontró el producto con código: {codigoProducto}");
                    return;
                }

                _view.EstablecerProducto(
                    producto.CodProducto.ToString(),
                    producto.NumProducto,
                    producto.DesProducto
                );

                await CargarPrecioProducto(producto.CodProducto.ToString());
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al validar producto: {ex.Message}");
            }
        }

        public async Task ValidarYAgregarDetalle(
            string productoId,
            string codigoProducto,
            string descripcionProducto,
            string cantidadTexto,
            string precioTexto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(productoId) || productoId == "0")
                {
                    _view.MostrarError("Debe seleccionar un producto válido");
                    _view.EnfocarCampo("codigo");
                    return;
                }

                if (!decimal.TryParse(cantidadTexto, out decimal cantidad) || cantidad <= 0)
                {
                    _view.MostrarError("La cantidad debe ser mayor a cero");
                    _view.EnfocarCampo("cantidad");
                    return;
                }

                if (!decimal.TryParse(precioTexto, out decimal precio) || precio <= 0)
                {
                    _view.MostrarError("El precio debe ser mayor a cero");
                    return;
                }

                decimal subtotal = cantidad * precio;

                _view.AgregarDetallePedido(
                    productoId,
                    codigoProducto,
                    descripcionProducto,
                    cantidad,
                    precio,
                    subtotal
                );

                _view.LimpiarDetalle();
                _view.EnfocarCampo("codigo");
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al agregar detalle: {ex.Message}");
            }
        }

        private async Task CargarPrecioProducto(string productoId)
        {
            try
            {
                if (!int.TryParse(productoId, out int codProducto))
                    return;

                var precios = await _productoService.GetProductoPrecios(codProducto);
                var precio = precios?.FirstOrDefault();

                if (precio != null && precio.PrecioVenta.HasValue)
                {
                    _view.EstablecerPrecioProducto((decimal)precio.PrecioVenta.Value);
                }
                else
                {
                    _view.EstablecerPrecioProducto(0);
                }
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al cargar precio: {ex.Message}");
            }
        }
    }
}