namespace Proyecto_Interfaces
{
    partial class Informacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitulo = new System.Windows.Forms.Label();
            this.lDirector = new System.Windows.Forms.Label();
            this.lReparto = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lScore = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(87, 104);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(52, 18);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "label1";
            // 
            // lDirector
            // 
            this.lDirector.AutoSize = true;
            this.lDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDirector.Location = new System.Drawing.Point(87, 298);
            this.lDirector.Name = "lDirector";
            this.lDirector.Size = new System.Drawing.Size(44, 16);
            this.lDirector.TabIndex = 2;
            this.lDirector.Text = "label2";
            // 
            // lReparto
            // 
            this.lReparto.AutoSize = true;
            this.lReparto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReparto.Location = new System.Drawing.Point(87, 340);
            this.lReparto.Name = "lReparto";
            this.lReparto.Size = new System.Drawing.Size(44, 16);
            this.lReparto.TabIndex = 3;
            this.lReparto.Text = "label3";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategoria.Location = new System.Drawing.Point(87, 387);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(44, 16);
            this.lCategoria.TabIndex = 4;
            this.lCategoria.Text = "label4";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(780, 165);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 44);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Película";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(780, 225);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 46);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Película";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(780, 125);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(44, 16);
            this.lScore.TabIndex = 7;
            this.lScore.Text = "label5";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(90, 27);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(81, 145);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(123, 116);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(90, 423);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(44, 16);
            this.lDescripcion.TabIndex = 9;
            this.lDescripcion.Text = "label1";
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lCategoria);
            this.Controls.Add(this.lReparto);
            this.Controls.Add(this.lDirector);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informacion";
            this.Text = "Informacion";
            this.Load += new System.EventHandler(this.Informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lDirector;
        private System.Windows.Forms.Label lReparto;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lDescripcion;
    }
}