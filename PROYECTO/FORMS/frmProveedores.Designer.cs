using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion_Prov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNI_Prov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCorreo_Prov = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTelefono_Prov = new System.Windows.Forms.TextBox();
            this.txtNombre_Prov = new System.Windows.Forms.TextBox();
            this.txtRTN_Prov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Prov = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDireccion_Prov);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDNI_Prov);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtCorreo_Prov);
            this.panel1.Controls.Add(this.Correo);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtTelefono_Prov);
            this.panel1.Controls.Add(this.txtNombre_Prov);
            this.panel1.Controls.Add(this.txtRTN_Prov);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(73, 127);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 585);
            this.panel1.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(37, 391);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(191, 24);
            this.cmbCategoria.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(35, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Categoría:";
            // 
            // txtDireccion_Prov
            // 
            this.txtDireccion_Prov.Location = new System.Drawing.Point(36, 302);
            this.txtDireccion_Prov.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtDireccion_Prov.Multiline = true;
            this.txtDireccion_Prov.Name = "txtDireccion_Prov";
            this.txtDireccion_Prov.Size = new System.Drawing.Size(191, 62);
            this.txtDireccion_Prov.TabIndex = 19;
            this.txtDireccion_Prov.TextChanged += new System.EventHandler(this.txtDireccion_Prov_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(35, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dirección:";
            // 
            // txtDNI_Prov
            // 
            this.txtDNI_Prov.Location = new System.Drawing.Point(40, 116);
            this.txtDNI_Prov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDNI_Prov.Name = "txtDNI_Prov";
            this.txtDNI_Prov.Size = new System.Drawing.Size(188, 22);
            this.txtDNI_Prov.TabIndex = 17;
            this.txtDNI_Prov.TextChanged += new System.EventHandler(this.txtDNI_Prov_TextChanged_1);
            this.txtDNI_Prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_Prov_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(37, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "DNI:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnEliminar.FlatAppearance.BorderSize = 4;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Location = new System.Drawing.Point(139, 498);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 42);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtCorreo_Prov
            // 
            this.txtCorreo_Prov.Location = new System.Drawing.Point(37, 252);
            this.txtCorreo_Prov.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtCorreo_Prov.Name = "txtCorreo_Prov";
            this.txtCorreo_Prov.Size = new System.Drawing.Size(191, 22);
            this.txtCorreo_Prov.TabIndex = 13;
            this.txtCorreo_Prov.TextChanged += new System.EventHandler(this.txtCorreo_Prov_TextChanged_1);
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Correo.Location = new System.Drawing.Point(37, 233);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(58, 16);
            this.Correo.TabIndex = 12;
            this.Correo.Text = "Correo:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(139, 444);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpiar.FlatAppearance.BorderSize = 4;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpiar.Location = new System.Drawing.Point(29, 498);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 42);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregar.FlatAppearance.BorderSize = 4;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregar.Location = new System.Drawing.Point(29, 444);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 39);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtTelefono_Prov
            // 
            this.txtTelefono_Prov.Location = new System.Drawing.Point(37, 206);
            this.txtTelefono_Prov.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtTelefono_Prov.Name = "txtTelefono_Prov";
            this.txtTelefono_Prov.Size = new System.Drawing.Size(191, 22);
            this.txtTelefono_Prov.TabIndex = 8;
            this.txtTelefono_Prov.TextChanged += new System.EventHandler(this.txtTelefono_Prov_TextChanged_1);
            this.txtTelefono_Prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_Prov_KeyPress);
            // 
            // txtNombre_Prov
            // 
            this.txtNombre_Prov.Location = new System.Drawing.Point(37, 160);
            this.txtNombre_Prov.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtNombre_Prov.Name = "txtNombre_Prov";
            this.txtNombre_Prov.Size = new System.Drawing.Size(191, 22);
            this.txtNombre_Prov.TabIndex = 7;
            this.txtNombre_Prov.TextChanged += new System.EventHandler(this.txtNombre_Prov_TextChanged_1);
            // 
            // txtRTN_Prov
            // 
            this.txtRTN_Prov.Location = new System.Drawing.Point(40, 71);
            this.txtRTN_Prov.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtRTN_Prov.Name = "txtRTN_Prov";
            this.txtRTN_Prov.Size = new System.Drawing.Size(188, 22);
            this.txtRTN_Prov.TabIndex = 5;
            this.txtRTN_Prov.TextChanged += new System.EventHandler(this.txtRTN_Prov_TextChanged_1);
            this.txtRTN_Prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRTN_Prov_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(37, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(37, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RTN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // dgv_Prov
            // 
            this.dgv_Prov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prov.Location = new System.Drawing.Point(415, 170);
            this.dgv_Prov.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgv_Prov.Name = "dgv_Prov";
            this.dgv_Prov.ReadOnly = true;
            this.dgv_Prov.RowHeadersWidth = 51;
            this.dgv_Prov.Size = new System.Drawing.Size(1000, 542);
            this.dgv_Prov.TabIndex = 0;
            this.dgv_Prov.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Prov_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(477, 127);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(937, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Buscar:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(512, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(712, 62);
            this.label13.TabIndex = 10;
            this.label13.Text = "REGISTRO DE PROVEEDORES";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 843);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgv_Prov);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgv_Prov;
        private Button button3;
        private Button btnLimpiar;
        private Button btnAgregar;
        private TextBox txtTelefono_Prov;
        private TextBox txtNombre_Prov;
        private TextBox txtRTN_Prov;
        private Label Correo;
        private TextBox txtCorreo_Prov;
        private Button btnEliminar;
        private TextBox txtDNI_Prov;
        private Label label5;
        private TextBox txtDireccion_Prov;
        private Label label6;
        private ComboBox cmbCategoria;
        private Label label7;
        private TextBox txtBuscar;
        private Label label8;
        private ErrorProvider errorProvider1;
        private Label label13;
    }
}