namespace GUI_MODERNISTA
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(551, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 65);
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
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button74);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1288, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 1063);
            this.panel1.TabIndex = 98;
            // 
            // dgvInfoVenta
            // 
            this.dgvInfoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvInfoVenta.Location = new System.Drawing.Point(-27, 508);
            this.dgvInfoVenta.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dgvInfoVenta.Name = "dgvInfoVenta";
            this.dgvInfoVenta.RowHeadersWidth = 102;
            this.dgvInfoVenta.Size = new System.Drawing.Size(992, 329);
            this.dgvInfoVenta.TabIndex = 137;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CANT";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DESCRIPCION";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "UNID";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TOTAL";
            this.Column4.MinimumWidth = 12;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(622, 322);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(199, 48);
            this.btnAñadir.TabIndex = 136;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(558, 429);
            this.rbTarjeta.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(141, 36);
            this.rbTarjeta.TabIndex = 135;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(370, 429);
            this.rbEfectivo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(154, 36);
            this.rbEfectivo.TabIndex = 134;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(293, 322);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(260, 38);
            this.txtCelular.TabIndex = 133;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(293, 260);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(260, 38);
            this.txtApellido.TabIndex = 132;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(293, 198);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 38);
            this.txtNombre.TabIndex = 131;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(293, 138);
            this.txtCi.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(260, 38);
            this.txtCi.TabIndex = 130;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(622, 138);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(199, 48);
            this.btnBuscar.TabIndex = 129;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(452, 1279);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 32);
            this.label16.TabIndex = 109;
            this.label16.Text = "label16";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConsultarTarjeta);
            this.panel2.Controls.Add(this.txtNumeroTarjeta);
            this.panel2.Controls.Add(this.cmbTarjeta);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(48, 885);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 350);
            this.panel2.TabIndex = 108;
            this.panel2.Visible = false;
            // 
            // btnConsultarTarjeta
            // 
            this.btnConsultarTarjeta.Location = new System.Drawing.Point(626, 26);
            this.btnConsultarTarjeta.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnConsultarTarjeta.Name = "btnConsultarTarjeta";
            this.btnConsultarTarjeta.Size = new System.Drawing.Size(199, 54);
            this.btnConsultarTarjeta.TabIndex = 112;
            this.btnConsultarTarjeta.Text = "Consultar";
            this.btnConsultarTarjeta.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(240, 150);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(260, 38);
            this.txtNumeroTarjeta.TabIndex = 111;
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(217, 34);
            this.cmbTarjeta.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(317, 39);
            this.cmbTarjeta.TabIndex = 110;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(75, 146);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "numero";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tarjeta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(107, 425);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 32);
            this.label9.TabIndex = 105;
            this.label9.Text = "Tipo de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 65);
            this.label2.TabIndex = 100;
            this.label2.Text = "FACTURA";
            // 
            // button74
            // 
            this.button74.Location = new System.Drawing.Point(740, 1266);
            this.button74.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button74.Name = "button74";
            this.button74.Size = new System.Drawing.Size(199, 54);
            this.button74.TabIndex = 8;
            this.button74.Text = "Imprimir";
            this.button74.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(107, 270);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 32);
            this.label13.TabIndex = 7;
            this.label13.Text = "Apellido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(107, 208);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 32);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(107, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "C.I.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(107, 332);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Celular:";
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.DisplayMember = "Nombre";
            this.cmbPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelicula.Font = new System.Drawing.Font("Berlin Sans FB", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(100, 305);
            this.cmbPelicula.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(555, 45);
            this.cmbPelicula.TabIndex = 140;
            // 
            // dtpCartelera
            // 
            this.dtpCartelera.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCartelera.Location = new System.Drawing.Point(700, 315);
            this.dtpCartelera.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dtpCartelera.Name = "dtpCartelera";
            this.dtpCartelera.Size = new System.Drawing.Size(584, 38);
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
            this.btnBuscarPeli.Location = new System.Drawing.Point(100, 380);
            this.btnBuscarPeli.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnBuscarPeli.Name = "btnBuscarPeli";
            this.btnBuscarPeli.Size = new System.Drawing.Size(1188, 67);
            this.btnBuscarPeli.TabIndex = 138;
            this.btnBuscarPeli.Text = "BUSCAR";
            this.btnBuscarPeli.UseVisualStyleBackColor = true;
            this.btnBuscarPeli.Click += new System.EventHandler(this.btnBuscarPeli_Click);
            // 
            // lblTipoFuncion
            // 
            this.lblTipoFuncion.AutoSize = true;
            this.lblTipoFuncion.BackColor = System.Drawing.Color.Red;
            this.lblTipoFuncion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFuncion.Location = new System.Drawing.Point(587, 617);
            this.lblTipoFuncion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTipoFuncion.Name = "lblTipoFuncion";
            this.lblTipoFuncion.Size = new System.Drawing.Size(314, 63);
            this.lblTipoFuncion.TabIndex = 141;
            this.lblTipoFuncion.Text = "2D Doblada";
            this.lblTipoFuncion.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 501);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 38);
            this.label7.TabIndex = 142;
            this.label7.Text = "GENERO:";
            // 
            // lblTipoFuncion2
            // 
            this.lblTipoFuncion2.AutoSize = true;
            this.lblTipoFuncion2.BackColor = System.Drawing.Color.Red;
            this.lblTipoFuncion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoFuncion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFuncion2.Location = new System.Drawing.Point(580, 922);
            this.lblTipoFuncion2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTipoFuncion2.Name = "lblTipoFuncion2";
            this.lblTipoFuncion2.Size = new System.Drawing.Size(314, 63);
            this.lblTipoFuncion2.TabIndex = 152;
            this.lblTipoFuncion2.Text = "3D Doblada";
            this.lblTipoFuncion2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 553);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 38);
            this.label3.TabIndex = 143;
            this.label3.Text = "CLASIFICACION:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(788, 504);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(0, 32);
            this.lblGenero.TabIndex = 144;
            // 
            // lblClasifi
            // 
            this.lblClasifi.AutoSize = true;
            this.lblClasifi.Location = new System.Drawing.Point(923, 553);
            this.lblClasifi.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblClasifi.Name = "lblClasifi";
            this.lblClasifi.Size = new System.Drawing.Size(0, 32);
            this.lblClasifi.TabIndex = 145;
            // 
            // picCartelera
            // 
            this.picCartelera.Location = new System.Drawing.Point(100, 504);
            this.picCartelera.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.picCartelera.Name = "picCartelera";
            this.picCartelera.Size = new System.Drawing.Size(430, 572);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.picCartelera);
            this.Controls.Add(this.lblTipoFuncion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTipoFuncion2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblClasifi);
            this.Controls.Add(this.cmbPelicula);
            this.Controls.Add(this.dtpCartelera);
            this.Controls.Add(this.btnBuscarPeli);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
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
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.DataGridView dgvInfoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
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
    }
}