using PruebaECOP.Api.Interfaces;
using PruebaEcopDesktop.Presenters;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace PruebaEcopDesktop.Views.Forms
{
    public partial class Login : MetroFramework.Forms.MetroForm, ILoginView
    {
        private LoginPresenter _presenter;

        public Login()
        {
            InitializeComponent();
        }

        public Login(IAuthClient authClient)
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, authClient);
        }

        #region "Implementación ILoginView"

        public string NombreUsuario => txtUsuario?.Text?.Trim() ?? string.Empty;

        public string ClaveUsuario => txtContrasena?.Text ?? string.Empty;

        public void MostrarError(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarError(mensaje)));
                return;
            }

            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarCargando(bool mostrar)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarCargando(mostrar)));
                return;
            }

            btnIniciarSesion.Enabled = !mostrar;
            txtUsuario.Enabled = !mostrar;
            txtContrasena.Enabled = !mostrar;
            btnMostrarContrasena.Enabled = !mostrar;

            this.UseWaitCursor = mostrar;
        }

        public void CerrarFormulario()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => CerrarFormulario()));
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void LimpiarCampos()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => LimpiarCampos()));
                return;
            }

            txtContrasena.Text = string.Empty;
            btnMostrarContrasena.Checked = false;
            txtUsuario.Focus();
        }

        #endregion

        #region "Eventos"

        private void Login_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.PasswordChar = '●';
            btnMostrarContrasena.Checked = false;

            txtUsuario?.Focus();
        }

        private void btnMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMostrarContrasena.Checked)
            {
                // Mostrar contraseña
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                // Ocultar contraseña
                txtContrasena.UseSystemPasswordChar = true;
                txtContrasena.PasswordChar = '●';
            }
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (_presenter == null)
            {
                MostrarError("El sistema no está configurado correctamente. Contacte al administrador.");
                return;
            }

            await _presenter.IniciarSesion();
        }

        private void lblOlvidasteContrasena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Por favor, contacte al administrador del sistema para recuperar su contraseña.",
                "Recuperar Contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtContrasena.Focus();
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnIniciarSesion_Click(sender, e);
            }
        }

        #endregion

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                txtUsuario.Focus();
            }));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
