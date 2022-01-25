using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using MySql.Data.MySqlClient;

namespace Proyecto_Interfaces
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistarse_Click(object sender, EventArgs e)
        {

            MySqlConnection con = Conexion.getConexion();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into usuarios(nombre,contraseña) values ('" + txtNombre.Text + "','" + txtContraseña.Text + "')";
            cmd.ExecuteNonQuery();

            txtContraseña.Text = "";
            txtNombre.Text = "";
            

        }

        private void btnLogearse_Click(object sender, EventArgs e)
        {
          /*  NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Host = "localhost";
            builder.Username = "postgres";
            builder.Password = "alumno";
            builder.Database = "autobuses";
            builder.Port = 5433;

            NpgsqlConnection con = new NpgsqlConnection(builder.ToString());
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "from usuarios";
            con.Open();
            cmd.ExecuteNonQuery();

            txtContraseña.Text = "";
            txtNombre.Text = "";*/
        }
    }
}
