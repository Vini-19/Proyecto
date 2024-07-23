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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCompra));
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFinalizarC = new System.Windows.Forms.Button();
            this.lbltotal2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaCompras = new System.Windows.Forms.ListBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1179, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnFinalizarC);
            this.panel2.Controls.Add(this.lbltotal2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ListaCompras);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(117, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 705);
            this.panel2.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(371, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(493, 62);
            this.label13.TabIndex = 25;
            this.label13.Text = "AGREGAR COMPRA";
            // 
            // btnFinalizarC
            // 
            this.btnFinalizarC.BackColor = System.Drawing.Color.White;
            this.btnFinalizarC.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnFinalizarC.FlatAppearance.BorderSize = 4;
            this.btnFinalizarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarC.ForeColor = System.Drawing.Color.Crimson;
            this.btnFinalizarC.Location = new System.Drawing.Point(845, 640);
            this.btnFinalizarC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinalizarC.Name = "btnFinalizarC";
            this.btnFinalizarC.Size = new System.Drawing.Size(136, 38);
            this.btnFinalizarC.TabIndex = 24;
            this.btnFinalizarC.Text = "Finalizar Compra";
            this.btnFinalizarC.UseVisualStyleBackColor = false;
            this.btnFinalizarC.Click += new System.EventHandler(this.btnFinalizarC_Click);
            // 
            // lbltotal2
            // 
            this.lbltotal2.AutoSize = true;
            this.lbltotal2.Location = new System.Drawing.Point(911, 550);
            this.lbltotal2.Name = "lbltotal2";
            this.lbltotal2.Size = new System.Drawing.Size(44, 16);
            this.lbltotal2.TabIndex = 23;
            this.lbltotal2.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(835, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total:";
            // 
            // ListaCompras
            // 
            this.ListaCompras.FormattingEnabled = true;
            this.ListaCompras.ItemHeight = 16;
            this.ListaCompras.Location = new System.Drawing.Point(653, 158);
            this.ListaCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListaCompras.Name = "ListaCompras";
            this.ListaCompras.Size = new System.Drawing.Size(328, 452);
            this.ListaCompras.TabIndex = 19;
            this.ListaCompras.SelectedIndexChanged += new System.EventHandler(this.ListaCompras_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
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
            this.panel1.Location = new System.Drawing.Point(219, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 455);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.Color.White;
            this.btnAgregarC.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregarC.FlatAppearance.BorderSize = 4;
            this.btnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregarC.Location = new System.Drawing.Point(36, 319);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(101, 47);
            this.btnAgregarC.TabIndex = 24;
            this.btnAgregarC.Text = "Agregar ";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(61, 246);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(179, 22);
            this.txtPrecio.TabIndex = 23;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(59, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Precio por Libras";
            // 
            // btnQuitarC
            // 
            this.btnQuitarC.BackColor = System.Drawing.Color.White;
            this.btnQuitarC.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnQuitarC.FlatAppearance.BorderSize = 4;
            this.btnQuitarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarC.ForeColor = System.Drawing.Color.Crimson;
            this.btnQuitarC.Location = new System.Drawing.Point(159, 319);
            this.btnQuitarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarC.Name = "btnQuitarC";
            this.btnQuitarC.Size = new System.Drawing.Size(100, 47);
            this.btnQuitarC.TabIndex = 12;
            this.btnQuitarC.Text = "Quitar";
            this.btnQuitarC.UseVisualStyleBackColor = false;
            this.btnQuitarC.ClientSizeChanged += new System.EventHandler(this.btnQuitarC_Click);
            this.btnQuitarC.Click += new System.EventHandler(this.btnQuitarC_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(61, 70);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(179, 24);
            this.cmbProveedor.TabIndex = 9;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged_1);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(61, 129);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(179, 24);
            this.cmbCategoria.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(61, 186);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(179, 22);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(59, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(59, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(59, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoría";
            // 
            // frmAgregarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 843);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAgregarCompra";
            this.Text = "frmAgregarCompra";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label8;
        private Label lblTotal;
        private ErrorProvider errorProvider1;
        private Panel panel2;
        private Label label13;
        private Button btnFinalizarC;
        private Label lbltotal2;
        private Label label2;
        private ListBox ListaCompras;
        private Panel panel1;
        private Button btnAgregarC;
        private TextBox txtPrecio;
        private Label label10;
        private Button btnQuitarC;
        private ComboBox cmbProveedor;
        private ComboBox cmbCategoria;
        private TextBox txtCantidad;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}