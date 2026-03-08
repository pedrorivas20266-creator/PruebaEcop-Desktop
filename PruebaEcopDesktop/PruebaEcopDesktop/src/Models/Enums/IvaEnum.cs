namespace PruebaEcopDesktop.Models.Enums
{
    public enum IvaEnum
    {
        Exenta = 3,
        Iva5 = 2,
        Iva10 = 1
    }

    public static class IvaHelper
    {
        public static string ObtenerDescripcion(IvaEnum iva)
        {
            switch (iva)
            {
                case IvaEnum.Exenta:
                    return "EXENTA";
                case IvaEnum.Iva5:
                    return "IVA 5%";
                case IvaEnum.Iva10:
                    return "IVA 10%";
                default:
                    return string.Empty;
            }
        }

        public static string ObtenerCodigo(IvaEnum iva)
        {
            return ((int)iva).ToString();
        }

        public static IvaEnum? ObtenerPorCodigo(string codigo)
        {
            if (int.TryParse(codigo, out int valor))
            {
                if (valor == 3) return IvaEnum.Exenta;
                if (valor == 2) return IvaEnum.Iva5;
                if (valor == 1) return IvaEnum.Iva10;
            }
            return null;
        }

        public static IvaEnum? ObtenerPorDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                return null;

            var desc = descripcion.ToUpper().Trim();
            
            if (desc.Contains("EXENTA") || desc.Contains("EXENTO") || desc == "0")
                return IvaEnum.Exenta;
            
            if (desc.Contains("5") || desc.Contains("CINCO"))
                return IvaEnum.Iva5;
            
            if (desc.Contains("10") || desc.Contains("DIEZ"))
                return IvaEnum.Iva10;

            return null;
        }

        public static decimal ObtenerPorcentaje(IvaEnum iva)
        {
            return (decimal)iva / 100;
        }

        public static decimal CalcularIva(decimal monto, IvaEnum iva)
        {
            return monto * ObtenerPorcentaje(iva);
        }

        public static decimal CalcularPrecioConIva(decimal precioBase, IvaEnum iva)
        {
            return precioBase * (1 + ObtenerPorcentaje(iva));
        }
    }
}