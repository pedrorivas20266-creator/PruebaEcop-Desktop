using PruebaECOP.Models.Requests;
using PruebaECOP.Services.Interfaces;
using PruebaEcopDesktop.Models.DTOs;
using PruebaEcopDesktop.Models.Enums;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEcopDesktop.Presenters
{
    public class ABMProductosPresenter
    {
        private readonly IABMProductosView _view;
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        private readonly IUnidadMedidaService _unidadMedidaService;

        public ABMProductosPresenter(
            IABMProductosView view,
            IProductoService productoService,
            ICategoriaService categoriaService = null,
            IUnidadMedidaService unidadMedidaService = null)
        {
            _view = view;
            _productoService = productoService;
            _categoriaService = categoriaService;
            _unidadMedidaService = unidadMedidaService;
        }

        public IProductoService ObtenerProductoService() => _productoService;
        public ICategoriaService ObtenerCategoriaService() => _categoriaService;
        public IUnidadMedidaService ObtenerUnidadMedidaService() => _unidadMedidaService;

        public async Task InicializarFormulario()
        {
            await CargarProductos();
            _view.HabilitarEstadoLectura();
        }

        public async Task IniciarNuevoProducto()
        {
            try
            {
                _view.LimpiarCampos();

                var codigoProducto = await GenerarCodigoProducto();
                _view.EstablecerCodigoProducto(codigoProducto);

                _view.HabilitarEstadoNuevo();
                _view.EnfocarCampo("descripcion");
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al iniciar nuevo producto: {ex.Message}");
            }
        }

        public void CancelarOperacion()
        {
            _view.LimpiarCampos();
            _view.HabilitarEstadoLectura();
        }

        public async Task<bool> ValidarCategoriaPorCodigo(string codigoCategoria)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codigoCategoria))
                    return false;

                if (_categoriaService == null)
                {
                    _view.MostrarAdvertencia("Servicio de categorías no disponible");
                    return false;
                }

                var categorias = await _categoriaService.GetCategorias(codigoCategoria, 1);
                var categoria = categorias?.FirstOrDefault();

                if (categoria == null)
                {
                    _view.MostrarError($"No se encontró la categoría con código: {codigoCategoria}");
                    return false;
                }

                _view.EstablecerCategoria(
                    categoria.CodCategoria.ToString(),
                    categoria.DesCategoria
                );

                return true;
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al validar categoría: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> ValidarUnidadMedidaPorCodigo(string codigoUnidadMedida)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codigoUnidadMedida))
                    return false;

                if (_unidadMedidaService == null)
                {
                    _view.MostrarAdvertencia("Servicio de unidades de medida no disponible");
                    return false;
                }

                var unidades = await _unidadMedidaService.GetUnidadesMedida(codigoUnidadMedida, 1);
                var unidad = unidades?.FirstOrDefault();

                if (unidad == null)
                {
                    _view.MostrarError($"No se encontró la unidad de medida con código: {codigoUnidadMedida}");
                    return false;
                }

                _view.EstablecerUnidadMedida(
                    unidad.CodUnidadMedida.ToString(),
                    unidad.DesUnidadMedida
                );

                return true;
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al validar unidad de medida: {ex.Message}");
                return false;
            }
        }

        public bool ValidarIvaPorCodigo(string codigoIva)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codigoIva))
                    return false;

                var iva = IvaHelper.ObtenerPorCodigo(codigoIva);

                if (!iva.HasValue)
                {
                    var ivaDescripcion = IvaHelper.ObtenerPorDescripcion(codigoIva);
                    if (ivaDescripcion.HasValue)
                    {
                        iva = ivaDescripcion;
                    }
                }

                if (!iva.HasValue)
                {
                    _view.MostrarError($"IVA inválido. Use: 0 = Exenta, 5 = IVA 5%, 10 = IVA 10%");
                    return false;
                }

                _view.EstablecerIva(
                    IvaHelper.ObtenerCodigo(iva.Value),
                    IvaHelper.ObtenerDescripcion(iva.Value)
                );

                return true;
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al validar IVA: {ex.Message}");
                return false;
            }
        }

        public async Task GuardarProducto()
        {
            try
            {
                if (!ValidarCamposRequeridos())
                    return;

                bool confirmar = _view.ConfirmarOperacion(
                    "¿Está seguro que desea guardar el producto?",
                    "Confirmar Guardado"
                );

                if (!confirmar)
                    return;

                var productoId = _view.ProductoIdSeleccionado;

                if (productoId.HasValue && productoId.Value > 0)
                {
                    await ActualizarProducto(productoId.Value);
                }
                else
                {
                    await CrearProducto();
                }

                _view.MostrarExito("Producto guardado correctamente");
                await CargarProductos();
                _view.LimpiarCampos();
                _view.HabilitarEstadoLectura();
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al guardar producto: {ex.Message}");
            }
        }

        public async Task CargarProductoParaEdicion(int productoId)
        {
            try
            {
                var productoConPrecios = await _productoService.GetProductoConPrecios(productoId);

                if (productoConPrecios == null)
                {
                    _view.MostrarError("No se pudo cargar el producto seleccionado");
                    return;
                }

                var productoQuery = new ProductoQuery
                {
                    CodProducto = productoConPrecios.CodProducto,
                    NumProducto = productoConPrecios.NumProducto,
                    CodigoBarra = productoConPrecios.CodigoBarra,
                    DesProducto = productoConPrecios.DesProducto,
                    CodCategoria = productoConPrecios.CodCategoria,
                    CodUnidadMedida = productoConPrecios.CodUnidadMedida,
                    CodIva = productoConPrecios.CodIva,
                    FechaIngreso = productoConPrecios.FechaIngreso,
                    CostoPromedio = Convert.ToDecimal(productoConPrecios.CostoPromedio),
                    CostoUltimo = Convert.ToDecimal(productoConPrecios.CostoUltimo),
                    Activo = productoConPrecios.Activo,
                    DescuentaStock = productoConPrecios.DescuentaStock,
                    FecGra = productoConPrecios.FecGra,
                    PrecioVenta = Convert.ToDecimal(productoConPrecios.Precios?.FirstOrDefault()?.PrecioVenta ?? 0), // double? a double - con valor predeterminado
                    DesCategoria = string.Empty,
                    DesUnidadMedida = string.Empty
                };

                if (_categoriaService != null)
                {
                    var categoria = await _categoriaService.GetCategoriaById(productoQuery.CodCategoria);
                    if (categoria != null)
                    {
                        productoQuery.DesCategoria = categoria.DesCategoria;
                    }
                }

                if (_unidadMedidaService != null)
                {
                    var unidadMedida = await _unidadMedidaService.GetUnidadMedidaById(productoQuery.CodUnidadMedida);
                    if (unidadMedida != null)
                    {
                        productoQuery.DesUnidadMedida = unidadMedida.DesUnidadMedida;
                    }
                }

                _view.CargarDatosProducto(productoQuery);
                _view.HabilitarEstadoNuevo();
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al cargar producto: {ex.Message}");
            }
        }

        public async Task EliminarProducto(int productoId)
        {
            try
            {
                bool confirmar = _view.ConfirmarOperacion(
                    "¿Está seguro que desea eliminar este producto?",
                    "Confirmar Eliminación"
                );

                if (!confirmar)
                    return;

                await _productoService.DeleteProducto(productoId);

                _view.MostrarExito("Producto eliminado correctamente");
                await CargarProductos();
                _view.LimpiarCampos();
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al eliminar producto: {ex.Message}");
            }
        }

        public async Task BuscarProductos(string filtro)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filtro))
                {
                    await CargarProductos();
                    return;
                }

                var productos = await _productoService.GetProductos(filtro, 100);

                var productosGrid = productos.Select(p => new ProductoGridDTO
                {
                    CodProducto = p.CodProducto,
                    NumProducto = p.NumProducto,
                    DesProducto = p.DesProducto,
                    CodigoBarra = p.CodigoBarra,
                    Categoria = p.DesCategoria,
                    UnidadMedida = p.DesUnidadMedida,
                    Iva = ObtenerDescripcionIva(p.CodIva),
                    Costo = p.CostoUltimo,
                    PrecioVenta = p.PrecioVenta,
                    ActualizaStock = p.DescuentaStock,
                    Activo = p.Activo
                }).ToList();

                _view.CargarProductos(productosGrid);
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al buscar productos: {ex.Message}");
            }
        }

        private async Task CargarProductos()
        {
            try
            {
                var productos = await _productoService.GetProductos(string.Empty, 100);

                var productosGrid = productos.Select(p => new ProductoGridDTO
                {
                    CodProducto = p.CodProducto,
                    NumProducto = p.NumProducto,
                    DesProducto = p.DesProducto,
                    CodigoBarra = p.CodigoBarra,
                    Categoria = p.DesCategoria ?? string.Empty,
                    UnidadMedida = p.DesUnidadMedida ?? string.Empty,
                    Iva = ObtenerDescripcionIva(p.CodIva),
                    Costo = p.CostoUltimo,
                    PrecioVenta = p.PrecioVenta,
                    ActualizaStock = p.DescuentaStock,
                    Activo = p.Activo
                }).ToList();

                _view.CargarProductos(productosGrid);
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al cargar productos: {ex.Message}");
            }
        }

        private async Task<string> GenerarCodigoProducto()
        {
            try
            {
                var productos = await _productoService.GetProductos(string.Empty, 1);
                var ultimoProducto = productos?.OrderByDescending(p => p.CodProducto).FirstOrDefault();

                if (ultimoProducto != null)
                {
                    if (int.TryParse(ultimoProducto.NumProducto, out int numeroActual))
                    {
                        return (numeroActual + 1).ToString("D6");
                    }
                }

                return "000001";
            }
            catch
            {
                return "000001";
            }
        }

        private async Task CrearProducto()
        {
            const int codPrecioGenerico = 1;

            var nuevoProducto = new ProductoRequest
            {
                NumProducto = _view.CodigoProducto,
                DesProducto = _view.Descripcion,
                CodigoBarra = _view.CodigoBarra,
                CodCategoria = int.Parse(_view.Categoria),
                CodUnidadMedida = int.Parse(_view.UnidadMedida),
                CodIva = int.Parse(_view.Iva),
                CostoUltimo = double.Parse(_view.Costo),
                Precios = new System.Collections.Generic.List<PrecioRequest>
                {
                    new PrecioRequest
                    {
                        CodTipoPrecio = codPrecioGenerico,
                        PrecioVenta = double.Parse(_view.PrecioVenta)
                    }
                },
                DescuentaStock = _view.ActualizaStock
            };

            await _productoService.CreateProducto(nuevoProducto);
        }

        private async Task ActualizarProducto(int productoId)
        {
            try
            {
                var productoConPrecios = await _productoService.GetProductoConPrecios(productoId);

                if (productoConPrecios == null)
                {
                    throw new Exception("No se pudo obtener el producto");
                }

                var costoUltimo = Convert.ToDouble(_view.Costo.Replace(".", "").Replace(",", "."),
                    System.Globalization.CultureInfo.InvariantCulture);

                var precioVenta = Convert.ToDouble(_view.PrecioVenta.Replace(".", "").Replace(",", "."),
                    System.Globalization.CultureInfo.InvariantCulture);

                var productoQuery = new ProductoQuery
                {
                    CodProducto = productoId,
                    NumProducto = productoId.ToString(),
                    DesProducto = _view.Descripcion,
                    CodigoBarra = _view.CodigoBarra,
                    CodCategoria = int.Parse(_view.Categoria),
                    CodUnidadMedida = int.Parse(_view.UnidadMedida),
                    CodIva = int.Parse(_view.Iva),
                    CostoUltimo = Convert.ToDecimal(costoUltimo),
                    PrecioVenta = Convert.ToDecimal(precioVenta),
                    DescuentaStock = _view.ActualizaStock,
                    Activo = _view.Activo,
                    FechaIngreso = productoConPrecios.FechaIngreso,
                    CostoPromedio = Convert.ToDecimal(productoConPrecios.CostoPromedio),
                    FecGra = productoConPrecios.FecGra
                };

                await _productoService.UpdateProducto(productoId, productoQuery);

                var precioActual = productoConPrecios.Precios?.FirstOrDefault();
                if (precioActual != null)
                {
                    var preciosRequest = new ActualizarPreciosRequest
                    {
                        Precios = new System.Collections.Generic.List<ActualizarPrecioItem>
                        {
                            new ActualizarPrecioItem
                            {
                                CodPrecio = precioActual.CodPrecio,
                                PrecioVenta = precioVenta
                            }
                        }
                    };

                    await _productoService.UpdateProductoPrecios(productoId, preciosRequest);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar producto: {ex.Message}", ex);
            }
        }

        private bool ValidarCamposRequeridos()
        {
            if (string.IsNullOrWhiteSpace(_view.Descripcion))
            {
                _view.MostrarAdvertencia("Debe ingresar la descripción del producto");
                _view.EnfocarCampo("descripcion");
                return false;
            }

            if (string.IsNullOrWhiteSpace(_view.Categoria))
            {
                _view.MostrarAdvertencia("Debe seleccionar una categoría");
                _view.EnfocarCampo("categoria");
                return false;
            }

            if (string.IsNullOrWhiteSpace(_view.UnidadMedida))
            {
                _view.MostrarAdvertencia("Debe seleccionar una unidad de medida");
                _view.EnfocarCampo("unidadmedida");
                return false;
            }

            if (string.IsNullOrWhiteSpace(_view.Iva))
            {
                _view.MostrarAdvertencia("Debe seleccionar un IVA");
                _view.EnfocarCampo("iva");
                return false;
            }

            if (!decimal.TryParse(_view.Costo, out decimal costo) || costo < 0)
            {
                _view.MostrarAdvertencia("Debe ingresar un costo válido");
                _view.EnfocarCampo("costo");
                return false;
            }

            if (!decimal.TryParse(_view.PrecioVenta, out decimal precio) || precio < 0)
            {
                _view.MostrarAdvertencia("Debe ingresar un precio de venta válido");
                _view.EnfocarCampo("precioventa");
                return false;
            }

            return true;
        }

        private string ObtenerDescripcionIva(int codigoIva)
        {
            var iva = IvaHelper.ObtenerPorCodigo(codigoIva.ToString());
            return iva.HasValue ? IvaHelper.ObtenerDescripcion(iva.Value) : "DESCONOCIDO";
        }
    }
}