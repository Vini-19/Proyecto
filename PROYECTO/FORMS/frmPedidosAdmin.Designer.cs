using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmPedidosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosAdmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumPed = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPendiente = new System.Windows.Forms.Button();
            this.btnAceptados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.lblNombre_Cliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(482, 412);
            this.dataGridView1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "PEDIDO #";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(1039, 505);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(211, 36);
            this.btnConfirmar.TabIndex = 28;
            this.btnConfirmar.Text = "Confirmar Pedido";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(871, 130);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 16);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "label6";
            // 
            // lblNumPed
            // 
            this.lblNumPed.AutoSize = true;
            this.lblNumPed.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPed.Location = new System.Drawing.Point(252, 47);
            this.lblNumPed.Name = "lblNumPed";
            this.lblNumPed.Size = new System.Drawing.Size(38, 36);
            this.lblNumPed.TabIndex = 34;
            this.lblNumPed.Text = "N";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.FlatAppearance.BorderSize = 4;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.Location = new System.Drawing.Point(889, 614);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(107, 48);
            this.btnSiguiente.TabIndex = 35;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAnterior.FlatAppearance.BorderSize = 4;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAnterior.Location = new System.Drawing.Point(394, 614);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(107, 48);
            this.btnAnterior.TabIndex = 36;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPendiente
            // 
            this.btnPendiente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPendiente.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnPendiente.FlatAppearance.BorderSize = 4;
            this.btnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendiente.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPendiente.Location = new System.Drawing.Point(1075, 300);
            this.btnPendiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(147, 55);
            this.btnPendiente.TabIndex = 38;
            this.btnPendiente.Text = "Pedidos Pendientes";
            this.btnPendiente.UseVisualStyleBackColor = false;
            this.btnPendiente.Click += new System.EventHandler(this.btnPendiente_Click);
            // 
            // btnAceptados
            // 
            this.btnAceptados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptados.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAceptados.FlatAppearance.BorderSize = 4;
            this.btnAceptados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptados.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAceptados.Location = new System.Drawing.Point(1075, 383);
            this.btnAceptados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptados.Name = "btnAceptados";
            this.btnAceptados.Size = new System.Drawing.Size(147, 57);
            this.btnAceptados.TabIndex = 39;
            this.btnAceptados.Text = "Pedidos Aceptados";
            this.btnAceptados.UseVisualStyleBackColor = false;
            this.btnAceptados.Click += new System.EventHandler(this.btnAceptados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAceptados);
            this.panel1.Controls.Add(this.btnPendiente);
            this.panel1.Controls.Add(this.lblPedido);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.lblNumPed);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblIdentidad);
            this.panel1.Controls.Add(this.lblNombre_Cliente);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(47, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 729);
            this.panel1.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatAppearance.BorderSize = 4;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Location = new System.Drawing.Point(1075, 224);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 55);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar Pedidos";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(788, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Fecha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(788, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Dirección:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(788, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Identidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nombre del Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Pedido ID:";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(580, 64);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(44, 16);
            this.lblPedido.TabIndex = 37;
            this.lblPedido.Text = "label6";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(871, 98);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(44, 16);
            this.lblDireccion.TabIndex = 32;
            this.lblDireccion.Text = "label5";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(871, 64);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(44, 16);
            this.lblTelefono.TabIndex = 31;
            this.lblTelefono.Text = "label4";
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Location = new System.Drawing.Point(580, 130);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(44, 16);
            this.lblIdentidad.TabIndex = 30;
            this.lblIdentidad.Text = "label3";
            // 
            // lblNombre_Cliente
            // 
            this.lblNombre_Cliente.AutoSize = true;
            this.lblNombre_Cliente.Location = new System.Drawing.Point(580, 98);
            this.lblNombre_Cliente.Name = "lblNombre_Cliente";
            this.lblNombre_Cliente.Size = new System.Drawing.Size(44, 16);
            this.lblNombre_Cliente.TabIndex = 29;
            this.lblNombre_Cliente.Text = "label2";
            // 
            // frmPedidosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 745);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPedidosAdmin";
            this.Text = "frmPedidosAdmin";
            this.Load += new System.EventHandler(this.frmPedidosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnConfirmar;
        private Label lblFecha;
        private Label lblNumPed;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPendiente;
        private Button btnAceptados;
        private Panel panel1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblPedido;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblIdentidad;
        private Label lblNombre_Cliente;
        private Button btnCancelar;
    }
}