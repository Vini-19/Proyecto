using PROYECTO;
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
    public partial class frmPrincipalEmpleado : Form
    {
        public frmPrincipalEmpleado()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private static Form FormAct;

        bool siderbarExpand = true;
        private void submenu()
        {
            if (panelProductos.Visible == true)
            {
                panelProductos.Visible = false;
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

        private void butons()
        {
            if (btnFacturacion.Enabled == true)
            {
                btnFacturacion.Enabled = false;
            }
            else
            {
                btnFacturacion.Enabled = true;
            }

           

            if (btnProduct.Enabled == true)
            {
                btnProduct.Enabled = false;
            }
            else
            {
                btnProduct.Enabled = true;
            }
            if (btnPedidos.Enabled == true)
            {
                btnPedidos.Enabled = false;
            }
            else
            {
                btnPedidos.Enabled = true;
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
            formulario.BackColor = Color.White;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }


        
        public void SetUsuarioLabel(string usuario)
        {
            lblUsuario.Text = usuario;
        }
      

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion sesio = new frmInicioSesion();  
            sesio.Show();
        }

        

        private void button14_Click(object sender, EventArgs e)
        {
            AbriForm(new frmClientes());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbriForm(new frmProveedores());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void btnFacturacion_Click_1(object sender, EventArgs e)
        {
            ShowMenu(panelFacturacion);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbriForm(new frmVentas());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbriForm(new frmAgregarCompra());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            sliderTran.Start();
            submenu();
            butons();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            logo.Visible = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipalEmpleado_Load_1(object sender, EventArgs e)
        {

        }

        private void sliderTran_Tick_1(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            AbriForm(new frmPedidosAdmin());
        }

        private void slidermenu_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button19_Click(object sender, EventArgs e)
        {
            AbriForm(new frmPedido());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AbriForm(new frmInventario());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowMenu(panelProductos);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
        
        }
    }
}
