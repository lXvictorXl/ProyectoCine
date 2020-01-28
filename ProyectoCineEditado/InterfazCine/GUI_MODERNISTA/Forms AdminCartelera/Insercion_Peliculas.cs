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
    public partial class Insercion_Peliculas : Form
    {
        public Insercion_Peliculas()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Conexion_Consulta modPeli = new Conexion_Consulta();
            Pelicula peli = new Pelicula();
            peli = modPeli.InfoPelicula(txtBuscar.Text);
            cmbPelicula.Text = peli.nombre;
            cmbEstadoPelicula.Text = peli.estado;
            cmbClasificacion.Text = peli.clasificacion;
            txtDuracionPelicula.Text = peli.duracion.TimeOfDay.ToString();
            txtFechaEstreno.Text = peli.fechaEstreno.ToShortDateString().ToString();
            txtGeneroPelicula.Text = peli.genero;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }
    }
}
