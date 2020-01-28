﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
            btninicio_Click(null ,e);
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            
            if(SubmenuReportes.Visible==false) 
            {
                SubmenuReportes.Visible=true;
            }
            else
            {
                SubmenuReportes.Visible=false;
            }
               
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new Reportes());
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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



        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void btnmanejo_Click(object sender, EventArgs e)
        {
            if (SubmenuManejo.Visible == false)
            {
                SubmenuManejo.Visible = true;
            }
            else
            {
                SubmenuManejo.Visible = false;
            }
        }


        private void SubmenuManejo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncrearc_Click(object sender, EventArgs e)
        {
            SubmenuManejo.Visible = false;
            AbrirFormEnPanel(new CrearCuenta());
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            SubmenuManejo.Visible = false;
            AbrirFormEnPanel(new ModificarCuenta());
        }

        private void btnborrarc_Click(object sender, EventArgs e)
        {
            SubmenuManejo.Visible = false;

        }

        private void btncajachica_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Insercion_Peliculas());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Butacas());
        }
    }
}