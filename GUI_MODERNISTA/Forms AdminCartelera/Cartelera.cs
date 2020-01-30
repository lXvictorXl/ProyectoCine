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

        }

        private void cargarDGV()
        {
            Conexion_Consulta listaPeliculas = new Conexion_Consulta();
            List<ClassCartelera> lista = listaPeliculas.GetFunciones();
            dgvPelicula.DataSource = null;
            dgvPelicula.DataSource = lista;
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
