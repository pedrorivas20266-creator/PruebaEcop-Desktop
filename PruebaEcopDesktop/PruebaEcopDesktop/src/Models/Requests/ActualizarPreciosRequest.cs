using System.Collections.Generic;

namespace PruebaECOP.Models.Requests
{
    public class ActualizarPreciosRequest
    {
        public List<ActualizarPrecioItem> Precios { get; set; }
    }
}