namespace Proyecto_Interfaces
{
    partial class Inicio
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
            this.btnAñadir = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.cbFavorito = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAñadir.Location = new System.Drawing.Point(400, 505);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(178, 39);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir Pelicula";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(89, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(854, 390);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(302, 30);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(265, 22);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Busqueda:";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(98, 25);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(86, 30);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // cbFavorito
            // 
            this.cbFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFavorito.AutoSize = true;
            this.cbFavorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFavorito.Location = new System.Drawing.Point(683, 33);
            this.cbFavorito.Name = "cbFavorito";
            this.cbFavorito.Size = new System.Drawing.Size(75, 20);
            this.cbFavorito.TabIndex = 8;
            this.cbFavorito.Text = "Favorito";
            this.cbFavorito.UseVisualStyleBackColor = true;
            this.cbFavorito.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(857, 33);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 30);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbFavorito);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAñadir);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.CheckBox cbFavorito;
        private System.Windows.Forms.Button btnSalir;
    }
}