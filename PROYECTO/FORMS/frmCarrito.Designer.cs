using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmCarrito
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
            pictureBox1 = new PictureBox();
            lblNombre1 = new Label();
            lblPrecio1 = new Label();
            lblCantidad1 = new Label();
            lblTotal = new Label();
            btnQuitar1 = new Button();
            btnTerminar = new Button();
            pictureBox2 = new PictureBox();
            btnQuitar2 = new Button();
            lblCantidad2 = new Label();
            lblPrecio2 = new Label();
            lblNombre2 = new Label();
            btnQuitar3 = new Button();
            lblCantidad3 = new Label();
            lblPrecio3 = new Label();
            lblNombre3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnQuitar4 = new Button();
            lblCantidad4 = new Label();
            lblPrecio4 = new Label();
            lblNombre4 = new Label();
            btnsiguiente = new Button();
            anterior = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(49, 38);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblNombre1.Location = new Point(49, 190);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(69, 19);
            lblNombre1.TabIndex = 1;
            lblNombre1.Text = "Nombre";
            // 
            // lblPrecio1
            // 
            lblPrecio1.AutoSize = true;
            lblPrecio1.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblPrecio1.Location = new Point(49, 230);
            lblPrecio1.Name = "lblPrecio1";
            lblPrecio1.Size = new Size(54, 19);
            lblPrecio1.TabIndex = 2;
            lblPrecio1.Text = "Precio";
            // 
            // lblCantidad1
            // 
            lblCantidad1.AutoSize = true;
            lblCantidad1.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblCantidad1.Location = new Point(49, 278);
            lblCantidad1.Name = "lblCantidad1";
            lblCantidad1.Size = new Size(74, 19);
            lblCantidad1.TabIndex = 3;
            lblCantidad1.Text = "Cantidad";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(59, 456);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label2";
            
            // 
            // btnQuitar1
            // 
            btnQuitar1.Location = new Point(49, 314);
            btnQuitar1.Margin = new Padding(3, 4, 3, 4);
            btnQuitar1.Name = "btnQuitar1";
            btnQuitar1.Size = new Size(86, 30);
            btnQuitar1.TabIndex = 6;
            btnQuitar1.Text = "Eliminar";
            btnQuitar1.UseVisualStyleBackColor = true;
            
            // 
            // btnTerminar
            // 
            btnTerminar.Location = new Point(661, 456);
            btnTerminar.Margin = new Padding(3, 4, 3, 4);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(86, 30);
            btnTerminar.TabIndex = 7;
            btnTerminar.Text = "Finalizar";
            btnTerminar.UseVisualStyleBackColor = true;
            
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(230, 38);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            
            // 
            // btnQuitar2
            // 
            btnQuitar2.Location = new Point(230, 314);
            btnQuitar2.Margin = new Padding(3, 4, 3, 4);
            btnQuitar2.Name = "btnQuitar2";
            btnQuitar2.Size = new Size(86, 30);
            btnQuitar2.TabIndex = 12;
            btnQuitar2.Text = "Eliminar";
            btnQuitar2.UseVisualStyleBackColor = true;
            
            // 
            // lblCantidad2
            // 
            lblCantidad2.AutoSize = true;
            lblCantidad2.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblCantidad2.Location = new Point(230, 278);
            lblCantidad2.Name = "lblCantidad2";
            lblCantidad2.Size = new Size(74, 19);
            lblCantidad2.TabIndex = 11;
            lblCantidad2.Text = "Cantidad";
            // 
            // lblPrecio2
            // 
            lblPrecio2.AutoSize = true;
            lblPrecio2.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblPrecio2.Location = new Point(230, 230);
            lblPrecio2.Name = "lblPrecio2";
            lblPrecio2.Size = new Size(54, 19);
            lblPrecio2.TabIndex = 10;
            lblPrecio2.Text = "Precio";
            // 
            // lblNombre2
            // 
            lblNombre2.AutoSize = true;
            lblNombre2.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblNombre2.Location = new Point(230, 190);
            lblNombre2.Name = "lblNombre2";
            lblNombre2.Size = new Size(69, 19);
            lblNombre2.TabIndex = 9;
            lblNombre2.Text = "Nombre";
            // 
            // btnQuitar3
            // 
            btnQuitar3.Location = new Point(409, 314);
            btnQuitar3.Margin = new Padding(3, 4, 3, 4);
            btnQuitar3.Name = "btnQuitar3";
            btnQuitar3.Size = new Size(86, 30);
            btnQuitar3.TabIndex = 16;
            btnQuitar3.Text = "Eliminar";
            btnQuitar3.UseVisualStyleBackColor = true;
            
            // 
            // lblCantidad3
            // 
            lblCantidad3.AutoSize = true;
            lblCantidad3.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblCantidad3.Location = new Point(409, 278);
            lblCantidad3.Name = "lblCantidad3";
            lblCantidad3.Size = new Size(74, 19);
            lblCantidad3.TabIndex = 15;
            lblCantidad3.Text = "Cantidad";
            // 
            // lblPrecio3
            // 
            lblPrecio3.AutoSize = true;
            lblPrecio3.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblPrecio3.Location = new Point(409, 230);
            lblPrecio3.Name = "lblPrecio3";
            lblPrecio3.Size = new Size(54, 19);
            lblPrecio3.TabIndex = 14;
            lblPrecio3.Text = "Precio";
            // 
            // lblNombre3
            // 
            lblNombre3.AutoSize = true;
            lblNombre3.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblNombre3.Location = new Point(409, 190);
            lblNombre3.Name = "lblNombre3";
            lblNombre3.Size = new Size(69, 19);
            lblNombre3.TabIndex = 13;
            lblNombre3.Text = "Nombre";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(409, 38);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(600, 38);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 134);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // btnQuitar4
            // 
            btnQuitar4.Location = new Point(600, 314);
            btnQuitar4.Margin = new Padding(3, 4, 3, 4);
            btnQuitar4.Name = "btnQuitar4";
            btnQuitar4.Size = new Size(86, 30);
            btnQuitar4.TabIndex = 21;
            btnQuitar4.Text = "Eliminar";
            btnQuitar4.UseVisualStyleBackColor = true;
           
            // 
            // lblCantidad4
            // 
            lblCantidad4.AutoSize = true;
            lblCantidad4.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblCantidad4.Location = new Point(600, 278);
            lblCantidad4.Name = "lblCantidad4";
            lblCantidad4.Size = new Size(74, 19);
            lblCantidad4.TabIndex = 20;
            lblCantidad4.Text = "Cantidad";
            // 
            // lblPrecio4
            // 
            lblPrecio4.AutoSize = true;
            lblPrecio4.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblPrecio4.Location = new Point(600, 230);
            lblPrecio4.Name = "lblPrecio4";
            lblPrecio4.Size = new Size(54, 19);
            lblPrecio4.TabIndex = 19;
            lblPrecio4.Text = "Precio";
            // 
            // lblNombre4
            // 
            lblNombre4.AutoSize = true;
            lblNombre4.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            lblNombre4.Location = new Point(600, 190);
            lblNombre4.Name = "lblNombre4";
            lblNombre4.Size = new Size(69, 19);
            lblNombre4.TabIndex = 18;
            lblNombre4.Text = "Nombre";
            // 
            // btnsiguiente
            // 
            btnsiguiente.Location = new Point(513, 458);
            btnsiguiente.Margin = new Padding(3, 2, 3, 2);
            btnsiguiente.Name = "btnsiguiente";
            btnsiguiente.Size = new Size(113, 30);
            btnsiguiente.TabIndex = 23;
            btnsiguiente.Text = "Siguiente>>>";
            btnsiguiente.UseVisualStyleBackColor = true;
            btnsiguiente.Click += btnsiguiente_Click_1;
            // 
            // anterior
            // 
            anterior.Location = new Point(145, 458);
            anterior.Margin = new Padding(3, 2, 3, 2);
            anterior.Name = "anterior";
            anterior.Size = new Size(107, 30);
            anterior.TabIndex = 24;
            anterior.Text = "<<<Anterior";
            anterior.UseVisualStyleBackColor = true;
            anterior.Click += anterior_Click;
            // 
            // frmCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 534);
            Controls.Add(anterior);
            Controls.Add(btnsiguiente);
            Controls.Add(pictureBox4);
            Controls.Add(btnQuitar4);
            Controls.Add(lblCantidad4);
            Controls.Add(lblPrecio4);
            Controls.Add(lblNombre4);
            Controls.Add(pictureBox3);
            Controls.Add(btnQuitar3);
            Controls.Add(lblCantidad3);
            Controls.Add(lblPrecio3);
            Controls.Add(lblNombre3);
            Controls.Add(btnQuitar2);
            Controls.Add(lblCantidad2);
            Controls.Add(lblPrecio2);
            Controls.Add(lblNombre2);
            Controls.Add(pictureBox2);
            Controls.Add(btnTerminar);
            Controls.Add(btnQuitar1);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidad1);
            Controls.Add(lblPrecio1);
            Controls.Add(lblNombre1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCarrito";
            Text = "frmCarrito";
            Load += frmCarrito_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNombre1;
        private Label lblPrecio1;
        private Label lblCantidad1;
        private Label lblTotal;
        private Button btnQuitar1;
        private Button btnTerminar;
        private PictureBox pictureBox2;
        private Button btnQuitar2;
        private Label lblCantidad2;
        private Label lblPrecio2;
        private Label lblNombre2;
        private Button btnQuitar3;
        private Label lblCantidad3;
        private Label lblPrecio3;
        private Label lblNombre3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnQuitar4;
        private Label lblCantidad4;
        private Label lblPrecio4;
        private Label lblNombre4;
        private Button btnsiguiente;
        private Button anterior;
    }
}