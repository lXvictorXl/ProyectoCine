﻿namespace GUI_MODERNISTA
{
    partial class Factura
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInfoVenta = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConsultarTarjeta = new System.Windows.Forms.Button();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button74 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.dtpCartelera = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarPeli = new System.Windows.Forms.Button();
            this.lblTipoFuncion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipoFuncion2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblClasifi = new System.Windows.Forms.Label();
            this.picCartelera = new System.Windows.Forms.PictureBox();
            this.peliculaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoVenta)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CARTELERA";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvInfoVenta);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.rbTarjeta);
            this.panel1.Controls.Add(this.rbEfectivo);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtCi);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblPrecioTotal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button74);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(530, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 585);
            this.panel1.TabIndex = 98;
            // 
            // dgvInfoVenta
            // 
            this.dgvInfoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoVenta.Location = new System.Drawing.Point(3, 203);
            this.dgvInfoVenta.Name = "dgvInfoVenta";
            this.dgvInfoVenta.RowHeadersWidth = 102;
            this.dgvInfoVenta.Size = new System.Drawing.Size(479, 150);
            this.dgvInfoVenta.TabIndex = 137;
            this.dgvInfoVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(315, 134);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 20);
            this.btnAñadir.TabIndex = 136;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(291, 179);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbTarjeta.TabIndex = 135;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Location = new System.Drawing.Point(221, 179);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbEfectivo.TabIndex = 134;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(192, 134);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 133;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(192, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 132;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(192, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 131;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(192, 57);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(100, 20);
            this.txtCi.TabIndex = 130;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(315, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 20);
            this.btnBuscar.TabIndex = 129;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(170, 536);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(0, 25);
            this.lblPrecioTotal.TabIndex = 109;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConsultarTarjeta);
            this.panel2.Controls.Add(this.txtNumeroTarjeta);
            this.panel2.Controls.Add(this.cmbTarjeta);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(63, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 147);
            this.panel2.TabIndex = 108;
            this.panel2.Visible = false;
            // 
            // btnConsultarTarjeta
            // 
            this.btnConsultarTarjeta.Location = new System.Drawing.Point(235, 11);
            this.btnConsultarTarjeta.Name = "btnConsultarTarjeta";
            this.btnConsultarTarjeta.Size = new System.Drawing.Size(137, 24);
            this.btnConsultarTarjeta.TabIndex = 112;
            this.btnConsultarTarjeta.Text = "Consultar";
            this.btnConsultarTarjeta.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(81, 57);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroTarjeta.TabIndex = 111;
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(81, 14);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(100, 21);
            this.cmbTarjeta.TabIndex = 110;
            this.cmbTarjeta.SelectedIndexChanged += new System.EventHandler(this.cmbTarjeta_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "NUMERO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "TARJETA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(122, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 105;
            this.label9.Text = "Tipo de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 100;
            this.label2.Text = "FACTURA";
            // 
            // button74
            // 
            this.button74.Location = new System.Drawing.Point(278, 531);
            this.button74.Name = "button74";
            this.button74.Size = new System.Drawing.Size(75, 23);
            this.button74.TabIndex = 8;
            this.button74.Text = "Imprimir";
            this.button74.UseVisualStyleBackColor = true;
            this.button74.Click += new System.EventHandler(this.button74_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(122, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Apellido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(122, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(122, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "C.I.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(122, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Celular:";
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.BackColor = System.Drawing.Color.White;
            this.cmbPelicula.DisplayMember = "Nombre";
            this.cmbPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelicula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPelicula.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(38, 148);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(209, 25);
            this.cmbPelicula.TabIndex = 140;
            this.cmbPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbPelicula_SelectedIndexChanged);
            // 
            // dtpCartelera
            // 
            this.dtpCartelera.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCartelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCartelera.Location = new System.Drawing.Point(262, 148);
            this.dtpCartelera.Name = "dtpCartelera";
            this.dtpCartelera.Size = new System.Drawing.Size(222, 26);
            this.dtpCartelera.TabIndex = 139;
            this.dtpCartelera.ValueChanged += new System.EventHandler(this.dtpCartelera_ValueChanged);
            // 
            // btnBuscarPeli
            // 
            this.btnBuscarPeli.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscarPeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPeli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarPeli.FlatAppearance.BorderSize = 0;
            this.btnBuscarPeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPeli.Location = new System.Drawing.Point(38, 159);
            this.btnBuscarPeli.Name = "btnBuscarPeli";
            this.btnBuscarPeli.Size = new System.Drawing.Size(446, 28);
            this.btnBuscarPeli.TabIndex = 138;
            this.btnBuscarPeli.Text = "BUSCAR";
            this.btnBuscarPeli.UseVisualStyleBackColor = true;
            this.btnBuscarPeli.Visible = false;
            this.btnBuscarPeli.Click += new System.EventHandler(this.btnBuscarPeli_Click);
            // 
            // lblTipoFuncion
            // 
            this.lblTipoFuncion.AutoSize = true;
            this.lblTipoFuncion.BackColor = System.Drawing.Color.Red;
            this.lblTipoFuncion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFuncion.Location = new System.Drawing.Point(216, 258);
            this.lblTipoFuncion.Name = "lblTipoFuncion";
            this.lblTipoFuncion.Size = new System.Drawing.Size(137, 27);
            this.lblTipoFuncion.TabIndex = 141;
            this.lblTipoFuncion.Text = "2D Doblada";
            this.lblTipoFuncion.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 142;
            this.label7.Text = "GENERO:";
            this.label7.Visible = false;
            // 
            // lblTipoFuncion2
            // 
            this.lblTipoFuncion2.AutoSize = true;
            this.lblTipoFuncion2.BackColor = System.Drawing.Color.Red;
            this.lblTipoFuncion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoFuncion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFuncion2.Location = new System.Drawing.Point(218, 387);
            this.lblTipoFuncion2.Name = "lblTipoFuncion2";
            this.lblTipoFuncion2.Size = new System.Drawing.Size(137, 27);
            this.lblTipoFuncion2.TabIndex = 152;
            this.lblTipoFuncion2.Text = "3D Doblada";
            this.lblTipoFuncion2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 143;
            this.label3.Text = "CLASIFICACION:";
            this.label3.Visible = false;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(292, 211);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(0, 13);
            this.lblGenero.TabIndex = 144;
            // 
            // lblClasifi
            // 
            this.lblClasifi.AutoSize = true;
            this.lblClasifi.Location = new System.Drawing.Point(342, 232);
            this.lblClasifi.Name = "lblClasifi";
            this.lblClasifi.Size = new System.Drawing.Size(0, 13);
            this.lblClasifi.TabIndex = 145;
            // 
            // picCartelera
            // 
            this.picCartelera.Location = new System.Drawing.Point(38, 211);
            this.picCartelera.Name = "picCartelera";
            this.picCartelera.Size = new System.Drawing.Size(161, 240);
            this.picCartelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCartelera.TabIndex = 156;
            this.picCartelera.TabStop = false;
            this.picCartelera.Click += new System.EventHandler(this.picCartelera_Click);
            // 
            // peliculaBindingSource2
            // 
            this.peliculaBindingSource2.DataMember = "Pelicula";
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataMember = "Pelicula";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1025, 585);
            this.Controls.Add(this.picCartelera);
            this.Controls.Add(this.lblTipoFuncion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTipoFuncion2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblClasifi);
            this.Controls.Add(this.cmbPelicula);
            this.Controls.Add(this.dtpCartelera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarPeli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoVenta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button74;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource funcionBindingSource;
  
        private System.Windows.Forms.BindingSource peliculaBindingSource1;
      
       
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        
        private System.Windows.Forms.BindingSource peliculaBindingSource2;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.DateTimePicker dtpCartelera;
        private System.Windows.Forms.Button btnBuscarPeli;
        private System.Windows.Forms.Label lblTipoFuncion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTipoFuncion2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblClasifi;
        private System.Windows.Forms.PictureBox picCartelera;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConsultarTarjeta;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvInfoVenta;
    }
}