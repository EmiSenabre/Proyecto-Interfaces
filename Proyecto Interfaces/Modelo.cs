using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Interfaces
{
    internal class Modelo 
    {
        ///Funcion para registrar usuarios
        public int registro(Usuario usuario)
        {
            try
            {
                MySqlConnection con = Conexion.getConexion();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into usuarios(nombre,password) values (@nombre,@contraseña)";
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);

                int resultado = cmd.ExecuteNonQuery();

                return resultado;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }

        ///Funcion para comprobar que no hay usuarios con el mismo nombre en la base de datos
        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            try
            {
                MySqlConnection con = Conexion.getConexion();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select id from usuarios where nombre like @nombre";
                cmd.Parameters.AddWithValue("@nombre", usuario);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        ///Funcion que comprueba si hay un usuario con ese nombre en la base de datos y si lo hay le pasa su informacion
        public Usuario porUsuario(string usuario)
        {
            MySqlDataReader reader;
            try
            {
                MySqlConnection con = Conexion.getConexion();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select id, nombre, password from usuarios where nombre like @nombre";
                cmd.Parameters.AddWithValue("@nombre", usuario);

                reader = cmd.ExecuteReader();

                Usuario usr = null;

                while (reader.Read())
                {
                    usr = new Usuario();
                    usr.Id = int.Parse(reader["id"].ToString());
                    usr.Nombre = reader["nombre"].ToString();
                    usr.Contraseña = reader["password"].ToString();
                }
                return usr;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
                
            }
        }

    }
}
