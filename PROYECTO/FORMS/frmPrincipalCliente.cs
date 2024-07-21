using PROYECTO;
using PROYECTO.FORMS;
using Proyecto_de_desarrolo.Formularios;
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
    public partial class frmPrincipalCliente : Form
    {
        public frmPrincipalCliente()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private static Form FormAct;
        private void submenu()
        {
            if (panelProductos.Visible == true)
            {
                panelProductos.Visible = false;
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
            formulario.BackColor = Color.White;
            contenedor.Controls.Add(formulario);
            formulario.Show();
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

       
        bool siderbarExpand = true;

        public void SetUsuarioLabel(string usuario)
        {
            lblUsuario.Text = usuario;
        }
      

        private void label1_Click(object sender, EventArgs e)
        {
            logo.Visible = true;
        }
        private void butons()
        {
            if (btnProduct.Enabled == true)
            {
                btnProduct.Enabled = false;
            }
            else
            {
                btnProduct.Enabled = true;
            }

        }
        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            sliderTran.Start();
            submenu();
            butons();
        }

        private void frmPrincipalCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            ShowMenu(pnusuario);
            ShowMenu(pnsubusu);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion sesio = new frmInicioSesion();
            sesio.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            ShowMenu(panelProductos);
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
                if (slidermenu.Width >= 225)
                {

                    siderbarExpand = true;
                    sliderTran.Stop();



                }


            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            AbriForm(new Pedidos_Cliente());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            AbriForm(new frmHistorialPedidos());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }
    }
}
