namespace Ej1
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
            this.gbIngresarNumero = new System.Windows.Forms.GroupBox();
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.tbIngresarNumero = new System.Windows.Forms.TextBox();
            this.gbMostrarPromedio = new System.Windows.Forms.GroupBox();
            this.lbMostarPromedio = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbBusquedaNumero = new System.Windows.Forms.GroupBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.tbBusquedaNumero = new System.Windows.Forms.TextBox();
            this.gbListaOrdenada = new System.Windows.Forms.GroupBox();
            this.lbListaOrdenada = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.gbMetodoBusqueda = new System.Windows.Forms.GroupBox();
            this.rbBusqSecuencial = new System.Windows.Forms.RadioButton();
            this.rbBusqBinaria = new System.Windows.Forms.RadioButton();
            this.gbIngresarNumero.SuspendLayout();
            this.gbMostrarPromedio.SuspendLayout();
            this.gbBusquedaNumero.SuspendLayout();
            this.gbListaOrdenada.SuspendLayout();
            this.gbMetodoBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngresarNumero
            // 
            this.gbIngresarNumero.Controls.Add(this.btnAgregarNumero);
            this.gbIngresarNumero.Controls.Add(this.tbIngresarNumero);
            this.gbIngresarNumero.Location = new System.Drawing.Point(24, 44);
            this.gbIngresarNumero.Name = "gbIngresarNumero";
            this.gbIngresarNumero.Size = new System.Drawing.Size(404, 105);
            this.gbIngresarNumero.TabIndex = 0;
            this.gbIngresarNumero.TabStop = false;
            this.gbIngresarNumero.Text = "Ingresar número";
            this.gbIngresarNumero.Enter += new System.EventHandler(this.gbIngresarNumero_Enter);
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarNumero.Location = new System.Drawing.Point(292, 40);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(84, 34);
            this.btnAgregarNumero.TabIndex = 1;
            this.btnAgregarNumero.Text = "Agregar Número";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            this.btnAgregarNumero.Click += new System.EventHandler(this.btnAgregarNumero_Click);
            // 
            // tbIngresarNumero
            // 
            this.tbIngresarNumero.Location = new System.Drawing.Point(29, 48);
            this.tbIngresarNumero.Name = "tbIngresarNumero";
            this.tbIngresarNumero.Size = new System.Drawing.Size(183, 20);
            this.tbIngresarNumero.TabIndex = 0;
            this.tbIngresarNumero.TextChanged += new System.EventHandler(this.tbIngresarNumero_TextChanged);
            // 
            // gbMostrarPromedio
            // 
            this.gbMostrarPromedio.Controls.Add(this.lbMostarPromedio);
            this.gbMostrarPromedio.Controls.Add(this.btnCalcular);
            this.gbMostrarPromedio.Location = new System.Drawing.Point(24, 169);
            this.gbMostrarPromedio.Name = "gbMostrarPromedio";
            this.gbMostrarPromedio.Size = new System.Drawing.Size(404, 105);
            this.gbMostrarPromedio.TabIndex = 1;
            this.gbMostrarPromedio.TabStop = false;
            this.gbMostrarPromedio.Text = "Mostrar promedio";
            this.gbMostrarPromedio.Enter += new System.EventHandler(this.gbMostrarPromedio_Enter);
            // 
            // lbMostarPromedio
            // 
            this.lbMostarPromedio.AutoSize = true;
            this.lbMostarPromedio.Location = new System.Drawing.Point(27, 45);
            this.lbMostarPromedio.Name = "lbMostarPromedio";
            this.lbMostarPromedio.Size = new System.Drawing.Size(10, 13);
            this.lbMostarPromedio.TabIndex = 5;
            this.lbMostarPromedio.Text = "-";
            this.lbMostarPromedio.Click += new System.EventHandler(this.lbMostarPromedio_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCalcular.Location = new System.Drawing.Point(292, 37);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbBusquedaNumero
            // 
            this.gbBusquedaNumero.Controls.Add(this.gbMetodoBusqueda);
            this.gbBusquedaNumero.Controls.Add(this.btnBusqueda);
            this.gbBusquedaNumero.Controls.Add(this.tbBusquedaNumero);
            this.gbBusquedaNumero.Location = new System.Drawing.Point(24, 294);
            this.gbBusquedaNumero.Name = "gbBusquedaNumero";
            this.gbBusquedaNumero.Size = new System.Drawing.Size(404, 144);
            this.gbBusquedaNumero.TabIndex = 2;
            this.gbBusquedaNumero.TabStop = false;
            this.gbBusquedaNumero.Text = "Busqueda de número";
            this.gbBusquedaNumero.Enter += new System.EventHandler(this.gbBusquedaNumero_Enter);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(292, 28);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(84, 34);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // tbBusquedaNumero
            // 
            this.tbBusquedaNumero.Location = new System.Drawing.Point(29, 28);
            this.tbBusquedaNumero.Name = "tbBusquedaNumero";
            this.tbBusquedaNumero.Size = new System.Drawing.Size(183, 20);
            this.tbBusquedaNumero.TabIndex = 1;
            this.tbBusquedaNumero.TextChanged += new System.EventHandler(this.tbBusquedaNumero_TextChanged);
            // 
            // gbListaOrdenada
            // 
            this.gbListaOrdenada.Controls.Add(this.lbListaOrdenada);
            this.gbListaOrdenada.Controls.Add(this.btnListar);
            this.gbListaOrdenada.Location = new System.Drawing.Point(462, 44);
            this.gbListaOrdenada.Name = "gbListaOrdenada";
            this.gbListaOrdenada.Size = new System.Drawing.Size(255, 394);
            this.gbListaOrdenada.TabIndex = 3;
            this.gbListaOrdenada.TabStop = false;
            this.gbListaOrdenada.Text = "Lista ordenada";
            this.gbListaOrdenada.Enter += new System.EventHandler(this.gbListaOrdenada_Enter);
            // 
            // lbListaOrdenada
            // 
            this.lbListaOrdenada.FormattingEnabled = true;
            this.lbListaOrdenada.Location = new System.Drawing.Point(30, 34);
            this.lbListaOrdenada.Name = "lbListaOrdenada";
            this.lbListaOrdenada.Size = new System.Drawing.Size(108, 342);
            this.lbListaOrdenada.TabIndex = 6;
            this.lbListaOrdenada.SelectedIndexChanged += new System.EventHandler(this.lbListaOrdenada_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(153, 34);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(84, 34);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gbMetodoBusqueda
            // 
            this.gbMetodoBusqueda.Controls.Add(this.rbBusqBinaria);
            this.gbMetodoBusqueda.Controls.Add(this.rbBusqSecuencial);
            this.gbMetodoBusqueda.Location = new System.Drawing.Point(36, 67);
            this.gbMetodoBusqueda.Name = "gbMetodoBusqueda";
            this.gbMetodoBusqueda.Size = new System.Drawing.Size(176, 71);
            this.gbMetodoBusqueda.TabIndex = 5;
            this.gbMetodoBusqueda.TabStop = false;
            this.gbMetodoBusqueda.Text = "Metodo de Busqueda";
            this.gbMetodoBusqueda.Enter += new System.EventHandler(this.gbMetodoBusqueda_Enter);
            // 
            // rbBusqSecuencial
            // 
            this.rbBusqSecuencial.AutoSize = true;
            this.rbBusqSecuencial.Location = new System.Drawing.Point(17, 23);
            this.rbBusqSecuencial.Name = "rbBusqSecuencial";
            this.rbBusqSecuencial.Size = new System.Drawing.Size(78, 17);
            this.rbBusqSecuencial.TabIndex = 0;
            this.rbBusqSecuencial.TabStop = true;
            this.rbBusqSecuencial.Text = "Secuencial";
            this.rbBusqSecuencial.UseVisualStyleBackColor = true;
            this.rbBusqSecuencial.CheckedChanged += new System.EventHandler(this.rbBusqSecuencial_CheckedChanged);
            // 
            // rbBusqBinaria
            // 
            this.rbBusqBinaria.AutoSize = true;
            this.rbBusqBinaria.Location = new System.Drawing.Point(17, 46);
            this.rbBusqBinaria.Name = "rbBusqBinaria";
            this.rbBusqBinaria.Size = new System.Drawing.Size(57, 17);
            this.rbBusqBinaria.TabIndex = 1;
            this.rbBusqBinaria.TabStop = true;
            this.rbBusqBinaria.Text = "Binaria";
            this.rbBusqBinaria.UseVisualStyleBackColor = true;
            this.rbBusqBinaria.CheckedChanged += new System.EventHandler(this.rbBusqBinaria_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.gbListaOrdenada);
            this.Controls.Add(this.gbBusquedaNumero);
            this.Controls.Add(this.gbMostrarPromedio);
            this.Controls.Add(this.gbIngresarNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbIngresarNumero.ResumeLayout(false);
            this.gbIngresarNumero.PerformLayout();
            this.gbMostrarPromedio.ResumeLayout(false);
            this.gbMostrarPromedio.PerformLayout();
            this.gbBusquedaNumero.ResumeLayout(false);
            this.gbBusquedaNumero.PerformLayout();
            this.gbListaOrdenada.ResumeLayout(false);
            this.gbMetodoBusqueda.ResumeLayout(false);
            this.gbMetodoBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngresarNumero;
        private System.Windows.Forms.Button btnAgregarNumero;
        private System.Windows.Forms.TextBox tbIngresarNumero;
        private System.Windows.Forms.GroupBox gbMostrarPromedio;
        private System.Windows.Forms.GroupBox gbBusquedaNumero;
        private System.Windows.Forms.TextBox tbBusquedaNumero;
        private System.Windows.Forms.GroupBox gbListaOrdenada;
        private System.Windows.Forms.Label lbMostarPromedio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lbListaOrdenada;
        private System.Windows.Forms.GroupBox gbMetodoBusqueda;
        private System.Windows.Forms.RadioButton rbBusqSecuencial;
        private System.Windows.Forms.RadioButton rbBusqBinaria;
    }
}

