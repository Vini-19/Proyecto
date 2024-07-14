using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo
{
    partial class frmVentas
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
            label1 = new Label();
            txtCodigo_Barra = new TextBox();
            dgvProductos = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRTN = new TextBox();
            txtFecha = new TextBox();
            btnGenerar_Factura = new Button();
            btnEnter = new Button();
            cmbCliente = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 122);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Código de Barra:";
            // 
            // txtCodigo_Barra
            // 
            txtCodigo_Barra.Location = new Point(256, 119);
            txtCodigo_Barra.Name = "txtCodigo_Barra";
            txtCodigo_Barra.Size = new Size(223, 27);
            txtCodigo_Barra.TabIndex = 3;
            txtCodigo_Barra.TextChanged += txtCodigo_Barra_TextChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Cantidad, Precio, Total });
            dgvProductos.Location = new Point(167, 155);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(678, 424);
            dgvProductos.TabIndex = 2;
            dgvProductos.CellValueChanged += dgvProductos_CellValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(886, 322);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 37);
            button1.TabIndex = 4;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(886, 262);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(98, 37);
            button2.TabIndex = 5;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(748, 69);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "RTN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(748, 38);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(748, 99);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha:";
            // 
            // txtRTN
            // 
            txtRTN.Enabled = false;
            txtRTN.Location = new Point(826, 66);
            txtRTN.Name = "txtRTN";
            txtRTN.Size = new Size(158, 27);
            txtRTN.TabIndex = 9;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(826, 99);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(158, 27);
            txtFecha.TabIndex = 11;
            // 
            // btnGenerar_Factura
            // 
            btnGenerar_Factura.Location = new Point(717, 594);
            btnGenerar_Factura.Name = "btnGenerar_Factura";
            btnGenerar_Factura.Size = new Size(128, 29);
            btnGenerar_Factura.TabIndex = 12;
            btnGenerar_Factura.Text = "Generar Factura";
            btnGenerar_Factura.UseVisualStyleBackColor = true;
            btnGenerar_Factura.Click += btnGenerar_Factura_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(485, 118);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 29);
            btnEnter.TabIndex = 13;
            btnEnter.Text = "Confirmar";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            btnEnter.Enter += btnEnter_Enter;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(826, 30);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(158, 28);
            cmbCliente.TabIndex = 14;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo de Barra";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 635);
            Controls.Add(cmbCliente);
            Controls.Add(btnEnter);
            Controls.Add(btnGenerar_Factura);
            Controls.Add(txtFecha);
            Controls.Add(txtRTN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCodigo_Barra);
            Controls.Add(dgvProductos);
            Controls.Add(label1);
            Name = "frmVentas";
            Text = "Ventas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo_Barra;
        private DataGridView dgvProductos;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRTN;
        private TextBox txtFecha;
        private Button btnGenerar_Factura;
        private Button btnEnter;
        private ComboBox cmbCliente;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
    }
}