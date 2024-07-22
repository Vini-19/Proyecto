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
            this.components = new System.ComponentModel.Container();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtDNI_Trabajador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo_Trabajador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono_Trabajador = new System.Windows.Forms.TextBox();
            this.txtDireccion_Trabajador = new System.Windows.Forms.TextBox();
            this.txtNombre_Trabajador = new System.Windows.Forms.TextBox();
            this.txtRTN_Trabajador = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvTrabajador = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(358, 85);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(686, 20);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // txtDNI_Trabajador
            // 
            this.txtDNI_Trabajador.Location = new System.Drawing.Point(30, 84);
            this.txtDNI_Trabajador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNI_Trabajador.Name = "txtDNI_Trabajador";
            this.txtDNI_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtDNI_Trabajador.TabIndex = 19;
            this.txtDNI_Trabajador.TextChanged += new System.EventHandler(this.txtDNI_Trabajador_TextChanged_1);
            this.txtDNI_Trabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_Trabajador_KeyPress_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "DNI";
            // 
            // txtCorreo_Trabajador
            // 
            this.txtCorreo_Trabajador.Location = new System.Drawing.Point(30, 255);
            this.txtCorreo_Trabajador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo_Trabajador.Name = "txtCorreo_Trabajador";
            this.txtCorreo_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtCorreo_Trabajador.TabIndex = 17;
            this.txtCorreo_Trabajador.TextChanged += new System.EventHandler(this.txtCorreo_Trabajador_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(30, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo Electrónico ";
            // 
            // txtTelefono_Trabajador
            // 
            this.txtTelefono_Trabajador.Location = new System.Drawing.Point(30, 218);
            this.txtTelefono_Trabajador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono_Trabajador.Name = "txtTelefono_Trabajador";
            this.txtTelefono_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtTelefono_Trabajador.TabIndex = 15;
            this.txtTelefono_Trabajador.TextChanged += new System.EventHandler(this.txtTelefono_Trabajador_TextChanged_1);
            this.txtTelefono_Trabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_Trabajador_KeyPress_1);
            // 
            // txtDireccion_Trabajador
            // 
            this.txtDireccion_Trabajador.Location = new System.Drawing.Point(30, 158);
            this.txtDireccion_Trabajador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion_Trabajador.Multiline = true;
            this.txtDireccion_Trabajador.Name = "txtDireccion_Trabajador";
            this.txtDireccion_Trabajador.Size = new System.Drawing.Size(142, 44);
            this.txtDireccion_Trabajador.TabIndex = 14;
            this.txtDireccion_Trabajador.TextChanged += new System.EventHandler(this.txtDireccion_Trabajador_TextChanged_1);
            // 
            // txtNombre_Trabajador
            // 
            this.txtNombre_Trabajador.Location = new System.Drawing.Point(30, 123);
            this.txtNombre_Trabajador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre_Trabajador.Name = "txtNombre_Trabajador";
            this.txtNombre_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtNombre_Trabajador.TabIndex = 13;
            this.txtNombre_Trabajador.TextChanged += new System.EventHandler(this.txtNombre_Trabajador_TextChanged_1);
            // 
            // txtRTN_Trabajador
            // 
            this.txtRTN_Trabajador.Location = new System.Drawing.Point(30, 47);
            this.txtRTN_Trabajador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRTN_Trabajador.Name = "txtRTN_Trabajador";
            this.txtRTN_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtRTN_Trabajador.TabIndex = 1;
            this.txtRTN_Trabajador.TextChanged += new System.EventHandler(this.txtRTN_Trabajador_TextChanged);
            this.txtRTN_Trabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRTN_Trabajador_KeyPress_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnEliminar.FlatAppearance.BorderSize = 4;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Location = new System.Drawing.Point(110, 475);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 32);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_2);
            // 
            // dgvTrabajador
            // 
            this.dgvTrabajador.AllowUserToAddRows = false;
            this.dgvTrabajador.AllowUserToDeleteRows = false;
            this.dgvTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajador.Location = new System.Drawing.Point(312, 114);
            this.dgvTrabajador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTrabajador.Name = "dgvTrabajador";
            this.dgvTrabajador.ReadOnly = true;
            this.dgvTrabajador.RowHeadersWidth = 51;
            this.dgvTrabajador.Size = new System.Drawing.Size(732, 510);
            this.dgvTrabajador.TabIndex = 5;
            this.dgvTrabajador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajador_CellClick_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpiar.FlatAppearance.BorderSize = 4;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpiar.Location = new System.Drawing.Point(20, 475);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_2);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregar.FlatAppearance.BorderSize = 4;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregar.Location = new System.Drawing.Point(20, 436);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 32);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(30, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "RTN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(30, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Buscar:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnModificar.FlatAppearance.BorderSize = 4;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnModificar.Location = new System.Drawing.Point(110, 436);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 32);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtContra);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDNI_Trabajador);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCorreo_Trabajador);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTelefono_Trabajador);
            this.panel1.Controls.Add(this.txtDireccion_Trabajador);
            this.panel1.Controls.Add(this.txtNombre_Trabajador);
            this.panel1.Controls.Add(this.txtRTN_Trabajador);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(55, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 531);
            this.panel1.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(30, 404);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 20);
            this.txtCodigo.TabIndex = 26;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(29, 389);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Código";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(29, 356);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(29, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Usuario";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(30, 370);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(142, 20);
            this.txtContra.TabIndex = 22;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(30, 333);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(142, 20);
            this.txtUsuario.TabIndex = 21;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Credenciales de Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(384, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(585, 50);
            this.label13.TabIndex = 10;
            this.label13.Text = "REGISTRO DE TRABAJADORES";
            // 
            // agregarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 685);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvTrabajador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "agregarTrabajador";
            this.Text = "agregarTrabajador";
            this.Load += new System.EventHandler(this.agregarTrabajador_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label13;
    }
}