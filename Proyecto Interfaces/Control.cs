using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Proyecto_Interfaces
{
    internal class Control
    {
        public string ctrlRegistro(Usuario usuario) {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Contraseña) || string.IsNullOrEmpty(usuario.ConfirmarCon))
            {
                respuesta = "Debe llenar todos los campos";
            }else
            {
                if(usuario.Contraseña == usuario.ConfirmarCon)
                {
                    if (modelo.existeUsuario(usuario.Nombre))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }
        public string ctrlLogin(string nombre, string contraseña)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuario datosUsuario = null;

            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(nombre);

                if(datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.Contraseña != contraseña)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                }
            }
            return respuesta;
        }
    }
}
