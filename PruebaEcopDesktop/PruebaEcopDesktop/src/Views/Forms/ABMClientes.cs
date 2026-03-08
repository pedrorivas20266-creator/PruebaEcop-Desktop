using PruebaECOP.Models.Dtos;
using PruebaECOP.Services.Interfaces;
using PruebaEcopDesktop.Models.DTOs;
using PruebaEcopDesktop.Models.Enums;
using PruebaEcopDesktop.Presenters;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PruebaEcopDesktop.Views.Forms
{
    public partial class ABMClientes : MetroFramework.Forms.MetroForm, IABMClientesView
    {
        private ABMClientesPresenter _presenter;
        private int? _clienteIdSeleccionado = null;
        const string titulo = "Gestión de Clientes";

        public ABMClientes()
        {
            InitializeComponent();
        }

        public ABMClientes(IClienteService clienteService)
        {
            InitializeComponent();
            _presenter = new ABMClientesPresenter(this, clienteService);
            this.FormClosing += ABMClientes_FormClosing;
        }

        private void ABMClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btngrabar.Enabled && btncancelar.Enabled)
            {
                if (!ConfirmarOperacion("Hay cambios sin guardar. ¿Desea cerrar sin guardar?", "Confirmar cierre"))
                {
                    e.Cancel = true;
                    return;
                }
            }

            e.Cancel = false;
        }

        private async void ABMClientes_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            if (_presenter != null)
            {
                await _presenter.InicializarFormulario();
            }
        }

        #region "Configuración Grilla"

        private void ConfigurarGrilla()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CodCliente",
                HeaderText = "ID",
                DataPropertyName = "CodCliente",
                Visible = false
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumCliente",
                HeaderText = "N° Cliente",
                DataPropertyName = "NumCliente",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombres",
                HeaderText = "Nombres",
                DataPropertyName = "Nombres",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Apellidos",
                HeaderText = "Apellidos",
                DataPropertyName = "Apellidos",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TipoDocumento",
                HeaderText = "Tipo Doc.",
                DataPropertyName = "TipoDocumento",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumeroDocumento",
                HeaderText = "N° Documento",
                DataPropertyName = "NumeroDocumento",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Telefono",
                HeaderText = "Teléfono",
                DataPropertyName = "Telefono",
                Width = 120
            });

            dataGridView1.ClearSelection();
        }

        #endregion

        #region "Implementación IABMClientesView"

        public string NumeroCliente => txtnumcliente.Text.Trim();
        public string Nombre => txtnombre.Text.Trim();
        public string Apellido => txtapellido.Text.Trim();
        public string TipoDocumento => txttipodocumento.Tag?.ToString() ?? string.Empty;
        public string NumeroDocumento => txtdocumento.Text.Trim();
        public string Telefono => txttelefono.Text.Trim();
        public string Email => txtemail.Text.Trim();
        public string Direccion => txtdireccion.Text.Trim();
        public int? ClienteIdSeleccionado => _clienteIdSeleccionado;

        public void EstablecerNumeroCliente(string numeroCliente)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerNumeroCliente(numeroCliente)));
                return;
            }

            txtnumcliente.Text = numeroCliente;
        }

        public void EstablecerTipoDocumento(string codigo, string descripcion)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerTipoDocumento(codigo, descripcion)));
                return;
            }

            txttipodocumento.Tag = codigo;
            txttipodocumento.Text = codigo;
            lbltipodocumento.Text = descripcion;
        }

        public void CargarClientes(IEnumerable<object> clientes)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => CargarClientes(clientes)));
                return;
            }

            var listaClientes = clientes.Cast<ClienteGridDTO>().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaClientes;
            dataGridView1.ClearSelection();
            _clienteIdSeleccionado = null;
        }

        public void LimpiarCampos()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LimpiarCampos));
                return;
            }

            txtnumcliente.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txttipodocumento.Tag = null;
            txttipodocumento.Text = string.Empty;
            txtdocumento.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            _clienteIdSeleccionado = null;
            lbltipodocumento.Text = string.Empty;
            txtbusqueda.Text = string.Empty;
            dataGridView1.ClearSelection();
            txtnombre.Focus();
        }

        public void HabilitarEstadoNuevo()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(HabilitarEstadoNuevo));
                return;
            }

            txtnumcliente.Enabled = false;
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txttipodocumento.Enabled = true;
            txtdocumento.Enabled = true;
            txttelefono.Enabled = true;
            txtemail.Enabled = true;
            txtdireccion.Enabled = true;

            btnnuevo.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btngrabar.Enabled = true;
            btncancelar.Enabled = true;

            dataGridView1.Enabled = false;
        }

        public void HabilitarEstadoLectura()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(HabilitarEstadoLectura));
                return;
            }

            txtnumcliente.Enabled = false;
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txttipodocumento.Enabled = false;
            txtdocumento.Enabled = false;
            txttelefono.Enabled = false;
            txtemail.Enabled = false;
            txtdireccion.Enabled = false;

            btngrabar.Enabled = false;
            btncancelar.Enabled = false;

            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            btnnuevo.Enabled = true;
            dataGridView1.Enabled = true;
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

        public void MostrarExito(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarExito(mensaje)));
                return;
            }

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MostrarAdvertencia(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarAdvertencia(mensaje)));
                return;
            }

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                case "nombre":
                    txtnombre.Focus();
                    break;
                case "apellido":
                    txtapellido.Focus();
                    break;
                case "tipodocumento":
                    txttipodocumento.Focus();
                    break;
                case "numerodocumento":
                case "documento":
                    txtdocumento.Focus();
                    break;
                case "telefono":
                    txttelefono.Focus();
                    break;
                case "email":
                    txtemail.Focus();
                    break;
                case "direccion":
                    txtdireccion.Focus();
                    break;
            }
        }

        public void CargarDatosCliente(object cliente)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => CargarDatosCliente(cliente)));
                return;
            }

            Cliente c = cliente as Cliente;
            if (c == null) return;

            _clienteIdSeleccionado = c.CodCliente;
            txtnumcliente.Text = c.NumCliente;
            txtnombre.Text = c.Nombres;
            txtapellido.Text = c.Apellidos;

            var tipoDoc = TipoDocumentoHelper.ObtenerPorCodigo(c.CodTipoDocumento.ToString());
            if (tipoDoc.HasValue)
            {
                txttipodocumento.Tag = c.CodTipoDocumento.ToString();
                txttipodocumento.Text = TipoDocumentoHelper.ObtenerDescripcion(tipoDoc.Value);
            }

            txtdocumento.Text = c.NumeroDocumento;
            txttelefono.Text = c.NumeroTelefono ?? string.Empty;
            txtemail.Text = c.Correo ?? string.Empty;
            txtdireccion.Text = c.Direccion ?? string.Empty;
        }

        public void MostrarSelectorTipoDocumento()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(MostrarSelectorTipoDocumento));
                return;
            }

            using (var form = new Form())
            {
                form.Text = "Seleccionar Tipo de Documento";
                form.Size = new Size(400, 200);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                var listBox = new ListBox
                {
                    Location = new Point(20, 20),
                    Size = new Size(350, 80),
                    Font = new Font("Trebuchet MS", 10)
                };

                listBox.Items.Add("1 - CÉDULA DE IDENTIDAD");
                listBox.Items.Add("2 - RUC DE CONTRIBUYENTE");

                var btnAceptar = new Button
                {
                    Text = "Aceptar",
                    DialogResult = DialogResult.OK,
                    Location = new Point(200, 120),
                    Size = new Size(80, 30)
                };

                var btnCancelar = new Button
                {
                    Text = "Cancelar",
                    DialogResult = DialogResult.Cancel,
                    Location = new Point(290, 120),
                    Size = new Size(80, 30)
                };

                form.Controls.Add(listBox);
                form.Controls.Add(btnAceptar);
                form.Controls.Add(btnCancelar);
                form.AcceptButton = btnAceptar;
                form.CancelButton = btnCancelar;

                if (form.ShowDialog() == DialogResult.OK && listBox.SelectedIndex >= 0)
                {
                    var seleccion = listBox.SelectedIndex + 1;
                    var tipo = TipoDocumentoHelper.ObtenerPorCodigo(seleccion.ToString());
                    if (tipo.HasValue)
                    {
                        EstablecerTipoDocumento(
                            TipoDocumentoHelper.ObtenerCodigo(tipo.Value),
                            TipoDocumentoHelper.ObtenerDescripcion(tipo.Value)
                        );
                        txtdocumento.Focus();
                    }
                }
            }
        }

        #endregion

        #region "Eventos de Teclado"

        private void txtnumcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtnombre.Focus();
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtapellido.Focus();
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txttipodocumento.Focus();
            }
        }

        private void txttipodocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtdocumento.Focus();
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = true;
                MostrarSelectorTipoDocumento();
            }
        }

        private void txttipodocumento_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txttipodocumento.Text) && _presenter != null)
            {
                _presenter.ValidarTipoDocumentoPorCodigo(txttipodocumento.Text.Trim());
            }
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txttelefono.Focus();
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtemail.Focus();
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtdireccion.Focus();
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btngrabar.Focus();
            }
        }

        private void txtnumcliente_Validated(object sender, EventArgs e)
        {
        }

        #endregion

        #region "Eventos de Botones"

        private async void btnnuevo_Click(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                await _presenter.IniciarNuevoCliente();
            }
        }

        private async void btnmodificar_Click(object sender, EventArgs e)
        {
            if (_clienteIdSeleccionado.HasValue && _presenter != null)
            {
                await _presenter.CargarClienteParaEdicion(_clienteIdSeleccionado.Value);
            }
            else
            {
                MostrarAdvertencia("Debe seleccionar un cliente para modificar");
            }
        }

        private async void btneliminar_Click(object sender, EventArgs e)
        {
            if (_clienteIdSeleccionado.HasValue && _presenter != null)
            {
                await _presenter.EliminarCliente(_clienteIdSeleccionado.Value);
            }
            else
            {
                MostrarAdvertencia("Debe seleccionar un cliente para eliminar");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                _presenter.CancelarOperacion();
            }
        }

        private async void btngrabar_Click_1(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                await _presenter.GuardarCliente();
            }
        }

        private async void btnbuscar_Click_1(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                await _presenter.BuscarClientes(txtbusqueda.Text.Trim());
            }
        }

        #endregion

        #region "Eventos DataGridView"

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                _clienteIdSeleccionado = Convert.ToInt32(row.Cells["CodCliente"].Value);

            }
            else
            {
                _clienteIdSeleccionado = null;

            }
        }

        #endregion

        private void ABMClientes_Shown(object sender, EventArgs e)
        {
            this.Activate();
            LimpiarCampos();
            this.ActiveControl = txtbusqueda;
        }

        private void txtnumcliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtnombre.Focus();
            }
        }

        private void txtnombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtapellido.Focus();
            }
        }

        private void txtapellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txttipodocumento.Focus();
            }
        }

        private void txttipodocumento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtdocumento.Focus();
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = true;
                MostrarSelectorTipoDocumento();
            }
        }

        private void txttipodocumento_Validated_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txttipodocumento.Text) && _presenter != null)
            {
                _presenter.ValidarTipoDocumentoPorCodigo(txttipodocumento.Text.Trim());
            }
        }

        private void txtdocumento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txttelefono.Focus();
            }
        }

        private void txttelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtemail.Focus();
            }
        }

        private void txtemail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtdireccion.Focus();
            }
        }

        private void txtdireccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btngrabar.Focus();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
