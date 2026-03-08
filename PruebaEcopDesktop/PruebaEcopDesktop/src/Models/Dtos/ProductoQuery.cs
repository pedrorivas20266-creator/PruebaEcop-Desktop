using System;

namespace PruebaECOP.Models.Dtos
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
        public double? CostoPromedio { get; set; }
        public double? CostoUltimo { get; set; }
        public bool Activo { get; set; } = true;
        public bool DescuentaStock { get; set; } = true;
        public DateTime? FecGra { get; set; }
        
        public double PrecioVenta { get; set; }
        public string DesUnidadMedida { get; set; } = string.Empty;
        public string DesCategoria { get; set; } = string.Empty;
    }
}