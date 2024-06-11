using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Numero_Buscado : Form
    {
        public Numero_Buscado(int pos)
        {
            InitializeComponent();

            if (pos==-1)
            {
                lbResulBusqueda.Text = $"Número no encontrado";
            }
            else 
            {
                lbResulBusqueda.Text = $"Número encontrado en posicion {pos}";
            }
        }

        private void lbResulBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
