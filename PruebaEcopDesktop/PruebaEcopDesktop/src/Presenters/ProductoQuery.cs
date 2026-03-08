using System;

namespace PruebaEcopDesktop.Presenters
{
    public class ProductoQuery
    {
        public int CodProducto { get; set; }
        public string NumProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string DesProducto { get; set; }
        public int CodCategoria { get; set; }
        public int CodUnidadMedida { get; set; }
        public int CodIva { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal CostoPromedio { get; set; }
        public decimal CostoUltimo { get; set; }
        public bool Activo { get; set; }
        public bool DescuentaStock { get; set; }
        public DateTime? FecGra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string DesCategoria { get; set; }
        public string DesUnidadMedida { get; set; }
    }
}