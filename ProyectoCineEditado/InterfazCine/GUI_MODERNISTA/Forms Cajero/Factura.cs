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
            listaPelis = lista.Buscar_Pelicula_C(dtpCartelera.Value.ToString("yyyy-MM-dd"));

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
            listaFuncionesSala = consulta.Buscar_Funciones_Para_Una_Peli(idPeli, dtpCartelera.Value.ToString("yyyy-MM-dd"));
            bool cambioTipoFuncion = false;
            bool tipoFuncionCambiado = false;///////////////////////////
            int posicionX=213, posicionY=291,saltarFila=2;//////////////////////////////////
            Funcion_Sala funcionSala = new Funcion_Sala();
            funcionSala = (Funcion_Sala)listaFuncionesSala[0];
            string tipoFuncion = funcionSala.Tipo;
            eliminarBotonesCreados();
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
                else if(!tipoFuncionCambiado)/////////////////////
                {                                   
                    lblTipoFuncion2.Text = funcionSala.Tipo + " DOBLADA";
                    lblTipoFuncion2.Visible = true;
                    cambioTipoFuncion = true;
                    tipoFuncionCambiado = true;///////////////////////
                    posicionY += 30;
                    posicionX = 213;
                    lblTipoFuncion2.Location = new Point(posicionX,posicionY);
                    posicionY += 32;
                    posicionX = 213;
                    saltarFila = i + 3;
                }

                //agregando botones
                Crear_Boton(i, funcionSala.Fecha_Hora.ToShortTimeString(),funcionSala.Nro_Sala.ToString(),posicionX,posicionY);
                posicionX += 95;
                if (i==saltarFila)
                {
                    saltarFila += 3;
                    posicionY += 25;
                    posicionX = 213;
                }
                
                ////////////////////////////////////
                tipoFuncion = funcionSala.Tipo;//para actualizar el tipo de funcion
            }

        }
        Button[] nuevoBoton = new Button[15];////////
        int cantidadBotonesCreados=0;//////

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
        private void Crear_Boton(int numeroBoton, string horaFuncion,string numSala,
                                 int posicionX, int posicionY)///////////////////////
        {
            nuevoBoton[numeroBoton] = new Button();
            nuevoBoton[numeroBoton].Text = horaFuncion+" Sala "+numSala;
            nuevoBoton[numeroBoton].Name = numeroBoton.ToString();
            nuevoBoton[numeroBoton].Location = new Point(posicionX, posicionY);
            nuevoBoton[numeroBoton].BackColor = Color.SeaGreen;
            nuevoBoton[numeroBoton].ForeColor = Color.Black;
            nuevoBoton[numeroBoton].FlatStyle = FlatStyle.Popup;/////
            nuevoBoton[numeroBoton].Size = new Size(90, 20);//////
            nuevoBoton[numeroBoton].Click += NuevoBoton_Click;
            this.Controls.Add(nuevoBoton[numeroBoton]);
            cantidadBotonesCreados++;
        }
        public void eliminarBotonesCreados()//////////////////
        {
            if (cantidadBotonesCreados>0)
            {
                for (int i = 0; i < cantidadBotonesCreados;i++)
                {
                    nuevoBoton[i].Dispose();
                }
                cantidadBotonesCreados = 0;
            }
        }
        private void NuevoBoton_Click(object sender, EventArgs e)/////////////
        {

            Button btn = sender as Button;
            int indice=Convert.ToInt32(btn.Name);
            Funcion_Sala funcionSala = new Funcion_Sala();
            funcionSala = (Funcion_Sala)listaFuncionesSala[indice];
            int i = 1;
            i++;
            throw new NotImplementedException();
        }

        private void picCartelera_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }

        
}
