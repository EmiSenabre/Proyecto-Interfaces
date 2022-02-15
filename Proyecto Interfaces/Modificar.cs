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
    public partial class Modificar : Form
    {
        Pelicula pelicula;
        FormGeneral general;
        public Modificar(Pelicula pelicula, FormGeneral general)
        {
            InitializeComponent();
            this.pelicula = pelicula;
            this.general = general;
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = pelicula.Description;
            txtDirector.Text = pelicula.Director;
            txtReparto.Text = pelicula.Actors;
            txtTitulo.Text = pelicula.Name;
            pbImage.Image = pelicula.Image;
            nAño.Value = pelicula.Year;
            nPuntuacion.Value = (decimal)pelicula.Score;
            cbCategoria.Text = pelicula.Category;
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
                cmd.CommandText = "UPDATE peliculas SET name=@name,director=@director,category=@category,actors=@actors,year=@year,score=@score,image=@image,description=@description WHERE id=@id";
                cmd.Parameters.AddWithValue("image", bytes);
                cmd.Parameters.AddWithValue("name", txtTitulo.Text);
                cmd.Parameters.AddWithValue("director",txtDirector.Text);
                cmd.Parameters.AddWithValue("category",cbCategoria.Text);
                cmd.Parameters.AddWithValue("actors",txtReparto.Text);
                cmd.Parameters.AddWithValue("year",nAño.Value);
                cmd.Parameters.AddWithValue("score",nPuntuacion.Value);
                cmd.Parameters.AddWithValue("description", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("id",pelicula.Id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pelicula guardada");
                //}catch (MySqlException ex)
                //{
                //MessageBox.Show("Error al guardar la imagen" + ex.Message);
                //}
                Inicio inicio = new Inicio(general);
                inicio.Visible = true;
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtDescripcion.Text.Equals(""))
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
                ok = false;
                errorProvider1.SetError(txtTitulo, "Ingresa un Titulo");
            }
            if (cbCategoria.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(cbCategoria, "Ingresa una Categoria");
            }
            if (pbImage.Image == null)
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagener|*.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(general);
            general.openForm(inicio);
        }
    }
}
