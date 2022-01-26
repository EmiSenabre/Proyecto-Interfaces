using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Interfaces
{
    internal class Usuario
    {
        string nombre, contraseña, confirmarCon;
        int id;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string ConfirmarCon { get => confirmarCon; set => confirmarCon = value; }
        public int Id { get => id; set => id = value; }
    }
}
