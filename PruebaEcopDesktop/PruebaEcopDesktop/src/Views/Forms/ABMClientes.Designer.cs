namespace PruebaEcopDesktop.Views.Forms
{
    partial class ABMClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnmodificar = new MetroFramework.Controls.MetroButton();
            this.btncancelar = new MetroFramework.Controls.MetroButton();
            this.txtnumcliente = new System.Windows.Forms.TextBox();
            this.lbltipodocumento = new MetroFramework.Controls.MetroLabel();
            this.btnbuscar = new MetroFramework.Controls.MetroButton();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btneliminar = new MetroFramework.Controls.MetroButton();
            this.btngrabar = new MetroFramework.Controls.MetroButton();
            this.btnnuevo = new MetroFramework.Controls.MetroButton();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lblclientebuscador = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblclientebuscador);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtbusqueda);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txttelefono);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.metroLabel12);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.btnmodificar);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.txtnumcliente);
            this.panel1.Controls.Add(this.lbltipodocumento);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtdocumento);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btngrabar);
            this.panel1.Controls.Add(this.btnnuevo);
            this.panel1.Controls.Add(this.txttipodocumento);
            this.panel1.Controls.Add(this.txtapellido);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Location = new System.Drawing.Point(-1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 554);
            this.panel1.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1152, 492);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(237, 35);
            this.metroButton1.TabIndex = 218;
            this.metroButton1.Text = "SALIR";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(671, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 407);
            this.dataGridView1.TabIndex = 217;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(671, 24);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(455, 26);
            this.txtbusqueda.TabIndex = 216;
            this.txtbusqueda.Text = "txtbusqueda";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(192, 332);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(400, 26);
            this.txtdireccion.TabIndex = 215;
            this.txtdireccion.Text = "txtdireccion";
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress_1);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(-2, 332);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(188, 25);
            this.metroLabel2.TabIndex = 214;
            this.metroLabel2.Text = "Dirección";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(192, 293);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(400, 26);
            this.txtemail.TabIndex = 213;
            this.txtemail.Text = "txtemail";
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress_1);
            // 
            // txttelefono
            // 
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelefono.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(192, 256);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(215, 26);
            this.txttelefono.TabIndex = 212;
            this.txttelefono.Text = "txttelefono";
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress_1);
            // 
            // metroLabel11
            // 
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(54, 255);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(132, 25);
            this.metroLabel11.TabIndex = 211;
            this.metroLabel11.Text = "Telefono";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel12
            // 
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(-2, 293);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(188, 25);
            this.metroLabel12.TabIndex = 210;
            this.metroLabel12.Text = "Email";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(13, 69);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(173, 25);
            this.metroLabel4.TabIndex = 209;
            this.metroLabel4.Text = "Código";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(363, 389);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(229, 35);
            this.btnmodificar.TabIndex = 208;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(114, 440);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(229, 35);
            this.btncancelar.TabIndex = 207;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtnumcliente
            // 
            this.txtnumcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumcliente.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumcliente.ForeColor = System.Drawing.Color.Red;
            this.txtnumcliente.Location = new System.Drawing.Point(192, 68);
            this.txtnumcliente.Name = "txtnumcliente";
            this.txtnumcliente.Size = new System.Drawing.Size(215, 26);
            this.txtnumcliente.TabIndex = 206;
            this.txtnumcliente.Text = "txtnumcliente";
            this.txtnumcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumcliente_KeyPress_1);
            // 
            // lbltipodocumento
            // 
            this.lbltipodocumento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbltipodocumento.Location = new System.Drawing.Point(311, 180);
            this.lbltipodocumento.Name = "lbltipodocumento";
            this.lbltipodocumento.Size = new System.Drawing.Size(341, 25);
            this.lbltipodocumento.TabIndex = 205;
            this.lbltipodocumento.Text = "lbltipodocumento";
            this.lbltipodocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(1152, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(237, 35);
            this.btnbuscar.TabIndex = 204;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // txtdocumento
            // 
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdocumento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.Location = new System.Drawing.Point(192, 218);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(215, 26);
            this.txtdocumento.TabIndex = 203;
            this.txtdocumento.Text = "txtdocumento";
            this.txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress_1);
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(13, 218);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(173, 25);
            this.metroLabel5.TabIndex = 202;
            this.metroLabel5.Text = "Documento";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(363, 440);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(229, 35);
            this.btneliminar.TabIndex = 201;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(114, 492);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(478, 35);
            this.btngrabar.TabIndex = 200;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click_1);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(114, 389);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(229, 35);
            this.btnnuevo.TabIndex = 199;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipodocumento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipodocumento.Location = new System.Drawing.Point(192, 180);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.Size = new System.Drawing.Size(113, 26);
            this.txttipodocumento.TabIndex = 198;
            this.txttipodocumento.Text = "txttipodocumento";
            this.txttipodocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipodocumento_KeyPress_1);
            this.txttipodocumento.Validated += new System.EventHandler(this.txttipodocumento_Validated_1);
            // 
            // txtapellido
            // 
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapellido.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(192, 143);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(308, 26);
            this.txtapellido.TabIndex = 197;
            this.txtapellido.Text = "txtapellido";
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress_1);
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(192, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(308, 26);
            this.txtnombre.TabIndex = 196;
            this.txtnombre.Text = "txtnombre";
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress_1);
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(-2, 181);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(188, 25);
            this.metroLabel6.TabIndex = 195;
            this.metroLabel6.Text = "Tipo de Documento (*)";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(13, 143);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 25);
            this.metroLabel1.TabIndex = 194;
            this.metroLabel1.Text = "Apellido";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(13, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(173, 25);
            this.metroLabel3.TabIndex = 193;
            this.metroLabel3.Text = "Nombre";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(1, 11);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(614, 43);
            this.metroTile1.TabIndex = 192;
            this.metroTile1.Text = "ABM DE CLIENTES";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // lblclientebuscador
            // 
            this.lblclientebuscador.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientebuscador.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblclientebuscador.Location = new System.Drawing.Point(929, 492);
            this.lblclientebuscador.Name = "lblclientebuscador";
            this.lblclientebuscador.Size = new System.Drawing.Size(197, 44);
            this.lblclientebuscador.TabIndex = 752;
            this.lblclientebuscador.Text = "Presione * (asterisco) para abrir el buscador en los campos marcados";
            this.lblclientebuscador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblclientebuscador.UseCompatibleTextRendering = true;
            // 
            // ABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1400, 556);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMClientes";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.ABMClientes_Load);
            this.Shown += new System.EventHandler(this.ABMClientes_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.TextBox txtdireccion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefono;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnmodificar;
        private MetroFramework.Controls.MetroButton btncancelar;
        private System.Windows.Forms.TextBox txtnumcliente;
        private MetroFramework.Controls.MetroLabel lbltipodocumento;
        private MetroFramework.Controls.MetroButton btnbuscar;
        private System.Windows.Forms.TextBox txtdocumento;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btneliminar;
        private MetroFramework.Controls.MetroButton btngrabar;
        private MetroFramework.Controls.MetroButton btnnuevo;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label lblclientebuscador;
    }
}