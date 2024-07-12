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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cmbCategoria = new ComboBox();
            label7 = new Label();
            txtDireccion_Prov = new TextBox();
            label6 = new Label();
            txtDNI_Prov = new TextBox();
            label5 = new Label();
            btnEliminar = new Button();
            txtCorreo_Prov = new TextBox();
            Correo = new Label();
            button3 = new Button();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            txtTelefono_Prov = new TextBox();
            txtNombre_Prov = new TextBox();
            txtRTN_Prov = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_Prov = new DataGridView();
            txtBuscar = new TextBox();
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Prov).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDireccion_Prov);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDNI_Prov);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtCorreo_Prov);
            panel1.Controls.Add(Correo);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtTelefono_Prov);
            panel1.Controls.Add(txtNombre_Prov);
            panel1.Controls.Add(txtRTN_Prov);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 634);
            panel1.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(37, 458);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(171, 28);
            cmbCategoria.TabIndex = 21;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 436);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 20;
            label7.Text = "Categoría";
            // 
            // txtDireccion_Prov
            // 
            txtDireccion_Prov.Location = new Point(37, 358);
            txtDireccion_Prov.Margin = new Padding(3, 2, 3, 2);
            txtDireccion_Prov.Multiline = true;
            txtDireccion_Prov.Name = "txtDireccion_Prov";
            txtDireccion_Prov.Size = new Size(171, 76);
            txtDireccion_Prov.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 336);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 18;
            label6.Text = "Dirección:";
            // 
            // txtDNI_Prov
            // 
            txtDNI_Prov.Location = new Point(37, 152);
            txtDNI_Prov.Margin = new Padding(3, 4, 3, 4);
            txtDNI_Prov.Name = "txtDNI_Prov";
            txtDNI_Prov.Size = new Size(171, 27);
            txtDNI_Prov.TabIndex = 17;
            txtDNI_Prov.TextChanged += txtDNI_Prov_TextChanged;
            txtDNI_Prov.KeyPress += txtDNI_Prov_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 128);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 16;
            label5.Text = "DNI:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(138, 570);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 30);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCorreo_Prov
            // 
            txtCorreo_Prov.Location = new Point(37, 307);
            txtCorreo_Prov.Margin = new Padding(3, 2, 3, 2);
            txtCorreo_Prov.Name = "txtCorreo_Prov";
            txtCorreo_Prov.Size = new Size(171, 27);
            txtCorreo_Prov.TabIndex = 13;
            txtCorreo_Prov.TextChanged += txtCorreo_Prov_TextChanged;
            // 
            // Correo
            // 
            Correo.AutoSize = true;
            Correo.Location = new Point(37, 285);
            Correo.Name = "Correo";
            Correo.Size = new Size(57, 20);
            Correo.TabIndex = 12;
            Correo.Text = "Correo:";
            // 
            // button3
            // 
            button3.Location = new Point(138, 520);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(94, 30);
            button3.TabIndex = 11;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(14, 570);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 30);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 520);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 30);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTelefono_Prov
            // 
            txtTelefono_Prov.Location = new Point(37, 256);
            txtTelefono_Prov.Margin = new Padding(3, 2, 3, 2);
            txtTelefono_Prov.Name = "txtTelefono_Prov";
            txtTelefono_Prov.Size = new Size(171, 27);
            txtTelefono_Prov.TabIndex = 8;
            txtTelefono_Prov.TextChanged += txtTelefono_Prov_TextChanged;
            txtTelefono_Prov.KeyPress += txtTelefono_Prov_KeyPress;
            // 
            // txtNombre_Prov
            // 
            txtNombre_Prov.Location = new Point(37, 205);
            txtNombre_Prov.Margin = new Padding(3, 2, 3, 2);
            txtNombre_Prov.Name = "txtNombre_Prov";
            txtNombre_Prov.Size = new Size(171, 27);
            txtNombre_Prov.TabIndex = 7;
            txtNombre_Prov.TextChanged += txtNombre_Prov_TextChanged;
            // 
            // txtRTN_Prov
            // 
            txtRTN_Prov.Location = new Point(37, 99);
            txtRTN_Prov.Margin = new Padding(3, 2, 3, 2);
            txtRTN_Prov.Name = "txtRTN_Prov";
            txtRTN_Prov.Size = new Size(171, 27);
            txtRTN_Prov.TabIndex = 5;
            txtRTN_Prov.TextChanged += txtRTN_Prov_TextChanged;
            txtRTN_Prov.KeyPress += txtRTN_Prov_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 234);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 77);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "RTN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 183);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 0;
            label1.Text = "Registro de Proveedores";
            // 
            // dgv_Prov
            // 
            dgv_Prov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Prov.Location = new Point(256, 48);
            dgv_Prov.Margin = new Padding(3, 2, 3, 2);
            dgv_Prov.Name = "dgv_Prov";
            dgv_Prov.ReadOnly = true;
            dgv_Prov.RowHeadersWidth = 51;
            dgv_Prov.Size = new Size(667, 586);
            dgv_Prov.TabIndex = 0;
            dgv_Prov.CellClick += dgv_Prov_CellClick;
            dgv_Prov.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(336, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(588, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 21);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 2;
            label8.Text = "Buscar:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 634);
            Controls.Add(label8);
            Controls.Add(txtBuscar);
            Controls.Add(dgv_Prov);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProveedores";
            Text = "frmProveedores";
            Load += frmProveedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Prov).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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