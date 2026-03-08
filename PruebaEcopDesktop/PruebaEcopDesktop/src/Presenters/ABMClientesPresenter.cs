using PruebaECOP.Models.Dtos;
using PruebaECOP.Services.Interfaces;
using PruebaEcopDesktop.Models.DTOs;
using PruebaEcopDesktop.Models.Enums;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEcopDesktop.Presenters
{
    public class ABMClientesPresenter
    {
        private readonly IABMClientesView _view;
        private readonly IClienteService _clienteService;

        public ABMClientesPresenter(
            IABMClientesView view,
            IClienteService clienteService)
        {
            _view = view;
            _clienteService = clienteService;
        }

        public IClienteService ObtenerClienteService()
        {
            return _clienteService;
        }

        public async Task InicializarFormulario()
        {
            await CargarClientes();
            _view.HabilitarEstadoLectura();
        }

        public async Task IniciarNuevoCliente()
        {
            try
            {
                _view.LimpiarCampos();
                
                var numeroCliente = await GenerarNumeroCliente();
                _view.EstablecerNumeroCliente(numeroCliente);
                
                _view.HabilitarEstadoNuevo();
                _view.EnfocarCampo("nombre");
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al iniciar nuevo cliente: {ex.Message}");
            }
        }

        public void CancelarOperacion()
        {
            _view.LimpiarCampos();
            _view.HabilitarEstadoLectura();
        }

        public bool ValidarTipoDocumentoPorCodigo(string codigoTipoDocumento)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codigoTipoDocumento))
                    return false;

                var tipoDocumento = TipoDocumentoHelper.ObtenerPorCodigo(codigoTipoDocumento);

                if (!tipoDocumento.HasValue)
                {
                    var tipoDescripcion = TipoDocumentoHelper.ObtenerPorDescripcion(codigoTipoDocumento);
                    if (tipoDescripcion.HasValue)
                    {
                        tipoDocumento = tipoDescripcion;
                    }
                }

                if (!tipoDocumento.HasValue)
                {
                    _view.MostrarError($"Tipo de documento inválido. Use: 1 = Cédula de Identidad, 2 = RUC de Contribuyente");
                    return false;
                }

                _view.EstablecerTipoDocumento(
                    TipoDocumentoHelper.ObtenerCodigo(tipoDocumento.Value),
                    TipoDocumentoHelper.ObtenerDescripcion(tipoDocumento.Value)
                );

                return true;
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al validar tipo de documento: {ex.Message}");
                return false;
            }
        }

        public async Task GuardarCliente()
        {
            try
            {
                if (!ValidarCamposRequeridos())
                    return;

                bool confirmar = _view.ConfirmarOperacion(
                    "¿Está seguro que desea guardar el cliente?",
                    "Confirmar Guardado"
                );

                if (!confirmar)
                    return;

                var clienteId = _view.ClienteIdSeleccionado;

                if (clienteId.HasValue && clienteId.Value > 0)
                {
                    await ActualizarCliente(clienteId.Value);
                }
                else
                {
                    await CrearCliente();
                }

                _view.MostrarExito("Cliente guardado correctamente");
                await CargarClientes();
                _view.LimpiarCampos();
                _view.HabilitarEstadoLectura();
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al guardar cliente: {ex.Message}");
            }
        }

        public async Task CargarClienteParaEdicion(int clienteId)
        {
            try
            {
                var cliente = await _clienteService.GetClienteById(clienteId);

                if (cliente == null)
                {
                    _view.MostrarError("No se pudo cargar el cliente seleccionado");
                    return;
                }

                _view.CargarDatosCliente(cliente);
                _view.HabilitarEstadoNuevo();
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al cargar cliente: {ex.Message}");
            }
        }

        public async Task EliminarCliente(int clienteId)
        {
            try
            {
                bool confirmar = _view.ConfirmarOperacion(
                    "¿Está seguro que desea eliminar este cliente?",
                    "Confirmar Eliminación"
                );

                if (!confirmar)
                    return;

                await _clienteService.DeleteCliente(clienteId);

                _view.MostrarExito("Cliente eliminado correctamente");
                await CargarClientes();
                _view.LimpiarCampos();
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al eliminar cliente: {ex.Message}");
            }
        }

        public async Task BuscarClientes(string filtro)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filtro))
                {
                    await CargarClientes();
                    return;
                }

                var clientes = await _clienteService.GetClientes(filtro, 100);
                
                var clientesGrid = clientes.Select(c => new ClienteGridDTO
                {
                    CodCliente = c.CodCliente,
                    NumCliente = c.NumCliente,
                    Nombres = c.Nombres,
                    Apellidos = c.Apellidos,
                    TipoDocumento = ObtenerDescripcionTipoDocumento(c.CodTipoDocumento),
                    NumeroDocumento = c.NumeroDocumento,
                    Telefono = c.NumeroTelefono,
                    Email = c.Correo,
                    Direccion = c.Direccion
                }).ToList();

                _view.CargarClientes(clientesGrid);
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al buscar clientes: {ex.Message}");
            }
        }

        private async Task CargarClientes()
        {
            try
            {
                var clientes = await _clienteService.GetClientes(string.Empty, 100);
                
                var clientesGrid = clientes.Select(c => new ClienteGridDTO
                {
                    CodCliente = c.CodCliente,
                    NumCliente = c.NumCliente,
                    Nombres = c.Nombres,
                    Apellidos = c.Apellidos,
                    TipoDocumento = ObtenerDescripcionTipoDocumento(c.CodTipoDocumento),
                    NumeroDocumento = c.NumeroDocumento,
                    Telefono = c.NumeroTelefono,
                    Email = c.Correo,
                    Direccion = c.Direccion
                }).ToList();

                _view.CargarClientes(clientesGrid);
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al cargar clientes: {ex.Message}");
            }
        }

        private async Task<string> GenerarNumeroCliente()
        {
            try
            {
                var clientes = await _clienteService.GetClientes(string.Empty, 1);
                var ultimoCliente = clientes?.OrderByDescending(c => c.CodCliente).FirstOrDefault();
                
                if (ultimoCliente != null)
                {
                    if (int.TryParse(ultimoCliente.NumCliente, out int numeroActual))
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

        private async Task CrearCliente()
        {
            var nuevoCliente = new Cliente
            {
                NumCliente = _view.NumeroCliente,
                Nombres = _view.Nombre,
                Apellidos = _view.Apellido,
                CodTipoDocumento = int.Parse(_view.TipoDocumento),
                NumeroDocumento = _view.NumeroDocumento,
                NumeroTelefono = _view.Telefono,
                Correo = _view.Email,
                Direccion = _view.Direccion,
                Activo = true
            };

            await _clienteService.CreateCliente(nuevoCliente);
        }

        private async Task ActualizarCliente(int clienteId)
        {
            var clienteActualizado = new Cliente
            {
                CodCliente = clienteId,
                NumCliente = _view.NumeroCliente,
                Nombres = _view.Nombre,
                Apellidos = _view.Apellido,
                CodTipoDocumento = int.Parse(_view.TipoDocumento),
                NumeroDocumento = _view.NumeroDocumento,
                NumeroTelefono = _view.Telefono,
                Correo = _view.Email,
                Direccion = _view.Direccion,
                Activo = true
            };

            await _clienteService.UpdateCliente(clienteId, clienteActualizado);
        }

        private bool ValidarCamposRequeridos()
        {
            if (string.IsNullOrWhiteSpace(_view.Nombre))
            {
                _view.MostrarAdvertencia("Debe ingresar el nombre del cliente");
                _view.EnfocarCampo("nombre");
                return false;
            }

            if (string.IsNullOrWhiteSpace(_view.Apellido))
            {
                _view.MostrarAdvertencia("Debe ingresar el apellido del cliente");
                _view.EnfocarCampo("apellido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(_view.TipoDocumento))
            {
                _view.MostrarAdvertencia("Debe seleccionar el tipo de documento");
                _view.EnfocarCampo("tipodocumento");
                return false;
            }

            if (string.IsNullOrWhiteSpace(_view.NumeroDocumento))
            {
                _view.MostrarAdvertencia("Debe ingresar el número de documento");
                _view.EnfocarCampo("numerodocumento");
                return false;
            }

            return true;
        }

        private string ObtenerDescripcionTipoDocumento(int codigoTipoDocumento)
        {
            var tipo = TipoDocumentoHelper.ObtenerPorCodigo(codigoTipoDocumento.ToString());
            return tipo.HasValue ? TipoDocumentoHelper.ObtenerDescripcion(tipo.Value) : "DESCONOCIDO";
        }
    }
}