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
    public partial class ABMProductos : MetroFramework.Forms.MetroForm, IABMProductosView
    {
        private ABMProductosPresenter _presenter;
        private int? _productoIdSeleccionado = null;
        const string titulo = "GESTIÓN DE PRODUCTOS";

        public ABMProductos()
        {
            InitializeComponent();
        }

        public ABMProductos(
            IProductoService productoService,
            ICategoriaService categoriaService = null,
            IUnidadMedidaService unidadMedidaService = null)
        {
            InitializeComponent();
            _presenter = new ABMProductosPresenter(
                this,
                productoService,
                categoriaService,
                unidadMedidaService
            );
        }

        private async void ABMProductos_Load(object sender, EventArgs e)
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
                Name = "CodProducto",
                HeaderText = "ID",
                DataPropertyName = "CodProducto",
                Visible = false
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumProducto",
                HeaderText = "Código",
                DataPropertyName = "NumProducto",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DesProducto",
                HeaderText = "Descripción",
                DataPropertyName = "DesProducto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CodigoBarra",
                HeaderText = "Código de Barra",
                DataPropertyName = "CodigoBarra",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Categoria",
                HeaderText = "Categoría",
                DataPropertyName = "Categoria",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioVenta",
                HeaderText = "Precio",
                DataPropertyName = "PrecioVenta",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Activo",
                HeaderText = "Activo",
                DataPropertyName = "Activo",
                Width = 60
            });

            dataGridView1.ClearSelection();
        }

        #endregion

        #region "Implementación IABMProductosView"

        public string CodigoProducto => txtcodigo.Text.Trim();
        public string Descripcion => txtdescripcion.Text.Trim();
        public string CodigoBarra => txtcodigobarra.Text.Trim();
        public string Categoria => txtcategoria.Tag?.ToString() ?? string.Empty;
        public string UnidadMedida => txtunidadmedida.Tag?.ToString() ?? string.Empty;
        public string Iva => txtiva.Tag?.ToString() ?? string.Empty;
        public string Costo => txtmoneda1.Text.Trim();
        public string PrecioVenta => txtMoneda2.Text.Trim();
        public bool ActualizaStock => chbactualizastock.Checked;
        public bool Activo => chbhabilitado.Checked;
        public int? ProductoIdSeleccionado => _productoIdSeleccionado;

        public void EstablecerCodigoProducto(string codigoProducto)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerCodigoProducto(codigoProducto)));
                return;
            }

            txtcodigo.Text = codigoProducto;
        }

        public void EstablecerCategoria(string codigo, string descripcion)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerCategoria(codigo, descripcion)));
                return;
            }

            txtcategoria.Tag = codigo;
            txtcategoria.Text = codigo;
            lblcategoria.Text = descripcion;
        }

        public void EstablecerUnidadMedida(string codigo, string descripcion)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerUnidadMedida(codigo, descripcion)));
                return;
            }

            txtunidadmedida.Tag = codigo;
            txtunidadmedida.Text = codigo;
            lblunidadmedida.Text = descripcion;
        }

        public void EstablecerIva(string codigo, string descripcion)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => EstablecerIva(codigo, descripcion)));
                return;
            }

            txtiva.Tag = codigo;
            txtiva.Text = codigo;
            lbliva.Text = descripcion;
        }

        public void CargarProductos(IEnumerable<object> productos)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => CargarProductos(productos)));
                return;
            }

            var listaProductos = productos.Cast<ProductoGridDTO>().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaProductos;
            dataGridView1.ClearSelection();
            _productoIdSeleccionado = null;
        }

        public void LimpiarCampos()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LimpiarCampos));
                return;
            }

            txtcodigo.Text = string.Empty;
            txtdescripcion.Text = string.Empty;
            txtcodigobarra.Text = string.Empty;
            txtcategoria.Tag = null;
            txtcategoria.Text = string.Empty;
            lblcategoria.Text = string.Empty;
            txtunidadmedida.Tag = null;
            txtunidadmedida.Text = string.Empty;
            lblunidadmedida.Text = string.Empty;
            txtiva.Tag = null;
            txtiva.Text = string.Empty;
            lbliva.Text = string.Empty;
            txtmoneda1.Text = "0";
            txtMoneda2.Text = "0";
            chbactualizastock.Checked = false;
            chbhabilitado.Checked = true;
            _productoIdSeleccionado = null;
            txtbusqueda.Text = string.Empty;
            dataGridView1.ClearSelection();
        }

        public void HabilitarEstadoNuevo()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(HabilitarEstadoNuevo));
                return;
            }

            txtcodigo.Enabled = false;
            txtdescripcion.Enabled = true;
            txtcodigobarra.Enabled = true;
            txtcategoria.Enabled = true;
            txtunidadmedida.Enabled = true;
            txtiva.Enabled = true;
            txtmoneda1.Enabled = true;
            txtMoneda2.Enabled = true;
            chbactualizastock.Enabled = true;
            chbhabilitado.Enabled = true;

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

            txtcodigo.Enabled = false;
            txtdescripcion.Enabled = false;
            txtcodigobarra.Enabled = false;
            txtcategoria.Enabled = false;
            txtunidadmedida.Enabled = false;
            txtiva.Enabled = false;
            txtmoneda1.Enabled = false;
            txtMoneda2.Enabled = false;
            chbactualizastock.Enabled = false;
            chbhabilitado.Enabled = false;

            btnnuevo.Enabled = true;
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            btngrabar.Enabled = false;
            btncancelar.Enabled = false;

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

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                case "codigo":
                    txtcodigo.Focus();
                    break;
                case "descripcion":
                    txtdescripcion.Focus();
                    break;
                case "codigobarra":
                    txtcodigobarra.Focus();
                    break;
                case "categoria":
                    txtcategoria.Focus();
                    break;
                case "unidadmedida":
                    txtunidadmedida.Focus();
                    break;
                case "iva":
                    txtiva.Focus();
                    break;
                case "costo":
                    txtmoneda1.Focus();
                    break;
                case "precioventa":
                    txtMoneda2.Focus();
                    break;
            }
        }

        public void CargarDatosProducto(object producto)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => CargarDatosProducto(producto)));
                return;
            }

            ProductoQuery pq = producto as ProductoQuery;
            if (pq != null)
            {
                _productoIdSeleccionado = pq.CodProducto;
                txtcodigo.Text = pq.NumProducto;
                txtdescripcion.Text = pq.DesProducto;
                txtcodigobarra.Text = pq.CodigoBarra ?? string.Empty;

                txtcategoria.Tag = pq.CodCategoria.ToString();
                txtcategoria.Text = pq.CodCategoria.ToString();
                lblcategoria.Text = pq.DesCategoria ?? string.Empty;

                txtunidadmedida.Tag = pq.CodUnidadMedida.ToString();
                txtunidadmedida.Text = pq.CodUnidadMedida.ToString();
                lblunidadmedida.Text = pq.DesUnidadMedida ?? string.Empty;

                var ivaEnum = IvaHelper.ObtenerPorCodigo(pq.CodIva.ToString());
                if (ivaEnum.HasValue)
                {
                    txtiva.Tag = pq.CodIva.ToString();
                    txtiva.Text = pq.CodIva.ToString();
                    lbliva.Text = IvaHelper.ObtenerDescripcion(ivaEnum.Value);
                }

                txtmoneda1.Text = pq.CostoUltimo.ToString("N2");
                txtMoneda2.Text = pq.PrecioVenta.ToString("N2");
                chbactualizastock.Checked = pq.DescuentaStock;
                chbhabilitado.Checked = pq.Activo;
                return;
            }

            Producto p = producto as Producto;
            if (p != null)
            {
                _productoIdSeleccionado = p.CodProducto;
                txtcodigo.Text = p.NumProducto;
                txtdescripcion.Text = p.DesProducto;
                txtcodigobarra.Text = p.CodigoBarra ?? string.Empty;

                txtcategoria.Tag = p.CodCategoria.ToString();
                txtcategoria.Text = p.CodCategoria.ToString();
                lblcategoria.Text = string.Empty; 

                txtunidadmedida.Tag = p.CodUnidadMedida.ToString();
                txtunidadmedida.Text = p.CodUnidadMedida.ToString();
                lblunidadmedida.Text = string.Empty; 

                var ivaEnum = IvaHelper.ObtenerPorCodigo(p.CodIva.ToString());
                if (ivaEnum.HasValue)
                {
                    txtiva.Tag = p.CodIva.ToString();
                    txtiva.Text = p.CodIva.ToString();
                    lbliva.Text = IvaHelper.ObtenerDescripcion(ivaEnum.Value);
                }

                txtmoneda1.Text = (p.CostoUltimo).ToString("N2");
                txtMoneda2.Text = "0"; 
                chbactualizastock.Checked = p.DescuentaStock;
                chbhabilitado.Checked = p.Activo;
            }
        }

        public void MostrarSelectorCategoria()
        {
            if (_presenter == null)
            {
                MostrarError("El presenter no está configurado");
                return;
            }

            var categoriaService = _presenter.ObtenerCategoriaService();

            if (categoriaService == null)
            {
                MostrarAdvertencia("Servicio de categorías no disponible");
                return;
            }

            var buscador = new Buscador777(
                BuscadorEntidad.Categoria,
                titulo: "CATEGORÍAS",
                buscar3Campos: false,
                categoriaService: categoriaService
            );

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                txtcategoria.Tag = buscador.CodCampo;
                txtcategoria.Text = buscador.NumCampo;
                lblcategoria.Text = buscador.DesCampo;
                txtunidadmedida.Focus();
            }
        }

        public void MostrarSelectorUnidadMedida()
        {
            if (_presenter == null)
            {
                MostrarError("El presenter no está configurado");
                return;
            }

            var unidadMedidaService = _presenter.ObtenerUnidadMedidaService();

            if (unidadMedidaService == null)
            {
                MostrarAdvertencia("Servicio de unidades de medida no disponible");
                return;
            }

            var buscador = new Buscador777(
                BuscadorEntidad.UnidadMedida,
                titulo: "UNIDADES DE MEDIDA",
                buscar3Campos: false,
                unidadMedidaService: unidadMedidaService
            );

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                txtunidadmedida.Tag = buscador.CodCampo;
                txtunidadmedida.Text = buscador.NumCampo;
                lblunidadmedida.Text = buscador.DesCampo;
                txtiva.Focus();
            }
        }

        public void MostrarSelectorIva()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(MostrarSelectorIva));
                return;
            }

            using (var form = new Form())
            {
                form.Text = "Seleccionar Tipo de IVA";
                form.Size = new Size(400, 220);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                var listBox = new ListBox
                {
                    Location = new Point(20, 20),
                    Size = new Size(350, 100),
                    Font = new Font("Trebuchet MS", 10)
                };

                listBox.Items.Add("0 - EXENTA");
                listBox.Items.Add("5 - IVA 5%");
                listBox.Items.Add("10 - IVA 10%");

                var btnAceptar = new Button
                {
                    Text = "Aceptar",
                    DialogResult = DialogResult.OK,
                    Location = new Point(200, 140),
                    Size = new Size(80, 30)
                };

                var btnCancelar = new Button
                {
                    Text = "Cancelar",
                    DialogResult = DialogResult.Cancel,
                    Location = new Point(290, 140),
                    Size = new Size(80, 30)
                };

                form.Controls.Add(listBox);
                form.Controls.Add(btnAceptar);
                form.Controls.Add(btnCancelar);
                form.AcceptButton = btnAceptar;
                form.CancelButton = btnCancelar;

                if (form.ShowDialog() == DialogResult.OK && listBox.SelectedIndex >= 0)
                {
                    IvaEnum ivaSeleccionado;
                    switch (listBox.SelectedIndex)
                    {
                        case 0:
                            ivaSeleccionado = IvaEnum.Exenta;
                            break;
                        case 1:
                            ivaSeleccionado = IvaEnum.Iva5;
                            break;
                        case 2:
                            ivaSeleccionado = IvaEnum.Iva10;
                            break;
                        default:
                            return;
                    }

                    EstablecerIva(
                        IvaHelper.ObtenerCodigo(ivaSeleccionado),
                        IvaHelper.ObtenerDescripcion(ivaSeleccionado)
                    );
                    txtmoneda1.Focus();
                }
            }
        }

        #endregion

        #region "Eventos de Teclado"

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtdescripcion.Focus();
            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtcodigobarra.Focus();
            }
        }

        private void txtcodigobarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtcategoria.Focus();
            }
        }

        private void txtcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtunidadmedida.Focus();
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = true;
                MostrarSelectorCategoria();
            }
        }

        private async void txtcategoria_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtcategoria.Text) && _presenter != null)
            {
                await _presenter.ValidarCategoriaPorCodigo(txtcategoria.Text.Trim());
            }
        }

        private void txtunidadmedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtiva.Focus();
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = true;
                MostrarSelectorUnidadMedida();
            }
        }

        private async void txtunidadmedida_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtunidadmedida.Text) && _presenter != null)
            {
                await _presenter.ValidarUnidadMedidaPorCodigo(txtunidadmedida.Text.Trim());
            }
        }

        private void txtiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtmoneda1.Focus();
            }
            else if (e.KeyChar == '*')
            {
                e.Handled = true;
                MostrarSelectorIva();
            }
        }

        private void txtiva_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtiva.Text) && _presenter != null)
            {
                _presenter.ValidarIvaPorCodigo(txtiva.Text.Trim());
            }
        }

        private void txtMoneda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtMoneda2.Focus();
            }
        }

        private void txtMoneda2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btngrabar.Focus();
            }
        }

        #endregion

        #region "Eventos de Botones"

        private async void btnnuevo_Click_1(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                await _presenter.IniciarNuevoProducto();
            }
        }

        private async void btnmodificar_Click_1(object sender, EventArgs e)
        {
            if (_productoIdSeleccionado.HasValue && _presenter != null)
            {
                await _presenter.CargarProductoParaEdicion(_productoIdSeleccionado.Value);
            }
            else
            {
                MostrarAdvertencia("Debe seleccionar un producto para modificar");
            }
        }

        private async void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (_productoIdSeleccionado.HasValue && _presenter != null)
            {
                await _presenter.EliminarProducto(_productoIdSeleccionado.Value);
            }
            else
            {
                MostrarAdvertencia("Debe seleccionar un producto para eliminar");
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                _presenter.CancelarOperacion();
            }
        }

        private async void btngrabar_Click(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                await _presenter.GuardarProducto();
            }
        }

        private async void btnbuscar_Click(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                await _presenter.BuscarProductos(txtbusqueda.Text.Trim());
            }
        }

        #endregion

        #region "Eventos DataGridView"

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                _productoIdSeleccionado = Convert.ToInt32(row.Cells["CodProducto"].Value);

            }
            else
            {
                _productoIdSeleccionado = null;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void ABMProductos_Shown(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Activate();
            this.ActiveControl = txtbusqueda;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                _productoIdSeleccionado = Convert.ToInt32(row.Cells["CodProducto"].Value);

            }
            else
            {
                _productoIdSeleccionado = null;

            }
        }
    }
}
