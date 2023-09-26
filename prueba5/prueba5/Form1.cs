using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba5
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
            foreach (Control ctrl in groupBox1.Controls)
            {
                ctrl.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in groupBox1.Controls)
            {
                ctrl.Text = Convert.ToString( aleatorio.Next(50));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
