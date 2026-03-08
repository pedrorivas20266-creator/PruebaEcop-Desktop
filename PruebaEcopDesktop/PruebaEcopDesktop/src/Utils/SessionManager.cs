namespace PruebaEcopDesktop.Utils
{
    /// <summary>
    /// Clase estática para gestionar la sesión del usuario y el token de autenticación
    /// </summary>
    public static class SessionManager
    {
        private static string _token;
        private static string _nombreUsuario;
        private static int? _usuarioId;

        /// <summary>
        /// Token de autenticación JWT
        /// </summary>
        public static string Token
        {
            get => _token;
            set => _token = value;
        }

        /// <summary>
        /// Nombre del usuario autenticado
        /// </summary>
        public static string NombreUsuario
        {
            get => _nombreUsuario;
            set => _nombreUsuario = value;
        }

        /// <summary>
        /// ID del usuario autenticado
        /// </summary>
        public static int? UsuarioId
        {
            get => _usuarioId;
            set => _usuarioId = value;
        }

        /// <summary>
        /// Verifica si hay una sesión activa
        /// </summary>
        public static bool EstaAutenticado => !string.IsNullOrEmpty(_token);

        /// <summary>
        /// Limpia la sesión actual
        /// </summary>
        public static void CerrarSesion()
        {
            _token = null;
            _nombreUsuario = null;
            _usuarioId = null;
        }
    }
}