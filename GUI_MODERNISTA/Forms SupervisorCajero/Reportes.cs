using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_MODERNISTA
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            Conexion_Consulta listaCajeros = new Conexion_Consulta();
            List<Cajero> lista = listaCajeros.Get();

            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = lista;

            Conexion_Consulta listaSupervisor = new Conexion_Consulta();
            List<Supervisor> lista2 = listaSupervisor.Obtener();

            dgvSupervisor.DataSource = null;
            dgvSupervisor.DataSource = lista2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnBSupervisor_Click(object sender, EventArgs e)
        {
            Conexion_Consulta supervisor = new Conexion_Consulta();
            Supervisor supervisorMostrar = new Supervisor();
            supervisorMostrar = supervisor.supervisorReporteID(txtIDSupervisor.Text);
            txtNombreSupervisor.Text = supervisorMostrar.nombre;
            txtAPSupervisor.Text = supervisorMostrar.apPaterno;
            txtAMSupervisor.Text = supervisorMostrar.apMaterno;
        }

        private void btnBEmpleado_Click(object sender, EventArgs e)
        {
            Conexion_Consulta empleado = new Conexion_Consulta();
            Cajero empleadoMostrar = new Cajero();
            empleadoMostrar = empleado.empleadoID(txtIDEmpleado.Text);
            txtNombreEmpleado.Text = empleadoMostrar.nombre;
            txtAPEmpleado.Text = empleadoMostrar.apPaterno;
            txtAMEmpleado.Text = empleadoMostrar.apMaterno;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            TextWriter archivo;
            archivo = new StreamWriter("Reportes.txt");

            string mensaje;
            mensaje = txtComentarios.Text;
            mensaje = Console.ReadLine();
            archivo.WriteLine(mensaje);

        }
    }
}
