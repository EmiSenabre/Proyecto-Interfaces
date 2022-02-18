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
        FormGeneralRegistro form;
        public Registro(FormGeneralRegistro form)
        {
            InitializeComponent();
            this.form = form;
        }

        ///Boton que abre un formulario registrar
        private void btnRegistarse_Click(object sender, EventArgs e)
        {
            
            Registrar registra = new Registrar(form);
            form.openForm(registra);

        }

        ///Boton que sirve para loguear usuarios en la aplicacion y comprueba que los campos estan correctos
        private void btnLogearse_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;

            try
            {
                Control control = new Control();
                string respuesta = control.ctrlLogin(nombre,contraseña);
                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        MySqlConnection con = Conexion.getConexion();
                        con.Open();


                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT id from usuarios where nombre like @nombre";
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        int id = int.Parse(reader["id"].ToString());
                        FormGeneral general = new FormGeneral(id);
                        general.Visible = true;
                        form.Visible = false;
                    }catch (Exception ex)
                    { MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
