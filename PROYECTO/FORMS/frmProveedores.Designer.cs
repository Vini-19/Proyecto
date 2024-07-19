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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Prov = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(260, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 435);
            this.panel1.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(28, 306);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(129, 21);
            this.cmbCategoria.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(26, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Categoría:";
            // 
            // txtDireccion_Prov
            // 
            this.txtDireccion_Prov.Location = new System.Drawing.Point(28, 238);
            this.txtDireccion_Prov.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDireccion_Prov.Multiline = true;
            this.txtDireccion_Prov.Name = "txtDireccion_Prov";
            this.txtDireccion_Prov.Size = new System.Drawing.Size(129, 51);
            this.txtDireccion_Prov.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(26, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dirección:";
            // 
            // txtDNI_Prov
            // 
            this.txtDNI_Prov.Location = new System.Drawing.Point(28, 92);
            this.txtDNI_Prov.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDNI_Prov.Name = "txtDNI_Prov";
            this.txtDNI_Prov.Size = new System.Drawing.Size(129, 20);
            this.txtDNI_Prov.TabIndex = 17;
            this.txtDNI_Prov.TextChanged += new System.EventHandler(this.txtDNI_Prov_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(28, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "DNI:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(103, 382);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 34);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtCorreo_Prov
            // 
            this.txtCorreo_Prov.Location = new System.Drawing.Point(28, 201);
            this.txtCorreo_Prov.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCorreo_Prov.Name = "txtCorreo_Prov";
            this.txtCorreo_Prov.Size = new System.Drawing.Size(129, 20);
            this.txtCorreo_Prov.TabIndex = 13;
            this.txtCorreo_Prov.TextChanged += new System.EventHandler(this.txtCorreo_Prov_TextChanged_1);
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Correo.Location = new System.Drawing.Point(28, 187);
            this.Correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(41, 13);
            this.Correo.TabIndex = 12;
            this.Correo.Text = "Correo:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(103, 335);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(10, 382);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAgregar.Location = new System.Drawing.Point(10, 335);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 32);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtTelefono_Prov
            // 
            this.txtTelefono_Prov.Location = new System.Drawing.Point(28, 164);
            this.txtTelefono_Prov.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTelefono_Prov.Name = "txtTelefono_Prov";
            this.txtTelefono_Prov.Size = new System.Drawing.Size(129, 20);
            this.txtTelefono_Prov.TabIndex = 8;
            this.txtTelefono_Prov.TextChanged += new System.EventHandler(this.txtTelefono_Prov_TextChanged_1);
            // 
            // txtNombre_Prov
            // 
            this.txtNombre_Prov.Location = new System.Drawing.Point(28, 127);
            this.txtNombre_Prov.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombre_Prov.Name = "txtNombre_Prov";
            this.txtNombre_Prov.Size = new System.Drawing.Size(129, 20);
            this.txtNombre_Prov.TabIndex = 7;
            this.txtNombre_Prov.TextChanged += new System.EventHandler(this.txtNombre_Prov_TextChanged_1);
            // 
            // txtRTN_Prov
            // 
            this.txtRTN_Prov.Location = new System.Drawing.Point(28, 56);
            this.txtRTN_Prov.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRTN_Prov.Name = "txtRTN_Prov";
            this.txtRTN_Prov.Size = new System.Drawing.Size(129, 20);
            this.txtRTN_Prov.TabIndex = 5;
            this.txtRTN_Prov.TextChanged += new System.EventHandler(this.txtRTN_Prov_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RTN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Proveedores";
            // 
            // dgv_Prov
            // 
            this.dgv_Prov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prov.Location = new System.Drawing.Point(452, 108);
            this.dgv_Prov.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv_Prov.Name = "dgv_Prov";
            this.dgv_Prov.ReadOnly = true;
            this.dgv_Prov.RowHeadersWidth = 51;
            this.dgv_Prov.Size = new System.Drawing.Size(500, 405);
            this.dgv_Prov.TabIndex = 0;
            this.dgv_Prov.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Prov_CellClick);
            this.dgv_Prov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Prov_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(512, 89);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(442, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(452, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Buscar:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 685);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgv_Prov);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
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
        private Label label1;
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
    }
}