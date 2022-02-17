using MySql.Data.MySqlClient;
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

namespace Proyecto_Interfaces
{
    public partial class Inicio : Form
    {
        FormGeneral general;
        int id;
        public Inicio(FormGeneral general, int id)
        {
            InitializeComponent();
            this.general = general;
            this.id = id;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar(general,id);
            general.openForm(agregar);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetData()
        {
            string sql = "SELECT * from peliculas";
            MySqlConnection con = Conexion.getConexion();
            con.Open();


            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            /*reader.Read();
            MemoryStream memoryStream = new MemoryStream((byte[])reader["image"]);
            Bitmap bmp = new Bitmap(memoryStream);
            pictureBox1.Image = bmp;*/

            while (reader.Read())
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Actors = (string)reader["actors"];
                pelicula.Name = (string)reader["name"];
                pelicula.Description = (string)reader["description"];
                pelicula.Director = (string)reader["director"];
                pelicula.Year = (int)reader["year"];
                pelicula.Score = (int)reader["score"];
                pelicula.Id = (int)reader["id"];
                MemoryStream memoryStream = new MemoryStream((byte[])reader["image"]);
                Bitmap bmp = new Bitmap(memoryStream);
                pelicula.Image = bmp;
                pelicula.Category = (string)reader["category"];

                UserControl1 userControl = new UserControl1(pelicula,general,id);
                flowLayoutPanel1.Controls.Add(userControl);


            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlDataReader reader;
            string sql;

            sql = "SELECT * FROM peliculas WHERE name LIKE '%" + txtBusqueda.Text + "%' ORDER BY name ASC";

            MySqlConnection conexionBD = Conexion.getConexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Actors = (string)reader["actors"];
                pelicula.Name = (string)reader["name"];
                pelicula.Description = (string)reader["description"];
                pelicula.Director = (string)reader["director"];
                pelicula.Year = (int)reader["year"];
                pelicula.Score = (int)reader["score"];
                pelicula.Id = (int)reader["id"];
                MemoryStream memoryStream = new MemoryStream((byte[])reader["image"]);
                Bitmap bmp = new Bitmap(memoryStream);
                pelicula.Image = bmp;
                pelicula.Category = (string)reader["category"];

                UserControl1 userControl = new UserControl1(pelicula, general,id);
                flowLayoutPanel1.Controls.Add(userControl);


            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(general,id);
            general.openForm(inicio);
        }
        //"SELECT * from peliculas where id=(select idmovie from user_movie where id="+id+")"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFavorito.Checked)
            {
                flowLayoutPanel1.Controls.Clear();
                MySqlDataReader reader;
                string sql;

                sql = "SELECT * from peliculas where id=(select idmovie from user_movie where id=" + id + ")";

                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Pelicula pelicula = new Pelicula();
                    pelicula.Actors = (string)reader["actors"];
                    pelicula.Name = (string)reader["name"];
                    pelicula.Description = (string)reader["description"];
                    pelicula.Director = (string)reader["director"];
                    pelicula.Year = (int)reader["year"];
                    pelicula.Score = (int)reader["score"];
                    pelicula.Id = (int)reader["id"];
                    MemoryStream memoryStream = new MemoryStream((byte[])reader["image"]);
                    Bitmap bmp = new Bitmap(memoryStream);
                    pelicula.Image = bmp;
                    pelicula.Category = (string)reader["category"];

                    UserControl1 userControl = new UserControl1(pelicula, general, id);
                    flowLayoutPanel1.Controls.Add(userControl);


                }
            }
            else
            {
                string sql = "SELECT * from peliculas";
                MySqlConnection con = Conexion.getConexion();
                con.Open();


                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                /*reader.Read();
                MemoryStream memoryStream = new MemoryStream((byte[])reader["image"]);
                Bitmap bmp = new Bitmap(memoryStream);
                pictureBox1.Image = bmp;*/

                while (reader.Read())
                {
                    Pelicula pelicula = new Pelicula();
                    pelicula.Actors = (string)reader["actors"];
                    pelicula.Name = (string)reader["name"];
                    pelicula.Description = (string)reader["description"];
                    pelicula.Director = (string)reader["director"];
                    pelicula.Year = (int)reader["year"];
                    pelicula.Score = (int)reader["score"];
                    pelicula.Id = (int)reader["id"];
                    MemoryStream memoryStream = new MemoryStream((byte[])reader["image"]);
                    Bitmap bmp = new Bitmap(memoryStream);
                    pelicula.Image = bmp;
                    pelicula.Category = (string)reader["category"];

                    UserControl1 userControl = new UserControl1(pelicula, general, id);
                    flowLayoutPanel1.Controls.Add(userControl);


                }
            }
        }
    }
}
