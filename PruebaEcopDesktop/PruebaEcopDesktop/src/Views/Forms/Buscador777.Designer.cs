namespace PruebaEcopDesktop.Views.Forms
{
    partial class Buscador777
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbfecha = new System.Windows.Forms.RadioButton();
            this.rbcodigo = new System.Windows.Forms.RadioButton();
            this.rbdescripcion = new System.Windows.Forms.RadioButton();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.dgresultados = new System.Windows.Forms.DataGridView();
            this.lblcantidadregistros = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.timerbuscador = new System.Windows.Forms.Timer(this.components);
            this.lblclientebuscador = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgresultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Location = new System.Drawing.Point(-1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 79);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rbfecha);
            this.groupBox1.Controls.Add(this.rbcodigo);
            this.groupBox1.Controls.Add(this.rbdescripcion);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(596, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbfecha
            // 
            this.rbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfecha.Location = new System.Drawing.Point(6, 47);
            this.rbfecha.Name = "rbfecha";
            this.rbfecha.Size = new System.Drawing.Size(97, 20);
            this.rbfecha.TabIndex = 4;
            this.rbfecha.TabStop = true;
            this.rbfecha.Text = "Fecha";
            this.rbfecha.UseVisualStyleBackColor = true;
            // 
            // rbcodigo
            // 
            this.rbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcodigo.Location = new System.Drawing.Point(6, 7);
            this.rbcodigo.Name = "rbcodigo";
            this.rbcodigo.Size = new System.Drawing.Size(97, 23);
            this.rbcodigo.TabIndex = 2;
            this.rbcodigo.TabStop = true;
            this.rbcodigo.Text = "Código";
            this.rbcodigo.UseVisualStyleBackColor = true;
            this.rbcodigo.CheckedChanged += new System.EventHandler(this.rbcodigo_CheckedChanged);
            // 
            // rbdescripcion
            // 
            this.rbdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdescripcion.Location = new System.Drawing.Point(6, 28);
            this.rbdescripcion.Name = "rbdescripcion";
            this.rbdescripcion.Size = new System.Drawing.Size(97, 20);
            this.rbdescripcion.TabIndex = 3;
            this.rbdescripcion.TabStop = true;
            this.rbdescripcion.Text = "Descripción";
            this.rbdescripcion.UseVisualStyleBackColor = true;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(17, 6);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(573, 66);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Buscar Productos";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // dgresultados
            // 
            this.dgresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgresultados.Location = new System.Drawing.Point(16, 123);
            this.dgresultados.Name = "dgresultados";
            this.dgresultados.Size = new System.Drawing.Size(768, 300);
            this.dgresultados.TabIndex = 1;
            this.dgresultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgresultados_CellClick);
            this.dgresultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgresultados_CellContentClick);
            // 
            // lblcantidadregistros
            // 
            this.lblcantidadregistros.AutoSize = true;
            this.lblcantidadregistros.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadregistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblcantidadregistros.Location = new System.Drawing.Point(591, 425);
            this.lblcantidadregistros.Name = "lblcantidadregistros";
            this.lblcantidadregistros.Size = new System.Drawing.Size(191, 20);
            this.lblcantidadregistros.TabIndex = 2;
            this.lblcantidadregistros.Text = "100 registros encontrados";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtbusqueda.Location = new System.Drawing.Point(16, 91);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(768, 26);
            this.txtbusqueda.TabIndex = 3;
            this.txtbusqueda.AcceptsTabChanged += new System.EventHandler(this.txtbusqueda_AcceptsTabChanged);
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            this.txtbusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyDown);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            this.txtbusqueda.Validated += new System.EventHandler(this.txtbusqueda_Validated);
            // 
            // timerbuscador
            // 
            this.timerbuscador.Interval = 500;
            this.timerbuscador.Tick += new System.EventHandler(this.timerbuscador_Tick);
            // 
            // lblclientebuscador
            // 
            this.lblclientebuscador.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientebuscador.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblclientebuscador.Location = new System.Drawing.Point(210, 440);
            this.lblclientebuscador.Name = "lblclientebuscador";
            this.lblclientebuscador.Size = new System.Drawing.Size(316, 59);
            this.lblclientebuscador.TabIndex = 753;
            this.lblclientebuscador.Text = "ESCRIBA en el campo de busqueda, luego dele CLICK al registro y presione ENTER.";
            this.lblclientebuscador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblclientebuscador.UseCompatibleTextRendering = true;
            // 
            // Buscador777
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.lblclientebuscador);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lblcantidadregistros);
            this.Controls.Add(this.dgresultados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Buscador777";
            this.Load += new System.EventHandler(this.Buscador777_Load);
            this.Shown += new System.EventHandler(this.Buscador777_Shown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgresultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.RadioButton rbfecha;
        private System.Windows.Forms.RadioButton rbdescripcion;
        private System.Windows.Forms.RadioButton rbcodigo;
        private System.Windows.Forms.DataGridView dgresultados;
        private System.Windows.Forms.Label lblcantidadregistros;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerbuscador;
        private System.Windows.Forms.Label lblclientebuscador;
    }
}