﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Interfaces
{
    public partial class UserControl1 : UserControl
    {
        Pelicula pelicula;
        FormGeneral general;
        public UserControl1(Pelicula pelicula, FormGeneral general)
        {
            InitializeComponent();
            this.pelicula = pelicula;
            this.general = general;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            pbImage.Image = pelicula.Image;
            lTitulo.Text = pelicula.Name + "(" + pelicula.Year + ")";
            LScore.Text = pelicula.Score + "/100";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar modifica = new Modificar(pelicula,general);
            general.openForm(modifica);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere borrar la pelicula?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from peliculas where id=" + pelicula.Id;
                MySqlConnection con = Conexion.getConexion();
                con.Open();


                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                Inicio inicio = new Inicio(general);
                general.openForm(inicio);
            }
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void lTitulo_Click(object sender, EventArgs e)
        {
            Informacion informacion = new Informacion(pelicula, general);
            general.openForm(informacion);
        }
    }
}
