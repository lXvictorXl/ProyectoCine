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
    public partial class DesignarCajero : Form
    {
        public DesignarCajero()
        {
            InitializeComponent();
        }

        private void CargarDGV1()
        {
            Conexion_Consulta listaCajeros = new Conexion_Consulta();
            List<EmpleadoTurnoCaja> lista = listaCajeros.get1s();

            dataGridDesignarCaja.DataSource = null;
            dataGridDesignarCaja.DataSource = lista;
        }

        private void BtnDesignarCaja_Click(object sender, EventArgs e)
        {
            EmpleadoTurnoCaja empleadoTurnoCaja = new EmpleadoTurnoCaja();
            Conexion_Consulta insertarCajero = new Conexion_Consulta();

            empleadoTurnoCaja.Caja_Chica =Convert.ToDouble(txtCajaChica.Text);
            empleadoTurnoCaja.fkIdCaja = Convert.ToInt32(txtCaja.Text);
            empleadoTurnoCaja.fkIdEmpleado = Convert.ToInt32(txtIdD.Text);
            empleadoTurnoCaja.Fecha = dtpFecha.Value.Date;

            switch(txtTurno.Text)
            {
                case ("MAÑANA"):
                    empleadoTurnoCaja.fkTunrnoEmpleado = 1;
                    break;
                case ("TARDE"):
                    empleadoTurnoCaja.fkTunrnoEmpleado = 2;
                    break;
                case ("NOCHE"):
                    empleadoTurnoCaja.fkTunrnoEmpleado = 3;
                    break;
            }
            bool registrado = insertarCajero.InsertarTurno(empleadoTurnoCaja);
            if (registrado)
            {
                MessageBox.Show("modificacion correcta ");
            }
            else
            {
                MessageBox.Show("modificacion incorrecta ");
            }
               
            
        }

        private void DesignarCajero_Load(object sender, EventArgs e)
        {
            CargarDGV1();
        }

        private void BuscarDC_Click(object sender, EventArgs e)
        {
            Conexion_Consulta cajero = new Conexion_Consulta();
            EmpleadoTurnoCaja caje = new EmpleadoTurnoCaja();
            caje = cajero.cajet(txtIdD.Text);
            txtTurno.Text = caje.Turno;
            txtCaja.Text = Convert.ToString(caje.NroCaja);


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarDGV1();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
