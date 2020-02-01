namespace GUI_MODERNISTA
{
    partial class Cartelera
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnCrearFuncion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dgvPelicula = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.cmbNroSala = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIdPelicula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1213, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARTELERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 577);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID PELICULA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 770);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "HORARIOS:";
            // 
            // txtHorario
            // 
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(320, 754);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(639, 49);
            this.txtHorario.TabIndex = 5;
            // 
            // btnCrearFuncion
            // 
            this.btnCrearFuncion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCrearFuncion.FlatAppearance.BorderSize = 0;
            this.btnCrearFuncion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrearFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFuncion.ForeColor = System.Drawing.Color.White;
            this.btnCrearFuncion.Location = new System.Drawing.Point(320, 875);
            this.btnCrearFuncion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCrearFuncion.Name = "btnCrearFuncion";
            this.btnCrearFuncion.Size = new System.Drawing.Size(539, 83);
            this.btnCrearFuncion.TabIndex = 7;
            this.btnCrearFuncion.Text = "CREAR";
            this.btnCrearFuncion.UseVisualStyleBackColor = false;
            this.btnCrearFuncion.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(99, 684);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "TIPO:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.cmbTipo.Location = new System.Drawing.Point(320, 665);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(175, 39);
            this.cmbTipo.TabIndex = 11;
            // 
            // dgvPelicula
            // 
            this.dgvPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelicula.Location = new System.Drawing.Point(107, 160);
            this.dgvPelicula.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPelicula.Name = "dgvPelicula";
            this.dgvPelicula.Size = new System.Drawing.Size(1269, 339);
            this.dgvPelicula.TabIndex = 12;
            this.dgvPelicula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPelicula_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1579, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1117, 339);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnFuncion
            // 
            this.btnFuncion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFuncion.FlatAppearance.BorderSize = 0;
            this.btnFuncion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncion.ForeColor = System.Drawing.Color.White;
            this.btnFuncion.Location = new System.Drawing.Point(1579, 875);
            this.btnFuncion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(539, 83);
            this.btnFuncion.TabIndex = 14;
            this.btnFuncion.Text = "INSERTAR";
            this.btnFuncion.UseVisualStyleBackColor = false;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1571, 594);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID FUNCION:";
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Location = new System.Drawing.Point(2208, 594);
            this.cmbFuncion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(175, 39);
            this.cmbFuncion.TabIndex = 17;
            // 
            // cmbNroSala
            // 
            this.cmbNroSala.FormattingEnabled = true;
            this.cmbNroSala.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbNroSala.Location = new System.Drawing.Point(2208, 718);
            this.cmbNroSala.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbNroSala.Name = "cmbNroSala";
            this.cmbNroSala.Size = new System.Drawing.Size(175, 39);
            this.cmbNroSala.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1571, 737);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID SALA:";
            // 
            // cmbIdPelicula
            // 
            this.cmbIdPelicula.FormattingEnabled = true;
            this.cmbIdPelicula.Location = new System.Drawing.Point(320, 577);
            this.cmbIdPelicula.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbIdPelicula.Name = "cmbIdPelicula";
            this.cmbIdPelicula.Size = new System.Drawing.Size(175, 39);
            this.cmbIdPelicula.TabIndex = 20;
            this.cmbIdPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbIdPelicula_SelectedIndexChanged);
            // 
            // Cartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(2880, 1459);
            this.Controls.Add(this.cmbIdPelicula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNroSala);
            this.Controls.Add(this.cmbFuncion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFuncion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvPelicula);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCrearFuncion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Cartelera";
            this.Text = "productos";
            this.Load += new System.EventHandler(this.Cartelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnCrearFuncion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DataGridView dgvPelicula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.ComboBox cmbNroSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIdPelicula;
    }
}