namespace Ej3
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
            this.gbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.gbEditarDatosAlumnno = new System.Windows.Forms.GroupBox();
            this.lbLibreta = new System.Windows.Forms.Label();
            this.tbDatosAlumno = new System.Windows.Forms.TextBox();
            this.btnVerAlumno = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbNota = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.lbxResultados = new System.Windows.Forms.ListBox();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.gbDatosAlumno.SuspendLayout();
            this.gbPromedio.SuspendLayout();
            this.gbResultados.SuspendLayout();
            this.gbEditarDatosAlumnno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosAlumno
            // 
            this.gbDatosAlumno.Controls.Add(this.btnVerAlumno);
            this.gbDatosAlumno.Controls.Add(this.tbDatosAlumno);
            this.gbDatosAlumno.Controls.Add(this.lbLibreta);
            this.gbDatosAlumno.Controls.Add(this.gbEditarDatosAlumnno);
            this.gbDatosAlumno.Location = new System.Drawing.Point(13, 24);
            this.gbDatosAlumno.Name = "gbDatosAlumno";
            this.gbDatosAlumno.Size = new System.Drawing.Size(433, 272);
            this.gbDatosAlumno.TabIndex = 0;
            this.gbDatosAlumno.TabStop = false;
            this.gbDatosAlumno.Text = "Datos del alumno";
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.btnCalcularPromedio);
            this.gbPromedio.Controls.Add(this.lbPromedio);
            this.gbPromedio.Location = new System.Drawing.Point(12, 302);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(434, 74);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Mostrar promedio";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.btnVerResultados);
            this.gbResultados.Controls.Add(this.lbxResultados);
            this.gbResultados.Location = new System.Drawing.Point(464, 34);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(325, 342);
            this.gbResultados.TabIndex = 2;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // gbEditarDatosAlumnno
            // 
            this.gbEditarDatosAlumnno.Controls.Add(this.btnRegistrarAlumno);
            this.gbEditarDatosAlumnno.Controls.Add(this.textBox2);
            this.gbEditarDatosAlumnno.Controls.Add(this.textBox1);
            this.gbEditarDatosAlumnno.Controls.Add(this.lbNota);
            this.gbEditarDatosAlumnno.Controls.Add(this.lbNombre);
            this.gbEditarDatosAlumnno.Location = new System.Drawing.Point(21, 73);
            this.gbEditarDatosAlumnno.Name = "gbEditarDatosAlumnno";
            this.gbEditarDatosAlumnno.Size = new System.Drawing.Size(406, 157);
            this.gbEditarDatosAlumnno.TabIndex = 0;
            this.gbEditarDatosAlumnno.TabStop = false;
            this.gbEditarDatosAlumnno.Text = "Editar Datos alumno";
            // 
            // lbLibreta
            // 
            this.lbLibreta.AutoSize = true;
            this.lbLibreta.Location = new System.Drawing.Point(18, 42);
            this.lbLibreta.Name = "lbLibreta";
            this.lbLibreta.Size = new System.Drawing.Size(39, 13);
            this.lbLibreta.TabIndex = 1;
            this.lbLibreta.Text = "Libreta";
            // 
            // tbDatosAlumno
            // 
            this.tbDatosAlumno.Location = new System.Drawing.Point(106, 35);
            this.tbDatosAlumno.Name = "tbDatosAlumno";
            this.tbDatosAlumno.Size = new System.Drawing.Size(175, 20);
            this.tbDatosAlumno.TabIndex = 2;
            // 
            // btnVerAlumno
            // 
            this.btnVerAlumno.Location = new System.Drawing.Point(306, 22);
            this.btnVerAlumno.Name = "btnVerAlumno";
            this.btnVerAlumno.Size = new System.Drawing.Size(106, 45);
            this.btnVerAlumno.TabIndex = 3;
            this.btnVerAlumno.Text = "Ver Alumno";
            this.btnVerAlumno.UseVisualStyleBackColor = true;
            this.btnVerAlumno.Click += new System.EventHandler(this.btnVerAlumno_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(21, 45);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Location = new System.Drawing.Point(21, 107);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(30, 13);
            this.lbNota.TabIndex = 1;
            this.lbNota.Text = "Nota";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(290, 57);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(106, 48);
            this.btnRegistrarAlumno.TabIndex = 4;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.Location = new System.Drawing.Point(54, 36);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(59, 13);
            this.lbPromedio.TabIndex = 0;
            this.lbPromedio.Text = "lbPromedio";
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Location = new System.Drawing.Point(308, 27);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(110, 31);
            this.btnCalcularPromedio.TabIndex = 1;
            this.btnCalcularPromedio.Text = "Calcular";
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            // 
            // lbxResultados
            // 
            this.lbxResultados.FormattingEnabled = true;
            this.lbxResultados.Location = new System.Drawing.Point(16, 29);
            this.lbxResultados.Name = "lbxResultados";
            this.lbxResultados.Size = new System.Drawing.Size(201, 290);
            this.lbxResultados.TabIndex = 0;
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(228, 63);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(91, 56);
            this.btnVerResultados.TabIndex = 1;
            this.btnVerResultados.Text = "Ver Resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbDatosAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDatosAlumno.ResumeLayout(false);
            this.gbDatosAlumno.PerformLayout();
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            this.gbEditarDatosAlumnno.ResumeLayout(false);
            this.gbEditarDatosAlumnno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosAlumno;
        private System.Windows.Forms.GroupBox gbEditarDatosAlumnno;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Button btnVerAlumno;
        private System.Windows.Forms.TextBox tbDatosAlumno;
        private System.Windows.Forms.Label lbLibreta;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.ListBox lbxResultados;
    }
}

