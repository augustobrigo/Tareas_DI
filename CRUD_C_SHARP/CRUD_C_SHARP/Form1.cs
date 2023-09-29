using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD_C_SHARP
{
    public partial class FormularioCRUD : Form
    {
        Boolean cargarImagen = false;
        String nombreImagen;
        conectarBD cnx = new conectarBD();
        List<claseMedicamento> listaMedicamentos = new List<claseMedicamento>();

        public FormularioCRUD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaMedicamentos = cnx.listar();
            dtgMedicamento.DataSource = listaMedicamentos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(nombreImagen, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] bloque = br.ReadBytes((int)fs.Length);

                cnx.Insertar(txtNombre.Text, Convert.ToDouble(txtPrecio.Text), bloque, Convert.ToInt16(txtStockMinimo.Text), Convert.ToInt16(txtStockActual.Text));
            } catch
                 (Exception)
            {
                MessageBox.Show("Datos incompletos");
            }
        }

        private void pctImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Filter = "imagenes|*.jpg;*.png";
            if (op1.ShowDialog() == DialogResult.OK)
            {
                nombreImagen = op1.FileName;
                pctImagen.Image = Image.FromFile(nombreImagen);
                cargarImagen = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            try {
            claseMedicamento medicamento = new claseMedicamento();
            medicamento.Indice =Convert.ToInt16( lblIndex.Text);
            medicamento.Nombre = txtNombre.Text;
            medicamento.Precio = Convert.ToDouble(txtPrecio.Text);
                if (cargarImagen == false) { 
               claseMedicamento med = listaMedicamentos.Find(x => x.Indice== medicamento.Indice);
                medicamento.Imagen = med.Imagen;
                }else
                {
                    FileStream fs = new FileStream(nombreImagen, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    byte[] bloque = br.ReadBytes((int)fs.Length);
                    medicamento.Imagen = bloque;
                }
                medicamento.Stockactual = Convert.ToInt16(txtStockActual.Text);
            medicamento.Stockminimo = Convert.ToInt16(txtStockMinimo.Text);
            cnx.modificarMedicamento(medicamento);
            }
            catch (Exception)
            {
                MessageBox.Show("faltan datos");
            }
        }

        private void dtgMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgMedicamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            lblIndex.Text = Convert.ToString(listaMedicamentos[fila].Indice);
            txtNombre.Text = listaMedicamentos[fila].Nombre;
            txtPrecio.Text = Convert.ToString(listaMedicamentos[fila].Precio);
            txtStockActual.Text = Convert.ToString(listaMedicamentos[fila].Stockactual);
            txtStockMinimo.Text = Convert.ToString(listaMedicamentos[fila].Stockminimo);
            MemoryStream ms = new MemoryStream(listaMedicamentos[fila].Imagen);
            pctImagen.BackgroundImageLayout = ImageLayout.Stretch;
            pctImagen.Image=Image.FromStream (ms);
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listaMedicamentos.Clear();
            dtgMedicamento.DataSource = null;
            listaMedicamentos = cnx.listar();
            dtgMedicamento.DataSource = listaMedicamentos;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtNombre.Text!="")
            {
                listaMedicamentos.Clear();
                listaMedicamentos = cnx.buscarMedicamento(txtNombre.Text);
                dtgMedicamento.DataSource = null;
                dtgMedicamento.DataSource = listaMedicamentos;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar " + txtNombre.Text + " ?", "Farmacia", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cnx.eliminar(txtNombre.Text);
                listaMedicamentos.Clear();
                listaMedicamentos = cnx.listar();
                dtgMedicamento.DataSource = null;
                
                dtgMedicamento.DataSource = listaMedicamentos;
                foreach(Control ctrl in grpbFormulario.Controls)
                {
                    ctrl.Text = "";
                    pctImagen.Image = null;
                }
            }
     

        }
    }
}

