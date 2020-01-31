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
        Empleado empleado = new Empleado();

        public Factura()
        {
            InitializeComponent();
        }
        public Factura(Empleado em)
        {
            InitializeComponent();
            empleado = em;
        }

        ArrayList listaPelis = new ArrayList();
        ArrayList listaFuncionesSala = new ArrayList();
        ArrayList listaButacasSeleccionadas = new ArrayList();
        ///Cada vez que se cambia la fecha se carga al comboBox las peliculas que se exhibiran en la fecha que se cambió 
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

        //Muestra las funciones de la pelicula seleccionada en el comboBox
        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            label3.Visible = true;
            
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
                else if (!tipoFuncionCambiado)
                {
                    lblTipoFuncion2.Text = funcionSala.Tipo + " DOBLADA";
                    lblTipoFuncion2.Visible = true;
                    cambioTipoFuncion = true;
                    tipoFuncionCambiado = true;
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

                tipoFuncion = funcionSala.Tipo;//para actualizar el tipo de funcion
            }
        }
        private void btnBuscarPeli_Click(object sender, EventArgs e)
        {
           /* int idPeli = obtener_IdPeli(cmbPelicula.Text);

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
                else if (!tipoFuncionCambiado)
                {
                    lblTipoFuncion2.Text = funcionSala.Tipo + " DOBLADA";
                    lblTipoFuncion2.Visible = true;
                    cambioTipoFuncion = true;
                    tipoFuncionCambiado = true;
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

                tipoFuncion = funcionSala.Tipo;//para actualizar el tipo de funcion
            }
            */
        }


        Button[] nuevoBoton = new Button[30];////////Varible global para crear nuevo boton
        int cantidadBotonesCreados = 0;//////

        //Encuentra un id de pelicula mediante el nombre
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

        //Crea botones dinamicamente segun la cantidad de horario que se exhiba la pelicula seleccionada
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

        //Elimina con un destructor los botones creados dinamicamente
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

        //Evento click de todos los botones dinamicos creados
        private void NuevoBoton_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            int indice = Convert.ToInt32(btn.Name);
            Funcion_Sala funcionSala = new Funcion_Sala();
            funcionSala = (Funcion_Sala)listaFuncionesSala[indice];
            int i = funcionSala.Id_FuncionSala;
            Butacas butaca = new Butacas(i,funcionSala.Nro_Sala,listaButacasSeleccionadas,funcionSala.Tipo,empleado,funcionSala.Fecha_Hora,funcionSala.NombrePelicula);
            
            butaca.pasado += new Butacas.pasar(Butaca_pasado);
            butaca.ShowDialog();
            crearListaDetalles();
            lblPrecioTotal.Text = total().ToString();
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
                        detalle.Tipo = ticket.Tipo;

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
                    detalle.Tipo = ticket.Tipo;

                    listaDeatalles.Add(detalle);

                    detalle = new DetalleFactura();
                    detalle.SubTotal = 0;
                    detalle.CantidadTickets = 0;
                }
                
            }
            dgvInfoVenta.DataSource = null;
            dgvInfoVenta.DataSource = listaDeatalles;
        }

        //Proceso que crea la Factura
        private void crearFactura()
        {
            
            FacturaCliente factura = new FacturaCliente();

            
        }

        //LLenar comboBox de Tarjetas
        private ArrayList llenarComboTarjetas(ArrayList listaTarjetas)
        {
            Conexion_Consulta consultaTarjetasCliente = new Conexion_Consulta();
            listaTarjetas = new ArrayList();
            listaTarjetas = consultaTarjetasCliente.ConsultaTarjetaCliente(txtCi.Text);

           
            return listaTarjetas;
        }

        //Proceso del delegado
        private void Butaca_pasado(ArrayList lista)
        {
            listaButacasSeleccionadas = lista;
        }



        //No hacen ni madres
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        
        private void picCartelera_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                panel2.Visible = false;
            }
        }

        //Proceso para hacer el descuento en el ticket si hay promocion

        private void realizarDescuento(string dia)
        {
            PromocionTicket promocion = promocionTicket(dia);
            if (promocion.Nombre != null)
            {
                foreach (Ticket ticket in listaButacasSeleccionadas)
                {
                    ticket.fkIdPromocion = promocion.id;
                    ticket.PrecioFinal = ticket.PrecioFinal * promocion.Descuento;
                }
                crearListaDetalles();
            }
        }

        //obtener promocion
        private PromocionTicket promocionTicket(string nombreTipoPago)
        {
            ArrayList listaPromociones = new ArrayList();
            DateTime hoy = DateTime.Today;
            PromocionTicket promo = new PromocionTicket(); ;
            Conexion_Consulta conexion_Consulta = new Conexion_Consulta();
            listaPromociones = conexion_Consulta.consultaPromociones(nombreTipoPago);
            if (listaPromociones.Count != 0)
            {
                foreach (PromocionTicket promocion in listaPromociones)
                {
                    if (hoy.DayOfWeek.ToString().Contains(promocion.Dia))
                    {
                        promo = promocion;
                        break;
                    }

                }
            }
            return promo;
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked)
            {
                ArrayList lista=new ArrayList();
                lista=llenarComboTarjetas(lista);
                panel2.Visible = true;
                foreach (Tarjeta tarjeta in lista)
                {
                    cmbTarjeta.Items.Add(tarjeta.Nombre);
                }
               
            }
        }

        private void cmbTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTarjeta.Items.Count != 0)
            {
                ArrayList lista = new ArrayList();
                lista=llenarComboTarjetas(lista);
                
                Tarjeta tarjeta = new Tarjeta();

                for (int i = 0; i < lista.Count; i++)
                {
                   
                    if (i==cmbTarjeta.SelectedIndex)
                    {
                        tarjeta = (Tarjeta)lista[i];
                        break;
                    }  
                }
                txtNumeroTarjeta.Text = tarjeta.Numero;
            }
            
        }

        private void button74_Click(object sender, EventArgs e)
        {
            FacturaCliente factura = new FacturaCliente();
            if (rbEfectivo.Checked)
            {
                realizarDescuento("2x1");
                factura.fkIdTipoPago = 1;
            }
            else if (rbTarjeta.Checked)
            {
                realizarDescuento("2x1");
                realizarDescuento(cmbTarjeta.Text);
                factura.fkIdTipoPago = 2;
            }
            
            factura.FechaEmision = DateTime.Now;
            factura.ApellidoCliente = txtApellido.Text;
            factura.fkNitCiCliente = txtCi.Text;
            factura.fkIdEmpleado = empleado.id;
            factura.NombreEmpleado = empleado.nombre + " " + empleado.apPaterno;
            factura.Total = total();

            Conexion_Consulta conexion_Consulta = new Conexion_Consulta();

            int idFactura=conexion_Consulta.insertarFactura(factura);

        }

        //Calcula el total de la Factura
        public decimal total()
        {
            decimal total = 0;
            foreach (Ticket ticket in listaButacasSeleccionadas)
            {
                total += ticket.PrecioFinal;
            }
            return total;
        }
    }

        
}
