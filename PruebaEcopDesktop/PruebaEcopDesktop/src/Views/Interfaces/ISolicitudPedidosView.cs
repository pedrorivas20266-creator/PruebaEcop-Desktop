using PruebaEcopDesktop.Models.DTOs;
using System;
using System.Collections.Generic;

namespace PruebaEcopDesktop.Views.Interfaces
{
    public interface ISolicitudPedidosView
    {
        void EstablecerCliente(string id, string codigo, string nombre);
        void EstablecerProducto(string id, string codigo, string descripcion);
        void EstablecerPrecioProducto(decimal precio);
        void MostrarError(string mensaje);
        void EnfocarCampo(string campo);
        void AgregarDetallePedido(string productoId, string codigo, string descripcion, decimal cantidad, decimal precioUnitario, decimal subtotal);
        void ActualizarTotal(decimal total);
        void LimpiarDetalle();
        void CargarDetalleParaEdicion(string productoId, string codigo, string descripcion, decimal cantidad, decimal precioUnitario);
        void EliminarFilaDetalle(int indice);
        bool ConfirmarOperacion(string mensaje, string titulo);
        void MostrarInformacion(string mensaje, string titulo);

        string ClienteId { get; }
        string NumeroPedido { get; }
        DateTime FechaPedido { get; }
        decimal Total { get; }
        List<DetallePedidoDTO> ObtenerDetallesPedido();
    }
}