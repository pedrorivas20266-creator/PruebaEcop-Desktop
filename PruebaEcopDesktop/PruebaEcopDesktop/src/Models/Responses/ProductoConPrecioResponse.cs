using System;
using System.Collections.Generic;

namespace PruebaECOP.Models.Responses
{
    public class ProductoConPrecioResponse
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
        public bool Activo { get; set; }
        public bool DescuentaStock { get; set; }
        public DateTime? FecGra { get; set; }
        public List<PrecioResponse> Precios { get; set; }
    }
}