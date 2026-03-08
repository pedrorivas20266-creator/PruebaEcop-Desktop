using PruebaECOP.Api.Interfaces;
using PruebaECOP.Models.Requests;
using PruebaEcopDesktop.Utils;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Threading.Tasks;

namespace PruebaEcopDesktop.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IAuthClient _authClient;

        public LoginPresenter(ILoginView view, IAuthClient authClient)
        {
            _view = view;
            _authClient = authClient;
        }

        public async Task IniciarSesion()
        {
            try
            {
                if (!ValidarCampos())
                    return;

                _view.MostrarCargando(true);

                var loginRequest = new LoginRequest
                {
                    NombreUsuario = _view.NombreUsuario,
                    ClaveUsuario = _view.ClaveUsuario
                };

                var response = await _authClient.Login(loginRequest);

                if (response != null && !string.IsNullOrEmpty(response.AccessToken))
                {
                    GuardarToken(response);
                    _view.CerrarFormulario();
                }
                else
                {
                    _view.MostrarError("Credenciales inválidas. Por favor, intente nuevamente.");
                    _view.LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al iniciar sesión: {ex.Message}");
            }
            finally
            {
                _view.MostrarCargando(false);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(_view.NombreUsuario))
            {
                _view.MostrarError("Debe ingresar el nombre de usuario");
                return false;
            }

            if (string.IsNullOrWhiteSpace(_view.ClaveUsuario))
            {
                _view.MostrarError("Debe ingresar la contraseña");
                return false;
            }

            return true;
        }

        private void GuardarToken(PruebaECOP.Models.Responses.LoginResponse response)
        {
            SessionManager.Token = response.AccessToken;

            if (response.Usuario != null)
            {
                SessionManager.NombreUsuario = response.Usuario.Nombres;
                SessionManager.UsuarioId = response.Usuario.CodUsuario;
            }

            ApiClientFactory.ActualizarToken();
        }
    }
}