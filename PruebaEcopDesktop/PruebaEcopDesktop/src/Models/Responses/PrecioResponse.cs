namespace PruebaECOP.Models.Responses
{
    public class PrecioResponse
    {
        public int CodPrecio { get; set; }
        public string NumPrecio { get; set; }
        public string DesPrecio { get; set; }
        public int CodProducto { get; set; }
        public int CodTipoPrecio { get; set; }
        public double? PrecioVenta { get; set; }
        public bool Activo { get; set; }
        public System.DateTime? FecGra { get; set; }
    }
}