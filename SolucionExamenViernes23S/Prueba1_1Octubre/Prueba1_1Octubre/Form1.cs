using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1_1Octubre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBox1.Controls)
            {

                foreach (Control c in groupBox1.Controls)
                    if (c is Button)
                    {
                        flowLayoutPanel2.Controls.Add(c);
                    }
                foreach (Control c in groupBox1.Controls)
                    if (c.GetType() == typeof(Label))
                    {
                        flowLayoutPanel3.Controls.Add(c);

                    }
                foreach (Control c in groupBox1.Controls)
                    if (c.GetType() == typeof(TextBox))
                    {
                        flowLayoutPanel4.Controls.Add(c);
                    }
                foreach (Control c in groupBox1.Controls)
                    if (c.GetType() == typeof(ComboBox))
                    {
                        flowLayoutPanel5.Controls.Add(c);
                    }
            }
        }
        // flowLayoutPanel1.Controls.Clear();
    }
}
        
    

