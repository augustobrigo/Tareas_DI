using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba3_1Octubre
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        int numeroReferencia = 0;
        int puntos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Enabled = true;
            cargarJuego();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarJuego();
        }

        private void cargarJuego()
        {
            numeroReferencia = aleatorio.Next(1, 25);
            label1.Text = Convert.ToString(numeroReferencia);
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 25; i++)
            {
                Button btn = new Button();
                btn.Click += Btn_Click;
                btn.Width = 50;
                btn.Height = 50;
                btn.Font = new Font("Arial", 15);
                btn.Text = Convert.ToString(aleatorio.Next(1, 25));
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            if (btn.Text==label1.Text)
            {
                puntos++;
            }else
            {
                puntos--;
            }
            label2.Text = Convert.ToString(puntos);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
