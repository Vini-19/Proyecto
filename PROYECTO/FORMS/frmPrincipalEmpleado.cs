﻿using PROYECTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo
{
    public partial class frmPrincipalEmpleado : Form
    {
        public frmPrincipalEmpleado()
        {
            InitializeComponent();
        }

        private void frmPrincipalEmpleado_Load(object sender, EventArgs e)
        {

        }

        private static Form FormAct;

        bool siderbarExpand = true;
        private void submenu()
        {
            if (panelProductos.Visible == true)
            {
                panelProductos.Visible = false;
            }
            if (panelPersonas.Visible == true)
            {
                panelPersonas.Visible = false;
            }
            if (panelFacturacion.Visible == true)
            {
                panelFacturacion.Visible = false;
            }
            if (pnusuario.Visible == true)
            {
                pnusuario.Visible = false;
            }
            if (pnsubusu.Visible == true)
            {
                pnsubusu.Visible = false;
            }
        }


        private void ShowMenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                submenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void AbriForm(Form formulario)
        {
            if (FormAct != null)
            {
                FormAct.Close();
            }

            FormAct = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.LightBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }


        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void sliderTran_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                slidermenu.Width -= 10;
                if (slidermenu.Width <= 60)
                {
                    siderbarExpand = false;
                    sliderTran.Stop();
                }
            }
            else
            {
                slidermenu.Width += 10;
                if (slidermenu.Width >= 263)
                {
                    siderbarExpand = true;
                    sliderTran.Stop();



                }


            }
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            ShowMenu(panelPersonas);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            ShowMenu(panelFacturacion);
        }
        public void SetUsuarioLabel(string usuario)
        {
            lblUsuario.Text = usuario;
        }
        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion sesio = new frmInicioSesion();  
            sesio.Show();
        }
    }
}