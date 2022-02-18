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
    public partial class FormGeneral : Form
    {
        int id;
        public FormGeneral(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        ///Funcion para cargar en el panel el formulario inicio
        private void FormGeneral_Load(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(this, id);
            openForm(inicio);
        }
        public Form activeForm = null;

        ///Funcion para cargar formularios en un panel
        public void openForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

    }
}
