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

        private void btnRegistarse_Click(object sender, EventArgs e)
        {
            
            Registrar registra = new Registrar(form);
            form.openForm(registra);

        }

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
                    FormGeneral general = new FormGeneral();
                    general.Visible = true;
                    form.Visible = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
