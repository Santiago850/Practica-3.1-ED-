using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicas_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste = 0;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            string[] palabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // telegrama urgente?
            if (rbUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';

            //Obtengo el número de palabras que forma el telegrama
            numPalabras = palabras.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + (0.5 * (numPalabras - 10));
            }
            else //Si el telegrama es urgente
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + (0.75 * (numPalabras - 10));
            }

            if (coste == 1)
                txtPrecio.Text = coste.ToString() + " euro";
            else
                txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
