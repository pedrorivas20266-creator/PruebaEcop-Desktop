using System.Collections.Generic;

namespace PruebaEcopDesktop.Views.Interfaces
{
    public interface IBuscadorView
    {
        void MostrarResultados(IEnumerable<object> datos);
        string TextoBusqueda { get; }
        void ActualizarCantidad(int cantidad);
        void MostrarError(string mensaje);
        bool HabilitarFecha { get; set; }
        int TipoBusqueda { get; }
    }
}