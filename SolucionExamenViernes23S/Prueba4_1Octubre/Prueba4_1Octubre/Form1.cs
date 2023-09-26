using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba4_1Octubre
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        int puntos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.BackColor = Color.Red;
            int x = aleatorio.Next(1, this.Width-40);
            int y = aleatorio.Next(1, this.Height-40);
            btn.Location = new Point(x,y);
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.Visible = false;
            puntos++;
            label1.Text = Convert.ToString(puntos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Crear dinámicamente y de forma programada objetos Button, si haces click sobre uno de ellos sumas 1 punto y desaparece, si lo haces sobre el panel del fondo restas un punto");
            timer1.Enabled = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            puntos--;
            label1.Text = Convert.ToString(puntos);
        }
    }
}
