using PruebaECOP.Services.Interfaces;
using PruebaEcopDesktop.Models.DTOs;
using PruebaEcopDesktop.Models.Enums;
using PruebaEcopDesktop.Presenters;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PruebaEcopDesktop.Views.Forms
{
    public partial class SolicitudPedidos : MetroFramework.Forms.MetroForm, ISolicitudPedidosView
    {
        private DataTable dtDetalle;
        private SolicitudPedidosPresenter _presenter;
        private bool _datosModificados = false;
        const string titulo = "Solicitud de Pedidos";

        public string ClienteId => txtcliente.Tag?.ToString() ?? "0";
        public string NumeroPedido => TextBox4.Text;
        public DateTime FechaPedido => DateTime.ParseExact(fecha1.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        public decimal Total
        {
            get
            {
                if (decimal.TryParse(txtMoneda6.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal total))
                    return total;
                return 0;
            }
        }

        public List<DetallePedidoDTO> ObtenerDetallesPedido()
        {
            var detalles = new List<DetallePedidoDTO>();

            foreach (DataRow row in dtDetalle.Rows)
            {
                detalles.Add(new DetallePedidoDTO
                {
                    ProductoId = int.Parse(row["ProductoId"].ToString()),
                    Codigo = row["Codigo"].ToString(),
                    Descripcion = row["Descripcion"].ToString(),
                    Cantidad = Convert.ToDecimal(row["Cantidad"]),
                    PrecioUnitario = Convert.ToDecimal(row["PrecioUnitario"]),
                    Subtotal = Convert.ToDecimal(row["Subtotal"])
                });
            }

            return detalles;
        }

        public SolicitudPedidos()
        {
            InitializeComponent();
            InicializarDataTableDetalle();
        }

        public SolicitudPedidos(IClienteService clienteService, IProductoService productoService, IPedidoService pedidoService)
        {
            InitializeComponent();
            InicializarDataTableDetalle();
            _presenter = new SolicitudPedidosPresenter(this, clienteService, productoService, pedidoService);
            this.FormClosing += SolicitudPedidos_FormClosing;
        }

        private void SolicitudPedidos_Load(object sender, EventArgs e)
        {
            NuevoPedido();
        }

        private void InicializarDataTableDetalle()
        {
            dtDetalle = new DataTable();
            dtDetalle.Columns.Add("ProductoId", typeof(string));
            dtDetalle.Columns.Add("Codigo", typeof(string));
            dtDetalle.Columns.Add("Descripcion", typeof(string));
            dtDetalle.Columns.Add("Cantidad", typeof(decimal));
            dtDetalle.Columns.Add("PrecioUnitario", typeof(decimal));
            dtDetalle.Columns.Add("Subtotal", typeof(decimal));

            if (dgdetallepedido != null)
            {
                dgdetallepedido.DataSource = dtDetalle;
                ConfigurarDataGridViewDetalle();
            }
        }

        private void ConfigurarDataGridViewDetalle()
        {
            dgdetallepedido.ReadOnly = true;
            dgdetallepedido.AllowUserToAddRows = false;
            dgdetallepedido.AllowUserToDeleteRows = false;
            dgdetallepedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgdetallepedido.MultiSelect = false;

            dgdetallepedido.RowsDefaultCellStyle.BackColor = Color.White;
            dgdetallepedido.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgdetallepedido.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            dgdetallepedido.DefaultCellStyle.SelectionForeColor = Color.White;
            dgdetallepedido.RowHeadersVisible = false;
            dgdetallepedido.BackgroundColor = Color.White;

            if (dgdetallepedido.Columns.Contains("ProductoId"))
                dgdetallepedido.Columns["ProductoId"].Visible = false;

            if (dgdetallepedido.Columns.Contains("Codigo"))
            {
                dgdetallepedido.Columns["Codigo"].HeaderText = "Código";
                dgdetallepedido.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgdetallepedido.Columns["Codigo"].Width = 100;
            }

            if (dgdetallepedido.Columns.Contains("Descripcion"))
            {
                dgdetallepedido.Columns["Descripcion"].HeaderText = "Descripción";
                dgdetallepedido.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgdetallepedido.Columns.Contains("Cantidad"))
            {
                dgdetallepedido.Columns["Cantidad"].HeaderText = "Cantidad";
                dgdetallepedido.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgdetallepedido.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgdetallepedido.Columns["Cantidad"].Width = 80;
            }

            if (dgdetallepedido.Columns.Contains("PrecioUnitario"))
            {
                dgdetallepedido.Columns["PrecioUnitario"].HeaderText = "Precio Unit.";
                dgdetallepedido.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
                dgdetallepedido.Columns["PrecioUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgdetallepedido.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgdetallepedido.Columns["PrecioUnitario"].Width = 100;
            }

            if (dgdetallepedido.Columns.Contains("Subtotal"))
            {
                dgdetallepedido.Columns["Subtotal"].HeaderText = "Subtotal";
                dgdetallepedido.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
                dgdetallepedido.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgdetallepedido.Columns["Subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgdetallepedido.Columns["Subtotal"].Width = 100;
            }

            dgdetallepedido.ClearSelection();
        }

        private void NuevoPedido()
        {
            LimpiarCamposCargaCabecera();
            LimpiarCamposCargaDetalle();
            LimpiarCamposCargaTotales();

            if (dtDetalle != null)
            {
                dtDetalle.Clear();
            }

            _datosModificados = false;
            txtcliente.Focus();
        }

        private void LimpiarCamposCargaCabecera()
        {
            txttipocompro.Text = "PED";
            lbltipocompro.Text = "Pedido de Venta";
            fecha1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtcliente.Tag = 0;
            txtcliente.Text = "";
            lblcliente.Text = "";
            TextBox4.Text = GenerarNumeroPedido().ToString();
        }

        private void LimpiarCamposCargaDetalle()
        {
            txtcodigo.Tag = 0;
            txtcodigo.Text = "";
            txtdescripcionproducto.Text = "";
            txtMoneda7.Text = "0";
            txtMoneda1.Text = "0";
            txtMoneda9.Text = "0";
        }

        private void LimpiarCamposCargaTotales()
        {
            txtMoneda6.Text = "0";
        }

        private int GenerarNumeroPedido()
        {
            return 0;
        }

        public void EstablecerCliente(string id, string codigo, string nombre)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerCliente(id, codigo, nombre)));
                return;
            }

            txtcliente.Tag = id;
            txtcliente.Text = id;
            lblcliente.Text = nombre;
        }

        public void EstablecerProducto(string id, string codigo, string descripcion)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerProducto(id, codigo, descripcion)));
                return;
            }

            txtcodigo.Tag = id;
            txtcodigo.Text = codigo;
            txtdescripcionproducto.Text = descripcion;
        }

        public void EstablecerPrecioProducto(decimal precio)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerPrecioProducto(precio)));
                return;
            }

            txtMoneda7.Text = precio.ToString("N2");
            CalcularSubtotal();
        }

        public void MostrarError(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarError(mensaje)));
                return;
            }

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarInformacion(string mensaje, string titulo)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarInformacion(mensaje, titulo)));
                return;
            }

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ConfirmarOperacion(string mensaje, string titulo)
        {
            if (InvokeRequired)
            {
                return (bool)Invoke(new Func<bool>(() => ConfirmarOperacion(mensaje, titulo)));
            }

            DialogResult result = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public void EnfocarCampo(string campo)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EnfocarCampo(campo)));
                return;
            }

            switch (campo.ToLower())
            {
                case "producto":
                case "codigo":
                    txtcodigo.Focus();
                    break;
                case "cantidad":
                    txtMoneda1.Focus();
                    break;
                case "cliente":
                    txtcliente.Focus();
                    break;
                case "btncargardetalle":
                    btncargardetalle.Focus();
                    break;
                case "btngrabar":
                    btngrabar.Focus();
                    break;
                case "btncancelar":
                    bencancelar.Focus();
                    break;
            }
        }

        public void AgregarDetallePedido(string productoId, string codigo, string descripcion, decimal cantidad, decimal precioUnitario, decimal subtotal)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AgregarDetallePedido(productoId, codigo, descripcion, cantidad, precioUnitario, subtotal)));
                return;
            }

            DataRow row = dtDetalle.NewRow();
            row["ProductoId"] = productoId;
            row["Codigo"] = codigo;
            row["Descripcion"] = descripcion;
            row["Cantidad"] = cantidad;
            row["PrecioUnitario"] = precioUnitario;
            row["Subtotal"] = subtotal;

            dtDetalle.Rows.Add(row);
            _datosModificados = true;

            RecalcularTotal();
        }

        public void ActualizarTotal(decimal total)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarTotal(total)));
                return;
            }

            txtMoneda6.Text = total.ToString("N2");
        }

        public void LimpiarDetalle()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => LimpiarDetalle()));
                return;
            }

            LimpiarCamposCargaDetalle();
        }

        public void CargarDetalleParaEdicion(string productoId, string codigo, string descripcion, decimal cantidad, decimal precioUnitario)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => CargarDetalleParaEdicion(productoId, codigo, descripcion, cantidad, precioUnitario)));
                return;
            }

            txtcodigo.Tag = productoId;
            txtcodigo.Text = codigo;
            txtdescripcionproducto.Text = descripcion;
            txtMoneda1.Text = cantidad.ToString("N2");
            txtMoneda7.Text = precioUnitario.ToString("N2");
            CalcularSubtotal();
            txtMoneda1.Focus();
        }

        public void EliminarFilaDetalle(int indice)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EliminarFilaDetalle(indice)));
                return;
            }

            if (indice >= 0 && indice < dtDetalle.Rows.Count)
            {
                dtDetalle.Rows.RemoveAt(indice);
                _datosModificados = true;
                RecalcularTotal();
            }
        }

        private void txtcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtcodigo.Focus();
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = true;
                AbrirBuscadorCliente();
            }
        }

        private async void txtcliente_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtcliente.Text) && _presenter != null)
            {
                await _presenter.ValidarClientePorCodigo(txtcliente.Text.Trim());
            }
            txtcodigo.Focus();
        }

        private async void txtcodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (string.IsNullOrWhiteSpace(txtcodigo.Text))
                {
                    if (dtDetalle.Rows.Count == 0)
                    {
                        MostrarError("Debe agregar al menos un producto al pedido");
                        txtcodigo.Focus();
                        return;
                    }

                    bool confirmar = ConfirmarOperacion(
                        "¿Desea terminar y guardar el pedido?",
                        "Confirmar Pedido"
                    );

                    if (confirmar)
                    {
                        btngrabar.Focus();
                        btngrabar_Click(sender, e);
                    }
                    else
                    {
                        bool cancelar = ConfirmarOperacion(
                            "¿Desea cancelar el pedido actual?",
                            "Cancelar Pedido"
                        );

                        if (cancelar)
                        {
                            NuevoPedido();
                        }
                        else
                        {
                            txtcodigo.Focus();
                        }
                    }
                }
                else
                {
                    txtMoneda1.Focus();
                }
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = true;
                AbrirBuscadorProducto();
            }
        }

        private async void txtcodigo_Validated(object sender, EventArgs e)
        {
            if (txtcodigo.Tag != null)
            {
                txtMoneda1.Focus();
            }
            else
            {
                btngrabar.Focus();
            }
        }

        private async void txtMoneda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && _presenter != null)
            {
                e.Handled = true;
                CalcularSubtotal();

                await _presenter.ValidarYAgregarDetalle(
                    txtcodigo.Tag?.ToString() ?? "0",
                    txtcodigo.Text,
                    txtdescripcionproducto.Text,
                    txtMoneda1.Text,
                    txtMoneda7.Text
                );
            }
        }

        private void txtMoneda1_Validated(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private async void btncargardetalle_Click(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                CalcularSubtotal();

                await _presenter.ValidarYAgregarDetalle(
                    txtcodigo.Tag?.ToString() ?? "0",
                    txtcodigo.Text,
                    txtdescripcionproducto.Text,
                    txtMoneda1.Text,
                    txtMoneda7.Text
                );
            }
        }

        private void btneditardetalle_Click(object sender, EventArgs e)
        {
            if (dgdetallepedido.SelectedRows.Count == 0)
            {
                MostrarError("Debe seleccionar una fila para editar");
                return;
            }

            int indiceSeleccionado = dgdetallepedido.SelectedRows[0].Index;
            DataRow row = dtDetalle.Rows[indiceSeleccionado];

            CargarDetalleParaEdicion(
                row["ProductoId"].ToString(),
                row["Codigo"].ToString(),
                row["Descripcion"].ToString(),
                Convert.ToDecimal(row["Cantidad"]),
                Convert.ToDecimal(row["PrecioUnitario"])
            );

            EliminarFilaDetalle(indiceSeleccionado);
        }

        private void btnborrardetalle_Click(object sender, EventArgs e)
        {
            if (dgdetallepedido.SelectedRows.Count == 0)
            {
                MostrarError("Debe seleccionar una fila para eliminar");
                return;
            }

            bool confirmar = ConfirmarOperacion(
                "¿Está seguro que desea eliminar este producto del pedido?",
                "Confirmar Eliminación"
            );

            if (confirmar)
            {
                int indiceSeleccionado = dgdetallepedido.SelectedRows[0].Index;
                EliminarFilaDetalle(indiceSeleccionado);
                MostrarInformacion("Producto eliminado correctamente", "Información");
            }
        }

        private async void btngrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcliente.Tag?.ToString()) || txtcliente.Tag.ToString() == "0")
            {
                MostrarError("Debe seleccionar un cliente");
                txtcliente.Focus();
                return;
            }

            if (dtDetalle.Rows.Count == 0)
            {
                MostrarError("Debe agregar al menos un producto al pedido");
                txtcodigo.Focus();
                return;
            }

            bool confirmar = ConfirmarOperacion(
                "¿Está seguro que desea guardar el pedido?",
                "Confirmar Guardado"
            );

            if (confirmar && _presenter != null)
            {
                bool resultado = await _presenter.GuardarPedido();

                if (resultado)
                {
                    _datosModificados = false;
                    NuevoPedido();
                }
            }
        }

        private void bencancelar_Click(object sender, EventArgs e)
        {
            if (_datosModificados)
            {
                bool confirmar = ConfirmarOperacion(
                    "Hay cambios sin guardar. ¿Está seguro que desea cancelar?",
                    "Confirmar Cancelación"
                );

                if (!confirmar)
                    return;
            }

            NuevoPedido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void dgdetallepedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgdetallepedido_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dgdetallepedido.ClearSelection();
        }

        private void SolicitudPedidos_Click(object sender, EventArgs e)
        {
            dgdetallepedido.ClearSelection();
        }

        private void SolicitudPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_datosModificados)
            {
                bool confirmar = ConfirmarOperacion(
                    "Hay cambios sin guardar. ¿Está seguro que desea salir?",
                    "Confirmar Salida"
                );

                if (!confirmar)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void AbrirBuscadorCliente()
        {
            if (_presenter == null)
            {
                MessageBox.Show("El presenter no está configurado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var buscador = new Buscador777(
                BuscadorEntidad.Cliente,
                titulo: "CLIENTES",
                buscar3Campos: true,
                clienteService: _presenter.ObtenerClienteService()
            );

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                _presenter.ClienteSeleccionado(
                    buscador.CodCampo,
                    buscador.NumCampo,
                    buscador.DesCampo
                );
            }
        }

        private async void AbrirBuscadorProducto()
        {
            if (_presenter == null)
            {
                MessageBox.Show("El presenter no está configurado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var buscador = new Buscador777(
                BuscadorEntidad.Producto,
                titulo: "PRODUCTOS",
                buscar3Campos: true,
                productoService: _presenter.ObtenerProductoService()
            );

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                await _presenter.ProductoSeleccionado(
                    buscador.CodCampo,
                    buscador.NumCampo,
                    buscador.DesCampo
                );
            }
        }

        private void CalcularSubtotal()
        {
            try
            {
                decimal precioUnitario = decimal.Parse(txtMoneda7.Text);
                decimal cantidad = decimal.Parse(txtMoneda1.Text);
                decimal subtotal = precioUnitario * cantidad;

                txtMoneda9.Text = subtotal.ToString("N2");
            }
            catch
            {
                txtMoneda9.Text = "0.00";
            }
        }

        private void RecalcularTotal()
        {
            try
            {
                decimal total = 0;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    total += Convert.ToDecimal(row["Subtotal"]);
                }

                ActualizarTotal(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CerrarFormulario()
        {
            if (_datosModificados)
            {
                bool confirmar = ConfirmarOperacion(
                    "Hay cambios sin guardar. ¿Está seguro que desea salir?",
                    "Confirmar Salida"
                );

                if (confirmar)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void SolicitudPedidos_Shown(object sender, EventArgs e)
        {
            this.Activate();
            this.ActiveControl = txtcliente;
        }
    }
}
