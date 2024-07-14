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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalEmpleado));
            contenedor = new Panel();
            pnsubusu = new Panel();
            pnusuario = new Panel();
            button7 = new Button();
            BtnProdu = new Button();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            sliderTran = new System.Windows.Forms.Timer(components);
            button5 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            btnProduct = new Button();
            panelProductos = new Panel();
            button3 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnFacturacion = new Button();
            button4 = new Button();
            button14 = new Button();
            btnPersonas = new Button();
            panelPersonas = new Panel();
            slidermenu = new FlowLayoutPanel();
            panelFacturacion = new Panel();
            button6 = new Button();
            label1 = new Label();
            btnMenu = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblUsuario = new Label();
            pictureBox2 = new PictureBox();
            contenedor.SuspendLayout();
            pnsubusu.SuspendLayout();
            pnusuario.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProductos.SuspendLayout();
            panelPersonas.SuspendLayout();
            slidermenu.SuspendLayout();
            panelFacturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // contenedor
            // 
            contenedor.Controls.Add(pnsubusu);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(263, 35);
            contenedor.Margin = new Padding(3, 2, 3, 2);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(898, 714);
            contenedor.TabIndex = 30;
            contenedor.Paint += contenedor_Paint;
            // 
            // pnsubusu
            // 
            pnsubusu.BackColor = Color.Transparent;
            pnsubusu.Controls.Add(pnusuario);
            pnsubusu.Dock = DockStyle.Right;
            pnsubusu.Location = new Point(741, 0);
            pnsubusu.Name = "pnsubusu";
            pnsubusu.Size = new Size(157, 714);
            pnsubusu.TabIndex = 1;
            pnsubusu.UseWaitCursor = true;
            pnsubusu.Visible = false;
            // 
            // pnusuario
            // 
            pnusuario.Controls.Add(button7);
            pnusuario.Dock = DockStyle.Top;
            pnusuario.Location = new Point(0, 0);
            pnusuario.Name = "pnusuario";
            pnusuario.Size = new Size(157, 65);
            pnusuario.TabIndex = 0;
            pnusuario.UseWaitCursor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.IndianRed;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(157, 53);
            button7.TabIndex = 27;
            button7.Text = "                  &Cerrar Sesion";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.UseWaitCursor = true;
            button7.Click += button7_Click;
            // 
            // BtnProdu
            // 
            BtnProdu.BackColor = Color.White;
            BtnProdu.FlatAppearance.BorderSize = 0;
            BtnProdu.FlatStyle = FlatStyle.Flat;
            BtnProdu.ForeColor = Color.Black;
            BtnProdu.Location = new Point(-33, -72);
            BtnProdu.Name = "BtnProdu";
            BtnProdu.Padding = new Padding(11, 0, 0, 0);
            BtnProdu.Size = new Size(301, 60);
            BtnProdu.TabIndex = 29;
            BtnProdu.Text = "Productos";
            BtnProdu.TextAlign = ContentAlignment.MiddleLeft;
            BtnProdu.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(-33, -205);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(301, 133);
            panel6.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // sliderTran
            // 
            sliderTran.Interval = 10;
            sliderTran.Tick += sliderTran_Tick;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(269, 275);
            button5.Name = "button5";
            button5.Size = new Size(260, 81);
            button5.TabIndex = 26;
            button5.Text = "                  &Salir";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.Gray;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ForeColor = Color.White;
            button18.Location = new Point(0, 121);
            button18.Name = "button18";
            button18.Padding = new Padding(40, 0, 0, 0);
            button18.Size = new Size(243, 51);
            button18.TabIndex = 18;
            button18.Text = "Productos Nuevos";
            button18.TextAlign = ContentAlignment.MiddleLeft;
            button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.Gray;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = Color.White;
            button19.Location = new Point(0, 64);
            button19.Name = "button19";
            button19.Padding = new Padding(40, 0, 0, 0);
            button19.Size = new Size(243, 51);
            button19.TabIndex = 17;
            button19.Text = "Pedidos";
            button19.TextAlign = ContentAlignment.MiddleLeft;
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.Gray;
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ForeColor = Color.White;
            button20.Location = new Point(0, 5);
            button20.Name = "button20";
            button20.Padding = new Padding(40, 0, 0, 0);
            button20.Size = new Size(243, 53);
            button20.TabIndex = 1;
            button20.Text = "Inventario";
            button20.TextAlign = ContentAlignment.MiddleLeft;
            button20.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Black;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(3, 490);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(260, 81);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "                  Productos";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // panelProductos
            // 
            panelProductos.BackColor = Color.Black;
            panelProductos.Controls.Add(button18);
            panelProductos.Controls.Add(button19);
            panelProductos.Controls.Add(button20);
            panelProductos.Location = new Point(269, 4);
            panelProductos.Margin = new Padding(3, 4, 3, 4);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(260, 177);
            panelProductos.TabIndex = 31;
            panelProductos.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 121);
            button3.Name = "button3";
            button3.Padding = new Padding(40, 0, 0, 0);
            button3.Size = new Size(243, 51);
            button3.TabIndex = 18;
            button3.Text = "Envíos";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 64);
            button8.Name = "button8";
            button8.Padding = new Padding(40, 0, 0, 0);
            button8.Size = new Size(243, 51);
            button8.TabIndex = 17;
            button8.Text = "Comprar";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Gray;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(0, 5);
            button9.Name = "button9";
            button9.Padding = new Padding(40, 0, 0, 0);
            button9.Size = new Size(243, 53);
            button9.TabIndex = 1;
            button9.Text = "Ventas";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = Color.Black;
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Image = (Image)resources.GetObject("btnFacturacion.Image");
            btnFacturacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.Location = new Point(3, 213);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Padding = new Padding(3, 0, 0, 0);
            btnFacturacion.Size = new Size(260, 81);
            btnFacturacion.TabIndex = 2;
            btnFacturacion.Text = "                  Facturación";
            btnFacturacion.TextAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.UseVisualStyleBackColor = false;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 57);
            button4.Name = "button4";
            button4.Padding = new Padding(40, 0, 0, 0);
            button4.Size = new Size(243, 51);
            button4.TabIndex = 19;
            button4.Text = "Proveedores";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.Gray;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.White;
            button14.Location = new Point(0, 0);
            button14.Name = "button14";
            button14.Padding = new Padding(40, 0, 0, 0);
            button14.Size = new Size(243, 51);
            button14.TabIndex = 17;
            button14.Text = "Clientes";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = false;
            // 
            // btnPersonas
            // 
            btnPersonas.BackColor = Color.Black;
            btnPersonas.FlatAppearance.BorderSize = 0;
            btnPersonas.FlatStyle = FlatStyle.Flat;
            btnPersonas.ForeColor = Color.White;
            btnPersonas.Image = (Image)resources.GetObject("btnPersonas.Image");
            btnPersonas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonas.Location = new Point(3, 3);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Padding = new Padding(2, 0, 0, 0);
            btnPersonas.Size = new Size(260, 81);
            btnPersonas.TabIndex = 2;
            btnPersonas.Text = "                  Personas";
            btnPersonas.TextAlign = ContentAlignment.MiddleLeft;
            btnPersonas.UseVisualStyleBackColor = false;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // panelPersonas
            // 
            panelPersonas.BackColor = Color.Black;
            panelPersonas.Controls.Add(button4);
            panelPersonas.Controls.Add(button14);
            panelPersonas.Location = new Point(3, 91);
            panelPersonas.Margin = new Padding(3, 4, 3, 4);
            panelPersonas.Name = "panelPersonas";
            panelPersonas.Size = new Size(260, 115);
            panelPersonas.TabIndex = 27;
            panelPersonas.Visible = false;
            // 
            // slidermenu
            // 
            slidermenu.BackColor = Color.Black;
            slidermenu.Controls.Add(btnPersonas);
            slidermenu.Controls.Add(panelPersonas);
            slidermenu.Controls.Add(btnFacturacion);
            slidermenu.Controls.Add(panelFacturacion);
            slidermenu.Controls.Add(btnProduct);
            slidermenu.Controls.Add(panelProductos);
            slidermenu.Controls.Add(button6);
            slidermenu.Controls.Add(button5);
            slidermenu.Dock = DockStyle.Left;
            slidermenu.FlowDirection = FlowDirection.TopDown;
            slidermenu.Location = new Point(0, 35);
            slidermenu.Name = "slidermenu";
            slidermenu.Size = new Size(263, 714);
            slidermenu.TabIndex = 27;
            // 
            // panelFacturacion
            // 
            panelFacturacion.BackColor = Color.Black;
            panelFacturacion.Controls.Add(button3);
            panelFacturacion.Controls.Add(button8);
            panelFacturacion.Controls.Add(button9);
            panelFacturacion.Location = new Point(3, 301);
            panelFacturacion.Margin = new Padding(3, 4, 3, 4);
            panelFacturacion.Name = "panelFacturacion";
            panelFacturacion.Size = new Size(260, 182);
            panelFacturacion.TabIndex = 29;
            panelFacturacion.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(269, 188);
            button6.Name = "button6";
            button6.Size = new Size(260, 81);
            button6.TabIndex = 32;
            button6.Text = "                  Pedidos";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 8);
            label1.Name = "label1";
            label1.Size = new Size(238, 19);
            label1.TabIndex = 1;
            label1.Text = "San José Carniceros | CROAS";
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(9, 8);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(30, 30);
            btnMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMenu.TabIndex = 1;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 35);
            panel1.TabIndex = 26;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsuario);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1001, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 35);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Cursor = Cursors.SizeAll;
            lblUsuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(62, 6);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 19);
            lblUsuario.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1131, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            // 
            // frmPrincipalEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 749);
            Controls.Add(contenedor);
            Controls.Add(BtnProdu);
            Controls.Add(panel6);
            Controls.Add(slidermenu);
            Controls.Add(panel1);
            Name = "frmPrincipalEmpleado";
            Text = "frmPrincipalEmpleado";
            Load += frmPrincipalEmpleado_Load;
            contenedor.ResumeLayout(false);
            pnsubusu.ResumeLayout(false);
            pnusuario.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelProductos.ResumeLayout(false);
            panelPersonas.ResumeLayout(false);
            slidermenu.ResumeLayout(false);
            panelFacturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel contenedor;
        private Button BtnProdu;
        private Panel panel6;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer sliderTran;
        private Button button5;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button btnProduct;
        private Panel panelProductos;
        private Button button3;
        private Button button8;
        private Button button9;
        private Button btnFacturacion;
        private Button button4;
        private Button button14;
        private Button btnPersonas;
        private Panel panelPersonas;
        private FlowLayoutPanel slidermenu;
        private Panel panelFacturacion;
        private Label label1;
        private PictureBox btnMenu;
        private Panel panel1;
        private Button button6;
        private Panel panel2;
        private Label lblUsuario;
        private PictureBox pictureBox2;
        private Panel pnsubusu;
        private Panel pnusuario;
        private Button button7;
    }
}