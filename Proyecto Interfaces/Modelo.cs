﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using MySql.Data.MySqlClient;


namespace Proyecto_Interfaces
{
    internal class Modelo 
    {
        public int registro(Usuario usuario)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into usuarios(nombre,password) values (@nombre,@contraseña)";
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@contraseña",usuario.Contraseña);
            
            int resultado = cmd.ExecuteNonQuery();

            return resultado;
        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
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
        }

        public Usuario porUsuario(string usuario)
        {
            MySqlDataReader reader;
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
        }

    }
}
