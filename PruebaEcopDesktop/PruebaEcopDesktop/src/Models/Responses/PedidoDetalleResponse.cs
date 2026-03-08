namespace PruebaECOP.Models.Responses
{
    public class PedidoDetalleResponse
    {
        public int CodPedidoDetalle { get; set; }
        public int CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public double? Cantidad { get; set; }
        public double? PrecioUnitario { get; set; }
        public double? Subtotal { get; set; }
        public int LineaNumero { get; set; }
    }
}