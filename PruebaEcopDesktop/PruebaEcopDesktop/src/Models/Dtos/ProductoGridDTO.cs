namespace PruebaEcopDesktop.Models.DTOs
{
    public class ProductoGridDTO
    {
        public int CodProducto { get; set; }
        public string NumProducto { get; set; }
        public string DesProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string Categoria { get; set; }
        public string UnidadMedida { get; set; }
        public string Iva { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool ActualizaStock { get; set; }
        public bool Activo { get; set; }
    }
}