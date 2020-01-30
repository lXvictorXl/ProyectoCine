namespace GUI_MODERNISTA
{
    partial class Insercion_Peliculas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtGeneroPelicula = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.picImagePeli = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.cmbEstadoPelicula = new System.Windows.Forms.ComboBox();
            this.txtFechaEstreno = new System.Windows.Forms.TextBox();
            this.txtDuracionPelicula = new System.Windows.Forms.TextBox();
            this.btnAgregarPeli = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagePeli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1099, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR PELICULAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "TITULO DE LA PELICULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(688, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "GENERO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(685, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "ESTADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(600, 601);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "CLASIFICACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(571, 544);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "FECHA ESTRENO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(661, 472);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "DURACION";
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(872, 241);
            this.cmbPelicula.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(316, 50);
            this.cmbPelicula.TabIndex = 39;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(2411, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(333, 100);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtGeneroPelicula
            // 
            this.txtGeneroPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneroPelicula.Location = new System.Drawing.Point(872, 310);
            this.txtGeneroPelicula.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtGeneroPelicula.Name = "txtGeneroPelicula";
            this.txtGeneroPelicula.Size = new System.Drawing.Size(316, 49);
            this.txtGeneroPelicula.TabIndex = 37;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(2037, 41);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(311, 49);
            this.txtBuscar.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1856, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 32);
            this.label8.TabIndex = 35;
            this.label8.Text = "BUSCAR";
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddPic.FlatAppearance.BorderSize = 0;
            this.btnAddPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.ForeColor = System.Drawing.Color.White;
            this.btnAddPic.Location = new System.Drawing.Point(1744, 725);
            this.btnAddPic.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(464, 100);
            this.btnAddPic.TabIndex = 34;
            this.btnAddPic.Text = "AGREGAR IMAGEN";
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // picImagePeli
            // 
            this.picImagePeli.Location = new System.Drawing.Point(1744, 207);
            this.picImagePeli.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picImagePeli.Name = "picImagePeli";
            this.picImagePeli.Size = new System.Drawing.Size(464, 427);
            this.picImagePeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagePeli.TabIndex = 33;
            this.picImagePeli.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(888, 725);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(333, 100);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1264, 725);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(333, 100);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Items.AddRange(new object[] {
            "A",
            "A+13",
            "A+16",
            "A+18"});
            this.cmbClasificacion.Location = new System.Drawing.Point(872, 601);
            this.cmbClasificacion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(345, 39);
            this.cmbClasificacion.TabIndex = 30;
            // 
            // cmbEstadoPelicula
            // 
            this.cmbEstadoPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbEstadoPelicula.FormattingEnabled = true;
            this.cmbEstadoPelicula.Location = new System.Drawing.Point(872, 384);
            this.cmbEstadoPelicula.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbEstadoPelicula.Name = "cmbEstadoPelicula";
            this.cmbEstadoPelicula.Size = new System.Drawing.Size(316, 50);
            this.cmbEstadoPelicula.TabIndex = 29;
            // 
            // txtFechaEstreno
            // 
            this.txtFechaEstreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEstreno.Location = new System.Drawing.Point(872, 532);
            this.txtFechaEstreno.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFechaEstreno.Name = "txtFechaEstreno";
            this.txtFechaEstreno.Size = new System.Drawing.Size(316, 49);
            this.txtFechaEstreno.TabIndex = 28;
            // 
            // txtDuracionPelicula
            // 
            this.txtDuracionPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracionPelicula.Location = new System.Drawing.Point(872, 458);
            this.txtDuracionPelicula.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDuracionPelicula.Name = "txtDuracionPelicula";
            this.txtDuracionPelicula.Size = new System.Drawing.Size(316, 49);
            this.txtDuracionPelicula.TabIndex = 27;
            // 
            // btnAgregarPeli
            // 
            this.btnAgregarPeli.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarPeli.FlatAppearance.BorderSize = 0;
            this.btnAgregarPeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPeli.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPeli.Location = new System.Drawing.Point(512, 725);
            this.btnAgregarPeli.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAgregarPeli.Name = "btnAgregarPeli";
            this.btnAgregarPeli.Size = new System.Drawing.Size(333, 100);
            this.btnAgregarPeli.TabIndex = 26;
            this.btnAgregarPeli.Text = "AGREGAR";
            this.btnAgregarPeli.UseVisualStyleBackColor = false;
            this.btnAgregarPeli.Click += new System.EventHandler(this.btnAgregarPeli_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(1744, 662);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(464, 49);
            this.txtRuta.TabIndex = 40;
            // 
            // Insercion_Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(2771, 1192);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.cmbPelicula);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtGeneroPelicula);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.picImagePeli);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbClasificacion);
            this.Controls.Add(this.cmbEstadoPelicula);
            this.Controls.Add(this.txtFechaEstreno);
            this.Controls.Add(this.txtDuracionPelicula);
            this.Controls.Add(this.btnAgregarPeli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Insercion_Peliculas";
            this.Text = "productos";
            ((System.ComponentModel.ISupportInitialize)(this.picImagePeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtGeneroPelicula;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.PictureBox picImagePeli;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.ComboBox cmbEstadoPelicula;
        private System.Windows.Forms.TextBox txtFechaEstreno;
        private System.Windows.Forms.TextBox txtDuracionPelicula;
        private System.Windows.Forms.Button btnAgregarPeli;
        private System.Windows.Forms.TextBox txtRuta;
    }
}