
using PROYECTO.CLASES;
using PROYECTO.REPORTES;
using Proyecto_de_desarrolo;
using Proyecto_de_desarrolo.Formularios;
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
            this.WindowState = FormWindowState.Maximized;

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
                contenedor.Controls.Remove(FormAct);
                FormAct.Close();
            }

            if (FormAct != formulario)
            {
                FormAct = formulario;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.BackColor = Color.LightBlue;
                contenedor.Controls.Add(formulario);
                formulario.Show();
            }
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
            if (PNREPOR.Visible == true)
            {
                PNREPOR.Visible = false;
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

            if (btnPersonas.Enabled == true)
            {
                btnPersonas.Enabled = false;
            }
            else
            {
                btnPersonas.Enabled = true;
            }

            if (btnReporte.Enabled == true)
            {
                btnReporte.Enabled = false;
            }
            else
            {
                btnReporte.Enabled = true;
            }

            

            if (btnProduct.Enabled == true)
            {
                btnProduct.Enabled = false;
            }
            else
            {
                btnProduct.Enabled = true;
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
            ShowMenu(panelProductos);
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

        private void button7_Click_1(object sender, EventArgs e)
        {
           frmInicioSesion ini = new frmInicioSesion();
            this.Hide();
            ini.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            AbriForm(new frmClientes());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbriForm(new frmProveedores());
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            AbriForm(new frmVentas());
            
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmAgregarCompra());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            AbriForm(new frmInventario());
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            AbriForm(new frmPedido());
        }

        private void contenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbriForm(new REPOR_VENTA());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbriForm(new REPOR_PRODUCT());
        }

        

       

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void PNREPOR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbriForm(new REPOR_VENTA());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            AbriForm(new REPOR_PRODUCT());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void btnPersonas_Click_1(object sender, EventArgs e)
        {
            ShowMenu(panelPersonas);
        }

        private void panelPersonas_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmClientes());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmProveedores());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbriForm(new agregarTrabajador());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void btnFacturacion_Click_2(object sender, EventArgs e)
        {
            ShowMenu(panelFacturacion);
        }

        private void panelFacturacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmVentas());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button8_Click_3(object sender, EventArgs e)
        {
            AbriForm(new frmAgregarCompra());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void btnProduct_Click_2(object sender, EventArgs e)
        {
            ShowMenu(panelProductos);
        }

        private void button20_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmInventario());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }
        }

        private void button19_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmPedido());
            if (logo.Visible == true)
            {
                logo.Visible = false;
            }

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowMenu(PNREPOR);
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            ShowMenu(pnusuario);
            ShowMenu(pnsubusu);
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion sesio = new frmInicioSesion();
            sesio.Show();
        }

        private void btnMenu_Click_2(object sender, EventArgs e)
        {
            sliderTran.Start();
            submenu();
            butons();
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
                    if (slidermenu.Width >= 263)
                    {
                        
                        siderbarExpand = true;
                        sliderTran.Stop();



                    }


                }
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            logo.Visible = true;
            
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void frmadmi_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

       

        private void button3_Click_3(object sender, EventArgs e)
        {
       
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}


