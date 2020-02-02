namespace GUI_MODERNISTA
{
    partial class DesignarCajero
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
            this.txtIdD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDesignarCaja = new System.Windows.Forms.Button();
            this.dataGridDesignarCaja = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarDC = new System.Windows.Forms.Button();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCajaChica = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDesignarCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(449, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TURNOS";
            // 
            // txtIdD
            // 
            this.txtIdD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdD.Location = new System.Drawing.Point(290, 343);
            this.txtIdD.Name = "txtIdD";
            this.txtIdD.Size = new System.Drawing.Size(253, 24);
            this.txtIdD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TURNO:";
            // 
            // BtnDesignarCaja
            // 
            this.BtnDesignarCaja.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnDesignarCaja.FlatAppearance.BorderSize = 0;
            this.BtnDesignarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDesignarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesignarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesignarCaja.ForeColor = System.Drawing.Color.White;
            this.BtnDesignarCaja.Location = new System.Drawing.Point(317, 509);
            this.BtnDesignarCaja.Name = "BtnDesignarCaja";
            this.BtnDesignarCaja.Size = new System.Drawing.Size(202, 35);
            this.BtnDesignarCaja.TabIndex = 7;
            this.BtnDesignarCaja.Text = "DESIGNAR";
            this.BtnDesignarCaja.UseVisualStyleBackColor = false;
            this.BtnDesignarCaja.Click += new System.EventHandler(this.BtnDesignarCaja_Click);
            // 
            // dataGridDesignarCaja
            // 
            this.dataGridDesignarCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDesignarCaja.Location = new System.Drawing.Point(184, 92);
            this.dataGridDesignarCaja.Name = "dataGridDesignarCaja";
            this.dataGridDesignarCaja.Size = new System.Drawing.Size(737, 201);
            this.dataGridDesignarCaja.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "NRO CAJA:";
            // 
            // BuscarDC
            // 
            this.BuscarDC.BackColor = System.Drawing.Color.SeaGreen;
            this.BuscarDC.FlatAppearance.BorderSize = 0;
            this.BuscarDC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BuscarDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarDC.ForeColor = System.Drawing.Color.White;
            this.BuscarDC.Location = new System.Drawing.Point(549, 343);
            this.BuscarDC.Name = "BuscarDC";
            this.BuscarDC.Size = new System.Drawing.Size(112, 24);
            this.BuscarDC.TabIndex = 13;
            this.BuscarDC.Text = "Buscar";
            this.BuscarDC.UseVisualStyleBackColor = false;
            this.BuscarDC.Click += new System.EventHandler(this.BuscarDC_Click);
            // 
            // txtCaja
            // 
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(290, 403);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(253, 24);
            this.txtCaja.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(927, 92);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 24);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(290, 433);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(209, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "FECHA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(209, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "CAJA CHICA:";
            // 
            // txtCajaChica
            // 
            this.txtCajaChica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaChica.Location = new System.Drawing.Point(290, 466);
            this.txtCajaChica.Name = "txtCajaChica";
            this.txtCajaChica.Size = new System.Drawing.Size(92, 24);
            this.txtCajaChica.TabIndex = 20;
            // 
            // txtTurno
            // 
            this.txtTurno.FormattingEnabled = true;
            this.txtTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE",
            "NOCHE"});
            this.txtTurno.Location = new System.Drawing.Point(290, 374);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(253, 21);
            this.txtTurno.TabIndex = 21;
            this.txtTurno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DesignarCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.txtCajaChica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.BuscarDC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridDesignarCaja);
            this.Controls.Add(this.BtnDesignarCaja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DesignarCajero";
            this.Text = "productos";
            this.Load += new System.EventHandler(this.DesignarCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDesignarCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDesignarCaja;
        private System.Windows.Forms.DataGridView dataGridDesignarCaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BuscarDC;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCajaChica;
        private System.Windows.Forms.ComboBox txtTurno;
    }
}