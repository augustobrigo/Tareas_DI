using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDinamico
{
    public partial class Form1 : Form
    {

        Random aleat = new Random();
        Color[] colores = { Color.Blue, Color.Red, Color.Green };
        String[] jugadores = { "Sergio Ramos", "Marco Asensio", "David Raya", "Unai Simón", "Pau Torres", "Jordi Alba" };
        int[] vector = new int[20];
        int puntos;
        int segundos = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 25; i++)
            {
                cbxCantidad.Items.Add(i);
            }
            cbxTipo.Items.Add("Colores");
            cbxTipo.Items.Add("Imágenes");
            cbxTipo.Items.Add("Números");
            cbxTipo.Items.Add("Jugadores");

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpContent.Controls.Clear();

            if (cbxCantidad.Text != "")
            {
                int total = Convert.ToInt32(cbxCantidad.Text);

                for (int i = 0; i < total; i++)
                {
                    Button botonX = new Button();

                    elegirTipo(botonX);

                    botonX.Click += BotonX_click;

                    flpContent.Controls.Add(botonX);
                }
            }
        }
        private void BotonX_click(object sender, EventArgs e)
        {
            Button btnX = (Button)sender;
            if (btnX.Tag == null)
            {

                MessageBox.Show("Soy el botón " + btnX.Text);
            }
            else
            {
                MessageBox.Show("Soy el botón " + btnX.Tag);
            }
        }

        private void elegirTipo(Button boton)
        {

            switch (cbxTipo.Text)
            {
                case "Colores":
                    int colorCode = aleat.Next(0, colores.Length);
                    boton.Text = colores[colorCode].Name;
                    boton.BackColor = colores[colorCode];
                    break;
                case "Imágenes":
                    int imageCode = aleat.Next(0, 20);
                    String ruta = ".\\imagenes\\" + imageCode + ".jpg";
                    boton.AutoSize = true;
                    boton.Text = "";
                    boton.Tag = imageCode.ToString();
                    boton.Image = Image.FromFile(@ruta);
                    break;
                case "Números":
                    boton.Text = aleat.Next(1, 100).ToString();
                    boton.BackColor = Color.Aquamarine;
                    break;
                case "Jugadores":
                    int playerCode = aleat.Next(0, jugadores.Length);
                    boton.Text = jugadores[playerCode];
                    boton.BackColor = Color.Aquamarine;
                    break;
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flpContent.Enabled = true;
            button1.Enabled = false;
            timer1.Enabled = true;
            puntos = 0;
            lblPuntos.Text = "0";
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = -1;
            }
            flpContent.Controls.Clear();
            int imageCode;
            
            for (int i = 0; i < vector.Length; i++)
            {

                imageCode = aleat.Next(0, 20);
                

                vector[i] = imageCode;

            }
            int extra = aleat.Next(0, 20);
            String ruta2 = ".\\imagenes\\" + extra + ".jpg";
            btnMuestra.Tag = extra;
            btnMuestra.Image = Image.FromFile(@ruta2);
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("entro en vector imagenes");
                Button boton = new Button();
                boton.Click += Boton_Click;
                    
                String ruta = ".\\imagenes\\" + vector[i] + ".jpg";
                boton.AutoSize = true;
                boton.Text = "";
                boton.Tag = vector[i];
                boton.Image = Image.FromFile(@ruta);
                flpContent.Controls.Add(boton);
            }

        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button btnX = (Button)sender;
            btnX.Enabled = false;
            if (btnX.Tag.Equals(btnMuestra.Tag)) {
                puntos++;
              
            }
            else
            {
                puntos--;
            }
            lblPuntos.Text = "" + puntos;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            lblSegundos.Text = Convert.ToString(segundos);
            if (segundos % 5 == 0)
            {
                generarPartida();
            }
            if (segundos == 0)
            {
                timer1.Stop();
                segundos = 30;
                lblSegundos.Text = "" + segundos;
                button1.Enabled = true;
                flpContent.Enabled = false;
            }
        }

        private void generarPartida()
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = -1;
            }
            flpContent.Controls.Clear();
            int imageCode;

            for (int i = 0; i < vector.Length; i++)
            {

                imageCode = aleat.Next(0, 20);


                vector[i] = imageCode;

            }
            int extra = aleat.Next(0, 20);
            String ruta2 = ".\\imagenes\\" + extra + ".jpg";
            btnMuestra.Tag = extra;
            btnMuestra.Image = Image.FromFile(@ruta2);
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("entro en vector imagenes");
                Button boton = new Button();
                boton.Click += Boton_Click;

                String ruta = ".\\imagenes\\" + vector[i] + ".jpg";
                boton.AutoSize = true;
                boton.Text = "";
                boton.Tag = vector[i];
                boton.Image = Image.FromFile(@ruta);
                flpContent.Controls.Add(boton);
            }
        }
    }
}
