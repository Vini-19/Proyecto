using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pictureBox1 = new PictureBox();
            contenedor = new Panel();
            panelFacturacion = new Panel();
            button5 = new Button();
            button2 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel2 = new Panel();
            panelPersonas = new Panel();
            button1 = new Button();
            button3 = new Button();
            button6 = new Button();
            PanelProduct = new Panel();
            BtnPed = new Button();
            btnProductos = new Button();
            button4 = new Button();
            BtnProdu = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFacturacion.SuspendLayout();
            panel2.SuspendLayout();
            panelPersonas.SuspendLayout();
            PanelProduct.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            // contenedor
            // 
            contenedor.Location = new Point(329, 0);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(967, 917);
            contenedor.TabIndex = 2;
            contenedor.Paint += contenedor_Paint;
            // 
            // panelFacturacion
            // 
            panelFacturacion.BackColor = Color.Maroon;
            panelFacturacion.Controls.Add(button5);
            panelFacturacion.Controls.Add(button2);
            panelFacturacion.Controls.Add(button7);
            panelFacturacion.Controls.Add(button8);
            panelFacturacion.Dock = DockStyle.Top;
            panelFacturacion.Location = new Point(0, 619);
            panelFacturacion.Margin = new Padding(3, 4, 3, 4);
            panelFacturacion.Name = "panelFacturacion";
            panelFacturacion.Size = new Size(301, 237);
            panelFacturacion.TabIndex = 21;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 177);
            button5.Name = "button5";
            button5.Padding = new Padding(40, 0, 0, 0);
            button5.Size = new Size(286, 51);
            button5.TabIndex = 18;
            button5.Text = "Envios";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 64);
            button2.Name = "button2";
            button2.Padding = new Padding(40, 0, 0, 0);
            button2.Size = new Size(286, 51);
            button2.TabIndex = 17;
            button2.Text = "Comprar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 5);
            button7.Name = "button7";
            button7.Padding = new Padding(40, 0, 0, 0);
            button7.Size = new Size(286, 53);
            button7.TabIndex = 1;
            button7.Text = "Ventas";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 120);
            button8.Name = "button8";
            button8.Padding = new Padding(40, 0, 0, 0);
            button8.Size = new Size(286, 51);
            button8.TabIndex = 15;
            button8.Text = "Reportes";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.Black;
            button9.Location = new Point(0, 559);
            button9.Name = "button9";
            button9.Padding = new Padding(11, 0, 0, 0);
            button9.Size = new Size(301, 60);
            button9.TabIndex = 20;
            button9.Text = "Facturacion";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.IndianRed;
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.White;
            button10.Location = new Point(0, 856);
            button10.Name = "button10";
            button10.Padding = new Padding(11, 0, 0, 0);
            button10.Size = new Size(301, 60);
            button10.TabIndex = 22;
            button10.Text = "&Salir";
            button10.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoScrollMargin = new Size(80, 80);
            panel2.AutoScrollMinSize = new Size(100, 100);
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(button10);
            panel2.Controls.Add(panelFacturacion);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(panelPersonas);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(PanelProduct);
            panel2.Controls.Add(BtnProdu);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 943);
            panel2.TabIndex = 3;
            // 
            // panelPersonas
            // 
            panelPersonas.BackColor = Color.Maroon;
            panelPersonas.Controls.Add(button1);
            panelPersonas.Controls.Add(button3);
            panelPersonas.Dock = DockStyle.Top;
            panelPersonas.Location = new Point(0, 432);
            panelPersonas.Margin = new Padding(3, 4, 3, 4);
            panelPersonas.Name = "panelPersonas";
            panelPersonas.Size = new Size(301, 127);
            panelPersonas.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 64);
            button1.Name = "button1";
            button1.Padding = new Padding(40, 0, 0, 0);
            button1.Size = new Size(286, 51);
            button1.TabIndex = 17;
            button1.Text = "Clientes";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_3;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 5);
            button3.Name = "button3";
            button3.Padding = new Padding(40, 0, 0, 0);
            button3.Size = new Size(286, 53);
            button3.TabIndex = 1;
            button3.Text = "Proveedores";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_2;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(0, 372);
            button6.Name = "button6";
            button6.Padding = new Padding(11, 0, 0, 0);
            button6.Size = new Size(301, 60);
            button6.TabIndex = 18;
            button6.Text = "Personas";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // PanelProduct
            // 
            PanelProduct.BackColor = Color.Maroon;
            PanelProduct.Controls.Add(BtnPed);
            PanelProduct.Controls.Add(btnProductos);
            PanelProduct.Controls.Add(button4);
            PanelProduct.Dock = DockStyle.Top;
            PanelProduct.Location = new Point(0, 193);
            PanelProduct.Margin = new Padding(3, 4, 3, 4);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(301, 179);
            PanelProduct.TabIndex = 17;
            PanelProduct.Paint += PanelProduct_Paint;
            // 
            // BtnPed
            // 
            BtnPed.BackColor = Color.Transparent;
            BtnPed.FlatStyle = FlatStyle.Flat;
            BtnPed.ForeColor = Color.White;
            BtnPed.Location = new Point(0, 64);
            BtnPed.Name = "BtnPed";
            BtnPed.Padding = new Padding(40, 0, 0, 0);
            BtnPed.Size = new Size(286, 51);
            BtnPed.TabIndex = 17;
            BtnPed.Text = "Pedidos";
            BtnPed.TextAlign = ContentAlignment.MiddleLeft;
            BtnPed.UseVisualStyleBackColor = false;
            BtnPed.Click += BtnPed_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Transparent;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 121);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(40, 0, 0, 0);
            btnProductos.Size = new Size(286, 51);
            btnProductos.TabIndex = 16;
            btnProductos.Text = "Productos Nuevos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 5);
            button4.Name = "button4";
            button4.Padding = new Padding(40, 0, 0, 0);
            button4.Size = new Size(286, 53);
            button4.TabIndex = 1;
            button4.Text = "Inventario";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // BtnProdu
            // 
            BtnProdu.BackColor = Color.White;
            BtnProdu.Dock = DockStyle.Top;
            BtnProdu.FlatAppearance.BorderSize = 0;
            BtnProdu.FlatStyle = FlatStyle.Flat;
            BtnProdu.ForeColor = Color.Black;
            BtnProdu.Location = new Point(0, 133);
            BtnProdu.Name = "BtnProdu";
            BtnProdu.Padding = new Padding(11, 0, 0, 0);
            BtnProdu.Size = new Size(301, 60);
            BtnProdu.TabIndex = 7;
            BtnProdu.Text = "Productos";
            BtnProdu.TextAlign = ContentAlignment.MiddleLeft;
            BtnProdu.UseVisualStyleBackColor = false;
            BtnProdu.Click += BtnProdu_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 133);
            panel3.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1298, 943);
            Controls.Add(panel2);
            Controls.Add(contenedor);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFacturacion.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelPersonas.ResumeLayout(false);
            PanelProduct.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnPedidos;
        private PictureBox pictureBox1;
        private Panel contenedor;
        private Panel panel2;
        private Panel PanelProduct;
        private Button btnProductos;
        private Button button4;
        private Button BtnProdu;
        private Panel panel3;
        private Button BtnPed;
        private Panel panelPersonas;
        private Button button1;
        private Button button3;
        private Button button6;
        private Panel panelFacturacion;
        private Button button2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button5;
        private Button button10;
    }
}