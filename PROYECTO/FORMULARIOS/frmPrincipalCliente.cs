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
            formulario.BackColor = Color.IndianRed;
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

        private void frmPrincipalCliente_Load(object sender, EventArgs e)
        {

        }
        bool siderbarExpand = true;
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

        private void button9_Click(object sender, EventArgs e)
        {
            AbriForm(new frmVentas());
        }




        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowMenu(panelProductos);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AbriForm(new Pedidos_Cliente());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void SetUsuarioLabel(string usuario)
        {
            lblUsuario.Text = usuario;
        }
        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sliderTran.Start();
        }
    }
}
