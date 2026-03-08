using PruebaEcopDesktop.Utils;
using PruebaEcopDesktop.Utils;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PruebaEcopDesktop.Utils
{
    public static class ApiClientFactory
    {
        private static HttpClient _client;

        /// <summary>
        /// Crea o retorna la instancia única de HttpClient con la URL base configurada
        /// </summary>
        public static HttpClient Create()
        {
            if (_client != null)
            {
                ActualizarToken();
                return _client;
            }

            var baseUrl = AppConfig.ApiBaseUrl;
            
            _client = new HttpClient();
            _client.BaseAddress = new Uri(baseUrl);

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            ActualizarToken();

            return _client;
        }

        /// <summary>
        /// Crea o retorna la instancia única de HttpClient (sobrecarga con URL personalizada)
        /// </summary>
        public static HttpClient Create(string baseUrl, string token = null)
        {
            if (_client != null)
            {
                ActualizarToken();
                return _client;
            }

            _client = new HttpClient();
            _client.BaseAddress = new Uri(baseUrl);

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            if (!string.IsNullOrEmpty(token))
            {
                SessionManager.Token = token;
            }

            ActualizarToken();

            return _client;
        }

        /// <summary>
        /// Actualiza el token de autorización en el HttpClient
        /// </summary>
        public static void ActualizarToken()
        {
            if (_client == null)
                return;

            if (!string.IsNullOrEmpty(SessionManager.Token))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", SessionManager.Token);
            }
            else
            {
                _client.DefaultRequestHeaders.Authorization = null;
            }
        }

        /// <summary>
        /// Limpia la instancia del HttpClient (útil para cerrar sesión)
        /// </summary>
        public static void Reset()
        {
            _client?.Dispose();
            _client = null;
        }
    }
}
