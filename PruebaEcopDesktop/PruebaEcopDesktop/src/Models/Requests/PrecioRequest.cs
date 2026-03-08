namespace PruebaECOP.Models.Requests
{
    public class PrecioRequest
    {
        public string NumPrecio { get; set; }
        public string DesPrecio { get; set; }
        public int CodTipoPrecio { get; set; }
        public double? PrecioVenta { get; set; }
    }
}