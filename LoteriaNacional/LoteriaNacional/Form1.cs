using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteriaNacional
{
    public partial class Form1 : Form
    {
        int miNum, salida;
        int intentos = 0;
        Random aleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbUnidades.Text != "" && cmbDecenas.Text != "" && cmbCentenas.Text != "" && cmbUnidadMillar.Text != "" && cmbDecenaMillar.Text != "")
            {
                lblMinumero.Text = cmbDecenaMillar.Text + cmbUnidadMillar.Text + cmbCentenas.Text + cmbDecenas.Text + cmbUnidades.Text;
                miNum = Convert.ToInt32(lblMinumero.Text);
                timer1.Enabled = true;
                btnIniciar.Enabled = false;
            }
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salida = aleatorio.Next(0, 99999);
            int unidad = salida % 10;
            int unidadMiNum = miNum % 10;
            int decenas = salida % 100;
            int decenasMiNum = miNum % 100;
            int centenas = salida % 1000;
            int centenasMiNum = miNum % 1000;
            int millar = salida % 10000;
            int millarMiNum = miNum % 10000;
            intentos++;
            lbl5digitos.Text = Convert.ToString(salida);
            label3.Text = Convert.ToString(intentos);

            if (salida == miNum)
            {
               
                lbl5digitos.Enabled = false;
           
                label3.Enabled = false;
                timer1.Stop();
            }
            if (lbl1digitos.Enabled == true)
            {
                lbl1digitos.Text = Convert.ToString(salida);
                label5.Text = Convert.ToString(intentos);
                if (unidadMiNum == unidad)
                {

                    lbl1digitos.Enabled = false;
                    label5.Enabled = false;

                }
            }
            if (lbl2Digitos.Enabled == true)
            {
                lbl2Digitos.Text = Convert.ToString(salida);
                label7.Text = Convert.ToString(intentos);
                if (decenasMiNum == decenas)
                {

                    lbl2Digitos.Enabled = false;
                    label7.Enabled = false;

                }
            }

            if (lbl3digitos.Enabled == true)
            {
                lbl3digitos.Text = Convert.ToString(salida);
                label9.Text = Convert.ToString(intentos);
                if (centenasMiNum == centenas)
                {

                    lbl3digitos.Enabled = false;
                    label9.Enabled = false;

                }
            }
            if (lbl4Digitos.Enabled == true)
            {
                lbl4Digitos.Text = Convert.ToString(salida);
                label11.Text = Convert.ToString(intentos);
                if (millar == millarMiNum)
                {

                    lbl4Digitos.Enabled = false;
                    label11.Enabled = false;

                }
            }
        }
    }
}
