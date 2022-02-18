using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Interfaces
{
    public partial class Agregar : Form
    {
        FormGeneral general;
        int id;
        public Agregar(FormGeneral general, int id)
        {
            InitializeComponent();
            this.general = general;
            this.id = id;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagener|*.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar imagen";

            if(ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos() == true)
            {
                MemoryStream ms = new MemoryStream();
                pbImage.Image.Save(ms, ImageFormat.Png);
                byte[] bytes = ms.ToArray();

                MySqlConnection con = Conexion.getConexion();
                con.Open();
                //try
                //{
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO peliculas (name,director,category,actors,year,score,image,description) VALUES ('" + txtTitulo.Text + "','" + txtDirector.Text + "','" + cbCategoria.Text + "','" + txtReparto.Text + "','" + nAño.Value + "','" + nPuntuacion.Value + "',@image,'" + txtDescripcion.Text + "')";
                cmd.Parameters.AddWithValue("image", bytes);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pelicula guardada");
                //}catch (MySqlException ex)
                //{
                //MessageBox.Show("Error al guardar la imagen" + ex.Message);
                //}
                Inicio inicio = new Inicio(general,id);
                general.openForm(inicio);

            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if(txtDescripcion.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(txtDescripcion, "Ingresa una descripcion");
            }
            if (txtDirector.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(txtDirector, "Ingresa un director");
            }
            if (txtReparto.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(txtReparto, "Ingresa el reparto");
            }
            if (txtTitulo.Text.Equals(""))
            {
                ok=false;
                errorProvider1.SetError(txtTitulo, "Ingresa un Titulo");
            }
            if (cbCategoria.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(cbCategoria, "Ingresa una Categoria");
            }
            if(pbImage.Image == null)
            {
                ok = false;
                errorProvider1.SetError(pbImage, "Inserte una Imagen");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtDescripcion, "");
            errorProvider1.SetError(txtDirector, "");
            errorProvider1.SetError(txtReparto, "");
            errorProvider1.SetError(txtTitulo, "");
            errorProvider1.SetError(cbCategoria, "");
            errorProvider1.SetError(pbImage, "");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(general,id);
            general.openForm(inicio);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
