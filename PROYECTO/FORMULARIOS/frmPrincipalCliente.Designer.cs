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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalCliente));
            contenedor = new Panel();
            pnsubusu = new Panel();
            pnusuario = new Panel();
            button7 = new Button();
            sliderTran = new System.Windows.Forms.Timer(components);
            button5 = new Button();
            button19 = new Button();
            button20 = new Button();
            btnProduct = new Button();
            panelProductos = new Panel();
            slidermenu = new FlowLayoutPanel();
            label1 = new Label();
            btnMenu = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblUsuario = new Label();
            pictureBox2 = new PictureBox();
            contenedor.SuspendLayout();
            pnsubusu.SuspendLayout();
            pnusuario.SuspendLayout();
            panelProductos.SuspendLayout();
            slidermenu.SuspendLayout();
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
            contenedor.Size = new Size(795, 519);
            contenedor.TabIndex = 30;
            contenedor.Paint += contenedor_Paint;
            // 
            // pnsubusu
            // 
            pnsubusu.BackColor = Color.Transparent;
            pnsubusu.Controls.Add(pnusuario);
            pnsubusu.Dock = DockStyle.Right;
            pnsubusu.Location = new Point(638, 0);
            pnsubusu.Name = "pnsubusu";
            pnsubusu.Size = new Size(157, 519);
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
            button5.Location = new Point(3, 228);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(297, 81);
            button5.TabIndex = 26;
            button5.Text = "                  &Salir";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            button19.Text = "Ordenes";
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
            button20.Text = "Comprar";
            button20.TextAlign = ContentAlignment.MiddleLeft;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Black;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(3, 4);
            btnProduct.Margin = new Padding(3, 4, 3, 4);
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
            panelProductos.Controls.Add(button19);
            panelProductos.Controls.Add(button20);
            panelProductos.Location = new Point(3, 94);
            panelProductos.Margin = new Padding(3, 5, 3, 5);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(297, 125);
            panelProductos.TabIndex = 31;
            panelProductos.Visible = false;
            // 
            // slidermenu
            // 
            slidermenu.BackColor = Color.Black;
            slidermenu.Controls.Add(btnProduct);
            slidermenu.Controls.Add(panelProductos);
            slidermenu.Controls.Add(button5);
            slidermenu.Dock = DockStyle.Left;
            slidermenu.FlowDirection = FlowDirection.TopDown;
            slidermenu.Location = new Point(0, 35);
            slidermenu.Name = "slidermenu";
            slidermenu.Size = new Size(263, 519);
            slidermenu.TabIndex = 27;
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
            btnMenu.Location = new Point(9, 5);
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
            panel1.Size = new Size(1058, 35);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsuario);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(898, 0);
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
            pictureBox2.Location = new Point(1028, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // frmPrincipalCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 554);
            Controls.Add(contenedor);
            Controls.Add(slidermenu);
            Controls.Add(panel1);
            Name = "frmPrincipalCliente";
            Text = "frmPrincipalCliente";
            Load += frmPrincipalCliente_Load;
            contenedor.ResumeLayout(false);
            pnsubusu.ResumeLayout(false);
            pnusuario.ResumeLayout(false);
            panelProductos.ResumeLayout(false);
            slidermenu.ResumeLayout(false);
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
        private System.Windows.Forms.Timer sliderTran;
        private Button button5;
        private Button button19;
        private Button button20;
        private Button btnProduct;
        private Panel panelProductos;
        private FlowLayoutPanel slidermenu;
        private Label label1;
        private PictureBox btnMenu;
        private Panel panel1;
        private Panel panel2;
        private Label lblUsuario;
        private PictureBox pictureBox2;
        private Panel pnsubusu;
        private Panel pnusuario;
        private Button button7;
    }
}