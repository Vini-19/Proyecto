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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtDNI_Cliente = new TextBox();
            label7 = new Label();
            txtCorreo_Cliente = new TextBox();
            label6 = new Label();
            txtTelefono_Cliente = new TextBox();
            txtDireccion_Cliente = new TextBox();
            txtNombre_Cliente = new TextBox();
            txtRTN_Cliente = new TextBox();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvCliente = new DataGridView();
            label8 = new Label();
            txtBuscar = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(txtDNI_Cliente);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCorreo_Cliente);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTelefono_Cliente);
            panel1.Controls.Add(txtDireccion_Cliente);
            panel1.Controls.Add(txtNombre_Cliente);
            panel1.Controls.Add(txtRTN_Cliente);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 592);
            panel1.TabIndex = 0;
            // 
            // txtDNI_Cliente
            // 
            txtDNI_Cliente.Location = new Point(40, 154);
            txtDNI_Cliente.Name = "txtDNI_Cliente";
            txtDNI_Cliente.Size = new Size(188, 27);
            txtDNI_Cliente.TabIndex = 19;
            txtDNI_Cliente.TextChanged += txtDNI_Cliente_TextChanged;
            txtDNI_Cliente.KeyPress += txtDNI_Cliente_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 130);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 18;
            label7.Text = "DNI";
            // 
            // txtCorreo_Cliente
            // 
            txtCorreo_Cliente.Location = new Point(40, 435);
            txtCorreo_Cliente.Name = "txtCorreo_Cliente";
            txtCorreo_Cliente.Size = new Size(188, 27);
            txtCorreo_Cliente.TabIndex = 17;
            txtCorreo_Cliente.TextChanged += txtCorreo_Cliente_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 412);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 16;
            label6.Text = "Correo Electrónico ";
            // 
            // txtTelefono_Cliente
            // 
            txtTelefono_Cliente.Location = new Point(40, 382);
            txtTelefono_Cliente.Name = "txtTelefono_Cliente";
            txtTelefono_Cliente.Size = new Size(188, 27);
            txtTelefono_Cliente.TabIndex = 15;
            txtTelefono_Cliente.TextChanged += txtTelefono_Cliente_TextChanged;
            txtTelefono_Cliente.KeyPress += txtTelefono_Cliente_KeyPress;
            // 
            // txtDireccion_Cliente
            // 
            txtDireccion_Cliente.Location = new Point(40, 284);
            txtDireccion_Cliente.Multiline = true;
            txtDireccion_Cliente.Name = "txtDireccion_Cliente";
            txtDireccion_Cliente.Size = new Size(188, 72);
            txtDireccion_Cliente.TabIndex = 14;
            txtDireccion_Cliente.TextChanged += txtDireccion_Cliente_TextChanged;
            // 
            // txtNombre_Cliente
            // 
            txtNombre_Cliente.Location = new Point(40, 220);
            txtNombre_Cliente.Name = "txtNombre_Cliente";
            txtNombre_Cliente.Size = new Size(188, 27);
            txtNombre_Cliente.TabIndex = 13;
            txtNombre_Cliente.TextChanged += txtNombre_Cliente_TextChanged;
            txtNombre_Cliente.KeyPress += txtNombre_Cliente_KeyPress;
            // 
            // txtRTN_Cliente
            // 
            txtRTN_Cliente.Location = new Point(40, 96);
            txtRTN_Cliente.Name = "txtRTN_Cliente";
            txtRTN_Cliente.Size = new Size(188, 27);
            txtRTN_Cliente.TabIndex = 1;
            txtRTN_Cliente.TextChanged += txtRTN_Cliente_TextChanged;
            txtRTN_Cliente.KeyPress += txtRTN_Cliente_KeyPress;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(148, 541);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(29, 541);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(148, 494);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(29, 494);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 359);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 73);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 5;
            label5.Text = "RTN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 259);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 196);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 30);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 2;
            label2.Text = "Registro de Clientes";
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(286, 51);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(638, 562);
            dgvCliente.TabIndex = 1;
            dgvCliente.CellClick += dgvCliente_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 21);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 2;
            label8.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(370, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(542, 27);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 635);
            Controls.Add(txtBuscar);
            Controls.Add(label8);
            Controls.Add(dgvCliente);
            Controls.Add(panel1);
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}