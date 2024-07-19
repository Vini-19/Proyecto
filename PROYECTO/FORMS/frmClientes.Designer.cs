using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo
{
    partial class frmClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDNI_Cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo_Cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono_Cliente = new System.Windows.Forms.TextBox();
            this.txtDireccion_Cliente = new System.Windows.Forms.TextBox();
            this.txtNombre_Cliente = new System.Windows.Forms.TextBox();
            this.txtRTN_Cliente = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.txtDNI_Cliente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCorreo_Cliente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTelefono_Cliente);
            this.panel1.Controls.Add(this.txtDireccion_Cliente);
            this.panel1.Controls.Add(this.txtNombre_Cliente);
            this.panel1.Controls.Add(this.txtRTN_Cliente);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(98, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 385);
            this.panel1.TabIndex = 0;
            // 
            // txtDNI_Cliente
            // 
            this.txtDNI_Cliente.Location = new System.Drawing.Point(30, 100);
            this.txtDNI_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI_Cliente.Name = "txtDNI_Cliente";
            this.txtDNI_Cliente.Size = new System.Drawing.Size(142, 20);
            this.txtDNI_Cliente.TabIndex = 19;
            this.txtDNI_Cliente.TextChanged += new System.EventHandler(this.txtDNI_Cliente_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "DNI";
            // 
            // txtCorreo_Cliente
            // 
            this.txtCorreo_Cliente.Location = new System.Drawing.Point(30, 283);
            this.txtCorreo_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo_Cliente.Name = "txtCorreo_Cliente";
            this.txtCorreo_Cliente.Size = new System.Drawing.Size(142, 20);
            this.txtCorreo_Cliente.TabIndex = 17;
            this.txtCorreo_Cliente.TextChanged += new System.EventHandler(this.txtCorreo_Cliente_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo Electrónico ";
            // 
            // txtTelefono_Cliente
            // 
            this.txtTelefono_Cliente.Location = new System.Drawing.Point(30, 248);
            this.txtTelefono_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono_Cliente.Name = "txtTelefono_Cliente";
            this.txtTelefono_Cliente.Size = new System.Drawing.Size(142, 20);
            this.txtTelefono_Cliente.TabIndex = 15;
            this.txtTelefono_Cliente.TextChanged += new System.EventHandler(this.txtTelefono_Cliente_TextChanged_1);
            // 
            // txtDireccion_Cliente
            // 
            this.txtDireccion_Cliente.Location = new System.Drawing.Point(30, 185);
            this.txtDireccion_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion_Cliente.Multiline = true;
            this.txtDireccion_Cliente.Name = "txtDireccion_Cliente";
            this.txtDireccion_Cliente.Size = new System.Drawing.Size(142, 48);
            this.txtDireccion_Cliente.TabIndex = 14;
            this.txtDireccion_Cliente.TextChanged += new System.EventHandler(this.txtDireccion_Cliente_TextChanged_1);
            // 
            // txtNombre_Cliente
            // 
            this.txtNombre_Cliente.Location = new System.Drawing.Point(30, 143);
            this.txtNombre_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Cliente.Name = "txtNombre_Cliente";
            this.txtNombre_Cliente.Size = new System.Drawing.Size(142, 20);
            this.txtNombre_Cliente.TabIndex = 13;
            this.txtNombre_Cliente.TextChanged += new System.EventHandler(this.txtNombre_Cliente_TextChanged_1);
            // 
            // txtRTN_Cliente
            // 
            this.txtRTN_Cliente.Location = new System.Drawing.Point(30, 62);
            this.txtRTN_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtRTN_Cliente.Name = "txtRTN_Cliente";
            this.txtRTN_Cliente.Size = new System.Drawing.Size(142, 20);
            this.txtRTN_Cliente.TabIndex = 1;
            this.txtRTN_Cliente.TextChanged += new System.EventHandler(this.txtRTN_Cliente_TextChanged_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(111, 352);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 19);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(22, 352);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 19);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(111, 321);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 19);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 321);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 19);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "RTN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro de Clientes";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(312, 133);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.Size = new System.Drawing.Size(903, 365);
            this.dgvCliente.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(376, 112);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(528, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(416, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(457, 50);
            this.label13.TabIndex = 9;
            this.label13.Text = "REGISTRO DE CLIENTES";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 685);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private TextBox txtTelefono_Cliente;
        private TextBox txtDireccion_Cliente;
        private TextBox txtNombre_Cliente;
        private TextBox txtRTN_Cliente;
        private DataGridView dgvCliente;
        private TextBox txtCorreo_Cliente;
        private Label label6;
        private TextBox txtDNI_Cliente;
        private Label label7;
        private Label label8;
        private TextBox txtBuscar;
        private ErrorProvider errorProvider1;
        private Label label13;
    }
}