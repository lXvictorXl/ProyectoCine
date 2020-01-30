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

        private void CargarDGV()
        {
            Conexion_Consulta listaCajeros = new Conexion_Consulta();
            List<Cajero> lista = listaCajeros.Get();

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lista;
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
            Conexion_Consulta modificarCajero = new Conexion_Consulta();
            empleado.nombre = txtNombre.Text;
            empleado.apPaterno = txtAP.Text;
            empleado.apMaterno = txtAM.Text;
            empleado.ci = txtCI.Text;
            empleado.cel = Convert.ToInt32(txtCelular.Text);
            empleado.direccion = txtDireccion.Text;
            empleado.password = txtPassword.Text;
            
            
            Conexion_Consulta cambiarCajero = new Conexion_Consulta();
            bool modificado = cambiarCajero.modificarCajero(empleado, Convert.ToInt32(txtId.Text));
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
            CargarDGV();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.nombre = txtNombre.Text;
            empleado.apPaterno = txtAP.Text;
            empleado.apMaterno = txtAM.Text;
            empleado.ci = txtCI.Text;
            empleado.cel = Convert.ToInt32(txtCelular.Text);
            empleado.direccion = txtDireccion.Text;
            empleado.password = txtPassword.Text;

            Conexion_Consulta eliminarCuenta = new Conexion_Consulta();
            bool modificado = eliminarCuenta.modificarCajero(empleado, Convert.ToInt32(txtId.Text));
            if (modificado)
            {
                empleado.estado = Convert.ToBoolean(0);
                MessageBox.Show("Se elimino la cuenta correctamente");
                Limpiar limpiar = new Limpiar();
                limpiar.BorrarCampos(this);
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
            CargarDGV();
        }
    }
}
