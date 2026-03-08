using PruebaEcopDesktop.Utils;
using System;
using System.Windows.Forms;

namespace PruebaEcopDesktop.Views.Forms
{
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        private string nombreUsuario;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            CerrarAplicacion();
        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var formPedidos = new SolicitudPedidos(
                    ServiceLocator.ClienteService,
                    ServiceLocator.ProductoService,
                    ServiceLocator.PedidoService);
                formPedidos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de pedidos: {ex.Message}");
            }
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var formProductos = new ABMProductos(
                    ServiceLocator.ProductoService,
                    ServiceLocator.CategoriaService,
                    ServiceLocator.UnidadMedidaService);
                formProductos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de productos: {ex.Message}");
            }
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var formClientes = new ABMClientes(ServiceLocator.ClienteService);
                formClientes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de clientes: {ex.Message}");
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CerrarAplicacion();
        }

        private void CerrarAplicacion()
        {
            var resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                AuthHelper.CerrarSesion();
                this.Close();
            }
        }

        private void MenuPrincipal_Shown(object sender, EventArgs e)
        {
            this.Activate();
            this.ActiveControl = menuStrip1;
        }
    }
}
