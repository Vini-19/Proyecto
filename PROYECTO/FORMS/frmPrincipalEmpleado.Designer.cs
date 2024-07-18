using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo
{
    partial class frmPrincipalEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalEmpleado));
            this.contenedor = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pnsubusu = new System.Windows.Forms.Panel();
            this.pnusuario = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.BtnProdu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sliderTran = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.slidermenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFacturacion = new System.Windows.Forms.Panel();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnsubusu.SuspendLayout();
            this.pnusuario.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelProductos.SuspendLayout();
            this.slidermenu.SuspendLayout();
            this.panelFacturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.logo);
            this.contenedor.Controls.Add(this.pnsubusu);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(225, 40);
            this.contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1611, 1398);
            this.contenedor.TabIndex = 30;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1476, 1398);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.UseWaitCursor = true;
            // 
            // pnsubusu
            // 
            this.pnsubusu.BackColor = System.Drawing.Color.Transparent;
            this.pnsubusu.Controls.Add(this.pnusuario);
            this.pnsubusu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnsubusu.Location = new System.Drawing.Point(1476, 0);
            this.pnsubusu.Name = "pnsubusu";
            this.pnsubusu.Size = new System.Drawing.Size(135, 1398);
            this.pnsubusu.TabIndex = 1;
            this.pnsubusu.UseWaitCursor = true;
            this.pnsubusu.Visible = false;
            // 
            // pnusuario
            // 
            this.pnusuario.Controls.Add(this.button7);
            this.pnusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnusuario.Location = new System.Drawing.Point(0, 0);
            this.pnusuario.Name = "pnusuario";
            this.pnusuario.Size = new System.Drawing.Size(135, 56);
            this.pnusuario.TabIndex = 0;
            this.pnusuario.UseWaitCursor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.IndianRed;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 46);
            this.button7.TabIndex = 27;
            this.button7.Text = "                  &Cerrar Sesion";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.UseWaitCursor = true;
            // 
            // BtnProdu
            // 
            this.BtnProdu.BackColor = System.Drawing.Color.White;
            this.BtnProdu.FlatAppearance.BorderSize = 0;
            this.BtnProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdu.ForeColor = System.Drawing.Color.Black;
            this.BtnProdu.Location = new System.Drawing.Point(-28, -62);
            this.BtnProdu.Name = "BtnProdu";
            this.BtnProdu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.BtnProdu.Size = new System.Drawing.Size(258, 52);
            this.BtnProdu.TabIndex = 29;
            this.BtnProdu.Text = "Productos";
            this.BtnProdu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdu.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(-28, -178);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 115);
            this.panel6.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // sliderTran
            // 
            this.sliderTran.Interval = 10;
            this.sliderTran.Tick += new System.EventHandler(this.sliderTran_Tick_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 509);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 70);
            this.button5.TabIndex = 26;
            this.button5.Text = "                  &Salir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Gray;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(0, 55);
            this.button19.Name = "button19";
            this.button19.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.button19.Size = new System.Drawing.Size(208, 44);
            this.button19.TabIndex = 17;
            this.button19.Text = "Catalogo";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gray;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(0, 4);
            this.button20.Name = "button20";
            this.button20.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.button20.Size = new System.Drawing.Size(208, 46);
            this.button20.TabIndex = 1;
            this.button20.Text = "Inventario";
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Black;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(3, 243);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(223, 70);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "                  Productos";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.Black;
            this.panelProductos.Controls.Add(this.button19);
            this.panelProductos.Controls.Add(this.button20);
            this.panelProductos.Location = new System.Drawing.Point(3, 319);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(223, 108);
            this.panelProductos.TabIndex = 31;
            this.panelProductos.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 105);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(208, 44);
            this.button3.TabIndex = 18;
            this.button3.Text = "Envíos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 55);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(208, 44);
            this.button8.TabIndex = 17;
            this.button8.Text = "Comprar";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 4);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(208, 46);
            this.button9.TabIndex = 1;
            this.button9.Text = "Ventas";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.Black;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(3, 3);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnFacturacion.Size = new System.Drawing.Size(223, 70);
            this.btnFacturacion.TabIndex = 2;
            this.btnFacturacion.Text = "                  Facturación";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click_1);
            // 
            // slidermenu
            // 
            this.slidermenu.BackColor = System.Drawing.Color.Black;
            this.slidermenu.Controls.Add(this.btnFacturacion);
            this.slidermenu.Controls.Add(this.panelFacturacion);
            this.slidermenu.Controls.Add(this.btnProduct);
            this.slidermenu.Controls.Add(this.panelProductos);
            this.slidermenu.Controls.Add(this.btnPedidos);
            this.slidermenu.Controls.Add(this.button5);
            this.slidermenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidermenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.slidermenu.Location = new System.Drawing.Point(0, 40);
            this.slidermenu.Name = "slidermenu";
            this.slidermenu.Size = new System.Drawing.Size(225, 1398);
            this.slidermenu.TabIndex = 27;
            this.slidermenu.Paint += new System.Windows.Forms.PaintEventHandler(this.slidermenu_Paint);
            // 
            // panelFacturacion
            // 
            this.panelFacturacion.BackColor = System.Drawing.Color.Black;
            this.panelFacturacion.Controls.Add(this.button3);
            this.panelFacturacion.Controls.Add(this.button8);
            this.panelFacturacion.Controls.Add(this.button9);
            this.panelFacturacion.Location = new System.Drawing.Point(3, 79);
            this.panelFacturacion.Name = "panelFacturacion";
            this.panelFacturacion.Size = new System.Drawing.Size(223, 158);
            this.panelFacturacion.TabIndex = 29;
            this.panelFacturacion.Visible = false;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Black;
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(3, 433);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(223, 70);
            this.btnPedidos.TabIndex = 32;
            this.btnPedidos.Text = "                  Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "San José Carniceros | CROAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(8, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1836, 40);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1695, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 40);
            this.panel2.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(53, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 19);
            this.lblUsuario.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1806, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // frmPrincipalEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1438);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.BtnProdu);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.slidermenu);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipalEmpleado";
            this.Text = "frmPrincipalEmpleado";
            this.Load += new System.EventHandler(this.frmPrincipalEmpleado_Load_1);
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnsubusu.ResumeLayout(false);
            this.pnusuario.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelProductos.ResumeLayout(false);
            this.slidermenu.ResumeLayout(false);
            this.panelFacturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel contenedor;
        private Button BtnProdu;
        private Panel panel6;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer sliderTran;
        private Button button5;
        private Button button19;
        private Button button20;
        private Button btnProduct;
        private Panel panelProductos;
        private Button button3;
        private Button button8;
        private Button button9;
        private Button btnFacturacion;
        private FlowLayoutPanel slidermenu;
        private Panel panelFacturacion;
        private Label label1;
        private PictureBox btnMenu;
        private Panel panel1;
        private Button btnPedidos;
        private Panel panel2;
        private Label lblUsuario;
        private PictureBox pictureBox2;
        private Panel pnsubusu;
        private Panel pnusuario;
        private Button button7;
        private PictureBox logo;
    }
}