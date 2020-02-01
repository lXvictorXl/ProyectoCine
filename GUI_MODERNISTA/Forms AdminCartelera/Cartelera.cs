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
    public partial class Cartelera : Form
    {
        Empleado empleado;
        public Cartelera()
        {
            InitializeComponent();
        }
        public Cartelera(Empleado em)
        {
            InitializeComponent();
            empleado = em;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion_Consulta conexion_Consulta = new Conexion_Consulta();
            ClassFuncion funcion = new ClassFuncion();
            funcion.pelicula = Convert.ToInt32(cmbIdPelicula.Text);
            funcion.tipo = cmbTipo.Text;
            funcion.hora_fecha = Convert.ToDateTime(txtHorario.Text);
            funcion.id_empleado = Convert.ToInt32(empleado.id);
            Limpiar limpiar = new Limpiar();

            bool insertado = conexion_Consulta.insertarFuncionBD(funcion);
            limpiar.BorrarCampos(this);
            if (insertado)
            {
                MessageBox.Show("Se añadio Correctamente");
            }
            else
            {
                MessageBox.Show("Se han presentado fallos");
            }
        }

        private void cargarDGV()
        {
            Conexion_Consulta listaPeliculas = new Conexion_Consulta();
            List<ClassCartelera> lista = listaPeliculas.GetFunciones();
            dgvPelicula.DataSource = null;
            dgvPelicula.DataSource = lista;
            foreach (ClassCartelera cartelera in lista)
                {
                cmbIdPelicula.Items.Add(cartelera.id);
                }
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            cargarDGV();
            cargarDGV2();
        }

     
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbIdPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {

        }
        private void cargarDGV2()
        {
            Conexion_Consulta listaFunciones = new Conexion_Consulta();
            List<ClassFuncion> lista = listaFunciones.GetHorarios();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }
    }
}
