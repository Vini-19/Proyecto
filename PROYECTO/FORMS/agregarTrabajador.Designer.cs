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
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(464, 74);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(681, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // txtDNI_Trabajador
            // 
            this.txtDNI_Trabajador.Location = new System.Drawing.Point(30, 97);
            this.txtDNI_Trabajador.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI_Trabajador.Name = "txtDNI_Trabajador";
            this.txtDNI_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtDNI_Trabajador.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "DNI";
            // 
            // txtCorreo_Trabajador
            // 
            this.txtCorreo_Trabajador.Location = new System.Drawing.Point(30, 266);
            this.txtCorreo_Trabajador.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo_Trabajador.Name = "txtCorreo_Trabajador";
            this.txtCorreo_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtCorreo_Trabajador.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo Electrónico ";
            // 
            // txtTelefono_Trabajador
            // 
            this.txtTelefono_Trabajador.Location = new System.Drawing.Point(30, 224);
            this.txtTelefono_Trabajador.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono_Trabajador.Name = "txtTelefono_Trabajador";
            this.txtTelefono_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtTelefono_Trabajador.TabIndex = 15;
            // 
            // txtDireccion_Trabajador
            // 
            this.txtDireccion_Trabajador.Location = new System.Drawing.Point(30, 166);
            this.txtDireccion_Trabajador.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion_Trabajador.Multiline = true;
            this.txtDireccion_Trabajador.Name = "txtDireccion_Trabajador";
            this.txtDireccion_Trabajador.Size = new System.Drawing.Size(142, 44);
            this.txtDireccion_Trabajador.TabIndex = 14;
            // 
            // txtNombre_Trabajador
            // 
            this.txtNombre_Trabajador.Location = new System.Drawing.Point(30, 131);
            this.txtNombre_Trabajador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Trabajador.Name = "txtNombre_Trabajador";
            this.txtNombre_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtNombre_Trabajador.TabIndex = 13;
            // 
            // txtRTN_Trabajador
            // 
            this.txtRTN_Trabajador.Location = new System.Drawing.Point(30, 62);
            this.txtRTN_Trabajador.Margin = new System.Windows.Forms.Padding(2);
            this.txtRTN_Trabajador.Name = "txtRTN_Trabajador";
            this.txtRTN_Trabajador.Size = new System.Drawing.Size(142, 20);
            this.txtRTN_Trabajador.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(111, 191);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 25);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // dgvTrabajador
            // 
            this.dgvTrabajador.AllowUserToAddRows = false;
            this.dgvTrabajador.AllowUserToDeleteRows = false;
            this.dgvTrabajador.BackgroundColor = System.Drawing.Color.Crimson;
            this.dgvTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajador.Location = new System.Drawing.Point(417, 99);
            this.dgvTrabajador.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTrabajador.Name = "dgvTrabajador";
            this.dgvTrabajador.ReadOnly = true;
            this.dgvTrabajador.RowHeadersWidth = 51;
            this.dgvTrabajador.Size = new System.Drawing.Size(727, 512);
            this.dgvTrabajador.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(21, 191);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 25);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 148);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 29);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 210);
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
            this.label4.Location = new System.Drawing.Point(30, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 116);
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
            this.label2.Location = new System.Drawing.Point(37, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro de Trabajadores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(417, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Buscar:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(111, 148);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 29);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtDNI_Trabajador);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCorreo_Trabajador);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTelefono_Trabajador);
            this.panel1.Controls.Add(this.txtDireccion_Trabajador);
            this.panel1.Controls.Add(this.txtNombre_Trabajador);
            this.panel1.Controls.Add(this.txtRTN_Trabajador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(175, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 531);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.txtContra);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Location = new System.Drawing.Point(3, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 237);
            this.panel2.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(29, 117);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 20);
            this.txtCodigo.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Credenciales Para Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 102);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Codigo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Usuario";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(29, 83);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(142, 20);
            this.txtContra.TabIndex = 22;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(29, 46);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(142, 20);
            this.txtUsuario.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(435, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(585, 50);
            this.label13.TabIndex = 8;
            this.label13.Text = "REGISTRO DE TRABAJADORES";
            // 
            // agregarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1416, 685);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvTrabajador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "agregarTrabajador";
            this.Text = "agregarTrabajador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private Panel panel2;
        private Label label13;
    }
}