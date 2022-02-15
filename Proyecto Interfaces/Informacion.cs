using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Interfaces
{
    public partial class Informacion : Form
    {
        Pelicula pelicula;
        FormGeneral general;
        public Informacion(Pelicula pelicula, FormGeneral general)
        {
            InitializeComponent();
            this.pelicula = pelicula;
            this.general = general;
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            pbImage.Image = pelicula.Image;
            lTitulo.Text = pelicula.Name + "(" + pelicula.Year + ")";
            lScore.Text = "Puntuación: " +pelicula.Score + "/100";
            lCategoria.Text = "Categoría: "+ pelicula.Category;
            lDirector.Text = "Director: "+pelicula.Director;
            lReparto.Text = "Reparto: "+pelicula.Actors;
            lDescripcion.Text = "Descripcion: " + pelicula.Description;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Quiere borrar la pelicula?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from peliculas where id=" + pelicula.Id;
                MySqlConnection con = Conexion.getConexion();
                con.Open();


                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                Inicio inicio = new Inicio(general);
                general.openForm(inicio);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar modifica = new Modificar(pelicula,general);
            general.openForm(modifica);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(general);
            general.openForm(inicio);
        }
    }
}
