﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class frmadmi : Form
    {
        public frmadmi()
        {
            InitializeComponent();

        }
        bool menuExpand = false;

        private static Form FormAct;

        private void Clientes_Click(object sender, EventArgs e)
        {

        }

        bool siderbarExpand = true;

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

      

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void frmadmi_Load(object sender, EventArgs e)
        {

        }

        private void slidermenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void panelPersonas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            ShowMenu(panelPersonas);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowMenu(panelProductos);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            ShowMenu(panelFacturacion);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }


        public void SetUsuarioLabel(string usuario)
        {
            lblUsuario.Text = usuario;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowMenu(pnusuario);
            ShowMenu(pnsubusu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion sesio = new frmInicioSesion();
            sesio.Show();
           
        }

        private void pnsubusu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            ShowMenu(panelPersonas);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFacturacion_Click_1(object sender, EventArgs e)
        {
            ShowMenu(panelFacturacion);
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ShowMenu(pnusuario);
            ShowMenu(pnsubusu);
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            sliderTran.Start();
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
    }
}

