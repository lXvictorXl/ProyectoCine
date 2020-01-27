using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        ArrayList listaPelis = new ArrayList();
        ArrayList listaFuncionesSala = new ArrayList();
        private void dtpCartelera_ValueChanged(object sender, EventArgs e)
        {
            Conexion_Consulta lista = new Conexion_Consulta();
            listaPelis.Clear();
            listaPelis = lista.Buscar_Pelicula_C(dtpCartelera.Value.Date.ToShortDateString());

            cmbPelicula.Items.Clear();
            foreach (Pelicula peli in listaPelis)
            {
                cmbPelicula.Items.Add(peli.nombre);
            }
        }
        private void btnBuscarPeli_Click(object sender, EventArgs e)
        {
            int idPeli = obtener_IdPeli(cmbPelicula.Text);

            //inserta imagen en el pictureBox desde la BD
            Conexion_Consulta consulta = new Conexion_Consulta();
            byte[] datosImagen = consulta.Obtener_Imagen_C(idPeli);
            MemoryStream ms = new MemoryStream(datosImagen);
            picCartelera.Image = Image.FromStream(ms);

            //inserta los datos de genero y clasificacion en los respectivos labels
            foreach (Pelicula peli in listaPelis)
            {
                if (idPeli == peli.id)
                {
                    lblGenero.Text = peli.genero;
                    lblClasifi.Text = peli.clasificacion;
                    break;
                }
            }

            //crea botones en el form según la cantidad de horarios y del tipo(2D o 3D) de la 
            //pelicula elejida
            listaFuncionesSala = consulta.Buscar_Funciones_Para_Una_Peli(idPeli, dtpCartelera.Value);
            bool cambioTipoFuncion = false;
            Funcion_Sala funcionSala = new Funcion_Sala();
            funcionSala = (Funcion_Sala)listaFuncionesSala[0];
            string tipoFuncion = funcionSala.Tipo;
            for (int i = 0; i < listaFuncionesSala.Count; i++)
            {
                funcionSala = new Funcion_Sala();
                funcionSala = (Funcion_Sala)listaFuncionesSala[i];
                if (funcionSala.Tipo.Equals(tipoFuncion) && !cambioTipoFuncion)
                {
                    lblTipoFuncion.Text = funcionSala.Tipo + " DOBLADA";
                    lblTipoFuncion.Visible = true;
                    lblTipoFuncion2.Visible = false;
                }
                else
                {
                    lblTipoFuncion2.Text = funcionSala.Tipo + " DOBLADA";
                    lblTipoFuncion2.Visible = true;
                    cambioTipoFuncion = true;
                }

                tipoFuncion = funcionSala.Tipo;
            }

        }

        private int obtener_IdPeli(string nombrePeli)
        {
            int id = 0;
            foreach (Pelicula peli in listaPelis)
            {
                if (nombrePeli.Equals(peli.nombre))
                {
                    id = peli.id;
                    break;
                }
            }
            return id;
        }
        private void Crear_Boton(int numeroBoton, string horaFuncion, int posicionX, int posicionY)
        {
            Button nuevoBoton = new Button();
            nuevoBoton.Text = horaFuncion;
            nuevoBoton.Name = "btnFuncionSala" + numeroBoton.ToString();
            nuevoBoton.Location = new Point(posicionX, posicionY);
            nuevoBoton.BackColor = Color.Aqua;
            nuevoBoton.ForeColor = Color.White;
            nuevoBoton.Size = new Size(250, 55);
            nuevoBoton.Click += NuevoBoton_Click;
            this.Controls.Add(nuevoBoton);
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void picCartelera_Click(object sender, EventArgs e)
        {

        }
       
    }

        
}
