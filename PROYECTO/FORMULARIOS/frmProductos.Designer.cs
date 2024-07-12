namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmProductos
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
            panel1 = new Panel();
            btnAgregar = new Button();
            txtCantidadP = new TextBox();
            label6 = new Label();
            txtCodbarra = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtnomProducto = new TextBox();
            label3 = new Label();
            cmbProveedor = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtCantidadP);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCodbarra);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtnomProducto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbProveedor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 494);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(155, 441);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidadP
            // 
            txtCantidadP.Location = new Point(14, 388);
            txtCantidadP.Name = "txtCantidadP";
            txtCantidadP.Size = new Size(121, 23);
            txtCantidadP.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(14, 349);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 9;
            label6.Text = "Cantidad de Producto";
            // 
            // txtCodbarra
            // 
            txtCodbarra.Location = new Point(14, 74);
            txtCodbarra.Name = "txtCodbarra";
            txtCodbarra.Size = new Size(121, 23);
            txtCodbarra.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(14, 56);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 4;
            label5.Text = "Codigo de barra";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(14, 300);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(14, 269);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // txtnomProducto
            // 
            txtnomProducto.Location = new Point(14, 146);
            txtnomProducto.Name = "txtnomProducto";
            txtnomProducto.Size = new Size(121, 23);
            txtnomProducto.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(14, 116);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre de Producto";
            label3.Click += label3_Click;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(14, 219);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(121, 23);
            cmbProveedor.TabIndex = 1;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 192);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(227, 16);
            label1.TabIndex = 1;
            label1.Text = "Registro de Productos Nuevos";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 565);
            Controls.Add(panel1);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox cmbProveedor;
        private Label label3;
        private TextBox txtnomProducto;
        private TextBox txtPrecio;
        private Label label4;
        private Label label5;
        private TextBox txtCodbarra;
        private TextBox txtCantidadP;
        private Label label6;
        private Button btnAgregar;
    }
}