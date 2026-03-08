using PruebaEcopDesktop.Views.Forms;
using System.Windows.Forms;

namespace PruebaEcopDesktop.Utils
{
    /// <summary>
    /// Clase auxiliar para operaciones de autenticación
    /// </summary>
    public static class AuthHelper
    {
        /// <summary>
        /// Cierra la sesión actual y regresa al formulario de login
        /// </summary>
        public static void CerrarSesion()
        {
            SessionManager.CerrarSesion();
            ApiClientFactory.Reset();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() != typeof(Login))
                {
                    form.Close();
                }
            }
        }

        /// <summary>
        /// Verifica si el usuario está autenticado
        /// </summary>
        public static bool VerificarAutenticacion()
        {
            return SessionManager.EstaAutenticado;
        }

        /// <summary>
        /// Obtiene el nombre del usuario autenticado
        /// </summary>
        public static string ObtenerNombreUsuario()
        {
            return SessionManager.NombreUsuario ?? "Usuario";
        }
    }
}