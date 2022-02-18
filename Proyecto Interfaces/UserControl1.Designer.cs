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
            this.lTitulo = new System.Windows.Forms.Label();
            this.LScore = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cbFavorito = new System.Windows.Forms.CheckBox();
            this.lPuntuación = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(141, 54);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(57, 20);
            this.lTitulo.TabIndex = 1;
            this.lTitulo.Text = "label1";
            this.lTitulo.Click += new System.EventHandler(this.lTitulo_Click);
            this.lTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lTitulo_MouseMove);
            // 
            // LScore
            // 
            this.LScore.AutoSize = true;
            this.LScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LScore.Location = new System.Drawing.Point(629, 54);
            this.LScore.Name = "LScore";
            this.LScore.Size = new System.Drawing.Size(44, 16);
            this.LScore.TabIndex = 2;
            this.LScore.Text = "label2";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(730, 26);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(730, 71);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 22);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(106, 104);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // cbFavorito
            // 
            this.cbFavorito.AutoSize = true;
            this.cbFavorito.Location = new System.Drawing.Point(530, 53);
            this.cbFavorito.Name = "cbFavorito";
            this.cbFavorito.Size = new System.Drawing.Size(64, 17);
            this.cbFavorito.TabIndex = 7;
            this.cbFavorito.Text = "Favorito";
            this.cbFavorito.UseVisualStyleBackColor = true;
            this.cbFavorito.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lPuntuación
            // 
            this.lPuntuación.AutoSize = true;
            this.lPuntuación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPuntuación.Location = new System.Drawing.Point(612, 26);
            this.lPuntuación.Name = "lPuntuación";
            this.lPuntuación.Size = new System.Drawing.Size(87, 16);
            this.lPuntuación.TabIndex = 8;
            this.lPuntuación.Text = "Puntuación:";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(830, 125);
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
