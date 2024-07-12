namespace Proyecto_de_desarrolo
{
    partial class frmPedido
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
            dgvProducto = new DataGridView();
            panel2 = new Panel();
            btnModificar = new Button();
            btnLimpiar = new Button();
            cmbCategoria = new ComboBox();
            label7 = new Label();
            txtNombre_Imagen = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            picProducto = new PictureBox();
            btnAgregar = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProducto);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(46, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 766);
            panel1.TabIndex = 4;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(26, 407);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(875, 342);
            dgvProducto.TabIndex = 6;
            dgvProducto.CellClick += dgvProducto_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(cmbCategoria);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtNombre_Imagen);
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(picProducto);
            panel2.Controls.Add(btnAgregar);
            panel2.Location = new Point(479, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 388);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.Location = new Point(282, 331);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(108, 43);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.Location = new Point(161, 331);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 43);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(230, 172);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(153, 28);
            cmbCategoria.TabIndex = 20;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 223);
            label7.Name = "label7";
            label7.Size = new Size(155, 20);
            label7.TabIndex = 19;
            label7.Text = "Nombre de la Imagen";
            // 
            // txtNombre_Imagen
            // 
            txtNombre_Imagen.Location = new Point(9, 246);
            txtNombre_Imagen.Name = "txtNombre_Imagen";
            txtNombre_Imagen.Size = new Size(197, 27);
            txtNombre_Imagen.TabIndex = 18;
            txtNombre_Imagen.TextChanged += txtNombre_Imagen_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(230, 235);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(153, 27);
            txtPrecio.TabIndex = 17;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(230, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 27);
            txtNombre.TabIndex = 15;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(230, 47);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(153, 27);
            txtCodigo.TabIndex = 14;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 149);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 13;
            label6.Text = "Categoría";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 212);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 12;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 86);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 11;
            label4.Text = "Nombre de Producto/Corte";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 24);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 10;
            label3.Text = "Código de Barra";
            // 
            // picProducto
            // 
            picProducto.Location = new Point(9, 24);
            picProducto.Name = "picProducto";
            picProducto.Size = new Size(197, 194);
            picProducto.SizeMode = PictureBoxSizeMode.Zoom;
            picProducto.TabIndex = 9;
            picProducto.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Location = new Point(30, 331);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 43);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 846);
            Controls.Add(panel1);
            Name = "frmPedido";
            Text = "frmPedido";
            Load += frmPedido_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btnAgregar;
        private PictureBox picProducto;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label6;
        private Label label7;
        private TextBox txtNombre_Imagen;
        private ComboBox cmbCategoria;
        private DataGridView dgvProducto;
        private Button btnLimpiar;
        private Button btnModificar;
        private ErrorProvider errorProvider1;
    }
}