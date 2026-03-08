using System;

namespace PruebaECOP.Models.Dtos
{
    public class UnidadMedida
    {
        public int CodUnidadMedida { get; set; }
        public string NumUnidadMedida { get; set; }
        public string DesUnidadMedida { get; set; }
        public bool Activo { get; set; }
        public DateTime? FecGra { get; set; }
    }
}