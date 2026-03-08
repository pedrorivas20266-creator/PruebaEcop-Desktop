namespace PruebaEcopDesktop.Models.Enums
{
    public enum TipoDocumentoEnum
    {
        CedulaIdentidad = 1,
        RucContribuyente = 2
    }

    public static class TipoDocumentoHelper
    {
        public static string ObtenerDescripcion(TipoDocumentoEnum tipo)
        {
            switch (tipo)
            {
                case TipoDocumentoEnum.CedulaIdentidad:
                    return "CÉDULA DE IDENTIDAD";
                case TipoDocumentoEnum.RucContribuyente:
                    return "RUC DE CONTRIBUYENTE";
                default:
                    return string.Empty;
            }
        }

        public static string ObtenerCodigo(TipoDocumentoEnum tipo)
        {
            return ((int)tipo).ToString();
        }

        public static TipoDocumentoEnum? ObtenerPorCodigo(string codigo)
        {
            if (int.TryParse(codigo, out int valor))
            {
                if (valor == 1) return TipoDocumentoEnum.CedulaIdentidad;
                if (valor == 2) return TipoDocumentoEnum.RucContribuyente;
            }
            return null;
        }

        public static TipoDocumentoEnum? ObtenerPorDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                return null;

            var desc = descripcion.ToUpper().Trim();
            
            if (desc.Contains("CEDULA") || desc.Contains("CÉDULA") || desc.Contains("IDENTIDAD") || desc == "1")
                return TipoDocumentoEnum.CedulaIdentidad;
            
            if (desc.Contains("RUC") || desc.Contains("CONTRIBUYENTE") || desc == "2")
                return TipoDocumentoEnum.RucContribuyente;

            return null;
        }
    }
}