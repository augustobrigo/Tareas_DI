using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Conectar_BD
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader adaptador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion = new MySqlConnection();

            conexion.ConnectionString = "Server=localhost;Port=3306;DataBase=dam2023;user=root;Pwd='';old guids=true;";
            conexion.Open();
            String cadenaSql = "show tables";
            comando = new MySqlCommand(cadenaSql, conexion);
            

        }
    }
}
