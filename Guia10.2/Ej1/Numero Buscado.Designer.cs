namespace Ej1
{
    partial class Numero_Buscado
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
            this.lbResulBusqueda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResulBusqueda
            // 
            this.lbResulBusqueda.AutoSize = true;
            this.lbResulBusqueda.Location = new System.Drawing.Point(12, 36);
            this.lbResulBusqueda.Name = "lbResulBusqueda";
            this.lbResulBusqueda.Size = new System.Drawing.Size(55, 13);
            this.lbResulBusqueda.TabIndex = 0;
            this.lbResulBusqueda.Text = "Resultado";
            this.lbResulBusqueda.Click += new System.EventHandler(this.lbResulBusqueda_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(202, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Numero_Buscado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 138);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbResulBusqueda);
            this.Name = "Numero_Buscado";
            this.Text = "Resultado de búsqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResulBusqueda;
        private System.Windows.Forms.Button button1;
    }
}