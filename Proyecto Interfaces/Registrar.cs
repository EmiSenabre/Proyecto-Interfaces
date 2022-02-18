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
    public partial class Registrar : Form
    {
        FormGeneralRegistro form;
        public Registrar(FormGeneralRegistro form)
        {
            InitializeComponent();
            this.form = form;
        }

        ///Funcion para registrar usuarios en la base de datos y comprueba que no haya otro usuario con el mismo nombre y que las contraseñas coiciden
        private void btnRegistarse_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.ConfirmarCon = txtConfimarCon.Text;

            try
            {
                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Registro registro = new Registro(form);
                    form.openForm(registro);
                }
            }catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        ///Boton que cancela la accion de registrar y abre un formulario de logueo
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(form);
            form.openForm(registro);
        }
    }
}
