using System.Collections.Generic;

namespace PruebaEcopDesktop.Views.Interfaces
{
    public interface IABMProductosView
    {
        void EstablecerCodigoProducto(string codigoProducto);
        void EstablecerCategoria(string codigo, string descripcion);
        void EstablecerUnidadMedida(string codigo, string descripcion);
        void EstablecerIva(string codigo, string descripcion);
        void CargarProductos(IEnumerable<object> productos);
        void LimpiarCampos();
        void HabilitarEstadoNuevo();
        void HabilitarEstadoLectura();
        void MostrarError(string mensaje);
        void MostrarExito(string mensaje);
        void MostrarAdvertencia(string mensaje);
        bool ConfirmarOperacion(string mensaje, string titulo);
        void EnfocarCampo(string campo);
        void CargarDatosProducto(object producto);
        void MostrarSelectorCategoria();
        void MostrarSelectorUnidadMedida();
        void MostrarSelectorIva();
        string CodigoProducto { get; }
        string Descripcion { get; }
        string CodigoBarra { get; }
        string Categoria { get; }
        string UnidadMedida { get; }
        string Iva { get; }
        string Costo { get; }
        string PrecioVenta { get; }
        bool ActualizaStock { get; }
        bool Activo { get; }
        int? ProductoIdSeleccionado { get; }
    }
}