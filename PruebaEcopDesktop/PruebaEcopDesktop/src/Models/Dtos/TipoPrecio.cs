using System;

namespace PruebaECOP.Models.Dtos
{
    public class TipoPrecio
    {
        public int CodTipoPrecio { get; set; }
        public string NumTipoPrecio { get; set; }
        public string DesTipoPrecio { get; set; }
        public bool Activo { get; set; }
        public DateTime? FecGra { get; set; }
    }
}