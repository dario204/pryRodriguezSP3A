namespace pryRodriguezSP3A
{
    partial class frmAutoTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoTest));
            this.mcrRegistro = new System.Windows.Forms.GroupBox();
            this.numFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mcrEstaditicas = new System.Windows.Forms.GroupBox();
            this.txtDominioSeisMeses = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.lblDominio_Seis_Meses = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.mcrRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFabricacion)).BeginInit();
            this.mcrEstaditicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcrRegistro
            // 
            this.mcrRegistro.Controls.Add(this.numFabricacion);
            this.mcrRegistro.Controls.Add(this.txtTitular);
            this.mcrRegistro.Controls.Add(this.txtDominio);
            this.mcrRegistro.Controls.Add(this.txtNumero);
            this.mcrRegistro.Controls.Add(this.lblTitular);
            this.mcrRegistro.Controls.Add(this.lblAño);
            this.mcrRegistro.Controls.Add(this.lblDominio);
            this.mcrRegistro.Controls.Add(this.lblNumero);
            this.mcrRegistro.Location = new System.Drawing.Point(16, 41);
            this.mcrRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrRegistro.Name = "mcrRegistro";
            this.mcrRegistro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrRegistro.Size = new System.Drawing.Size(557, 217);
            this.mcrRegistro.TabIndex = 0;
            this.mcrRegistro.TabStop = false;
            this.mcrRegistro.Text = "Registro de Turnos";
            // 
            // numFabricacion
            // 
            this.numFabricacion.Location = new System.Drawing.Point(167, 130);
            this.numFabricacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numFabricacion.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numFabricacion.Name = "numFabricacion";
            this.numFabricacion.Size = new System.Drawing.Size(105, 22);
            this.numFabricacion.TabIndex = 7;
            this.numFabricacion.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(139, 175);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(355, 22);
            this.txtTitular.TabIndex = 6;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(139, 79);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(132, 22);
            this.txtDominio.TabIndex = 5;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged);
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(139, 25);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(132, 22);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(32, 175);
            this.lblTitular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(44, 16);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(9, 133);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(124, 16);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de Fabricacion";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(32, 79);
            this.lblDominio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(57, 16);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(9, 25);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(112, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero de Turno";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(641, 50);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(127, 46);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(641, 148);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(641, 305);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 41);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // mcrEstaditicas
            // 
            this.mcrEstaditicas.Controls.Add(this.txtDominioSeisMeses);
            this.mcrEstaditicas.Controls.Add(this.txtAntiguedad);
            this.mcrEstaditicas.Controls.Add(this.txtCantidadTurnos);
            this.mcrEstaditicas.Controls.Add(this.lblDominio_Seis_Meses);
            this.mcrEstaditicas.Controls.Add(this.lblAntiguedad);
            this.mcrEstaditicas.Controls.Add(this.lblCantidad);
            this.mcrEstaditicas.Location = new System.Drawing.Point(16, 292);
            this.mcrEstaditicas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrEstaditicas.Name = "mcrEstaditicas";
            this.mcrEstaditicas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrEstaditicas.Size = new System.Drawing.Size(556, 176);
            this.mcrEstaditicas.TabIndex = 4;
            this.mcrEstaditicas.TabStop = false;
            this.mcrEstaditicas.Text = "Estadisticas";
            // 
            // txtDominioSeisMeses
            // 
            this.txtDominioSeisMeses.Location = new System.Drawing.Point(271, 143);
            this.txtDominioSeisMeses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDominioSeisMeses.Name = "txtDominioSeisMeses";
            this.txtDominioSeisMeses.Size = new System.Drawing.Size(115, 22);
            this.txtDominioSeisMeses.TabIndex = 10;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(271, 92);
            this.txtAntiguedad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(115, 22);
            this.txtAntiguedad.TabIndex = 9;
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(271, 38);
            this.txtCantidadTurnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.Size = new System.Drawing.Size(115, 22);
            this.txtCantidadTurnos.TabIndex = 8;
            // 
            // lblDominio_Seis_Meses
            // 
            this.lblDominio_Seis_Meses.AutoSize = true;
            this.lblDominio_Seis_Meses.Location = new System.Drawing.Point(8, 143);
            this.lblDominio_Seis_Meses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDominio_Seis_Meses.Name = "lblDominio_Seis_Meses";
            this.lblDominio_Seis_Meses.Size = new System.Drawing.Size(233, 16);
            this.lblDominio_Seis_Meses.TabIndex = 7;
            this.lblDominio_Seis_Meses.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(8, 92);
            this.lblAntiguedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(129, 16);
            this.lblAntiguedad.TabIndex = 6;
            this.lblAntiguedad.Text = "Año del mas antiguo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(8, 38);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(119, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad de turnos";
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 511);
            this.Controls.Add(this.mcrEstaditicas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mcrRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAutoTest";
            this.Text = "Auto Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mcrRegistro.ResumeLayout(false);
            this.mcrRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFabricacion)).EndInit();
            this.mcrEstaditicas.ResumeLayout(false);
            this.mcrEstaditicas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mcrRegistro;
        private System.Windows.Forms.NumericUpDown numFabricacion;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox mcrEstaditicas;
        private System.Windows.Forms.TextBox txtDominioSeisMeses;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.Label lblDominio_Seis_Meses;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblCantidad;
    }
}

