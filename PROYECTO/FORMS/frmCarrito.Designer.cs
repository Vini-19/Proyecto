﻿using System.Drawing;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarrito));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCantidad1 = new System.Windows.Forms.Label();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCantidad3 = new System.Windows.Forms.Label();
            this.lblPrecio3 = new System.Windows.Forms.Label();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCantidad4 = new System.Windows.Forms.Label();
            this.lblPrecio4 = new System.Windows.Forms.Label();
            this.lblNombre4 = new System.Windows.Forms.Label();
            this.btnQuitar4 = new System.Windows.Forms.Button();
            this.btnQuitar3 = new System.Windows.Forms.Button();
            this.btnQuitar2 = new System.Windows.Forms.Button();
            this.btnQuitar1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.lblVacio = new System.Windows.Forms.Label();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.lblVacio);
            this.panel2.Controls.Add(this.btnTerminar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnQuitar4);
            this.panel2.Controls.Add(this.btnQuitar3);
            this.panel2.Controls.Add(this.btnQuitar2);
            this.panel2.Controls.Add(this.btnQuitar1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.lblCantidad4);
            this.panel2.Controls.Add(this.lblPrecio4);
            this.panel2.Controls.Add(this.lblNombre4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblCantidad3);
            this.panel2.Controls.Add(this.lblPrecio3);
            this.panel2.Controls.Add(this.lblNombre3);
            this.panel2.Controls.Add(this.lblCantidad2);
            this.panel2.Controls.Add(this.lblPrecio2);
            this.panel2.Controls.Add(this.lblNombre2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblCantidad1);
            this.panel2.Controls.Add(this.lblPrecio1);
            this.panel2.Controls.Add(this.lblNombre1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(64, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 616);
            this.panel2.TabIndex = 29;
            // 
            // lblCantidad1
            // 
            this.lblCantidad1.AutoSize = true;
            this.lblCantidad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad1.Location = new System.Drawing.Point(227, 357);
            this.lblCantidad1.Name = "lblCantidad1";
            this.lblCantidad1.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad1.TabIndex = 7;
            this.lblCantidad1.Text = "Cantidad";
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio1.Location = new System.Drawing.Point(227, 319);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio1.TabIndex = 6;
            this.lblPrecio1.Text = "Precio";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre1.Location = new System.Drawing.Point(227, 285);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(68, 18);
            this.lblNombre1.TabIndex = 5;
            this.lblNombre1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(231, 150);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad2.Location = new System.Drawing.Point(433, 357);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad2.TabIndex = 15;
            this.lblCantidad2.Text = "Cantidad";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio2.Location = new System.Drawing.Point(433, 319);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio2.TabIndex = 14;
            this.lblPrecio2.Text = "Precio";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre2.Location = new System.Drawing.Point(433, 285);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(68, 18);
            this.lblNombre2.TabIndex = 13;
            this.lblNombre2.Text = "Nombre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(436, 150);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(626, 150);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // lblCantidad3
            // 
            this.lblCantidad3.AutoSize = true;
            this.lblCantidad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad3.Location = new System.Drawing.Point(623, 357);
            this.lblCantidad3.Name = "lblCantidad3";
            this.lblCantidad3.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad3.TabIndex = 20;
            this.lblCantidad3.Text = "Cantidad";
            // 
            // lblPrecio3
            // 
            this.lblPrecio3.AutoSize = true;
            this.lblPrecio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio3.Location = new System.Drawing.Point(623, 319);
            this.lblPrecio3.Name = "lblPrecio3";
            this.lblPrecio3.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio3.TabIndex = 19;
            this.lblPrecio3.Text = "Precio";
            // 
            // lblNombre3
            // 
            this.lblNombre3.AutoSize = true;
            this.lblNombre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre3.Location = new System.Drawing.Point(623, 285);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(68, 18);
            this.lblNombre3.TabIndex = 18;
            this.lblNombre3.Text = "Nombre";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Location = new System.Drawing.Point(813, 150);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(137, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // lblCantidad4
            // 
            this.lblCantidad4.AutoSize = true;
            this.lblCantidad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad4.Location = new System.Drawing.Point(810, 357);
            this.lblCantidad4.Name = "lblCantidad4";
            this.lblCantidad4.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad4.TabIndex = 25;
            this.lblCantidad4.Text = "Cantidad";
            // 
            // lblPrecio4
            // 
            this.lblPrecio4.AutoSize = true;
            this.lblPrecio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio4.Location = new System.Drawing.Point(810, 319);
            this.lblPrecio4.Name = "lblPrecio4";
            this.lblPrecio4.Size = new System.Drawing.Size(57, 18);
            this.lblPrecio4.TabIndex = 24;
            this.lblPrecio4.Text = "Precio";
            // 
            // lblNombre4
            // 
            this.lblNombre4.AutoSize = true;
            this.lblNombre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre4.Location = new System.Drawing.Point(810, 285);
            this.lblNombre4.Name = "lblNombre4";
            this.lblNombre4.Size = new System.Drawing.Size(68, 18);
            this.lblNombre4.TabIndex = 23;
            this.lblNombre4.Text = "Nombre";
            // 
            // btnQuitar4
            // 
            this.btnQuitar4.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar4.ForeColor = System.Drawing.Color.White;
            this.btnQuitar4.Location = new System.Drawing.Point(852, 395);
            this.btnQuitar4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar4.Name = "btnQuitar4";
            this.btnQuitar4.Size = new System.Drawing.Size(85, 36);
            this.btnQuitar4.TabIndex = 30;
            this.btnQuitar4.Text = "Eliminar";
            this.btnQuitar4.UseVisualStyleBackColor = false;
            this.btnQuitar4.Click += new System.EventHandler(this.btnQuitar4_Click);
            // 
            // btnQuitar3
            // 
            this.btnQuitar3.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar3.ForeColor = System.Drawing.Color.White;
            this.btnQuitar3.Location = new System.Drawing.Point(658, 395);
            this.btnQuitar3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar3.Name = "btnQuitar3";
            this.btnQuitar3.Size = new System.Drawing.Size(85, 36);
            this.btnQuitar3.TabIndex = 29;
            this.btnQuitar3.Text = "Eliminar";
            this.btnQuitar3.UseVisualStyleBackColor = false;
            this.btnQuitar3.Click += new System.EventHandler(this.btnQuitar3_Click);
            // 
            // btnQuitar2
            // 
            this.btnQuitar2.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar2.ForeColor = System.Drawing.Color.White;
            this.btnQuitar2.Location = new System.Drawing.Point(459, 395);
            this.btnQuitar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar2.Name = "btnQuitar2";
            this.btnQuitar2.Size = new System.Drawing.Size(85, 36);
            this.btnQuitar2.TabIndex = 28;
            this.btnQuitar2.Text = "Eliminar";
            this.btnQuitar2.UseVisualStyleBackColor = false;
            this.btnQuitar2.Click += new System.EventHandler(this.btnQuitar2_Click);
            // 
            // btnQuitar1
            // 
            this.btnQuitar1.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar1.ForeColor = System.Drawing.Color.White;
            this.btnQuitar1.Location = new System.Drawing.Point(264, 395);
            this.btnQuitar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar1.Name = "btnQuitar1";
            this.btnQuitar1.Size = new System.Drawing.Size(85, 36);
            this.btnQuitar1.TabIndex = 27;
            this.btnQuitar1.Text = "Eliminar";
            this.btnQuitar1.UseVisualStyleBackColor = false;
            this.btnQuitar1.Click += new System.EventHandler(this.btnQuitar1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(886, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 37);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "TOTAL PAGAR:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(191, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(135, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "LPS.";
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.Color.Black;
            this.btnTerminar.Location = new System.Drawing.Point(989, 108);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(93, 38);
            this.btnTerminar.TabIndex = 33;
            this.btnTerminar.Text = "Finalizar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // lblVacio
            // 
            this.lblVacio.AutoSize = true;
            this.lblVacio.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacio.Location = new System.Drawing.Point(337, 269);
            this.lblVacio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVacio.Name = "lblVacio";
            this.lblVacio.Size = new System.Drawing.Size(515, 68);
            this.lblVacio.TabIndex = 34;
            this.lblVacio.Text = "CARRITO VACIO";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.White;
            this.btnsiguiente.FlatAppearance.BorderSize = 4;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.ForeColor = System.Drawing.Color.Firebrick;
            this.btnsiguiente.Location = new System.Drawing.Point(794, 759);
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
            this.anterior.Location = new System.Drawing.Point(427, 759);
            this.anterior.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(113, 38);
            this.anterior.TabIndex = 24;
            this.anterior.Text = "<<<Anterior";
            this.anterior.UseVisualStyleBackColor = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(175, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 36;
            this.button1.Text = "<<<Anterior";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.anterior_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(886, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 35;
            this.button2.Text = "Siguiente>>>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnsiguiente_Click_1);
            // 
            // frmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.btnsiguiente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCarrito";
            this.Text = "frmCarrito";
            this.Load += new System.EventHandler(this.frmCarrito_Load);
            this.Click += new System.EventHandler(this.frmCarrito_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label lblVacio;
        private Button btnTerminar;
        private Panel panel1;
        private Label label2;
        private Label lblTotal;
        private Label label1;
        private Button btnQuitar4;
        private Button btnQuitar3;
        private Button btnQuitar2;
        private Button btnQuitar1;
        private PictureBox pictureBox4;
        private Label lblCantidad4;
        private Label lblPrecio4;
        private Label lblNombre4;
        private PictureBox pictureBox3;
        private Label lblCantidad3;
        private Label lblPrecio3;
        private Label lblNombre3;
        private Label lblCantidad2;
        private Label lblPrecio2;
        private Label lblNombre2;
        private PictureBox pictureBox2;
        private Label lblCantidad1;
        private Label lblPrecio1;
        private Label lblNombre1;
        private PictureBox pictureBox1;
        private Button btnsiguiente;
        private Button anterior;
    }
}