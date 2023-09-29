using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CRUD_C_SHARP
{
    class conectarBD
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;
        List<claseMedicamento> listaMedicamento = new List<claseMedicamento>();
       
        public conectarBD()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;Database=dam2020;Uid=root;pwd='';old guids=true";

        }
        public List<claseMedicamento> listar()
        {
            conexion.Open();
            String cadenaSql = "select * from medicamento where activo=1";
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                claseMedicamento cm = new claseMedicamento();
                cm.Indice = Convert.ToInt16(datos["indice"]);
                cm.Nombre = Convert.ToString(datos["nombre"]);
                cm.Precio = Convert.ToDouble(String.Format("{0:0.00}", datos["precio"]));
                cm.Imagen = (byte[])datos["imagen"];
                cm.Stockactual = Convert.ToInt16(datos["stockactual"]);
                cm.Stockminimo = Convert.ToInt16(datos["stockminimo"]);
                listaMedicamento.Add(cm);
            }
            conexion.Close();
            return listaMedicamento;
        }

        internal void Insertar(String nombreM, Double precio, byte[] imagen, int stockMin, int stockActual)
        {
            conexion.Open();
            String cadenaSql = "insert into medicamento values(null,?nom,?precio,?imagen,?stockmin,?stockactual)";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.Add("?nom", MySqlDbType.VarChar).Value = nombreM;
            comando.Parameters.Add("?precio", MySqlDbType.Double).Value = precio;
            comando.Parameters.Add("?imagen", MySqlDbType.Blob).Value = imagen;
            comando.Parameters.Add("?stockmin", MySqlDbType.Int16).Value = stockMin;
            comando.Parameters.Add("?stockActual", MySqlDbType.Int16).Value = stockActual;


           
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public int buscarUsuario(String dni,String pwd)
        {
          
                String sql = "select nivel from usuario where dni=?dni and clave=?pwd ";
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("?dni", MySqlDbType.String).Value = dni;
                comando.Parameters.Add("?pwd", MySqlDbType.String).Value = pwd;
                MySqlDataReader datos = comando.ExecuteReader();
                int nivel = 0;
                if (datos.Read())
                {
                    nivel = Convert.ToInt16(datos["nivel"]);
                }
               
            

            conexion.Close();

            return nivel;
        }

        public void insertarFacturas(List<claseMedicamento> listaCesta, string dniVendedor, double total)
        {
            string cadenaProductos = "";
            for (int i = 0; i < listaCesta.Count; i++)
            {
                cadenaProductos += listaCesta[i].Nombre + ",";
            }
                conexion.Open();
                String cadenaSql="insert into facturacion values(null,?dni,?cadenaProd,?fecha,?total)";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.Add("?dni", MySqlDbType.VarChar).Value = dniVendedor;
            comando.Parameters.Add("?cadenaProd", MySqlDbType.VarChar).Value = cadenaProductos;
            comando.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = DateTime.Now;
            comando.Parameters.Add("?total", MySqlDbType.Double).Value = total;
            comando.ExecuteNonQuery();
            conexion.Close();
            
        }

        internal void modificarMedicamento(claseMedicamento med)
        {
            conexion.Open();
            String cadenaSql = "update  medicamento set nombre=?nom,precio=?pr,stockminimo=?sm,stockactual=?sa,imagen=?im where indice=?id";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.Add("?id", MySqlDbType.Int16).Value = med.Indice;
            comando.Parameters.Add("?nom", MySqlDbType.VarChar).Value = med.Nombre;
            comando.Parameters.Add("?pr", MySqlDbType.Double).Value = med.Precio;

            comando.Parameters.Add("?sa", MySqlDbType.Int16).Value = med.Stockactual;
            comando.Parameters.Add("?sm", MySqlDbType.Int16).Value = med.Stockminimo;
            comando.Parameters.Add("?im", MySqlDbType.Blob).Value = (byte[])med.Imagen;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        internal List<claseMedicamento> buscarMedicamento(string nombre)
        {
            conexion.Open();
            String cadenaSql = "select * from medicamento where activo=1 and nombre=?nom";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.Add("?nom", MySqlDbType.VarChar).Value = nombre;
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                claseMedicamento cm = new claseMedicamento();
                cm.Indice = Convert.ToInt16(datos["indice"]);
                cm.Nombre = Convert.ToString(datos["nombre"]);
                cm.Precio = Convert.ToDouble(String.Format("{0:0.00}", datos["precio"]));
                cm.Imagen = (byte[])datos["imagen"];
                cm.Stockactual = Convert.ToInt16(datos["stockactual"]);
                cm.Stockminimo = Convert.ToInt16(datos["stockminimo"]);
                listaMedicamento.Add(cm);
            }
            conexion.Close();
            return listaMedicamento;
        }

        internal void eliminar(string nombre)
        {
            conexion.Open();
            String cadenaSql = "update medicamento set activo=0 where nombre=?nom";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.Add("?nom", MySqlDbType.VarChar).Value = nombre;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Lanzar_actualizacion(List<claseMedicamento> listaCesta)
        {
            conexion.Open();
            for (int i = 0; i < listaCesta.Count; i++)
            {
                string NombreMed = listaCesta[i].Nombre;
                String cadenaSql = "update medicamento set stockactual=stockactual-1 where nombre= '" + NombreMed+"'";
                comando = new MySqlCommand(cadenaSql, conexion);
                comando.ExecuteNonQuery();
            }
            //  String cadenaSql = ""
            conexion.Close();
        }

       

        public void actualizarTratamiento(List<claseMedicamento> listaCesta, string dni,int mes)
        {
            conexion.Open();
          for (int i = 0; i < listaCesta.Count; i++)
            {
                String cadenaSql = "update tratamientos set recogido=1 where dni=?d and medicamento=?m and mes=?mes";
                comando = new MySqlCommand(cadenaSql, conexion);
                comando.Parameters.Add("?d", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("?m", MySqlDbType.VarChar).Value = listaCesta[i].Nombre;
                comando.Parameters.Add("?mes", MySqlDbType.Int16).Value = mes;
                comando.ExecuteNonQuery();
            }
            conexion.Close();
        }

        
    }
}
