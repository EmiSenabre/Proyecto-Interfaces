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
    public partial class UserControl1 : UserControl
    {
        Pelicula pelicula;
        FormGeneral general;
        int id;
        public UserControl1(Pelicula pelicula, FormGeneral general, int id)
        {
            InitializeComponent();
            this.pelicula = pelicula;
            this.general = general;
            this.id = id;
        }

        //Funcion que carga los datos de la pelicula
        private void UserControl1_Load(object sender, EventArgs e)
        {
            pbImage.Image = pelicula.Image;
            lTitulo.Text = pelicula.Name + "(" + pelicula.Year + ")";
            LScore.Text = pelicula.Score + "/100";
            try
            {
                MySqlConnection con = Conexion.getConexion();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * from user_movie where iduser like @user && idmovie like @movie";
                cmd.Parameters.AddWithValue("@user", id);
                cmd.Parameters.AddWithValue("@movie", pelicula.Id);
                if (cmd.ExecuteReader().Read())
                {
                    cbFavorito.Checked = true;
                }
                else
                {
                    cbFavorito.Checked = false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        //Boton para abrir formulario modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar modifica = new Modificar(pelicula,general,id);
            general.openForm(modifica);
        }

        //Boton para eliminar pelicula de la base de datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere borrar la pelicula?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from peliculas where id=" + pelicula.Id;
                try
                {
                    MySqlConnection con = Conexion.getConexion();
                    con.Open();


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteReader();
                    Inicio inicio = new Inicio(general, id);
                    general.openForm(inicio);
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Funcion para abrir formulario informacion
        private void UserControl1_Click(object sender, EventArgs e)
        {
            Informacion informacion = new Informacion(pelicula, general, id);
            general.openForm(informacion);
        }

        //Funcion para abrir formulario informacion
        private void lTitulo_Click(object sender, EventArgs e)
        {
            Informacion informacion = new Informacion(pelicula, general,id);
            general.openForm(informacion);
        }

        //Funcion para cambiar el color del usercontrol cuando esta el raton encima
        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightGray;
        }

        //Funcion para cambiar el color del usercontrol cuando esta el raton sale de este
        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            BackColor= Color.White;
        }

        //Funcion para guardar en el usuario una pelicula en favorito o eliminarla de favorito
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFavorito.Checked)
            {
                try
                {
                    MySqlConnection con = Conexion.getConexion();
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * from user_movie where iduser like @user && idmovie like @movie";
                    cmd.Parameters.AddWithValue("@user", id);
                    cmd.Parameters.AddWithValue("@movie", pelicula.Id);
                    if (cmd.ExecuteReader().Read())
                    {
                        cbFavorito.Checked = true;
                    }
                    else
                    {
                        MySqlConnection con2 = Conexion.getConexion();
                        con2.Open();
                        MySqlCommand cmd2 = con2.CreateCommand();
                        cmd2.CommandText = "INSERT INTO user_movie (iduser,idmovie) VALUES ('" + id + "','" + pelicula.Id + "')";
                        cmd2.ExecuteNonQuery();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                string sql = "delete from user_movie where iduser=" + id + "&& idmovie=" + pelicula.Id;
                try
                {
                    MySqlConnection con = Conexion.getConexion();
                    con.Open();


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteReader();
                    Inicio inicio = new Inicio(general, id);
                    general.openForm(inicio);
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        //Funcion para cambiar el color del usercontrol cuando esta el raton encima
        private void lTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightGray;
        }
    }
}
