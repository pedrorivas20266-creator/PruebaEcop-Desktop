namespace PruebaEcopDesktop.Models.DTOs
{
    public class DetallePedidoDTO
    {
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}