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
    public partial class Form1 : Form
    {
        int cont = 0;
        int[] num = new int[1000];


        public Form1()
        {
            InitializeComponent();
        }
        double CalcularPromedio()
        {
            double promedio = 0;
            
            for (int i=0;i<=cont;i++) 
            {
                promedio += num[i];
            }

            if (cont > 0)
                promedio = promedio / cont;
            return promedio;
        }
        void OrdenarLista(int[] lista) 
        {
            int i=0,
                j=0;
            int aux=0;
            
            for (i=0;i<cont;i++) 
            {
                for (j=i+1;j<cont;j++) 
                {
                    if (lista[i] > lista[j]) 
                    {
                        
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
        }
        int BusqBinaria(int[] lista, int num) 
        {
            int pivot = -1;
            int inf = 0,
                centro = 0,
                sup = cont;

            while (inf<=sup && pivot<0) 
            {
                centro = (inf + sup) / 2;
                if (lista[centro] == num) 
                {
                    pivot = centro;
                } 
                else 
                {
                    if (num > lista[centro]) 
                    {
                        inf = centro + 1;
                    }
                    else
                    {
                        sup = centro - 1;
                    }
                }

            }

                return pivot;
        }
        int BusqSecuencial(int[] lista, int num)
        {
            int pivot = -1;
            int i = 0;
            while (i < cont && pivot < 0)
            {
                if (lista[i] == num)
                {
                    pivot = i;
                }
                else 
                {
                    ++i;
                }

            }
            return pivot;
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            num[cont] = Convert.ToInt32(tbIngresarNumero.Text);
            cont++;
            
            tbIngresarNumero.Text="";
        }

        private void gbIngresarNumero_Enter(object sender, EventArgs e)
        {

        }

        private void gbListaOrdenada_Enter(object sender, EventArgs e)
        {

        }

        private void tbIngresarNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gbMostrarPromedio_Enter(object sender, EventArgs e)
        {

        }

        private void gbBusquedaNumero_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double prom;
            prom=CalcularPromedio();
            lbMostarPromedio.Text = $"{prom:f2}";
        }

        private void lbMostarPromedio_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbListaOrdenada.Items.Clear();
            OrdenarLista(num);
            
            for (int i=0;i<cont;i++) 
            {
                lbListaOrdenada.Items.Add($"{num[i]}");
            }
        }

        private void lbListaOrdenada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkBinaria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            int na;//numero buscado
            int pos = 0;
            na = Convert.ToInt32(tbBusquedaNumero.Text);
            

            if (rbBusqBinaria.Checked == true)
            {
                pos = BusqBinaria(num,na);
            }
            if (rbBusqSecuencial.Checked == true) 
            {
                pos = BusqSecuencial(num,na);
            }
            
            Numero_Buscado NumBusq = new Numero_Buscado(pos);
            NumBusq.Show();
            tbBusquedaNumero.Text = "";
        }

        private void gbMetodoBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void rbBusqSecuencial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBusqBinaria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbBusquedaNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
