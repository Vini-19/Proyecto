using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO
{
    partial class frmadmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.slidermenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.panelPersonas = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.panelFacturacion = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sliderTran = new System.Windows.Forms.Timer(this.components);
            this.BtnProdu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.Panel();
            this.pnsubusu = new System.Windows.Forms.Panel();
            this.pnusuario = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.slidermenu.SuspendLayout();
            this.panelPersonas.SuspendLayout();
            this.panelFacturacion.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contenedor.SuspendLayout();
            this.pnsubusu.SuspendLayout();
            this.pnusuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(952, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(992, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 38);
            this.panel2.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(62, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 19);
            this.lblUsuario.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1122, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "San José Carniceros | CROAS";
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(9, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // slidermenu
            // 
            this.slidermenu.BackColor = System.Drawing.Color.Black;
            this.slidermenu.Controls.Add(this.btnPersonas);
            this.slidermenu.Controls.Add(this.panelPersonas);
            this.slidermenu.Controls.Add(this.btnFacturacion);
            this.slidermenu.Controls.Add(this.panelFacturacion);
            this.slidermenu.Controls.Add(this.btnProduct);
            this.slidermenu.Controls.Add(this.panelProductos);
            this.slidermenu.Controls.Add(this.button6);
            this.slidermenu.Controls.Add(this.button5);
            this.slidermenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidermenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.slidermenu.Location = new System.Drawing.Point(0, 38);
            this.slidermenu.Name = "slidermenu";
            this.slidermenu.Size = new System.Drawing.Size(263, 973);
            this.slidermenu.TabIndex = 1;
            this.slidermenu.WrapContents = false;
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackColor = System.Drawing.Color.Black;
            this.btnPersonas.FlatAppearance.BorderSize = 0;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonas.ForeColor = System.Drawing.Color.White;
            this.btnPersonas.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonas.Image")));
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.Location = new System.Drawing.Point(3, 3);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnPersonas.Size = new System.Drawing.Size(260, 81);
            this.btnPersonas.TabIndex = 2;
            this.btnPersonas.Text = "                  Personas";
            this.btnPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.UseVisualStyleBackColor = false;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // panelPersonas
            // 
            this.panelPersonas.BackColor = System.Drawing.Color.Black;
            this.panelPersonas.Controls.Add(this.button4);
            this.panelPersonas.Controls.Add(this.button14);
            this.panelPersonas.Location = new System.Drawing.Point(3, 91);
            this.panelPersonas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPersonas.Name = "panelPersonas";
            this.panelPersonas.Size = new System.Drawing.Size(260, 129);
            this.panelPersonas.TabIndex = 27;
            this.panelPersonas.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 61);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(243, 55);
            this.button4.TabIndex = 19;
            this.button4.Text = "Proveedores";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gray;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(0, 0);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(243, 55);
            this.button14.TabIndex = 17;
            this.button14.Text = "Clientes";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.Black;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(3, 227);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnFacturacion.Size = new System.Drawing.Size(260, 81);
            this.btnFacturacion.TabIndex = 2;
            this.btnFacturacion.Text = "                  Facturación";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click_1);
            // 
            // panelFacturacion
            // 
            this.panelFacturacion.BackColor = System.Drawing.Color.Black;
            this.panelFacturacion.Controls.Add(this.button2);
            this.panelFacturacion.Controls.Add(this.button3);
            this.panelFacturacion.Controls.Add(this.button8);
            this.panelFacturacion.Controls.Add(this.button9);
            this.panelFacturacion.Location = new System.Drawing.Point(3, 315);
            this.panelFacturacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFacturacion.Name = "panelFacturacion";
            this.panelFacturacion.Size = new System.Drawing.Size(260, 255);
            this.panelFacturacion.TabIndex = 29;
            this.panelFacturacion.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 191);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(243, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reportes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 130);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(243, 55);
            this.button3.TabIndex = 18;
            this.button3.Text = "Envíos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 69);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(243, 55);
            this.button8.TabIndex = 17;
            this.button8.Text = "comprar";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 5);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(243, 57);
            this.button9.TabIndex = 1;
            this.button9.Text = "Ventas";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Black;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(3, 577);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(260, 81);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "                  Productos";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click_1);
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.Black;
            this.panelProductos.Controls.Add(this.button19);
            this.panelProductos.Controls.Add(this.button20);
            this.panelProductos.Location = new System.Drawing.Point(3, 665);
            this.panelProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(260, 132);
            this.panelProductos.TabIndex = 31;
            this.panelProductos.Visible = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Gray;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(0, 69);
            this.button19.Name = "button19";
            this.button19.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button19.Size = new System.Drawing.Size(243, 55);
            this.button19.TabIndex = 17;
            this.button19.Text = "Pedidos";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gray;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(0, 5);
            this.button20.Name = "button20";
            this.button20.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button20.Size = new System.Drawing.Size(243, 57);
            this.button20.TabIndex = 1;
            this.button20.Text = "Inventario";
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 804);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 81);
            this.button6.TabIndex = 27;
            this.button6.Text = "                  Pedidos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
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
            this.button5.Location = new System.Drawing.Point(3, 891);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 81);
            this.button5.TabIndex = 26;
            this.button5.Text = "                  &Salir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // sliderTran
            // 
            this.sliderTran.Interval = 10;
            this.sliderTran.Tick += new System.EventHandler(this.sliderTran_Tick);
            // 
            // BtnProdu
            // 
            this.BtnProdu.BackColor = System.Drawing.Color.White;
            this.BtnProdu.FlatAppearance.BorderSize = 0;
            this.BtnProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdu.ForeColor = System.Drawing.Color.Black;
            this.BtnProdu.Location = new System.Drawing.Point(0, -71);
            this.BtnProdu.Name = "BtnProdu";
            this.BtnProdu.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnProdu.Size = new System.Drawing.Size(301, 64);
            this.BtnProdu.TabIndex = 24;
            this.BtnProdu.Text = "Productos";
            this.BtnProdu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdu.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(0, -213);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 142);
            this.panel6.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.pnsubusu);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(263, 38);
            this.contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(889, 973);
            this.contenedor.TabIndex = 25;
            this.contenedor.UseWaitCursor = true;
            // 
            // pnsubusu
            // 
            this.pnsubusu.BackColor = System.Drawing.Color.Transparent;
            this.pnsubusu.Controls.Add(this.pnusuario);
            this.pnsubusu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnsubusu.Location = new System.Drawing.Point(732, 0);
            this.pnsubusu.Name = "pnsubusu";
            this.pnsubusu.Size = new System.Drawing.Size(157, 973);
            this.pnsubusu.TabIndex = 0;
            this.pnsubusu.UseWaitCursor = true;
            this.pnsubusu.Visible = false;
            this.pnsubusu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnsubusu_Paint);
            // 
            // pnusuario
            // 
            this.pnusuario.Controls.Add(this.button7);
            this.pnusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnusuario.Location = new System.Drawing.Point(0, 0);
            this.pnusuario.Name = "pnusuario";
            this.pnusuario.Size = new System.Drawing.Size(157, 65);
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
            this.button7.Size = new System.Drawing.Size(157, 53);
            this.button7.TabIndex = 27;
            this.button7.Text = "                  &Cerrar Sesion";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.UseWaitCursor = true;
            // 
            // frmadmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 1011);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.BtnProdu);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.slidermenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmadmi";
            this.Text = "frmadmi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.slidermenu.ResumeLayout(false);
            this.panelPersonas.ResumeLayout(false);
            this.panelFacturacion.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contenedor.ResumeLayout(false);
            this.pnsubusu.ResumeLayout(false);
            this.pnusuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox btnMenu;
        private Label label1;
        private FlowLayoutPanel slidermenu;
        private System.Windows.Forms.Timer sliderTran;
        private Panel panelPersonas;
        private Button button14;
        private Button btnPersonas;
        private Button BtnProdu;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Button btnFacturacion;
        private Panel panelFacturacion;
        private Button button3;
        private Button button8;
        private Button button9;
        private Button button2;
        private Button btnProduct;
        private Panel panelProductos;
        private Button button19;
        private Button button20;
        private Panel contenedor;
        private Button button5;
        private Button button4;
        private Button button6;
        private Panel panel4;
        private Panel pnsubusu;
        private Panel pnusuario;
        private Button button7;
        private Panel panel2;
        private Label lblUsuario;
        private PictureBox pictureBox2;
    }
}