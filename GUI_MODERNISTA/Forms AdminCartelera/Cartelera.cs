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
        public Cartelera()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion_Consulta conexion_Consulta = new Conexion_Consulta();
            ClassFuncion funcion = new ClassFuncion();
            funcion.pelicula = Convert.ToInt32(cmbIdPelicula.Text);
            funcion.tipo = cmbTipo.Text;
            funcion.hora_fecha = Convert.ToDateTime(txtHorario.Text);
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
            bool insertado = conexion_Consulta.insertarFuncionBD(funcion);
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
            dgvCartelera.DataSource = null;
            dgvCartelera.DataSource = lista;
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }
    }
}
