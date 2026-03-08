using System;
using System.Collections.Generic;

namespace PruebaECOP.Models.Requests
{
    public class PedidoRequest
    {
        public string NumPedido { get; set; }
        public DateTime? Fecha { get; set; }
        public int CodUsuario { get; set; }
        public int CodCliente { get; set; }
        public int CodMoneda { get; set; } = 1; // Valor por defecto
        public List<PedidoDetalleRequest> Detalles { get; set; }
    }

    public class PedidoDetalleRequest
    {
        public int CodProducto { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public int LineaNumero { get; set; }
    }
}