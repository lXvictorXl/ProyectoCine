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

namespace GUI_MODERNISTA
{
    public partial class Butacas : Form
    {
        public delegate void pasar(ArrayList lista);
        public event pasar pasado;

        ArrayList listaTickets;
        int idFuncionSala;
        string tipoFuncion = "";

        public Butacas()
        {
            InitializeComponent();
        }
        public Butacas(int idFS,int nroS,ArrayList listaTick,string tipo)
        {
            listaTickets = new ArrayList();
            InitializeComponent();
            idFuncionSala = idFS;
            lblSala.Text = nroS.ToString();
            listaTickets = listaTick;
            tipoFuncion = tipo;
            Crear_Boton();
            lblTickets.Text = cantidadBotonesSeleccionados.ToString();
        }
        public void colorButacasSeleccionadas()
        {
            foreach (Ticket ticket in listaTickets)
            {
                if (ticket.fkFuncionSala==idFuncionSala)
                {
                    nuevoBoton[ticket.NroButaca].BackColor = Color.LightBlue;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarButacas_Click(object sender, EventArgs e)
        {
            listaTickets.Sort(new CompararIdFuncionSala());
            pasado(listaTickets);

            eliminarBotonesCreados();
            Close();
        }
        public class CompararIdFuncionSala:IComparer
        {
            public int Compare(object x, object y)
            {
                return ((Ticket)y).fkFuncionSala + ((Ticket)x).fkFuncionSala;
            }
        }

        Button[] nuevoBoton = new Button[62];
        int cantidadBotonesCreados = 0,cantidadBotonesSeleccionados=0;

        /// fUNCION PARA CREAR BOTONES
        private void Crear_Boton()
        {
            int posicionX= 22,posicionY = 228;
            int totalAsientosLibres = 0, tamColumna = 5;
            Conexion_Consulta butacasOcupadas = new Conexion_Consulta();
            ArrayList listaButacasOcupadas = butacasOcupadas.Butacas_Vendidas(idFuncionSala);

            for (int i = 1; i < nuevoBoton.Length; i++)
            {
                cantidadBotonesCreados++;
                nuevoBoton[i] = new Button();
                nuevoBoton[i].Text = i.ToString();
                nuevoBoton[i].Name = i.ToString();
                nuevoBoton[i].Location = new Point(posicionX, posicionY);

                if (listaButacasOcupadas.Contains(i))
                {
                    nuevoBoton[i].BackColor = Color.Red;
                    nuevoBoton[i].Enabled = false;
                   
                }
                else
                {
                    nuevoBoton[i].BackColor = Color.SeaGreen;
                    foreach (Ticket ticket in listaTickets)
                    {
                        if (ticket.NroButaca == i && ticket.fkFuncionSala == idFuncionSala)
                        {
                            nuevoBoton[i].BackColor = Color.LightBlue;
                            cantidadBotonesSeleccionados++;
                            break;
                        }
                    }
                    totalAsientosLibres++;
                }
                
                nuevoBoton[i].ForeColor = Color.Black;
                nuevoBoton[i].FlatStyle = FlatStyle.Popup;/////
                nuevoBoton[i].Size = new Size(34, 34);//////
                nuevoBoton[i].Click += Butacas_Click;
                this.Controls.Add(nuevoBoton[i]);
                posicionX += 40;
                if (i>4 && i%tamColumna==0 && i<50)
                {
                    posicionX+=40;
                }
                if (i > 9 && i % (tamColumna*2) == 0 && i<60)
                {
                    posicionX = 21;
                    posicionY += 38;
                }
            }
            
        }

        //Elimina con un destructor los botones creados dinamicamente
        public void eliminarBotonesCreados()//////////////////
        {
            if (cantidadBotonesCreados > 0)
            {
                for (int i = 1; i < cantidadBotonesCreados+1; i++)
                {
                    nuevoBoton[i].Dispose();
                }
                cantidadBotonesCreados = 0;
            }
        }
        private void Butacas_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Ticket ticket1 = new Ticket();
            int indice = Convert.ToInt32(btn.Name);
            if (nuevoBoton[indice].BackColor == Color.SeaGreen)
            {
                nuevoBoton[indice].BackColor = Color.LightBlue;
                cantidadBotonesSeleccionados++;
                ticket1.NroButaca = indice;
                //ti
                ticket1.fkFuncionSala = idFuncionSala;
                if (tipoFuncion.Contains("2"))
                {
                    ticket1.fkIdCosto = 1;
                }
                else if(tipoFuncion.Contains("3"))
                {
                    ticket1.fkIdCosto = 2;
                }
                Conexion_Consulta costo = new Conexion_Consulta();
                ticket1.PrecioFinal = costo.costoTicket(ticket1.fkIdCosto);

                listaTickets.Add(ticket1);
            }
            else if (nuevoBoton[indice].BackColor == Color.LightBlue)
            {
                nuevoBoton[indice].BackColor = Color.SeaGreen;
                cantidadBotonesSeleccionados--;
                ArrayList listaTicketsActualizada = listaTickets;
                foreach (Ticket ticket in listaTicketsActualizada)
                {
                    if (ticket.fkFuncionSala==idFuncionSala&&ticket.NroButaca==indice)
                    {
                        listaTickets.Remove(ticket);
                        break;
                    }
                }
            }
            lblTickets.Text = cantidadBotonesSeleccionados.ToString();
        }
       
        private void button22_Click(object sender, EventArgs e)
        {
            eliminarBotonesCreados();
            Close();
        }

    }
}
