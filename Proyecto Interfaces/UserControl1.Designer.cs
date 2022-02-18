namespace Proyecto_Interfaces
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.lTitulo = new System.Windows.Forms.Label();
            this.LScore = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbFavorito = new System.Windows.Forms.CheckBox();
            this.lPuntuación = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            resources.ApplyResources(this.lTitulo, "lTitulo");
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Click += new System.EventHandler(this.lTitulo_Click);
            this.lTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lTitulo_MouseMove);
            // 
            // LScore
            // 
            resources.ApplyResources(this.LScore, "LScore");
            this.LScore.Name = "LScore";
            // 
            // btnModificar
            // 
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbFavorito
            // 
            resources.ApplyResources(this.cbFavorito, "cbFavorito");
            this.cbFavorito.Name = "cbFavorito";
            this.cbFavorito.UseVisualStyleBackColor = true;
            this.cbFavorito.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lPuntuación
            // 
            resources.ApplyResources(this.lPuntuación, "lPuntuación");
            this.lPuntuación.Name = "lPuntuación";
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // UserControl1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lPuntuación);
            this.Controls.Add(this.cbFavorito);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.LScore);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pbImage);
            this.Name = "UserControl1";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            this.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label LScore;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox cbFavorito;
        private System.Windows.Forms.Label lPuntuación;
    }
}
