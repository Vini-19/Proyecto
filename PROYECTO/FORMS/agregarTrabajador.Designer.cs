using System.Drawing;
using System.Windows.Forms;

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
            components = new System.ComponentModel.Container();
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
            txtCodigo = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label9 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvTrabajador).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(423, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(907, 27);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // txtDNI_Trabajador
            // 
            txtDNI_Trabajador.Location = new Point(40, 149);
            txtDNI_Trabajador.Name = "txtDNI_Trabajador";
            txtDNI_Trabajador.Size = new Size(188, 27);
            txtDNI_Trabajador.TabIndex = 19;
            txtDNI_Trabajador.TextChanged += txtDNI_Trabajador_TextChanged;
            txtDNI_Trabajador.KeyPress += txtDNI_Trabajador_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 126);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 18;
            label7.Text = "DNI";
            // 
            // txtCorreo_Trabajador
            // 
            txtCorreo_Trabajador.Location = new Point(40, 409);
            txtCorreo_Trabajador.Name = "txtCorreo_Trabajador";
            txtCorreo_Trabajador.Size = new Size(188, 27);
            txtCorreo_Trabajador.TabIndex = 17;
            txtCorreo_Trabajador.TextChanged += txtCorreo_Trabajador_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 387);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 16;
            label6.Text = "Correo Electrónico ";
            // 
            // txtTelefono_Trabajador
            // 
            txtTelefono_Trabajador.Location = new Point(40, 345);
            txtTelefono_Trabajador.Name = "txtTelefono_Trabajador";
            txtTelefono_Trabajador.Size = new Size(188, 27);
            txtTelefono_Trabajador.TabIndex = 15;
            txtTelefono_Trabajador.TextChanged += txtTelefono_Trabajador_TextChanged;
            txtTelefono_Trabajador.KeyPress += txtTelefono_Trabajador_KeyPress;
            // 
            // txtDireccion_Trabajador
            // 
            txtDireccion_Trabajador.Location = new Point(40, 255);
            txtDireccion_Trabajador.Multiline = true;
            txtDireccion_Trabajador.Name = "txtDireccion_Trabajador";
            txtDireccion_Trabajador.Size = new Size(188, 65);
            txtDireccion_Trabajador.TabIndex = 14;
            txtDireccion_Trabajador.TextChanged += txtDireccion_Trabajador_TextChanged;
            // 
            // txtNombre_Trabajador
            // 
            txtNombre_Trabajador.Location = new Point(40, 202);
            txtNombre_Trabajador.Name = "txtNombre_Trabajador";
            txtNombre_Trabajador.Size = new Size(188, 27);
            txtNombre_Trabajador.TabIndex = 13;
            txtNombre_Trabajador.TextChanged += txtNombre_Trabajador_TextChanged;
            // 
            // txtRTN_Trabajador
            // 
            txtRTN_Trabajador.Location = new Point(40, 96);
            txtRTN_Trabajador.Name = "txtRTN_Trabajador";
            txtRTN_Trabajador.Size = new Size(188, 27);
            txtRTN_Trabajador.TabIndex = 1;
            txtRTN_Trabajador.TextChanged += txtRTN_Cliente_TextChanged;
            txtRTN_Trabajador.KeyPress += txtRTN_Trabajador_KeyPress;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(150, 720);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
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
            dgvTrabajador.Location = new Point(339, 63);
            dgvTrabajador.Name = "dgvTrabajador";
            dgvTrabajador.ReadOnly = true;
            dgvTrabajador.RowHeadersWidth = 51;
            dgvTrabajador.Size = new Size(991, 788);
            dgvTrabajador.TabIndex = 5;
            dgvTrabajador.CellClick += dgvTrabajador_CellClick;
            dgvTrabajador.CellContentClick += dgvCliente_CellContentClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(30, 720);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(30, 670);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 323);
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
            label4.Location = new Point(40, 232);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 179);
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
            label2.Location = new Point(59, 29);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 2;
            label2.Text = "Registro de Trabajadores";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 33);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 6;
            label8.Text = "Buscar:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(150, 670);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtContra);
            panel1.Controls.Add(txtUsuario);
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
            panel1.Location = new Point(53, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 817);
            panel1.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(40, 622);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(188, 27);
            txtCodigo.TabIndex = 26;
            
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 599);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 25;
            label12.Text = "Codigo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 547);
            label11.Name = "label11";
            label11.Size = new Size(83, 20);
            label11.TabIndex = 24;
            label11.Text = "Contraseña";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 489);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 23;
            label10.Text = "Usuario";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(40, 569);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(188, 27);
            txtContra.TabIndex = 22;
            
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(40, 512);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(188, 27);
            txtUsuario.TabIndex = 21;
            
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Location = new Point(59, 467);
            label9.Name = "label9";
            label9.Size = new Size(179, 20);
            label9.TabIndex = 20;
            label9.Text = "Credenciales Para Usuario";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // agregarTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 901);
            Controls.Add(txtBuscar);
            Controls.Add(dgvTrabajador);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "agregarTrabajador";
            Text = "agregarTrabajador";
            Load += agregarTrabajador_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrabajador).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label9;
        private ErrorProvider errorProvider1;
        private TextBox txtCodigo;
        private Label label12;
    }
}