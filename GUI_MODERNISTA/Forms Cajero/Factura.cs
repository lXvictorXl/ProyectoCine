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
<<<<<<< HEAD
        Empleado empleado = new Empleado();
=======
       
>>>>>>> parent of 2994725... Backup Resubido
        public Factura()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        public Factura(Empleado em)
        {
            InitializeComponent();
            empleado = em;
        }

=======
       
>>>>>>> parent of 2994725... Backup Resubido
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
            int posicionX = 213, posicionY = 291, saltarFila = 2;//////////////////////////////////
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
                else if (!tipoFuncionCambiado)/////////////////////
                {
                    lblTipoFuncion2.Text = funcionSala.Tipo + " DOBLADA";
                    lblTipoFuncion2.Visible = true;
                    cambioTipoFuncion = true;
                    tipoFuncionCambiado = true;///////////////////////
                    posicionY += 30;
                    posicionX = 213;
                    lblTipoFuncion2.Location = new Point(posicionX, posicionY);
                    posicionY += 32;
                    posicionX = 213;
                    saltarFila = i + 3;
                }

                //agregando botones
                Crear_Boton(i, funcionSala.Fecha_Hora.ToShortTimeString(), funcionSala.Nro_Sala.ToString(), posicionX, posicionY);
                posicionX += 95;
                if (i == saltarFila)
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
        int cantidadBotonesCreados = 0;//////
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
        private void Crear_Boton(int numeroBoton, string horaFuncion, string numSala,
                                 int posicionX, int posicionY)
        {
            nuevoBoton[numeroBoton] = new Button();
            nuevoBoton[numeroBoton].Text = horaFuncion + " Sala " + numSala;
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
            if (cantidadBotonesCreados > 0)
            {
                for (int i = 0; i < cantidadBotonesCreados; i++)
                {
                    nuevoBoton[i].Dispose();
                }
                cantidadBotonesCreados = 0;
            }
        }
        private void NuevoBoton_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            int indice = Convert.ToInt32(btn.Name);
            Funcion_Sala funcionSala = new Funcion_Sala();
            funcionSala = (Funcion_Sala)listaFuncionesSala[indice];
<<<<<<< HEAD
            int i = funcionSala.Id_FuncionSala;
            Butacas butaca = new Butacas(i,funcionSala.Nro_Sala,listaButacasSeleccionadas,funcionSala.Tipo,empleado,funcionSala.Fecha_Hora,funcionSala.NombrePelicula);
            
            butaca.pasado += new Butacas.pasar(Butaca_pasado);
            butaca.ShowDialog();
            crearListaDetalles();
          
        }
        //Proceso que crea Dettalles de la Factura
        private void crearListaDetalles()
        {
            ArrayList listaDeatalles = new ArrayList();
            DetalleFactura detalle=new DetalleFactura();
            Ticket ticket = new Ticket();
            Ticket ticketSiguiente = new Ticket();
            detalle.SubTotal = 0;
            detalle.CantidadTickets = 0;            
  
            for (int i = 0; i < listaButacasSeleccionadas.Count; i++)
            {
                ticket = new Ticket();
                ticket = (Ticket)listaButacasSeleccionadas[i];
                ticketSiguiente = new Ticket();
                if (i == listaButacasSeleccionadas.Count - 1)
                    ticketSiguiente = ticket;
                else
                    ticketSiguiente = (Ticket)listaButacasSeleccionadas[i + 1];
                if (ticket.fkFuncionSala==ticketSiguiente.fkFuncionSala)
                {
                    detalle.SubTotal += ticket.PrecioFinal;
                    detalle.CantidadTickets++;
                    if (i == listaButacasSeleccionadas.Count - 1)
                    {
                        detalle.TituloPelicula = ticket.TituloPelicula;
                        detalle.FechaHoraFuncion = ticket.FechaHoraFuncion;
                        detalle.NroSala = ticket.NroSala;

                        listaDeatalles.Add(detalle);
                    }
                }
                else
                {
                    detalle.SubTotal += ticket.PrecioFinal;
                    detalle.CantidadTickets++;
                    detalle.TituloPelicula = ticket.TituloPelicula;
                    detalle.FechaHoraFuncion = ticket.FechaHoraFuncion;
                    detalle.NroSala = ticket.NroSala;

                    listaDeatalles.Add(detalle);

                    detalle = new DetalleFactura();
                    detalle.SubTotal = 0;
                    detalle.CantidadTickets = 0;
                }
                
            }
            dgvInfoVenta.DataSource = null;
            dgvInfoVenta.DataSource = listaDeatalles;
        }

        //Proceso del delegado
        private void Butaca_pasado(ArrayList lista)
=======
            int i = 1;
            i++;
            throw new NotImplementedException();
        }

        private void picCartelera_Click(object sender, EventArgs e)
>>>>>>> parent of 2994725... Backup Resubido
        {

        }

<<<<<<< HEAD


        //No hacen ni madres
        private void timer1_Tick(object sender, EventArgs e)
=======
        private void btnAñadir_Click(object sender, EventArgs e)
>>>>>>> parent of 2994725... Backup Resubido
        {
            Cliente cliente = new Cliente();
            Conexion_Consulta consulta = new Conexion_Consulta();
            cliente = consulta.infoCliente(txtCi.Text);
            
            if (txtCi.Text.Equals(cliente.ciNit)) 
            {
                
                cliente.nombre = txtNombre.Text;
                cliente.apellido = txtApellido.Text;
                cliente.cel = Convert.ToInt32(txtCelular.Text);
                if(consulta.modificarCliente(cliente))
               
                MessageBox.Show("MODIFICACION CORRECTA");
            }

           else
            {
                MessageBox.Show("MODIFICACION incirecta");
            }
        }

<<<<<<< HEAD
        
        private void picCartelera_Click(object sender, EventArgs e)
=======
        private void btnBuscar_Click(object sender, EventArgs e)
>>>>>>> parent of 2994725... Backup Resubido
        {
            Cliente cliente = new Cliente();
            Conexion_Consulta consulta = new Conexion_Consulta();
            cliente = consulta.infoCliente(txtCi.Text);
            txtNombre.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            txtCelular.Text = cliente.cel.ToString();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Conexion_Consulta conexion = new Conexion_Consulta();
            cliente.ciNit = txtCi.Text;
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.cel = Convert.ToInt32(txtCelular.Text);
            bool registrado = conexion.insertaCliente(cliente);
            if (registrado)
            {
                MessageBox.Show("Se añadio Correctamente");
            }
            else
            {
                MessageBox.Show("hay un error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        
}
