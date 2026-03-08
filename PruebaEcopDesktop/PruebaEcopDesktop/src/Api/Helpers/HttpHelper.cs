using Newtonsoft.Json;
using PruebaEcopDesktop.Utils;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PruebaECOP.Api.Helpers
{
    public static class HttpHelper
    {
        private static void ConfigurarAutorizacion(HttpClient http)
        {
            if (!string.IsNullOrEmpty(SessionManager.Token))
            {
                http.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", SessionManager.Token);
            }
        }

        public static async Task<T> GetAsync<T>(HttpClient http, string url)
        {
            ConfigurarAutorizacion(http);

            var response = await http.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static async Task<T> PostAsync<T>(HttpClient http, string url, object data)
        {
            ConfigurarAutorizacion(http);

            var json = JsonConvert.SerializeObject(data);
            System.Diagnostics.Debug.WriteLine($"[HttpHelper.PostAsync] URL: {url}");
            System.Diagnostics.Debug.WriteLine($"[HttpHelper.PostAsync] Request Data: {json}");

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await http.PostAsync(url, content);
            System.Diagnostics.Debug.WriteLine($"[HttpHelper.PostAsync] Status Code: {response.StatusCode}");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            System.Diagnostics.Debug.WriteLine($"[HttpHelper.PostAsync] Response Data: {result}");

            return JsonConvert.DeserializeObject<T>(result);
        }

        public static async Task<T> PutAsync<T>(HttpClient http, string url, object data)
        {
            ConfigurarAutorizacion(http);
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await http.PutAsync(url, content);
            var result = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<T>(result);
        }

        public static async Task DeleteAsync(HttpClient http, string url)
        {
            ConfigurarAutorizacion(http);

            var response = await http.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
        }
    }
}
