using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba4
{
    public partial class Form1 : Form
    {
        int segundos = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            segundos = 10;
            label1.Visible = true;
            label1.Text = Convert.ToString(segundos);



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
           
            if (segundos < 6) { label1.BackColor = Color.Aqua; }
            if (segundos < 4) { label1.BackColor = Color.Orange; }
            if (segundos <3 ){ label1.BackColor = Color.Red; }
            
            label1.Text = Convert.ToString(segundos);
            if (segundos == -1) { label1.Visible = false; timer1.Stop(); label1.BackColor = Color.Yellow; }
        }
    }
}
