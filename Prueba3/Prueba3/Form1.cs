using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba3
{
    public partial class Form1 : Form
    {
        int numero;
        int intentos = 0;
        Random aleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             numero = Convert.ToInt32(textBox1.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            intentos++;
           int numero2 = aleatorio.Next(1,100);
            label1.Text = Convert.ToString(numero2);
            label2.Text = Convert.ToString(intentos);
            if (numero2 == numero)
            {
                timer1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && Convert.ToInt16(textBox1.Text)<100)
            {
                button1.Enabled = true;
            }
            if (e.KeyCode==Keys.Escape)
            {
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            label1.Text = "";
            label2.Text = "";
            button1.Enabled = false;
            intentos = 0;
        }
    }
}
