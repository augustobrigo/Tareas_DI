using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba6
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] vector1 = { "A", "B", "C", "D" };
            String[] vector2 = { "Navalmoral", "Toril", "Majadas", "Saucedilla" };
            String[] vector3 = { "DAM", "DAW", "ASIR", "SMR" };
            foreach(Control ctrl in groupBox1.Controls)
            {
                if (ctrl.GetType()==typeof(Button))
                {
                    Button btn = (Button)ctrl;
                    if (btn.Text=="button1")
                    {
                        btn.BackColor = Color.Red;

                    }
                    if (btn.Text == "button3")
                    {
                        btn.BackColor = Color.Green;

                    }
                    if (btn.Text == "button4")
                    {
                        btn.BackColor = Color.Yellow;
                    }
                }
                if (ctrl.GetType()==typeof(Label))
                {
                    Label lbl = (Label)ctrl;
                    lbl.Text = "Buenos días DAM";
                }
                if (ctrl.GetType() == typeof(TextBox)){
                    TextBox txt = (TextBox)ctrl;
                    txt.Text = "Teclea tus datos";
                }
                if (ctrl.GetType() == typeof(ComboBox)){
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.Items.Clear();
                    if (cmb.Name=="comboBox1")
                    cmb.Items.AddRange(vector1);
                    if (cmb.Name == "comboBox2")
                        cmb.Items.AddRange(vector2);
                    if (cmb.Name == "comboBox3")
                        cmb.Items.AddRange(vector3);
                }
                if (ctrl.GetType() == typeof(ListBox))
                {
                    ListBox lbx = (ListBox)ctrl;
                    lbx.Items.Clear();
                    for(int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(aleatorio.Next(1,100));
                    }
                }
            }
        }
    }
}
