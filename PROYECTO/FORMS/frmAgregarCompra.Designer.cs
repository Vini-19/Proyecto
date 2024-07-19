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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnQuitarC = new System.Windows.Forms.Button();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaCompras = new System.Windows.Forms.ListBox();
            this.btnFinalizarC = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblsubtotal2 = new System.Windows.Forms.Label();
            this.lbltotal2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnAgregarC);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnQuitarC);
            this.panel1.Controls.Add(this.cmbProveedor);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(456, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 288);
            this.panel1.TabIndex = 0;
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAgregarC.Location = new System.Drawing.Point(162, 94);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(70, 34);
            this.btnAgregarC.TabIndex = 24;
            this.btnAgregarC.Text = "Agregar Compra";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click_1);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(26, 188);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(95, 20);
            this.txtPrecio.TabIndex = 23;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Precio por Libras";
            // 
            // btnQuitarC
            // 
            this.btnQuitarC.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitarC.Location = new System.Drawing.Point(162, 138);
            this.btnQuitarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarC.Name = "btnQuitarC";
            this.btnQuitarC.Size = new System.Drawing.Size(70, 31);
            this.btnQuitarC.TabIndex = 12;
            this.btnQuitarC.Text = "Quitar";
            this.btnQuitarC.UseVisualStyleBackColor = false;
            this.btnQuitarC.Click += new System.EventHandler(this.btnQuitarC_Click_1);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(26, 46);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(95, 21);
            this.cmbProveedor.TabIndex = 9;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged_1);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(26, 94);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(95, 21);
            this.cmbCategoria.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(26, 140);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(95, 20);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoría";
            // 
            // ListaCompras
            // 
            this.ListaCompras.FormattingEnabled = true;
            this.ListaCompras.Location = new System.Drawing.Point(724, 147);
            this.ListaCompras.Margin = new System.Windows.Forms.Padding(2);
            this.ListaCompras.Name = "ListaCompras";
            this.ListaCompras.Size = new System.Drawing.Size(208, 264);
            this.ListaCompras.TabIndex = 12;
            // 
            // btnFinalizarC
            // 
            this.btnFinalizarC.BackColor = System.Drawing.Color.SpringGreen;
            this.btnFinalizarC.Location = new System.Drawing.Point(830, 421);
            this.btnFinalizarC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFinalizarC.Name = "btnFinalizarC";
            this.btnFinalizarC.Size = new System.Drawing.Size(102, 31);
            this.btnFinalizarC.TabIndex = 13;
            this.btnFinalizarC.Text = "Finalizar Compra";
            this.btnFinalizarC.UseVisualStyleBackColor = false;
            this.btnFinalizarC.Click += new System.EventHandler(this.btnFinalizarC_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(884, 386);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total:";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(738, 371);
            this.lblsubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblsubtotal.TabIndex = 16;
            this.lblsubtotal.Text = "Subtotal:";
            // 
            // lblsubtotal2
            // 
            this.lblsubtotal2.AutoSize = true;
            this.lblsubtotal2.Location = new System.Drawing.Point(809, 371);
            this.lblsubtotal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsubtotal2.Name = "lblsubtotal2";
            this.lblsubtotal2.Size = new System.Drawing.Size(35, 13);
            this.lblsubtotal2.TabIndex = 17;
            this.lblsubtotal2.Text = "label6";
            // 
            // lbltotal2
            // 
            this.lbltotal2.AutoSize = true;
            this.lbltotal2.Location = new System.Drawing.Point(809, 386);
            this.lbltotal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal2.Name = "lbltotal2";
            this.lbltotal2.Size = new System.Drawing.Size(35, 13);
            this.lbltotal2.TabIndex = 18;
            this.lbltotal2.Text = "label7";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(508, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(389, 50);
            this.label13.TabIndex = 19;
            this.label13.Text = "AGREGAR COMPRA";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // frmAgregarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 685);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbltotal2);
            this.Controls.Add(this.lblsubtotal2);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFinalizarC);
            this.Controls.Add(this.ListaCompras);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgregarCompra";
            this.Text = "frmAgregarCompra";
            this.Load += new System.EventHandler(this.frmAgregarCompra_Load_2);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
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
        private Label label13;
    }
}