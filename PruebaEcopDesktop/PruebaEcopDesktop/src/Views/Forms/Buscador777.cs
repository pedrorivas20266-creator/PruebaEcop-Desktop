using PruebaECOP.Services.Interfaces;
using PruebaEcopDesktop.Models.DTOs;
using PruebaEcopDesktop.Models.Enums;
using PruebaEcopDesktop.Presenters;
using PruebaEcopDesktop.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PruebaEcopDesktop.Views.Forms
{
    public partial class Buscador777 : MetroFramework.Forms.MetroForm, IBuscadorView
    {
        private BuscadorPresenter _presenter;
        private BuscadorEntidad _entidad;
        private bool _buscar3Campos;

        public string CodCampo { get; set; }
        public string NumCampo { get; set; }
        public string DesCampo { get; set; }
        public string Aux1 { get; set; }
        public string Aux2 { get; set; }

        public string TextoBusqueda => txtbusqueda.Text.Trim();

        public int TipoBusqueda
        {
            get
            {
                if (rbcodigo.Checked) return 1;
                if (rbdescripcion.Checked) return 2;
                if (rbfecha.Checked) return 3;
                return 1;
            }
        }

        private bool _habilitarFecha;
        public bool HabilitarFecha
        {
            get => _habilitarFecha;
            set
            {
                _habilitarFecha = value;
                if (InvokeRequired)
                {
                    Invoke(new Action(() => rbfecha.Enabled = value));
                }
                else
                {
                    rbfecha.Enabled = value;
                }
            }
        }

        public Buscador777(
            BuscadorEntidad entidad,
            string titulo = null,
            bool buscar3Campos = true,
            IClienteService clienteService = null,
            IProductoService productoService = null,
            ICategoriaService categoriaService = null,
            IUnidadMedidaService unidadMedidaService = null,
            IPedidoService pedidoService = null)
        {
            InitializeComponent();

            _entidad = entidad;
            _buscar3Campos = buscar3Campos;

            string tituloFinal = titulo ?? ObtenerTituloDefault(entidad);
            lbltitulo.Text = "BUSCAR " + tituloFinal.ToUpper();

            _presenter = new BuscadorPresenter(
                this,
                entidad,
                clienteService,
                productoService,
                categoriaService,
                unidadMedidaService,
                pedidoService);

            rbcodigo.Checked = true;

            dgresultados.RowsAdded += DgBuscador_RowCountChanged;
            dgresultados.RowsRemoved += DgBuscador_RowsChanged;
        }

        private string ObtenerTituloDefault(BuscadorEntidad entidad)
        {
            switch (entidad)
            {
                case BuscadorEntidad.Cliente:
                    return "CLIENTE";
                case BuscadorEntidad.Producto:
                    return "PRODUCTO";
                case BuscadorEntidad.Categoria:
                    return "CATEGORÍA";
                case BuscadorEntidad.UnidadMedida:
                    return "UNIDAD DE MEDIDA";
                case BuscadorEntidad.Pedido:
                    return "PEDIDO";
                case BuscadorEntidad.Precio:
                    return "PRECIO";
                default:
                    return entidad.ToString().ToUpper();
            }
        }

        public void MostrarResultados(IEnumerable<object> datos)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarResultados(datos)));
                return;
            }

            var listaResultados = datos.Cast<BuscadorResultadoDTO>().ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("CODIGOOCULTO", typeof(string));
            dt.Columns.Add("CODIGO", typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("AUX1", typeof(string));
            dt.Columns.Add("AUX2", typeof(string));

            foreach (var item in listaResultados)
            {
                dt.Rows.Add(
                    item.CodigoOculto,
                    item.Codigo,
                    item.Descripcion,
                    item.Aux1,
                    item.Aux2);
            }

            dgresultados.DataSource = dt;
            FormatearDataGridView(dgresultados);
        }

        public void ActualizarCantidad(int cantidad)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarCantidad(cantidad)));
                return;
            }

            lblcantidadregistros.Text = $"{cantidad} Registros Encontrados";
        }

        public void MostrarError(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarError(mensaje)));
                return;
            }

            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DgBuscador_RowCountChanged(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int registros = dgresultados.RowCount;
            ActualizarCantidad(registros);
        }

        private void DgBuscador_RowsChanged(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int registros = dgresultados.RowCount;
            ActualizarCantidad(registros);
        }

        private async void Buscador777_Load(object sender, EventArgs e)
        {
            FormatearDataGridView(dgresultados);
        }

        private async void Buscador777_Shown(object sender, EventArgs e)
        {
            this.Activate();
            await _presenter.BuscarAsync(string.Empty);
            this.ActiveControl = txtbusqueda;
            txtbusqueda.Focus();
        }

        private async void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            await _presenter.BuscarAsync(txtbusqueda.Text.Trim());
        }

        private void FormatearDataGridView(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;

            dgv.ReadOnly = true;
            dgv.BackgroundColor = System.Drawing.Color.LightGray;
            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 10);
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgv.Columns.Contains("CODIGOOCULTO"))
            {
                dgv.Columns["CODIGOOCULTO"].Visible = false;
            }

            if (!_buscar3Campos)
            {
                if (dgv.Columns.Contains("AUX1"))
                    dgv.Columns["AUX1"].Visible = false;

                if (dgv.Columns.Contains("AUX2"))
                    dgv.Columns["AUX2"].Visible = false;
            }

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ClearSelection();
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ObtenerValores();
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                e.Handled = true;
            }
        }

        private void ObtenerValores()
        {
            if (dgresultados.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dgresultados.CurrentRow;

                CodCampo = filaSeleccionada.Cells["CODIGOOCULTO"].Value?.ToString() ?? string.Empty;
                NumCampo = filaSeleccionada.Cells["CODIGO"].Value?.ToString() ?? string.Empty;
                DesCampo = filaSeleccionada.Cells["DESCRIPCION"].Value?.ToString() ?? string.Empty;
                Aux1 = filaSeleccionada.Cells["AUX1"].Value?.ToString() ?? string.Empty;
                Aux2 = filaSeleccionada.Cells["AUX2"].Value?.ToString() ?? string.Empty;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgresultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgresultados.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dgresultados.CurrentRow;

                var valorCodigo = filaSeleccionada.Cells["CODIGOOCULTO"].Value?.ToString() ?? string.Empty;
                var valorDescripcion = filaSeleccionada.Cells["DESCRIPCION"].Value?.ToString() ?? string.Empty;

                if (rbcodigo.Checked)
                {
                    txtbusqueda.Text = valorDescripcion;
                }
                else if (rbdescripcion.Checked)
                {
                    txtbusqueda.Text = valorDescripcion;
                }
            }
        }

        private void dgresultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ObtenerValores();
            }
        }

        private void rbcodigo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtbusqueda_Validated(object sender, EventArgs e)
        {
            txtbusqueda.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {
        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dgresultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void txtbusqueda_AcceptsTabChanged(object sender, EventArgs e)
        {
        }

        private void timerbuscador_Tick(object sender, EventArgs e)
        {
        }
    }
}
