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
    public partial class Editar_Perfil : Form
    {
        Empleado empleado = new Empleado();
        public Editar_Perfil()
        {
            InitializeComponent();
        }
     
        public Editar_Perfil(Empleado em)
        {
            empleado = em;
            InitializeComponent();
            mostrardatos();
            
        }
        public void mostrardatos()
        {
            lblNombre.Text = empleado.nombre;
            lblci.Text = empleado.ci;
            lblNombre.Text = empleado.nombre;
            lblApPaterno.Text = empleado.apPaterno;
            lblApMaterno.Text = empleado.apMaterno;
            textDireccion.Text = empleado.direccion;
            textCelular.Text = empleado.cel.ToString();
        } 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool modificado = false;
            Conexion_Consulta modificaperfil = new Conexion_Consulta();
            if (textPassword.Text.Equals(empleado.password) && textAgregarNuevoPassword.Text.Equals(textConfirmarNuevoPassword.Text))
            {
                empleado.direccion = textDireccion.Text;
                empleado.cel = Convert.ToInt32(textCelular.Text);
                empleado.password = textAgregarNuevoPassword.Text;
                modificado = modificaperfil.modificarPerfil(empleado);
                MessageBox.Show ("MODIFICACION CORRECTA");
                mostrardatos();           
            }
            else
            {
                lblNombre.Text = "ERROR!!!";
            }
        }
    }
}
