using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_9
{
    public partial class Form1 : Form
    {
        public static int controjo_op1 = 0;
        public static int contmenos1rojo_op1 = 0;
        public static int controjo_op2;
        public static int contmenos1rojo_op2;
        public static int cont_op2= 1;
        public static int controjo_op3 = 0;
        public static int contverde_op3 = 0;
        public static int controjo_op4;
        public static int contverde_op4 = 0;
        public static int cont_op4 = 1;
        public static int cont_ver_op4 = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_opcion1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl.BackColor == Color.Red)
                {
                    ctrl.BackColor = Color.Green;
                }
            }
            temporizador_opcion1.Enabled = true;
            temporizador_opcion2.Enabled = false;
            temporizador_opcion3.Enabled = false;
            temporizador_opcion4.Enabled = false;
        }

        private void temporizador_opcion1_Tick(object sender, EventArgs e)
        {
            Button btn1 = flowLayoutPanel1.Controls[controjo_op1] as Button;
            Button btn2 = flowLayoutPanel1.Controls[contmenos1rojo_op1] as Button;
            if (controjo_op1 < (flowLayoutPanel1.Controls.Count - 1))
            {
                controjo_op1++;
                contmenos1rojo_op1 = controjo_op1 - 1;
                btn1.BackColor = Color.Red;
                btn2.BackColor = Color.Green;

            }
            else
            {
                controjo_op1 = 0;
            }

        }

        private void btn_opcion2_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl.BackColor == Color.Red)
                {
                    ctrl.BackColor = Color.Green;
                }
            }
            temporizador_opcion2.Enabled = true;
            temporizador_opcion1.Enabled = false;
            temporizador_opcion3.Enabled = false;
            temporizador_opcion4.Enabled = false;
        }

        private void temporizador_opcion2_Tick(object sender, EventArgs e)
        {
            controjo_op2 = flowLayoutPanel1.Controls.Count - cont_op2;
            Button btn1 = flowLayoutPanel1.Controls[controjo_op2] as Button;
            Button btn2 = flowLayoutPanel1.Controls[contmenos1rojo_op2] as Button;
            if (controjo_op2 <= (flowLayoutPanel1.Controls.Count - 1) && controjo_op2 != 0)
            {
                cont_op2++;
                if (controjo_op2 == (flowLayoutPanel1.Controls.Count))
                {
                    contmenos1rojo_op2 = 0;
                }
                else if (controjo_op2 < (flowLayoutPanel1.Controls.Count))
                {
                    contmenos1rojo_op2 = controjo_op2;

                }
                btn1.BackColor = Color.Red;
                btn2.BackColor = Color.Green;

            }
            else
            {
                cont_op2 = 1;
            }
        }

        private void btn_opcion3_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl.BackColor == Color.Red)
                {
                    ctrl.BackColor = Color.Green;
                }
            }
            temporizador_opcion3.Enabled = true;
            temporizador_opcion4.Enabled = false;
            temporizador_opcion1.Enabled = false;
            temporizador_opcion2.Enabled = false;

        }

        private void temporizador_opcion3_Tick(object sender, EventArgs e)
        {
            Button btn1 = flowLayoutPanel1.Controls[controjo_op3] as Button;
            Button btn2 = flowLayoutPanel1.Controls[contverde_op3] as Button;

            if (controjo_op3 < (flowLayoutPanel1.Controls.Count - 1))
            {
                controjo_op3++;
                btn1.BackColor = Color.Red;
                if (controjo_op3 >= (flowLayoutPanel1.Controls.Count - 1) && contverde_op3 >= (flowLayoutPanel1.Controls.Count - 1))
                {
                    contverde_op3 = 0;
                }

            }else if (controjo_op3 >= (flowLayoutPanel1.Controls.Count - 1))
            {
                if (contverde_op3 < (flowLayoutPanel1.Controls.Count - 1))
                {
                    contverde_op3++;
                    btn2.BackColor = Color.Green;
                }
                else
                {
                    controjo_op3 = 0;
                }
            }


        }

        private void btn_opcion4_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl.BackColor == Color.Red)
                {
                    ctrl.BackColor = Color.Green;
                }
            }
            temporizador_opcion3.Enabled = false;
            temporizador_opcion4.Enabled = true;
            temporizador_opcion1.Enabled = false;
            temporizador_opcion2.Enabled = false;
        }

        private void temporizador_opcion4_Tick(object sender, EventArgs e)
        {
            contverde_op4 = flowLayoutPanel1.Controls.Count - cont_ver_op4;
            controjo_op4 = flowLayoutPanel1.Controls.Count - cont_op4;
            Button btn1 = flowLayoutPanel1.Controls[controjo_op4] as Button;
            Button btn2 = flowLayoutPanel1.Controls[contverde_op4] as Button;
            if (controjo_op4 <= (flowLayoutPanel1.Controls.Count - 1))
            {
                if (cont_op4 < (flowLayoutPanel1.Controls.Count))
                {
                    cont_op4++;
                    btn1.BackColor = Color.Red;
                    if (cont_op4 >= (flowLayoutPanel1.Controls.Count - 1) && cont_ver_op4 >= (flowLayoutPanel1.Controls.Count - 1))
                    {
                        cont_ver_op4 = 1;
                    }
                } else if (cont_op4 >= (flowLayoutPanel1.Controls.Count))
                {
                    if (cont_ver_op4 < (flowLayoutPanel1.Controls.Count) && cont_ver_op4 != 0)
                    {
                        cont_ver_op4++;
                        btn2.BackColor = Color.Green;
                    }
                    else
                    {
                        cont_op4 = 1;
                    }
                }
            }
            
        }
    }
}
