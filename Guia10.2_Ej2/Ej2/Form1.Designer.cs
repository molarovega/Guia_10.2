namespace Ej2
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
            this.btnRegistarAlumno = new System.Windows.Forms.Button();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbLibreta = new System.Windows.Forms.TextBox();
            this.lbNota = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbLibreta = new System.Windows.Forms.Label();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.gbMostrarAlumno = new System.Windows.Forms.GroupBox();
            this.lbxMostrarAlumno = new System.Windows.Forms.ListBox();
            this.btnMostrarAlumno = new System.Windows.Forms.Button();
            this.tbMostrarLibreta = new System.Windows.Forms.TextBox();
            this.lbMostrarAumno = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.rbnTodos = new System.Windows.Forms.RadioButton();
            this.rbtsSuperaronPromedio = new System.Windows.Forms.RadioButton();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.lbnResultados = new System.Windows.Forms.ListBox();
            this.gbDatosAlumno.SuspendLayout();
            this.gbPromedio.SuspendLayout();
            this.gbMostrarAlumno.SuspendLayout();
            this.gbResultados.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosAlumno
            // 
            this.gbDatosAlumno.Controls.Add(this.btnRegistarAlumno);
            this.gbDatosAlumno.Controls.Add(this.tbNota);
            this.gbDatosAlumno.Controls.Add(this.tbNombre);
            this.gbDatosAlumno.Controls.Add(this.tbLibreta);
            this.gbDatosAlumno.Controls.Add(this.lbNota);
            this.gbDatosAlumno.Controls.Add(this.lbNombre);
            this.gbDatosAlumno.Controls.Add(this.lbLibreta);
            this.gbDatosAlumno.Location = new System.Drawing.Point(17, 26);
            this.gbDatosAlumno.Name = "gbDatosAlumno";
            this.gbDatosAlumno.Size = new System.Drawing.Size(378, 144);
            this.gbDatosAlumno.TabIndex = 0;
            this.gbDatosAlumno.TabStop = false;
            this.gbDatosAlumno.Text = "Datos del alumno";
            // 
            // btnRegistarAlumno
            // 
            this.btnRegistarAlumno.Location = new System.Drawing.Point(280, 60);
            this.btnRegistarAlumno.Name = "btnRegistarAlumno";
            this.btnRegistarAlumno.Size = new System.Drawing.Size(80, 41);
            this.btnRegistarAlumno.TabIndex = 6;
            this.btnRegistarAlumno.Text = "Registrar Alumno";
            this.btnRegistarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistarAlumno.Click += new System.EventHandler(this.btnRegistarAlumno_Click);
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(99, 109);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(165, 20);
            this.tbNota.TabIndex = 5;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(99, 71);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(167, 20);
            this.tbNombre.TabIndex = 4;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbLibreta
            // 
            this.tbLibreta.Location = new System.Drawing.Point(99, 34);
            this.tbLibreta.Name = "tbLibreta";
            this.tbLibreta.Size = new System.Drawing.Size(171, 20);
            this.tbLibreta.TabIndex = 3;
            this.tbLibreta.TextChanged += new System.EventHandler(this.tbLibreta_TextChanged);
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Location = new System.Drawing.Point(21, 116);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(30, 13);
            this.lbNota.TabIndex = 2;
            this.lbNota.Text = "Nota";
            this.lbNota.Click += new System.EventHandler(this.lbNota_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(21, 78);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbLibreta
            // 
            this.lbLibreta.AutoSize = true;
            this.lbLibreta.Location = new System.Drawing.Point(21, 41);
            this.lbLibreta.Name = "lbLibreta";
            this.lbLibreta.Size = new System.Drawing.Size(39, 13);
            this.lbLibreta.TabIndex = 0;
            this.lbLibreta.Text = "Libreta";
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.lbPromedio);
            this.gbPromedio.Controls.Add(this.btnPromedio);
            this.gbPromedio.Location = new System.Drawing.Point(17, 176);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(378, 92);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Mostrar promedio";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.Location = new System.Drawing.Point(41, 45);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(10, 13);
            this.lbPromedio.TabIndex = 1;
            this.lbPromedio.Text = "-";
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(280, 35);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(80, 33);
            this.btnPromedio.TabIndex = 0;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // gbMostrarAlumno
            // 
            this.gbMostrarAlumno.Controls.Add(this.lbxMostrarAlumno);
            this.gbMostrarAlumno.Controls.Add(this.btnMostrarAlumno);
            this.gbMostrarAlumno.Controls.Add(this.tbMostrarLibreta);
            this.gbMostrarAlumno.Controls.Add(this.lbMostrarAumno);
            this.gbMostrarAlumno.Location = new System.Drawing.Point(17, 274);
            this.gbMostrarAlumno.Name = "gbMostrarAlumno";
            this.gbMostrarAlumno.Size = new System.Drawing.Size(378, 154);
            this.gbMostrarAlumno.TabIndex = 2;
            this.gbMostrarAlumno.TabStop = false;
            this.gbMostrarAlumno.Text = "Mostrar alumno";
            // 
            // lbxMostrarAlumno
            // 
            this.lbxMostrarAlumno.FormattingEnabled = true;
            this.lbxMostrarAlumno.Location = new System.Drawing.Point(27, 70);
            this.lbxMostrarAlumno.Name = "lbxMostrarAlumno";
            this.lbxMostrarAlumno.Size = new System.Drawing.Size(331, 69);
            this.lbxMostrarAlumno.TabIndex = 3;
            // 
            // btnMostrarAlumno
            // 
            this.btnMostrarAlumno.Location = new System.Drawing.Point(279, 19);
            this.btnMostrarAlumno.Name = "btnMostrarAlumno";
            this.btnMostrarAlumno.Size = new System.Drawing.Size(79, 31);
            this.btnMostrarAlumno.TabIndex = 2;
            this.btnMostrarAlumno.Text = "Ver alumno";
            this.btnMostrarAlumno.UseVisualStyleBackColor = true;
            this.btnMostrarAlumno.Click += new System.EventHandler(this.btnMostrarAlumno_Click);
            // 
            // tbMostrarLibreta
            // 
            this.tbMostrarLibreta.Location = new System.Drawing.Point(80, 34);
            this.tbMostrarLibreta.Name = "tbMostrarLibreta";
            this.tbMostrarLibreta.Size = new System.Drawing.Size(159, 20);
            this.tbMostrarLibreta.TabIndex = 1;
            this.tbMostrarLibreta.TextChanged += new System.EventHandler(this.tbMostrarLibreta_TextChanged);
            // 
            // lbMostrarAumno
            // 
            this.lbMostrarAumno.AutoSize = true;
            this.lbMostrarAumno.Location = new System.Drawing.Point(25, 37);
            this.lbMostrarAumno.Name = "lbMostrarAumno";
            this.lbMostrarAumno.Size = new System.Drawing.Size(39, 13);
            this.lbMostrarAumno.TabIndex = 0;
            this.lbMostrarAumno.Text = "Libreta";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.gbOpciones);
            this.gbResultados.Controls.Add(this.btnVerResultados);
            this.gbResultados.Controls.Add(this.lbnResultados);
            this.gbResultados.Location = new System.Drawing.Point(401, 26);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(387, 402);
            this.gbResultados.TabIndex = 3;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.rbnTodos);
            this.gbOpciones.Controls.Add(this.rbtsSuperaronPromedio);
            this.gbOpciones.Location = new System.Drawing.Point(228, 128);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(153, 67);
            this.gbOpciones.TabIndex = 2;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // rbnTodos
            // 
            this.rbnTodos.AutoSize = true;
            this.rbnTodos.Location = new System.Drawing.Point(15, 45);
            this.rbnTodos.Name = "rbnTodos";
            this.rbnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbnTodos.TabIndex = 1;
            this.rbnTodos.TabStop = true;
            this.rbnTodos.Text = "Todos";
            this.rbnTodos.UseVisualStyleBackColor = true;
            // 
            // rbtsSuperaronPromedio
            // 
            this.rbtsSuperaronPromedio.AutoSize = true;
            this.rbtsSuperaronPromedio.Location = new System.Drawing.Point(15, 22);
            this.rbtsSuperaronPromedio.Name = "rbtsSuperaronPromedio";
            this.rbtsSuperaronPromedio.Size = new System.Drawing.Size(131, 17);
            this.rbtsSuperaronPromedio.TabIndex = 0;
            this.rbtsSuperaronPromedio.TabStop = true;
            this.rbtsSuperaronPromedio.Text = "Superaron el promedio";
            this.rbtsSuperaronPromedio.UseVisualStyleBackColor = true;
            this.rbtsSuperaronPromedio.CheckedChanged += new System.EventHandler(this.rbtsSuperaronPromedio_CheckedChanged);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(268, 56);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(81, 45);
            this.btnVerResultados.TabIndex = 1;
            this.btnVerResultados.Text = "Ver Resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // lbnResultados
            // 
            this.lbnResultados.FormattingEnabled = true;
            this.lbnResultados.Location = new System.Drawing.Point(6, 24);
            this.lbnResultados.Name = "lbnResultados";
            this.lbnResultados.Size = new System.Drawing.Size(216, 368);
            this.lbnResultados.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbMostrarAlumno);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbDatosAlumno);
            this.Name = "Form1";
            this.Text = "Ejercicio2";
            this.gbDatosAlumno.ResumeLayout(false);
            this.gbDatosAlumno.PerformLayout();
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.gbMostrarAlumno.ResumeLayout(false);
            this.gbMostrarAlumno.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosAlumno;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbLibreta;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.GroupBox gbMostrarAlumno;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbLibreta;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.Button btnRegistarAlumno;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.ListBox lbxMostrarAlumno;
        private System.Windows.Forms.Button btnMostrarAlumno;
        private System.Windows.Forms.TextBox tbMostrarLibreta;
        private System.Windows.Forms.Label lbMostrarAumno;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.RadioButton rbnTodos;
        private System.Windows.Forms.RadioButton rbtsSuperaronPromedio;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.ListBox lbnResultados;
    }
}

