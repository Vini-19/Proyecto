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
using static System.Windows.Forms.DataFormats;

namespace Proyecto_de_desarrolo
{
    public partial class frmPrincipal : Form
    {
        private static Form FormAct;

        public frmPrincipal()
        {
            InitializeComponent();
            Diseño();
        }


        private void Diseño()
        {
            PanelProduct.Visible = false;
            panelPersonas.Visible = false;
            panelFacturacion.Visible = false;
        }

        private void submenu()
        {
            if (PanelProduct.Visible == true)
            {
                PanelProduct.Visible = false;
            }
            if (panelPersonas.Visible == true)
            {
                panelPersonas.Visible = false;
            }
            if (panelFacturacion.Visible == true)
            {
                panelFacturacion.Visible = false;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

            AbriForm(new frmInventario());

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbriForm(new frmPedido());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbriForm(new frmVentas());
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            AbriForm(new frmEnvios());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbriForm(new frmProveedores());

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbriForm(new frmReportes());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbriForm(new frmAgregarCompra());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbriForm(new frmProductos());
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnProdu_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelProduct);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbriForm(new frmInventario());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbriForm(new frmAgregarCompra());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmPedido());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbriForm(new frmProductos());
        }

        private void BtnPed_Click(object sender, EventArgs e)
        {
            AbriForm(new frmPedido());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbriForm(new frmAgregarCompra());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbriForm(new frmProductos());
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmProveedores());
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            AbriForm(new frmClientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbriForm(new frmAgregarCompra());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbriForm(new frmVentas());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbriForm(new frmReportes());
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            AbriForm(new frmEnvios());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowMenu(panelPersonas);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowMenu(panelFacturacion);
        }

        private void PanelProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
