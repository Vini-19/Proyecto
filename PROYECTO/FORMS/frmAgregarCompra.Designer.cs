using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmAgregarCompra
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
            btnAgregarC = new Button();
            txtPrecio = new TextBox();
            label10 = new Label();
            btnQuitarC = new Button();
            cmbProveedor = new ComboBox();
            cmbCategoria = new ComboBox();
            txtCantidad = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ListaCompras = new ListBox();
            btnFinalizarC = new Button();
            lblTotal = new Label();
            label2 = new Label();
            lblsubtotal = new Label();
            lblsubtotal2 = new Label();
            lbltotal2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAgregarC);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnQuitarC);
            panel1.Controls.Add(cmbProveedor);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(11, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 443);
            panel1.TabIndex = 0;
            // 
            // btnAgregarC
            // 
            btnAgregarC.Location = new Point(216, 167);
            btnAgregarC.Name = "btnAgregarC";
            btnAgregarC.Size = new Size(94, 29);
            btnAgregarC.TabIndex = 24;
            btnAgregarC.Text = "Agregar Compra";
            btnAgregarC.UseVisualStyleBackColor = true;
            btnAgregarC.Click += btnAgregarC_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(35, 289);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 23;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 267);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 22;
            label10.Text = "Precio por Libras";
            label10.Click += label10_Click;
            // 
            // btnQuitarC
            // 
            btnQuitarC.Location = new Point(216, 213);
            btnQuitarC.Name = "btnQuitarC";
            btnQuitarC.Size = new Size(94, 29);
            btnQuitarC.TabIndex = 12;
            btnQuitarC.Text = "Quitar";
            btnQuitarC.UseVisualStyleBackColor = true;
            btnQuitarC.Click += btnQuitarC_Click;
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(35, 71);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(125, 28);
            cmbProveedor.TabIndex = 9;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(34, 145);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(125, 28);
            cmbCategoria.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(35, 215);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 7;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 192);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 6;
            label5.Text = "Peso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 48);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 2;
            label4.Text = "Proveedor";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 123);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 1;
            label3.Text = "Categoría";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 24);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Añadir Compra";
            // 
            // ListaCompras
            // 
            ListaCompras.FormattingEnabled = true;
            ListaCompras.Location = new Point(368, 63);
            ListaCompras.Name = "ListaCompras";
            ListaCompras.Size = new Size(276, 404);
            ListaCompras.TabIndex = 12;
            ListaCompras.SelectedIndexChanged += ListaCompras_SelectedIndexChanged;
            // 
            // btnFinalizarC
            // 
            btnFinalizarC.Location = new Point(509, 484);
            btnFinalizarC.Margin = new Padding(3, 4, 3, 4);
            btnFinalizarC.Name = "btnFinalizarC";
            btnFinalizarC.Size = new Size(135, 31);
            btnFinalizarC.TabIndex = 13;
            btnFinalizarC.Text = "Finalizar Compra";
            btnFinalizarC.UseVisualStyleBackColor = true;
            btnFinalizarC.Click += btnFinalizarC_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(581, 431);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 431);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 15;
            label2.Text = "Total:";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(387, 408);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(68, 20);
            lblsubtotal.TabIndex = 16;
            lblsubtotal.Text = "Subtotal:";
            // 
            // lblsubtotal2
            // 
            lblsubtotal2.AutoSize = true;
            lblsubtotal2.Location = new Point(481, 408);
            lblsubtotal2.Name = "lblsubtotal2";
            lblsubtotal2.Size = new Size(50, 20);
            lblsubtotal2.TabIndex = 17;
            lblsubtotal2.Text = "label6";
            // 
            // lbltotal2
            // 
            lbltotal2.AutoSize = true;
            lbltotal2.Location = new Point(481, 431);
            lbltotal2.Name = "lbltotal2";
            lbltotal2.Size = new Size(50, 20);
            lbltotal2.TabIndex = 18;
            lbltotal2.Text = "label7";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAgregarCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 528);
            Controls.Add(lbltotal2);
            Controls.Add(lblsubtotal2);
            Controls.Add(lblsubtotal);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(btnFinalizarC);
            Controls.Add(ListaCompras);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmAgregarCompra";
            Text = "frmAgregarCompra";
            Load += frmAgregarCompra_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private ComboBox cmbProveedor;
        private ComboBox cmbCategoria;
        private TextBox txtCantidad;
        private Label label5;
        private Button btnQuitarC;
        private ListBox ListaCompras;
        private Button btnFinalizarC;
        private Label label8;
        private TextBox txtPrecio;
        private Label label10;
        private Button btnAgregarC;
        private Label lblTotal;
        private Label label2;
        private Label lblsubtotal;
        private Label lblsubtotal2;
        private Label lbltotal2;
        private ErrorProvider errorProvider1;
    }
}