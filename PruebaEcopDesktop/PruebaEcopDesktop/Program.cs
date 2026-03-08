using PruebaEcopDesktop.Utils;
using PruebaEcopDesktop.Views.Forms;
using System;
using System.Windows.Forms;

namespace PruebaEcopDesktop
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                ServiceLocator.Inicializar();

                var loginForm = new Login(ServiceLocator.AuthClient);

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    if (SessionManager.EstaAutenticado)
                    {
                        string nombreUsuario = SessionManager.NombreUsuario ?? "Usuario";
                        var menuPrincipal = new MenuPrincipal(nombreUsuario);
                        Application.Run(menuPrincipal);
                    }
                    else
                    {
                        MessageBox.Show("Autenticación fallida. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la aplicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
