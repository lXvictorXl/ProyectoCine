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
    public partial class ModificarCuenta : Form
    {
       
        public ModificarCuenta(int? Id=null)
        {
            InitializeComponent();


        }

        private void ModificarCuenta_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void CargarDatos()
        {

        }

        private void CargarDGV()
        {
            Conexion_Consulta listaCajeros = new Conexion_Consulta();
            dgvEmpleados.DataSource = listaCajeros.Get();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion_Consulta cajero = new Conexion_Consulta();
            Empleado cajeroMod = new Empleado();
            cajeroMod = cajero.cajeroID(txtId.Text);
            txtNombre.Text = cajeroMod.nombre;
            txtAP.Text = cajeroMod.apPaterno;
            txtAM.Text = cajeroMod.apMaterno;
            txtCI.Text = cajeroMod.ci;
            txtCelular.Text = cajeroMod.cel.ToString();
            txtDireccion.Text = cajeroMod.direccion;
            txtPassword.Text = cajeroMod.password;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Empleado empleado = new Empleado();
            empleado.nombre = txtNombre.Text;
            empleado.apPaterno = txtAP.Text;
            empleado.apPaterno = txtAM.Text;
            empleado.ci = txtCI.Text;
            empleado.cel = Convert.ToInt32(txtCelular.Text);
            empleado.direccion = txtDireccion.Text;
            empleado.password = txtPassword.Text;
            
            
            /*Conexion_Consulta insertarCajero = new Conexion_Consulta();
            bool modificado = insertarCajero.modificarCajero(empleado);
            if (modificado)
            {
                MessageBox.Show("Se modifico correctamente");
                Limpiar limpiar = new Limpiar();
                limpiar.BorrarCampos(this);
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
            CargarDGV();*/

        }
    }
}
