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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }

        private void btnAgregarPeli_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.nombre = cmbPelicula.Text;
            pelicula.genero = txtGeneroPelicula.Text;
            pelicula.estado = cmbPelicula.Text;
            pelicula.duracion =Convert.ToDateTime(txtDuracionPelicula.Text);
            pelicula.clasificacion = cmbClasificacion.Text;
            string ruta =txtRuta.Text;
            


            Conexion_Consulta insertarPelicula = new Conexion_Consulta();
            bool registrado = insertarPelicula.insertarPeliculaBD(pelicula,ruta);
            if (registrado)
            {
                
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog.FileName;
            }
            picImagePeli.Image=Image.FromFile(txtRuta.Text);
        }
    }
}
