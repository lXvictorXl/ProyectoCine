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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int apram, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Empleado empleado;
        private void button1_Click(object sender, EventArgs e)
        {
            empleado = new Empleado();
            Conexion_Consulta datosEmpleado = new Conexion_Consulta();

            empleado = datosEmpleado.devolverEmpleado(txtuser.Text, txtpass.Text, cbMenus.Text);
            if (empleado.nombre!=null)
            {
               switch(empleado.idCargo)
                {
                    case 1:
                        Menu_Administrador_Cartelera menuAdminCartelera = new Menu_Administrador_Cartelera(empleado);
                        menuAdminCartelera.Show();
                        
                        break;
                    case 2:
                        Menu menuSupervisor = new Menu(empleado);
                        menuSupervisor.Show();
                        break;
                    case 3:
                        Menu_Cajero menuCajero = new Menu_Cajero(empleado);
                        menuCajero.Show();
                        break;
                  
                }
            }
            else
            {
                linkpass.Text="El CI o el Password es Incorrecto!!!";
            }
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "CI")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.DimGray;

            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "CI";
                txtuser.ForeColor = Color.DimGray;

            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {

            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMessage(this.Handle, 0x112, 0xf112, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMessage(this.Handle, 0x112, 0xf112, 0);
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

