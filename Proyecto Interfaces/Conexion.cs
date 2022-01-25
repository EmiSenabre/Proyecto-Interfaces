using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using MySql.Data.MySqlClient;


namespace Proyecto_Interfaces
{
    internal class Conexion
    {
        public static MySqlConnection getConexion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "alumno";
            builder.Database = "autobuses";
            builder.Port = 3306;

            MySqlConnection con = new MySqlConnection(builder.ToString());
            
            return con;
        }
    }
}
