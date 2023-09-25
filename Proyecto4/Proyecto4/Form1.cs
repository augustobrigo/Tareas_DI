using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto4
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList V1 = new ArrayList();
            ArrayList V2 = new ArrayList();
            ArrayList V3 = new ArrayList();
            ArrayList V4 = new ArrayList();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
           
            for (int i = 0; i < 100; i++)
            {
                int numero = aleatorio.Next(1, 100);
                if (numero>75 && numero <= 100)
                {
                    V1=insertarOrdenado(numero,V1);
                    
                
                }else
                if (numero>50 && numero <=75)
                {
                    V2 = insertarOrdenado(numero, V2);
                  
                }else
                if (numero > 25 && numero <= 50)
                {
                    V3 = insertarOrdenado(numero, V3);
                  
                }else
                if (numero >=0 && numero<=25)
               
                {
                    V4 = insertarOrdenado(numero, V4);
                }
            }
            foreach (int x in V1)
            {
                Label lbX = new Label();
                lbX.ForeColor = Color.Green;
                lbX.Text = Convert.ToString(x);
                flowLayoutPanel1.Controls.Add(lbX);
            }
            foreach (int x in V2)
            {
                Label lbX = new Label();
                lbX.ForeColor = Color.Blue;
                lbX.Text = Convert.ToString(x);
                flowLayoutPanel2.Controls.Add(lbX);
            }
            foreach (int x in V3)
            {
                Label lbX = new Label();
                lbX.ForeColor = Color.Orange;
                lbX.Text = Convert.ToString(x);
                flowLayoutPanel3.Controls.Add(lbX);
            }
            foreach ( int x in V4)
            {
                Label lbX = new Label();
                lbX.ForeColor = Color.Red;
                lbX.Text = Convert.ToString(x);
                flowLayoutPanel4.Controls.Add(lbX);
            }
            label3.Text = Convert.ToString(flowLayoutPanel1.Controls.Count);
            label4.Text = Convert.ToString(flowLayoutPanel2.Controls.Count);
            label5.Text = Convert.ToString(flowLayoutPanel3.Controls.Count);
            label6.Text = Convert.ToString(flowLayoutPanel4.Controls.Count);
        }

        private ArrayList insertarOrdenado(int num,ArrayList V)
        {
            V.Add(num);
            V.Sort();
            return V;
        }
    }
}
