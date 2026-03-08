using System;

namespace PruebaECOP.Models.Dtos
{
    public class Producto
    {
        public int CodProducto { get; set; }
        public string NumProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string DesProducto { get; set; }
        public int CodCategoria { get; set; }
        public int CodUnidadMedida { get; set; }
        public int CodIva { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal CostoPromedio { get; set; } = 0m;
        public decimal CostoUltimo { get; set; } = 0m;
        public bool Activo { get; set; }
        public bool DescuentaStock { get; set; }
        public DateTime? FecGra { get; set; }
        public string DesCategoria { get; set; }
        public string DesUnidadMedida { get; set; }
        public decimal PrecioVenta { get; set; } = 0m;
    }
}