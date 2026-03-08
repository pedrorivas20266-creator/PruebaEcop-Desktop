using System;

namespace PruebaEcopDesktop.Views.Forms
{
    partial class SolicitudPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSubTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtVencimiento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNumFactura = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgvDetalleProductos = new System.Windows.Forms.DataGridView();
            this.panelFiltrosProducto = new System.Windows.Forms.Panel();
            this.panelAccionesProducto = new System.Windows.Forms.Panel();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnVolverProducto = new System.Windows.Forms.Button();
            this.txtComprobante = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtNumero = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoneda6 = new TxtMoneda.TxtMoneda(this.components);
            this.txtMoneda1 = new TxtMoneda.TxtMoneda(this.components);
            this.btnborrardetalle = new System.Windows.Forms.Button();
            this.btneditardetalle = new System.Windows.Forms.Button();
            this.btncargardetalle = new System.Windows.Forms.Button();
            this.dgdetallepedido = new System.Windows.Forms.DataGridView();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescripcionproducto = new System.Windows.Forms.TextBox();
            this.txtMoneda9 = new TxtMoneda.TxtMoneda(this.components);
            this.txtMoneda7 = new TxtMoneda.TxtMoneda(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bencancelar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.lblcliente = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltipocompro = new System.Windows.Forms.Label();
            this.txttipocompro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha1 = new Fecha.Fecha();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.btnmaximizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lblclientebuscador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProductos)).BeginInit();
            this.panelFiltrosProducto.SuspendLayout();
            this.panelAccionesProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            this.tabProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetallepedido)).BeginInit();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(870, 6);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(120, 23);
            this.txtSubTotal.TabIndex = 7;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(800, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 15);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Sub-Total";
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Location = new System.Drawing.Point(630, 6);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(150, 23);
            this.txtVencimiento.TabIndex = 5;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(540, 9);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 15);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Vencimiento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(280, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(240, 23);
            this.txtDescripcion.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(205, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 15);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Descripción";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(95, 6);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(100, 23);
            this.txtNumFactura.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(10, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 15);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Num Factura";
            // 
            // dgvDetalleProductos
            // 
            this.dgvDetalleProductos.AllowUserToAddRows = false;
            this.dgvDetalleProductos.AllowUserToDeleteRows = false;
            this.dgvDetalleProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleProductos.Location = new System.Drawing.Point(0, 37);
            this.dgvDetalleProductos.Name = "dgvDetalleProductos";
            this.dgvDetalleProductos.ReadOnly = true;
            this.dgvDetalleProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleProductos.Size = new System.Drawing.Size(200, 63);
            this.dgvDetalleProductos.TabIndex = 1;
            // 
            // panelFiltrosProducto
            // 
            this.panelFiltrosProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFiltrosProducto.Controls.Add(this.txtSubTotal);
            this.panelFiltrosProducto.Controls.Add(this.metroLabel7);
            this.panelFiltrosProducto.Controls.Add(this.txtVencimiento);
            this.panelFiltrosProducto.Controls.Add(this.metroLabel6);
            this.panelFiltrosProducto.Controls.Add(this.txtDescripcion);
            this.panelFiltrosProducto.Controls.Add(this.metroLabel5);
            this.panelFiltrosProducto.Controls.Add(this.txtNumFactura);
            this.panelFiltrosProducto.Controls.Add(this.metroLabel4);
            this.panelFiltrosProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltrosProducto.Location = new System.Drawing.Point(0, 0);
            this.panelFiltrosProducto.Name = "panelFiltrosProducto";
            this.panelFiltrosProducto.Size = new System.Drawing.Size(200, 37);
            this.panelFiltrosProducto.TabIndex = 0;
            // 
            // panelAccionesProducto
            // 
            this.panelAccionesProducto.Controls.Add(this.btnQuitarProducto);
            this.panelAccionesProducto.Controls.Add(this.btnModificarProducto);
            this.panelAccionesProducto.Controls.Add(this.btnVolverProducto);
            this.panelAccionesProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAccionesProducto.Location = new System.Drawing.Point(120, 37);
            this.panelAccionesProducto.Name = "panelAccionesProducto";
            this.panelAccionesProducto.Size = new System.Drawing.Size(80, 63);
            this.panelAccionesProducto.TabIndex = 2;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.Color.White;
            this.btnQuitarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProducto.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btnQuitarProducto.Location = new System.Drawing.Point(10, 100);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(60, 55);
            this.btnQuitarProducto.TabIndex = 2;
            this.btnQuitarProducto.Text = "🗑️";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.White;
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btnModificarProducto.Location = new System.Drawing.Point(10, 30);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(60, 55);
            this.btnModificarProducto.TabIndex = 1;
            this.btnModificarProducto.Text = "✏️";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            // 
            // btnVolverProducto
            // 
            this.btnVolverProducto.BackColor = System.Drawing.Color.White;
            this.btnVolverProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverProducto.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btnVolverProducto.Location = new System.Drawing.Point(10, 230);
            this.btnVolverProducto.Name = "btnVolverProducto";
            this.btnVolverProducto.Size = new System.Drawing.Size(60, 55);
            this.btnVolverProducto.TabIndex = 0;
            this.btnVolverProducto.Text = "↩️";
            this.btnVolverProducto.UseVisualStyleBackColor = false;
            // 
            // txtComprobante
            // 
            this.txtComprobante.Owner = null;
            // 
            // txtNumero
            // 
            this.txtNumero.Owner = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.panelAccionesProducto);
            this.tabProductos.Controls.Add(this.dgvDetalleProductos);
            this.tabProductos.Controls.Add(this.panelFiltrosProducto);
            this.tabProductos.Location = new System.Drawing.Point(0, 0);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(200, 100);
            this.tabProductos.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(200, 100);
            this.panelBotones.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroLabel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblclientebuscador);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMoneda6);
            this.panel1.Controls.Add(this.txtMoneda1);
            this.panel1.Controls.Add(this.btnborrardetalle);
            this.panel1.Controls.Add(this.btneditardetalle);
            this.panel1.Controls.Add(this.btncargardetalle);
            this.panel1.Controls.Add(this.dgdetallepedido);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.txtdescripcionproducto);
            this.panel1.Controls.Add(this.txtMoneda9);
            this.panel1.Controls.Add(this.txtMoneda7);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Panel5);
            this.panel1.Controls.Add(this.lblcliente);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtcliente);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbltipocompro);
            this.panel1.Controls.Add(this.txttipocompro);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fecha1);
            this.panel1.Controls.Add(this.TextBox4);
            this.panel1.Controls.Add(this.btnmaximizar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 592);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 750;
            this.label7.Text = "Total Pedido";
            // 
            // txtMoneda6
            // 
            this.txtMoneda6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoneda6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneda6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMoneda6.Location = new System.Drawing.Point(549, 547);
            this.txtMoneda6.Name = "txtMoneda6";
            this.txtMoneda6.Size = new System.Drawing.Size(448, 25);
            this.txtMoneda6.TabIndex = 749;
            this.txtMoneda6.Text = "txtMoneda6";
            this.txtMoneda6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMoneda6.TxtMonedaBase = "0";
            this.txtMoneda6.TxtMonedaDecimales = null;
            // 
            // txtMoneda1
            // 
            this.txtMoneda1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoneda1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneda1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda1.Location = new System.Drawing.Point(743, 243);
            this.txtMoneda1.Name = "txtMoneda1";
            this.txtMoneda1.Size = new System.Drawing.Size(64, 23);
            this.txtMoneda1.TabIndex = 748;
            this.txtMoneda1.Text = "txtMoneda1";
            this.txtMoneda1.TxtMonedaBase = "0";
            this.txtMoneda1.TxtMonedaDecimales = null;
            this.txtMoneda1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneda1_KeyPress);
            this.txtMoneda1.Validated += new System.EventHandler(this.txtMoneda1_Validated);
            // 
            // btnborrardetalle
            // 
            this.btnborrardetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnborrardetalle.Image = global::PruebaEcopDesktop.Properties.Resources.eliminar;
            this.btnborrardetalle.Location = new System.Drawing.Point(1004, 370);
            this.btnborrardetalle.Name = "btnborrardetalle";
            this.btnborrardetalle.Size = new System.Drawing.Size(58, 41);
            this.btnborrardetalle.TabIndex = 746;
            this.btnborrardetalle.UseVisualStyleBackColor = true;
            this.btnborrardetalle.Click += new System.EventHandler(this.btnborrardetalle_Click);
            // 
            // btneditardetalle
            // 
            this.btneditardetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditardetalle.Image = global::PruebaEcopDesktop.Properties.Resources.lapiz;
            this.btneditardetalle.Location = new System.Drawing.Point(1004, 323);
            this.btneditardetalle.Name = "btneditardetalle";
            this.btneditardetalle.Size = new System.Drawing.Size(58, 41);
            this.btneditardetalle.TabIndex = 745;
            this.btneditardetalle.UseVisualStyleBackColor = true;
            this.btneditardetalle.Click += new System.EventHandler(this.btneditardetalle_Click);
            // 
            // btncargardetalle
            // 
            this.btncargardetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncargardetalle.Image = global::PruebaEcopDesktop.Properties.Resources.volver_flecha;
            this.btncargardetalle.Location = new System.Drawing.Point(1004, 276);
            this.btncargardetalle.Name = "btncargardetalle";
            this.btncargardetalle.Size = new System.Drawing.Size(58, 41);
            this.btncargardetalle.TabIndex = 744;
            this.btncargardetalle.UseVisualStyleBackColor = true;
            this.btncargardetalle.Click += new System.EventHandler(this.btncargardetalle_Click);
            // 
            // dgdetallepedido
            // 
            this.dgdetallepedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdetallepedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgdetallepedido.Location = new System.Drawing.Point(20, 276);
            this.dgdetallepedido.Name = "dgdetallepedido";
            this.dgdetallepedido.Size = new System.Drawing.Size(978, 226);
            this.dgdetallepedido.TabIndex = 743;
            this.dgdetallepedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdetallepedido_CellContentClick);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(20, 243);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(89, 23);
            this.txtcodigo.TabIndex = 742;
            this.txtcodigo.Text = "TXTCODIGO";
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress_1);
            this.txtcodigo.Validated += new System.EventHandler(this.txtcodigo_Validated);
            // 
            // txtdescripcionproducto
            // 
            this.txtdescripcionproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcionproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcionproducto.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcionproducto.Location = new System.Drawing.Point(119, 243);
            this.txtdescripcionproducto.Name = "txtdescripcionproducto";
            this.txtdescripcionproducto.ReadOnly = true;
            this.txtdescripcionproducto.Size = new System.Drawing.Size(464, 23);
            this.txtdescripcionproducto.TabIndex = 741;
            this.txtdescripcionproducto.Text = "txtdescripcionproducto";
            // 
            // txtMoneda9
            // 
            this.txtMoneda9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoneda9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneda9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda9.Location = new System.Drawing.Point(813, 243);
            this.txtMoneda9.Name = "txtMoneda9";
            this.txtMoneda9.ReadOnly = true;
            this.txtMoneda9.Size = new System.Drawing.Size(184, 23);
            this.txtMoneda9.TabIndex = 740;
            this.txtMoneda9.Text = "txtMoneda9";
            this.txtMoneda9.TxtMonedaBase = "0";
            this.txtMoneda9.TxtMonedaDecimales = null;
            // 
            // txtMoneda7
            // 
            this.txtMoneda7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoneda7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneda7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda7.Location = new System.Drawing.Point(592, 243);
            this.txtMoneda7.Name = "txtMoneda7";
            this.txtMoneda7.Size = new System.Drawing.Size(145, 23);
            this.txtMoneda7.TabIndex = 738;
            this.txtMoneda7.Text = "txtMoneda7";
            this.txtMoneda7.TxtMonedaBase = "0";
            this.txtMoneda7.TxtMonedaDecimales = null;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(808, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 20);
            this.label17.TabIndex = 737;
            this.label17.Text = "Total Item";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(741, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 20);
            this.label15.TabIndex = 735;
            this.label15.Text = "Cant";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(590, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 734;
            this.label14.Text = "Precio U";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(115, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 733;
            this.label13.Text = "Descripción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 732;
            this.label10.Text = "Código (*)";
            // 
            // Panel5
            // 
            this.Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.label3);
            this.Panel5.Controls.Add(this.label2);
            this.Panel5.Controls.Add(this.bencancelar);
            this.Panel5.Controls.Add(this.btngrabar);
            this.Panel5.Location = new System.Drawing.Point(865, 102);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(197, 91);
            this.Panel5.TabIndex = 731;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 752;
            this.label3.Text = "Cancelar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 751;
            this.label2.Text = "Grabar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bencancelar
            // 
            this.bencancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bencancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bencancelar.ForeColor = System.Drawing.Color.White;
            this.bencancelar.Image = global::PruebaEcopDesktop.Properties.Resources.cerrar1;
            this.bencancelar.Location = new System.Drawing.Point(107, 8);
            this.bencancelar.Name = "bencancelar";
            this.bencancelar.Size = new System.Drawing.Size(65, 49);
            this.bencancelar.TabIndex = 12;
            this.bencancelar.Click += new System.EventHandler(this.bencancelar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrabar.ForeColor = System.Drawing.Color.White;
            this.btngrabar.Image = global::PruebaEcopDesktop.Properties.Resources.disquete2;
            this.btngrabar.Location = new System.Drawing.Point(25, 8);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(65, 49);
            this.btngrabar.TabIndex = 11;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // lblcliente
            // 
            this.lblcliente.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(242, 135);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(445, 20);
            this.lblcliente.TabIndex = 729;
            this.lblcliente.Text = "lblcliente";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(30, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 24);
            this.label18.TabIndex = 730;
            this.label18.Text = "Número";
            // 
            // txtcliente
            // 
            this.txtcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(116, 134);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(120, 23);
            this.txtcliente.TabIndex = 728;
            this.txtcliente.Text = "TXTCLIENTE";
            this.txtcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcliente_KeyPress);
            this.txtcliente.Validated += new System.EventHandler(this.txtcliente_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 727;
            this.label11.Text = "Cliente (*)";
            // 
            // lbltipocompro
            // 
            this.lbltipocompro.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipocompro.Location = new System.Drawing.Point(218, 70);
            this.lbltipocompro.Name = "lbltipocompro";
            this.lbltipocompro.Size = new System.Drawing.Size(444, 20);
            this.lbltipocompro.TabIndex = 726;
            this.lbltipocompro.Text = "lbltipocompro";
            // 
            // txttipocompro
            // 
            this.txttipocompro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipocompro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttipocompro.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipocompro.Location = new System.Drawing.Point(116, 70);
            this.txttipocompro.Name = "txttipocompro";
            this.txttipocompro.Size = new System.Drawing.Size(96, 23);
            this.txttipocompro.TabIndex = 725;
            this.txttipocompro.Text = "TXTTIPOCOMPRO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 724;
            this.label8.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 723;
            this.label1.Text = "Comprobante";
            // 
            // fecha1
            // 
            this.fecha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fecha1.FechaDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fecha1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha1.Location = new System.Drawing.Point(116, 101);
            this.fecha1.MaxLength = 10;
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(145, 23);
            this.fecha1.TabIndex = 722;
            this.fecha1.Text = "1/1/1900";
            // 
            // TextBox4
            // 
            this.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.ForeColor = System.Drawing.Color.IndianRed;
            this.TextBox4.Location = new System.Drawing.Point(116, 165);
            this.TextBox4.MaxLength = 20;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(358, 29);
            this.TextBox4.TabIndex = 721;
            this.TextBox4.Text = "TextBox4";
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Image = global::PruebaEcopDesktop.Properties.Resources.ventana__1_;
            this.btnmaximizar.Location = new System.Drawing.Point(940, 10);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(58, 40);
            this.btnmaximizar.TabIndex = 720;
            this.btnmaximizar.UseVisualStyleBackColor = true;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::PruebaEcopDesktop.Properties.Resources.cerrar__1_;
            this.button1.Location = new System.Drawing.Point(1004, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 40);
            this.button1.TabIndex = 719;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(0, 10);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(528, 43);
            this.metroTile1.TabIndex = 718;
            this.metroTile1.Text = "SOLICITUD DE PEDIDOS";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // lblclientebuscador
            // 
            this.lblclientebuscador.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientebuscador.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblclientebuscador.Location = new System.Drawing.Point(865, 55);
            this.lblclientebuscador.Name = "lblclientebuscador";
            this.lblclientebuscador.Size = new System.Drawing.Size(197, 44);
            this.lblclientebuscador.TabIndex = 751;
            this.lblclientebuscador.Text = "Presione * (asterisco) para abrir el buscador en los campos marcados";
            this.lblclientebuscador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblclientebuscador.UseCompatibleTextRendering = true;
            // 
            // SolicitudPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SolicitudPedidos";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.SolicitudPedidos_Load);
            this.Shown += new System.EventHandler(this.SolicitudPedidos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProductos)).EndInit();
            this.panelFiltrosProducto.ResumeLayout(false);
            this.panelFiltrosProducto.PerformLayout();
            this.panelAccionesProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            this.tabProductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetallepedido)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroComboBox cmbProducto;
        private MetroFramework.Controls.MetroButton btnAgregarProducto;
        private MetroFramework.Controls.MetroButton btnGenerarPedido;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroLabel lblCantidadTotal;
        private MetroFramework.Controls.MetroLabel lblPrecioTotal;
        private MetroFramework.Controls.MetroTextBox txtSubTotal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtVencimiento;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNumFactura;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridView dgvDetalleProductos;
        private System.Windows.Forms.Panel panelFiltrosProducto;
        private System.Windows.Forms.Panel panelAccionesProducto;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnVolverProducto;
        private MetroFramework.Components.MetroStyleManager txtComprobante;
        private MetroFramework.Components.MetroStyleManager txtNumero;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmaximizar;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private TxtMoneda.TxtMoneda txtMoneda1;
        private System.Windows.Forms.Button btnborrardetalle;
        private System.Windows.Forms.Button btneditardetalle;
        private System.Windows.Forms.Button btncargardetalle;
        private System.Windows.Forms.DataGridView dgdetallepedido;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescripcionproducto;
        private TxtMoneda.TxtMoneda txtMoneda9;
        private TxtMoneda.TxtMoneda txtMoneda7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltipocompro;
        private System.Windows.Forms.TextBox txttipocompro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Fecha.Fecha fecha1;
        internal System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Label label7;
        private TxtMoneda.TxtMoneda txtMoneda6;
        internal System.Windows.Forms.Panel Panel5;
        private System.Windows.Forms.Button bencancelar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblclientebuscador;
    }
}