using System;
using System.Collections.Generic;

namespace PruebaECOP.Models.Responses
{
    public class PedidoResponse
    {
        public int CodPedido { get; set; }
        public string NumPedido { get; set; }
        public DateTime? Fecha { get; set; }
        public int CodUsuario { get; set; }
        public int CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public int CodMoneda { get; set; }
        public double? Total { get; set; }
        public double? Iva { get; set; }
        public bool Activo { get; set; }
        public string MotivoAnulacion { get; set; }
        public DateTime? FecGra { get; set; }
        public List<PedidoDetalleResponse> Detalles { get; set; }
    }
}