namespace pryRodriguezSP3A
{
    partial class Form1
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
            this.mcrRegistro = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.mcrEstaditicas = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblDominio_Seis_Meses = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtDominio_Seis_Meses = new System.Windows.Forms.TextBox();
            this.mcrRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.mcrEstaditicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcrRegistro
            // 
            this.mcrRegistro.Controls.Add(this.numericUpDown1);
            this.mcrRegistro.Controls.Add(this.txtTitular);
            this.mcrRegistro.Controls.Add(this.txtDominio);
            this.mcrRegistro.Controls.Add(this.txtNumero);
            this.mcrRegistro.Controls.Add(this.lblTitular);
            this.mcrRegistro.Controls.Add(this.lblAño);
            this.mcrRegistro.Controls.Add(this.lblDominio);
            this.mcrRegistro.Controls.Add(this.lblNumero);
            this.mcrRegistro.Location = new System.Drawing.Point(12, 33);
            this.mcrRegistro.Name = "mcrRegistro";
            this.mcrRegistro.Size = new System.Drawing.Size(418, 176);
            this.mcrRegistro.TabIndex = 0;
            this.mcrRegistro.TabStop = false;
            this.mcrRegistro.Text = "Registro de Turnos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(481, 41);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 37);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(481, 130);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(481, 347);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 33);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(7, 20);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(90, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero de Turno";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(7, 71);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(7, 118);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(99, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de Fabricacion";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(7, 153);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(104, 20);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(104, 64);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 20);
            this.txtDominio.TabIndex = 5;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(104, 145);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(267, 20);
            this.txtTitular.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 118);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // mcrEstaditicas
            // 
            this.mcrEstaditicas.Controls.Add(this.txtDominio_Seis_Meses);
            this.mcrEstaditicas.Controls.Add(this.txtAntiguedad);
            this.mcrEstaditicas.Controls.Add(this.txtCantidad);
            this.mcrEstaditicas.Controls.Add(this.lblDominio_Seis_Meses);
            this.mcrEstaditicas.Controls.Add(this.lblAntiguedad);
            this.mcrEstaditicas.Controls.Add(this.lblCantidad);
            this.mcrEstaditicas.Location = new System.Drawing.Point(13, 272);
            this.mcrEstaditicas.Name = "mcrEstaditicas";
            this.mcrEstaditicas.Size = new System.Drawing.Size(417, 143);
            this.mcrEstaditicas.TabIndex = 4;
            this.mcrEstaditicas.TabStop = false;
            this.mcrEstaditicas.Text = "Estadisticas";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 31);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(96, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad de turnos";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(6, 75);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(103, 13);
            this.lblAntiguedad.TabIndex = 6;
            this.lblAntiguedad.Text = "Año del mas antiguo";
            // 
            // lblDominio_Seis_Meses
            // 
            this.lblDominio_Seis_Meses.AutoSize = true;
            this.lblDominio_Seis_Meses.Location = new System.Drawing.Point(6, 116);
            this.lblDominio_Seis_Meses.Name = "lblDominio_Seis_Meses";
            this.lblDominio_Seis_Meses.Size = new System.Drawing.Size(166, 13);
            this.lblDominio_Seis_Meses.TabIndex = 7;
            this.lblDominio_Seis_Meses.Text = "Cantidad con dominio de 6 meses";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(203, 31);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(87, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(203, 75);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(87, 20);
            this.txtAntiguedad.TabIndex = 9;
            // 
            // txtDominio_Seis_Meses
            // 
            this.txtDominio_Seis_Meses.Location = new System.Drawing.Point(203, 116);
            this.txtDominio_Seis_Meses.Name = "txtDominio_Seis_Meses";
            this.txtDominio_Seis_Meses.Size = new System.Drawing.Size(87, 20);
            this.txtDominio_Seis_Meses.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 447);
            this.Controls.Add(this.mcrEstaditicas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mcrRegistro);
            this.Name = "Form1";
            this.Text = "Auto Test";
            this.mcrRegistro.ResumeLayout(false);
            this.mcrRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.mcrEstaditicas.ResumeLayout(false);
            this.mcrEstaditicas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mcrRegistro;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
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
        private System.Windows.Forms.TextBox txtDominio_Seis_Meses;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblDominio_Seis_Meses;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblCantidad;
    }
}

