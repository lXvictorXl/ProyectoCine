using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.ci = txtCi.Text;
            empleado.nombre = txtNombre.Text;
            empleado.apPaterno = txtAP.Text;
            empleado.apMaterno = txtAM.Text;
            empleado.fechaNac = Convert.ToDateTime(txtFecha);
            empleado.cel = Convert.ToInt32(txtCelular.Text);
            empleado.direccion = txtDireccion.Text;
            empleado.password = txtPassword.Text;

            Conexion_Consulta nuevoCajero = new Conexion_Consulta();
            bool registrado = nuevoCajero.insertarCajero(empleado);
            if (registrado)
            {
                MessageBox.Show("El Empleado se Registro Correctamente");
                Limpiar limpiar = new Limpiar();
                limpiar.BorrarCampos(this);
            }
            else
            {
                MessageBox.Show("Ocurrio un error con el Registro");
            }
        }
    }
}
