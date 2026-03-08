using System;
using System.Windows.Forms;

namespace PruebaEcopDesktop.Views.Forms
{
    partial class ABMProductos
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
            this.chbhabilitado = new MetroFramework.Controls.MetroCheckBox();
            this.chbactualizastock = new MetroFramework.Controls.MetroCheckBox();
            this.btnmodificar = new MetroFramework.Controls.MetroButton();
            this.btncancelar = new MetroFramework.Controls.MetroButton();
            this.btnbuscar = new MetroFramework.Controls.MetroButton();
            this.btneliminar = new MetroFramework.Controls.MetroButton();
            this.btngrabar = new MetroFramework.Controls.MetroButton();
            this.btnnuevo = new MetroFramework.Controls.MetroButton();
            this.lbliva = new MetroFramework.Controls.MetroLabel();
            this.lblcategoria = new MetroFramework.Controls.MetroLabel();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtcodigobarra = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txtmoneda1 = new TxtMoneda.TxtMoneda(this.components);
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMoneda2 = new TxtMoneda.TxtMoneda(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblunidadmedida = new MetroFramework.Controls.MetroLabel();
            this.txtunidadmedida = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lblclientebuscador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbhabilitado
            // 
            this.chbhabilitado.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.chbhabilitado.Location = new System.Drawing.Point(355, 415);
            this.chbhabilitado.Name = "chbhabilitado";
            this.chbhabilitado.Size = new System.Drawing.Size(78, 25);
            this.chbhabilitado.TabIndex = 220;
            this.chbhabilitado.Text = "Activo";
            // 
            // chbactualizastock
            // 
            this.chbactualizastock.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.chbactualizastock.Location = new System.Drawing.Point(188, 415);
            this.chbactualizastock.Name = "chbactualizastock";
            this.chbactualizastock.Size = new System.Drawing.Size(146, 25);
            this.chbactualizastock.TabIndex = 219;
            this.chbactualizastock.Text = "Actualiza Stock";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(352, 523);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(222, 35);
            this.btnmodificar.TabIndex = 218;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(110, 523);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(222, 35);
            this.btncancelar.TabIndex = 217;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(1298, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(150, 35);
            this.btnbuscar.TabIndex = 216;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(352, 470);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(222, 35);
            this.btneliminar.TabIndex = 215;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(110, 577);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(464, 35);
            this.btngrabar.TabIndex = 214;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(110, 472);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(222, 35);
            this.btnnuevo.TabIndex = 213;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click_1);
            // 
            // lbliva
            // 
            this.lbliva.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbliva.Location = new System.Drawing.Point(336, 287);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(304, 25);
            this.lbliva.TabIndex = 212;
            this.lbliva.Text = "lbliva";
            this.lbliva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcategoria
            // 
            this.lblcategoria.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblcategoria.Location = new System.Drawing.Point(337, 204);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(304, 25);
            this.lblcategoria.TabIndex = 211;
            this.lblcategoria.Text = "lblcategoria";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtiva
            // 
            this.txtiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiva.Location = new System.Drawing.Point(187, 287);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(143, 26);
            this.txtiva.TabIndex = 210;
            this.txtiva.Text = "txtiva";
            this.txtiva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtiva_KeyPress);
            this.txtiva.Validated += new System.EventHandler(this.txtiva_Validated);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(11, 287);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 25);
            this.metroLabel1.TabIndex = 209;
            this.metroLabel1.Text = "Tipo de Iva (*)";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcodigobarra
            // 
            this.txtcodigobarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigobarra.Location = new System.Drawing.Point(188, 160);
            this.txtcodigobarra.Name = "txtcodigobarra";
            this.txtcodigobarra.Size = new System.Drawing.Size(238, 26);
            this.txtcodigobarra.TabIndex = 208;
            this.txtcodigobarra.Text = "txtcodigobarra";
            this.txtcodigobarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigobarra_KeyPress);
            // 
            // txtcategoria
            // 
            this.txtcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.Location = new System.Drawing.Point(188, 204);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(143, 26);
            this.txtcategoria.TabIndex = 207;
            this.txtcategoria.Text = "txtcategoria";
            this.txtcategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcategoria_KeyPress);
            this.txtcategoria.Validated += new System.EventHandler(this.txtcategoria_Validated);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(187, 119);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(454, 26);
            this.txtdescripcion.TabIndex = 206;
            this.txtdescripcion.Text = "txtdescripcion";
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(187, 81);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(239, 26);
            this.txtcodigo.TabIndex = 205;
            this.txtcodigo.Text = "txtcodigo";
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(12, 204);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(154, 25);
            this.metroLabel6.TabIndex = 204;
            this.metroLabel6.Text = "Categoria (*)";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(12, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(154, 25);
            this.metroLabel4.TabIndex = 203;
            this.metroLabel4.Text = "Codigo de Barra";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(12, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(154, 25);
            this.metroLabel2.TabIndex = 202;
            this.metroLabel2.Text = "Descripcion";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(12, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 25);
            this.metroLabel3.TabIndex = 201;
            this.metroLabel3.Text = "Codigo";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(0, 14);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(395, 43);
            this.metroTile1.TabIndex = 200;
            this.metroTile1.Text = "PRODUCTOS";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // txtmoneda1
            // 
            this.txtmoneda1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmoneda1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoneda1.ForeColor = System.Drawing.Color.Red;
            this.txtmoneda1.Location = new System.Drawing.Point(188, 331);
            this.txtmoneda1.Name = "txtmoneda1";
            this.txtmoneda1.Size = new System.Drawing.Size(453, 26);
            this.txtmoneda1.TabIndex = 222;
            this.txtmoneda1.Text = "txtmoneda1";
            this.txtmoneda1.TxtMonedaBase = "0";
            this.txtmoneda1.TxtMonedaDecimales = null;
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.ForeColor = System.Drawing.Color.Red;
            this.metroLabel8.Location = new System.Drawing.Point(18, 331);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(147, 25);
            this.metroLabel8.TabIndex = 221;
            this.metroLabel8.Text = "Costo";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMoneda2
            // 
            this.txtMoneda2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoneda2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda2.ForeColor = System.Drawing.Color.Red;
            this.txtMoneda2.Location = new System.Drawing.Point(187, 372);
            this.txtMoneda2.Name = "txtMoneda2";
            this.txtMoneda2.Size = new System.Drawing.Size(453, 26);
            this.txtMoneda2.TabIndex = 224;
            this.txtMoneda2.Text = "txtMoneda2";
            this.txtMoneda2.TxtMonedaBase = "0";
            this.txtMoneda2.TxtMonedaDecimales = null;
            this.txtMoneda2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneda2_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.Color.Red;
            this.metroLabel5.Location = new System.Drawing.Point(17, 372);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(147, 25);
            this.metroLabel5.TabIndex = 223;
            this.metroLabel5.Text = "Precio";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblunidadmedida
            // 
            this.lblunidadmedida.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblunidadmedida.Location = new System.Drawing.Point(336, 245);
            this.lblunidadmedida.Name = "lblunidadmedida";
            this.lblunidadmedida.Size = new System.Drawing.Size(304, 25);
            this.lblunidadmedida.TabIndex = 227;
            this.lblunidadmedida.Text = "lblunidadmedida";
            this.lblunidadmedida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtunidadmedida
            // 
            this.txtunidadmedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtunidadmedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunidadmedida.Location = new System.Drawing.Point(187, 245);
            this.txtunidadmedida.Name = "txtunidadmedida";
            this.txtunidadmedida.Size = new System.Drawing.Size(143, 26);
            this.txtunidadmedida.TabIndex = 226;
            this.txtunidadmedida.Text = "txtunidadmedida";
            this.txtunidadmedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtunidadmedida_KeyPress);
            this.txtunidadmedida.Validated += new System.EventHandler(this.txtunidadmedida_Validated);
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(11, 245);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(154, 25);
            this.metroLabel9.TabIndex = 225;
            this.metroLabel9.Text = "Un. Medida (*)";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(687, 18);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(590, 26);
            this.txtbusqueda.TabIndex = 228;
            this.txtbusqueda.Text = "txtbusqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(687, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 495);
            this.dataGridView1.TabIndex = 229;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1226, 577);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(222, 35);
            this.metroButton1.TabIndex = 230;
            this.metroButton1.Text = "SALIR";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lblclientebuscador
            // 
            this.lblclientebuscador.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientebuscador.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblclientebuscador.Location = new System.Drawing.Point(1004, 577);
            this.lblclientebuscador.Name = "lblclientebuscador";
            this.lblclientebuscador.Size = new System.Drawing.Size(197, 44);
            this.lblclientebuscador.TabIndex = 752;
            this.lblclientebuscador.Text = "Presione * (asterisco) para abrir el buscador en los campos marcados";
            this.lblclientebuscador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblclientebuscador.UseCompatibleTextRendering = true;
            // 
            // ABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1472, 642);
            this.Controls.Add(this.lblclientebuscador);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lblunidadmedida);
            this.Controls.Add(this.txtunidadmedida);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtMoneda2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtmoneda1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.chbhabilitado);
            this.Controls.Add(this.chbactualizastock);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtcodigobarra);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMProductos";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.ABMProductos_Load);
            this.Shown += new System.EventHandler(this.ABMProductos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chbhabilitado;
        private MetroFramework.Controls.MetroCheckBox chbactualizastock;
        private MetroFramework.Controls.MetroButton btnmodificar;
        private MetroFramework.Controls.MetroButton btncancelar;
        private MetroFramework.Controls.MetroButton btnbuscar;
        private MetroFramework.Controls.MetroButton btneliminar;
        private MetroFramework.Controls.MetroButton btngrabar;
        private MetroFramework.Controls.MetroButton btnnuevo;
        private MetroFramework.Controls.MetroLabel lbliva;
        private MetroFramework.Controls.MetroLabel lblcategoria;
        private System.Windows.Forms.TextBox txtiva;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtcodigobarra;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcodigo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private TxtMoneda.TxtMoneda txtmoneda1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private TxtMoneda.TxtMoneda txtMoneda2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblunidadmedida;
        private System.Windows.Forms.TextBox txtunidadmedida;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Label lblclientebuscador;
    }
}