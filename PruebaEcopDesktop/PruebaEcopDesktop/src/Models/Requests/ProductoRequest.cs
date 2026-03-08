using System;
using System.Collections.Generic;

namespace PruebaECOP.Models.Requests
{
    public class ProductoRequest
    {
        public string NumProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string DesProducto { get; set; }
        public int CodCategoria { get; set; }
        public int CodUnidadMedida { get; set; }
        public int CodIva { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public double? CostoPromedio { get; set; }
        public double? CostoUltimo { get; set; }
        public bool DescuentaStock { get; set; }
        public List<PrecioRequest> Precios { get; set; }
    }
}