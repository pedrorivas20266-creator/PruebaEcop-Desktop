using System.Collections.Generic;

namespace PruebaEcopDesktop.Views.Interfaces
{
    public interface IABMClientesView
    {
        void EstablecerNumeroCliente(string numeroCliente);
        void EstablecerTipoDocumento(string codigo, string descripcion);
        void CargarClientes(IEnumerable<object> clientes);
        void LimpiarCampos();
        void HabilitarEstadoNuevo();
        void HabilitarEstadoLectura();
        void MostrarError(string mensaje);
        void MostrarExito(string mensaje);
        void MostrarAdvertencia(string mensaje);
        bool ConfirmarOperacion(string mensaje, string titulo);
        void EnfocarCampo(string campo);
        void CargarDatosCliente(object cliente);
        void MostrarSelectorTipoDocumento();
        string NumeroCliente { get; }
        string Nombre { get; }
        string Apellido { get; }
        string TipoDocumento { get; }
        string NumeroDocumento { get; }
        string Telefono { get; }
        string Email { get; }
        string Direccion { get; }
        int? ClienteIdSeleccionado { get; }
    }
}