using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_MODERNISTA
{
    public partial class Menu_Administrador_Cartelera : Form
    {
        Empleado empleado = new Empleado();
        public Menu_Administrador_Cartelera()
        {
            InitializeComponent();
        }
        public Menu_Administrador_Cartelera(Empleado em)
        {
            InitializeComponent();
            empleado = em;
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            lblUsuario.Text = empleado.nombre;
        }
      
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null, e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }



       

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio_Administracion_Cartelera());
        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnInsercionPeliculas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Insercion_Peliculas());
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Funciones());
        }

        private void btnEditarPerfil_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Editar_Perfil(empleado));
        }

        private void bntCartelera_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cartelera());
        }

        private void btnInic_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio_Administracion_Cartelera());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
