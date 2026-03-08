using System.Configuration;

namespace PruebaEcopDesktop.Utils
{
    /// <summary>
    /// Clase para acceder a la configuración de la aplicación
    /// </summary>
    public static class AppConfig
    {
        /// <summary>
        /// Obtiene la URL base de la API desde el archivo de configuración
        /// </summary>
        public static string ApiBaseUrl
        {
            get
            {
                var url = ConfigurationManager.AppSettings["ApiBaseUrl"];

                if (string.IsNullOrEmpty(url))
                {
                    throw new ConfigurationErrorsException(
                        "No se encontró la configuración 'ApiBaseUrl' en App.config");
                }

                return url;
            }
        }

        /// <summary>
        /// Obtiene un valor de configuración personalizado
        /// </summary>
        public static string GetValue(string key, string defaultValue = null)
        {
            var value = ConfigurationManager.AppSettings[key];
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }
    }
}