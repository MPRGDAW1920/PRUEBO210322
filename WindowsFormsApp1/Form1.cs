using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            char tipoTelegrama;
            int numPalabras;
            double coste;
            //Leo el telegrama repasso subida
            textoTelegrama = telegrama.Text;
            //Obtengo el primer carácter de la cadena
            tipoTelegrama = textoTelegrama[0];
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ').Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'O' || tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numPalabras;
else
//Si el telegrama es urgente
if (tipoTelegrama == 'U' || tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            precio.Text = coste.ToString() + " euros";
        }
    }
    }

