using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba5_1Octubre
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        int numero = 0;
        int mayor = -1;
        int menor = 1000001;
        int suma = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            label0.Text =Convert.ToString( contador);
            numero = aleatorio.Next(1, 1000000);
            label1.Text = Convert.ToString(numero);
            if (numero>mayor)
            {
                mayor = numero;
                label2.Text = Convert.ToString(numero);
            }
            if (numero < menor)
            {
                menor = numero;
                label3.Text = Convert.ToString(numero);
            }
            suma = suma + numero;
            label4.Text =Convert.ToString( suma / contador);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
