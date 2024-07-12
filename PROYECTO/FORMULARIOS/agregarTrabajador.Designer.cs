namespace Proyecto_de_desarrolo.Formularios
{
    partial class agregarTrabajador
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
            txtBuscar = new TextBox();
            txtDNI_Trabajador = new TextBox();
            label7 = new Label();
            txtCorreo_Trabajador = new TextBox();
            label6 = new Label();
            txtTelefono_Trabajador = new TextBox();
            txtDireccion_Trabajador = new TextBox();
            txtNombre_Trabajador = new TextBox();
            txtRTN_Trabajador = new TextBox();
            btnEliminar = new Button();
            dgvTrabajador = new DataGridView();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            btnModificar = new Button();
            panel1 = new Panel();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajador).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(370, 22);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(794, 23);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // txtDNI_Trabajador
            // 
            txtDNI_Trabajador.Location = new Point(35, 116);
            txtDNI_Trabajador.Margin = new Padding(3, 2, 3, 2);
            txtDNI_Trabajador.Name = "txtDNI_Trabajador";
            txtDNI_Trabajador.Size = new Size(165, 23);
            txtDNI_Trabajador.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 98);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 18;
            label7.Text = "DNI";
            // 
            // txtCorreo_Trabajador
            // 
            txtCorreo_Trabajador.Location = new Point(35, 307);
            txtCorreo_Trabajador.Margin = new Padding(3, 2, 3, 2);
            txtCorreo_Trabajador.Name = "txtCorreo_Trabajador";
            txtCorreo_Trabajador.Size = new Size(165, 23);
            txtCorreo_Trabajador.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 290);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 16;
            label6.Text = "Correo Electrónico ";
            // 
            // txtTelefono_Trabajador
            // 
            txtTelefono_Trabajador.Location = new Point(35, 259);
            txtTelefono_Trabajador.Margin = new Padding(3, 2, 3, 2);
            txtTelefono_Trabajador.Name = "txtTelefono_Trabajador";
            txtTelefono_Trabajador.Size = new Size(165, 23);
            txtTelefono_Trabajador.TabIndex = 15;
            // 
            // txtDireccion_Trabajador
            // 
            txtDireccion_Trabajador.Location = new Point(35, 213);
            txtDireccion_Trabajador.Margin = new Padding(3, 2, 3, 2);
            txtDireccion_Trabajador.Name = "txtDireccion_Trabajador";
            txtDireccion_Trabajador.Size = new Size(165, 23);
            txtDireccion_Trabajador.TabIndex = 14;
            // 
            // txtNombre_Trabajador
            // 
            txtNombre_Trabajador.Location = new Point(35, 165);
            txtNombre_Trabajador.Margin = new Padding(3, 2, 3, 2);
            txtNombre_Trabajador.Name = "txtNombre_Trabajador";
            txtNombre_Trabajador.Size = new Size(165, 23);
            txtNombre_Trabajador.TabIndex = 13;
            // 
            // txtRTN_Trabajador
            // 
            txtRTN_Trabajador.Location = new Point(35, 72);
            txtRTN_Trabajador.Margin = new Padding(3, 2, 3, 2);
            txtRTN_Trabajador.Name = "txtRTN_Trabajador";
            txtRTN_Trabajador.Size = new Size(165, 23);
            txtRTN_Trabajador.TabIndex = 1;
            txtRTN_Trabajador.TextChanged += txtRTN_Cliente_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(131, 518);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTrabajador
            // 
            dgvTrabajador.AllowUserToAddRows = false;
            dgvTrabajador.AllowUserToDeleteRows = false;
            dgvTrabajador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajador.Location = new Point(297, 47);
            dgvTrabajador.Margin = new Padding(3, 2, 3, 2);
            dgvTrabajador.Name = "dgvTrabajador";
            dgvTrabajador.ReadOnly = true;
            dgvTrabajador.RowHeadersWidth = 51;
            dgvTrabajador.Size = new Size(867, 591);
            dgvTrabajador.TabIndex = 5;
            dgvTrabajador.CellContentClick += dgvCliente_CellContentClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(26, 519);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 22);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(26, 482);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 242);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 55);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 5;
            label5.Text = "RTN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 194);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 22);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 2;
            label2.Text = "Registro de Trabajadores";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(297, 25);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 6;
            label8.Text = "Buscar:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(131, 482);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtDNI_Trabajador);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCorreo_Trabajador);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTelefono_Trabajador);
            panel1.Controls.Add(txtDireccion_Trabajador);
            panel1.Controls.Add(txtNombre_Trabajador);
            panel1.Controls.Add(txtRTN_Trabajador);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(46, 25);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 613);
            panel1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Location = new Point(52, 350);
            label9.Name = "label9";
            label9.Size = new Size(143, 15);
            label9.TabIndex = 20;
            label9.Text = "Credenciales Para Usuario";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(35, 384);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 427);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 367);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 23;
            label10.Text = "Usuario";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 410);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 24;
            label11.Text = "Contraseña";
            // 
            // agregarTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 676);
            Controls.Add(txtBuscar);
            Controls.Add(dgvTrabajador);
            Controls.Add(label8);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "agregarTrabajador";
            Text = "agregarTrabajador";
            Load += agregarTrabajador_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrabajador).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private TextBox txtDNI_Trabajador;
        private Label label7;
        private TextBox txtCorreo_Trabajador;
        private Label label6;
        private TextBox txtTelefono_Trabajador;
        private TextBox txtDireccion_Trabajador;
        private TextBox txtNombre_Trabajador;
        private TextBox txtRTN_Trabajador;
        private Button btnEliminar;
        private DataGridView dgvTrabajador;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Button btnModificar;
        private Panel panel1;
        private Label label11;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
    }
}