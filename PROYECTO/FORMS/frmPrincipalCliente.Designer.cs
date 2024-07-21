using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo
{
    partial class frmPrincipalCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalCliente));
            this.contenedor = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pnsubusu = new System.Windows.Forms.Panel();
            this.pnusuario = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.sliderTran = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.slidermenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnsubusu.SuspendLayout();
            this.pnusuario.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.slidermenu.SuspendLayout();
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
            this.contenedor.Location = new System.Drawing.Point(300, 50);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1624, 1005);
            this.contenedor.TabIndex = 30;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1444, 1005);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.UseWaitCursor = true;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // pnsubusu
            // 
            this.pnsubusu.BackColor = System.Drawing.Color.Transparent;
            this.pnsubusu.Controls.Add(this.pnusuario);
            this.pnsubusu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnsubusu.Location = new System.Drawing.Point(1444, 0);
            this.pnsubusu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnsubusu.Name = "pnsubusu";
            this.pnsubusu.Size = new System.Drawing.Size(180, 1005);
            this.pnsubusu.TabIndex = 1;
            this.pnsubusu.UseWaitCursor = true;
            this.pnsubusu.Visible = false;
            // 
            // pnusuario
            // 
            this.pnusuario.Controls.Add(this.button7);
            this.pnusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnusuario.Location = new System.Drawing.Point(0, 0);
            this.pnusuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnusuario.Name = "pnusuario";
            this.pnusuario.Size = new System.Drawing.Size(180, 69);
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
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 57);
            this.button7.TabIndex = 27;
            this.button7.Text = "                  &Cerrar Sesion";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.UseWaitCursor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // sliderTran
            // 
            this.sliderTran.Interval = 10;
            this.sliderTran.Tick += new System.EventHandler(this.sliderTran_Tick);
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
            this.button5.Location = new System.Drawing.Point(4, 269);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(297, 86);
            this.button5.TabIndex = 26;
            this.button5.Text = "                  &Salir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gray;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(0, 5);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button20.Name = "button20";
            this.button20.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button20.Size = new System.Drawing.Size(277, 57);
            this.button20.TabIndex = 1;
            this.button20.Text = "Comprar Producto";
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click_1);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Black;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(4, 4);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(297, 86);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "                  Productos";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click_1);
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.Black;
            this.panelProductos.Controls.Add(this.btnOrdenes);
            this.panelProductos.Controls.Add(this.button20);
            this.panelProductos.Location = new System.Drawing.Point(4, 99);
            this.panelProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(297, 161);
            this.panelProductos.TabIndex = 31;
            this.panelProductos.Visible = false;
            // 
            // slidermenu
            // 
            this.slidermenu.BackColor = System.Drawing.Color.Black;
            this.slidermenu.Controls.Add(this.btnProduct);
            this.slidermenu.Controls.Add(this.panelProductos);
            this.slidermenu.Controls.Add(this.button5);
            this.slidermenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidermenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.slidermenu.Location = new System.Drawing.Point(0, 50);
            this.slidermenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slidermenu.Name = "slidermenu";
            this.slidermenu.Size = new System.Drawing.Size(300, 1005);
            this.slidermenu.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "San José Carniceros | CROAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(11, 7);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 50);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1721, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 50);
            this.panel2.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(83, 7);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 24);
            this.lblUsuario.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1894, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.Gray;
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnOrdenes.Location = new System.Drawing.Point(0, 70);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnOrdenes.Size = new System.Drawing.Size(277, 57);
            this.btnOrdenes.TabIndex = 2;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // frmPrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.slidermenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipalCliente";
            this.Text = "frmPrincipalCliente";
            this.Load += new System.EventHandler(this.frmPrincipalCliente_Load_1);
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnsubusu.ResumeLayout(false);
            this.pnusuario.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.slidermenu.ResumeLayout(false);
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
        private System.Windows.Forms.Timer sliderTran;
        private Button button5;
        private Button button20;
        private Button btnProduct;
        private Panel panelProductos;
        private FlowLayoutPanel slidermenu;
        private Label label1;
        private PictureBox btnMenu;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel pnsubusu;
        private Panel pnusuario;
        private Button button7;
        private PictureBox logo;
        private Panel panel2;
        private Label lblUsuario;
        private Button btnOrdenes;
    }
}