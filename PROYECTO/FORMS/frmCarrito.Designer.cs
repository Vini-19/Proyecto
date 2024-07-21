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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.lblCantidad1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnQuitar1 = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnQuitar2 = new System.Windows.Forms.Button();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.btnQuitar3 = new System.Windows.Forms.Button();
            this.lblCantidad3 = new System.Windows.Forms.Label();
            this.lblPrecio3 = new System.Windows.Forms.Label();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnQuitar4 = new System.Windows.Forms.Button();
            this.lblCantidad4 = new System.Windows.Forms.Label();
            this.lblPrecio4 = new System.Windows.Forms.Label();
            this.lblNombre4 = new System.Windows.Forms.Label();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(330, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre1.Location = new System.Drawing.Point(327, 242);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(68, 18);
            this.lblNombre1.TabIndex = 1;
            this.lblNombre1.Text = "Nombre";
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio1.Location = new System.Drawing.Point(327, 276);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio1.TabIndex = 2;
            this.lblPrecio1.Text = "Precio";
            // 
            // lblCantidad1
            // 
            this.lblCantidad1.AutoSize = true;
            this.lblCantidad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad1.Location = new System.Drawing.Point(327, 314);
            this.lblCantidad1.Name = "lblCantidad1";
            this.lblCantidad1.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad1.TabIndex = 3;
            this.lblCantidad1.Text = "Cantidad";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(357, 455);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "label2";
            // 
            // btnQuitar1
            // 
            this.btnQuitar1.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar1.ForeColor = System.Drawing.Color.White;
            this.btnQuitar1.Location = new System.Drawing.Point(360, 342);
            this.btnQuitar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar1.Name = "btnQuitar1";
            this.btnQuitar1.Size = new System.Drawing.Size(85, 36);
            this.btnQuitar1.TabIndex = 6;
            this.btnQuitar1.Text = "Eliminar";
            this.btnQuitar1.UseVisualStyleBackColor = false;
            this.btnQuitar1.Click += new System.EventHandler(this.btnQuitar1_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.White;
            this.btnTerminar.FlatAppearance.BorderSize = 4;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTerminar.Location = new System.Drawing.Point(978, 458);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(94, 38);
            this.btnTerminar.TabIndex = 7;
            this.btnTerminar.Text = "Finalizar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(506, 107);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnQuitar2
            // 
            this.btnQuitar2.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar2.ForeColor = System.Drawing.Color.White;
            this.btnQuitar2.Location = new System.Drawing.Point(538, 342);
            this.btnQuitar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar2.Name = "btnQuitar2";
            this.btnQuitar2.Size = new System.Drawing.Size(85, 36);
            this.btnQuitar2.TabIndex = 12;
            this.btnQuitar2.Text = "Eliminar";
            this.btnQuitar2.UseVisualStyleBackColor = false;
            this.btnQuitar2.Click += new System.EventHandler(this.btnQuitar2_Click);
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad2.Location = new System.Drawing.Point(503, 314);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad2.TabIndex = 11;
            this.lblCantidad2.Text = "Cantidad";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio2.Location = new System.Drawing.Point(503, 276);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio2.TabIndex = 10;
            this.lblPrecio2.Text = "Precio";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre2.Location = new System.Drawing.Point(503, 242);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(68, 18);
            this.lblNombre2.TabIndex = 9;
            this.lblNombre2.Text = "Nombre";
            // 
            // btnQuitar3
            // 
            this.btnQuitar3.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar3.ForeColor = System.Drawing.Color.White;
            this.btnQuitar3.Location = new System.Drawing.Point(711, 342);
            this.btnQuitar3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar3.Name = "btnQuitar3";
            this.btnQuitar3.Size = new System.Drawing.Size(85, 36);
            this.btnQuitar3.TabIndex = 16;
            this.btnQuitar3.Text = "Eliminar";
            this.btnQuitar3.UseVisualStyleBackColor = false;
            this.btnQuitar3.Click += new System.EventHandler(this.btnQuitar3_Click);
            // 
            // lblCantidad3
            // 
            this.lblCantidad3.AutoSize = true;
            this.lblCantidad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad3.Location = new System.Drawing.Point(676, 314);
            this.lblCantidad3.Name = "lblCantidad3";
            this.lblCantidad3.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad3.TabIndex = 15;
            this.lblCantidad3.Text = "Cantidad";
            // 
            // lblPrecio3
            // 
            this.lblPrecio3.AutoSize = true;
            this.lblPrecio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio3.Location = new System.Drawing.Point(676, 276);
            this.lblPrecio3.Name = "lblPrecio3";
            this.lblPrecio3.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio3.TabIndex = 14;
            this.lblPrecio3.Text = "Precio";
            // 
            // lblNombre3
            // 
            this.lblNombre3.AutoSize = true;
            this.lblNombre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre3.Location = new System.Drawing.Point(676, 242);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(68, 18);
            this.lblNombre3.TabIndex = 13;
            this.lblNombre3.Text = "Nombre";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(679, 107);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnQuitar3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(847, 107);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(137, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // btnQuitar4
            // 
            this.btnQuitar4.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar4.ForeColor = System.Drawing.Color.White;
            this.btnQuitar4.Location = new System.Drawing.Point(854, 342);
            this.btnQuitar4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar4.Name = "btnQuitar4";
            this.btnQuitar4.Size = new System.Drawing.Size(85, 36);
            this.btnQuitar4.TabIndex = 21;
            this.btnQuitar4.Text = "Eliminar";
            this.btnQuitar4.UseVisualStyleBackColor = false;
            this.btnQuitar4.Click += new System.EventHandler(this.btnQuitar4_Click);
            // 
            // lblCantidad4
            // 
            this.lblCantidad4.AutoSize = true;
            this.lblCantidad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad4.Location = new System.Drawing.Point(851, 314);
            this.lblCantidad4.Name = "lblCantidad4";
            this.lblCantidad4.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad4.TabIndex = 20;
            this.lblCantidad4.Text = "Cantidad";
            // 
            // lblPrecio4
            // 
            this.lblPrecio4.AutoSize = true;
            this.lblPrecio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio4.Location = new System.Drawing.Point(846, 276);
            this.lblPrecio4.Name = "lblPrecio4";
            this.lblPrecio4.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio4.TabIndex = 19;
            this.lblPrecio4.Text = "Precio";
            // 
            // lblNombre4
            // 
            this.lblNombre4.AutoSize = true;
            this.lblNombre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre4.Location = new System.Drawing.Point(846, 242);
            this.lblNombre4.Name = "lblNombre4";
            this.lblNombre4.Size = new System.Drawing.Size(68, 18);
            this.lblNombre4.TabIndex = 18;
            this.lblNombre4.Text = "Nombre";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.White;
            this.btnsiguiente.FlatAppearance.BorderSize = 4;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.ForeColor = System.Drawing.Color.Firebrick;
            this.btnsiguiente.Location = new System.Drawing.Point(810, 458);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(115, 38);
            this.btnsiguiente.TabIndex = 23;
            this.btnsiguiente.Text = "Siguiente>>>";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click_1);
            // 
            // anterior
            // 
            this.anterior.BackColor = System.Drawing.Color.White;
            this.anterior.FlatAppearance.BorderSize = 4;
            this.anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anterior.ForeColor = System.Drawing.Color.Firebrick;
            this.anterior.Location = new System.Drawing.Point(444, 458);
            this.anterior.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(113, 38);
            this.anterior.TabIndex = 24;
            this.anterior.Text = "<<<Anterior";
            this.anterior.UseVisualStyleBackColor = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // frmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 721);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnQuitar4);
            this.Controls.Add(this.lblCantidad4);
            this.Controls.Add(this.lblPrecio4);
            this.Controls.Add(this.lblNombre4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnQuitar3);
            this.Controls.Add(this.lblCantidad3);
            this.Controls.Add(this.lblPrecio3);
            this.Controls.Add(this.lblNombre3);
            this.Controls.Add(this.btnQuitar2);
            this.Controls.Add(this.lblCantidad2);
            this.Controls.Add(this.lblPrecio2);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnQuitar1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad1);
            this.Controls.Add(this.lblPrecio1);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCarrito";
            this.Text = "frmCarrito";
            this.Load += new System.EventHandler(this.frmCarrito_Load);
            this.Click += new System.EventHandler(this.frmCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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