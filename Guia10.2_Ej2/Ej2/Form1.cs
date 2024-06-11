using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        int CONT = 0;
        string[] ALUMNO = new string[100];
        int[] NOTA = new int[100];
        int[] LIBRETA = new int[100];
        double PROM = 0;

        void Ordenar(int[] libr, string[] alumno, int[] nota) 
        {
            int i,j,aLib,aNota;
            string aAlum;

            for (i=0;i<CONT;i++) 
            {
                for (j=i+1; j < CONT;j++) 
                {
                    if (libr[i] < libr[j]) 
                    {
                        aLib = libr[j];
                        aAlum = alumno[j];
                        aNota = nota[j];
                        /*---------------*/
                        libr[j] = libr[i];
                        alumno[j] = alumno[i];
                        nota[j] = nota[i];
                        /*---------------*/
                        libr[i] = aLib;
                        alumno[i] = aAlum;
                        nota[i] = aNota;
                    } 
                }
            }
        }

        int Buscar(int[] libr, int numlib) 
        {
            int pivot = -1;
            int i = 0;
            while (i < CONT && pivot < 0)
            {
                if (libr[i] == numlib)
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

        public Form1()
        {
            InitializeComponent();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNota_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistarAlumno_Click(object sender, EventArgs e)
        {
            LIBRETA[CONT] = Convert.ToInt32(tbLibreta.Text);
            ALUMNO[CONT] = Convert.ToString(tbNombre.Text);
            NOTA[CONT] = Convert.ToInt32(tbNota.Text);
            PROM += NOTA[CONT];
            ++CONT;
            tbLibreta.Text = "";
            tbNombre.Text = "";
            tbNota.Text = "";
        }

        private void tbLibreta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            lbPromedio.Text = $"{PROM/CONT:f2}";
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            lbnResultados.Items.Clear();
            Ordenar(LIBRETA,ALUMNO,NOTA);

            if (rbtsSuperaronPromedio.Checked==true)
            {
                for (int i=0; i<CONT;i++) 
                {
                    if (NOTA[i] > PROM/CONT) 
                    {
                        lbnResultados.Items.Add($"{LIBRETA[i]} - {ALUMNO[i]} - {NOTA[i]}");
                    }
                }
            }
            else 
            {
                for (int i = 0; i < CONT; i++) 
                {
                    lbnResultados.Items.Add($"{LIBRETA[i]} - {ALUMNO[i]} - {NOTA[i]}");
                }
            }
        }

        private void rbtsSuperaronPromedio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarAlumno_Click(object sender, EventArgs e)
        {
            lbxMostrarAlumno.Items.Clear();
            int libnum,num;
            libnum = Convert.ToInt32(tbMostrarLibreta.Text);

            Ordenar(LIBRETA, ALUMNO, NOTA);
            num = Buscar(LIBRETA,libnum);

            if (num == -1)
            {
                lbxMostrarAlumno.Items.Add($"Libreta no valida");
            }
            else 
            {
                lbxMostrarAlumno.Items.Add($"{LIBRETA[num]}");
                lbxMostrarAlumno.Items.Add($"{ALUMNO[num]}");
                lbxMostrarAlumno.Items.Add($"{NOTA[num]}");
            }
            tbMostrarLibreta.Text = "";
        }

        private void tbMostrarLibreta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
