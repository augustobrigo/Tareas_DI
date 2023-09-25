using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2_1octubre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  mostrar();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        private void mostrar()
        {
           if (comboBox1.Text!="" && comboBox2.Text  !="") {
            for (int i = 0; i < Convert.ToInt16(comboBox2.Text); i++)
                {
                    if (comboBox1.Text == "ComboBox")
                    {
                        ComboBox cmb = new ComboBox();
                        flowLayoutPanel1.Controls.Add(cmb);
                    }
                    if (comboBox1.Text == "Button")
                    {
                        Button btn = new Button();
                        btn.BackColor = Color.Red;
                        flowLayoutPanel1.Controls.Add(btn);
                    }
                    if (comboBox1.Text == "Label")
                    {
                        Label lbl = new Label();
                        lbl.Text = "Etiqueta";
                        flowLayoutPanel1.Controls.Add(lbl);
                    }
                    if (comboBox1.Text == "TextBox")
                    {
                        TextBox txt = new TextBox();
                        txt.BackColor = Color.Green;
                        flowLayoutPanel1.Controls.Add(txt);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
