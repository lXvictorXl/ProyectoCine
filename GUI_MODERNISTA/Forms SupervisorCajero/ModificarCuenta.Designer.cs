namespace GUI_MODERNISTA
{
    partial class ModificarCuenta
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
            this.components = new System.ComponentModel.Container();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineBDDataSet = new GUI_MODERNISTA.CineBDDataSet();
            this.empleadoTableAdapter = new GUI_MODERNISTA.CineBDDataSetTableAdapters.EmpleadoTableAdapter();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(295, 635);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(269, 43);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(374, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "APELLIDO P. :";
            // 
            // txtAM
            // 
            this.txtAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAM.Location = new System.Drawing.Point(488, 416);
            this.txtAM.Margin = new System.Windows.Forms.Padding(4);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(336, 28);
            this.txtAM.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(374, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "APELLIDO M. :";
            // 
            // txtAP
            // 
            this.txtAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAP.Location = new System.Drawing.Point(488, 379);
            this.txtAP.Margin = new System.Windows.Forms.Padding(4);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(336, 28);
            this.txtAP.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(374, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(488, 342);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(336, 28);
            this.txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "MODIFICAR CUENTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(374, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "CI:";
            // 
            // txtCI
            // 
            this.txtCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCI.Location = new System.Drawing.Point(488, 453);
            this.txtCI.Margin = new System.Windows.Forms.Padding(4);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(336, 28);
            this.txtCI.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(374, 499);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "CELULAR:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(488, 491);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(336, 28);
            this.txtCelular.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(374, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(488, 301);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 28);
            this.txtId.TabIndex = 27;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(657, 301);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(167, 28);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(376, 539);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "DIRECCION:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(488, 531);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(336, 28);
            this.txtDireccion.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(376, 578);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(488, 570);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(336, 28);
            this.txtPassword.TabIndex = 32;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(694, 635);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(269, 43);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "ELIMINAR CUENTA";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.cineBDDataSet;
            // 
            // cineBDDataSet
            // 
            this.cineBDDataSet.DataSetName = "CineBDDataSet";
            this.cineBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(1015, 96);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(167, 28);
            this.btnEmpleados.TabIndex = 35;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(281, 96);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(709, 183);
            this.dgvEmpleados.TabIndex = 36;
            // 
            // ModificarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1440, 753);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarCuenta";
            this.Text = "productos";
            this.Load += new System.EventHandler(this.ModificarCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEliminar;
        private CineBDDataSet cineBDDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private CineBDDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}