using PruebaECOP.Api.Clients;
using PruebaECOP.Api.Interfaces;
using PruebaECOP.Services;
using PruebaECOP.Services.Interfaces;
using System.Net.Http;

namespace PruebaEcopDesktop.Utils
{
    /// <summary>
    /// Localizador de servicios para inyección de dependencias simple
    /// </summary>
    public static class ServiceLocator
    {
        private static HttpClient _httpClient;
        private static IAuthClient _authClient;
        private static IClienteClient _clienteClient;
        private static IProductoClient _productoClient;
        private static ICategoriaClient _categoriaClient;
        private static IUnidadMedidaClient _unidadMedidaClient;
        private static IPedidoClient _pedidoClient;
        private static IAuthService _authService;
        private static IClienteService _clienteService;
        private static IProductoService _productoService;
        private static ICategoriaService _categoriaService;
        private static IUnidadMedidaService _unidadMedidaService;
        private static IPedidoService _pedidoService;

        /// <summary>
        /// Inicializa todos los servicios y clientes
        /// </summary>
        public static void Inicializar()
        {
            // Crear HttpClient con la configuración
            _httpClient = ApiClientFactory.Create();

            // Inicializar Clients
            _authClient = new AuthClient(_httpClient);
            _clienteClient = new ClienteClient(_httpClient);
            _productoClient = new ProductoClient(_httpClient);
            _categoriaClient = new CategoriaClient(_httpClient);
            _unidadMedidaClient = new UnidadMedidaClient(_httpClient);
            _pedidoClient = new PedidoClient(_httpClient);

            // Inicializar Services
            _authService = new AuthService(_authClient);
            _clienteService = new ClienteService(_clienteClient);
            _productoService = new ProductoService(_productoClient);
            _categoriaService = new CategoriaService(_categoriaClient);
            _unidadMedidaService = new UnidadMedidaService(_unidadMedidaClient);
            _pedidoService = new PedidoService(_pedidoClient);
        }

        public static IAuthClient AuthClient => _authClient ?? throw new System.InvalidOperationException("ServiceLocator no inicializado. Llame a ServiceLocator.Inicializar() primero.");
        public static IClienteClient ClienteClient => _clienteClient ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static IProductoClient ProductoClient => _productoClient ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static ICategoriaClient CategoriaClient => _categoriaClient ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static IUnidadMedidaClient UnidadMedidaClient => _unidadMedidaClient ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static IPedidoClient PedidoClient => _pedidoClient ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");

        public static IAuthService AuthService => _authService ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static IClienteService ClienteService => _clienteService ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static IProductoService ProductoService => _productoService ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static ICategoriaService CategoriaService => _categoriaService ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static IUnidadMedidaService UnidadMedidaService => _unidadMedidaService ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");
        public static IPedidoService PedidoService => _pedidoService ?? throw new System.InvalidOperationException("ServiceLocator no inicializado.");

        /// <summary>
        /// Limpia todas las instancias
        /// </summary>
        public static void Limpiar()
        {
            _httpClient?.Dispose();
            _httpClient = null;

            _authClient = null;
            _clienteClient = null;
            _productoClient = null;
            _categoriaClient = null;
            _unidadMedidaClient = null;
            _pedidoClient = null;

            _authService = null;
            _clienteService = null;
            _productoService = null;
            _categoriaService = null;
            _unidadMedidaService = null;
            _pedidoService = null;
        }
    }
}