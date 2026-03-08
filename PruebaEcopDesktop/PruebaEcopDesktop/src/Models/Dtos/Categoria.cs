using System;

namespace PruebaECOP.Models.Dtos
{
    public class Categoria
    {
        public int CodCategoria { get; set; }
        public string NumCategoria { get; set; }
        public string DesCategoria { get; set; }
        public bool Activo { get; set; }
        public DateTime? FecGra { get; set; }
    }
}