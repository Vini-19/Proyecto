using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre_Imagen = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.cmbCategoria);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtNombre_Imagen);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.picProducto);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(51, 208);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 446);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnModificar.FlatAppearance.BorderSize = 4;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnModificar.Location = new System.Drawing.Point(219, 366);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 34);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpiar.FlatAppearance.BorderSize = 4;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpiar.Location = new System.Drawing.Point(372, 366);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 34);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(55, 281);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(153, 24);
            this.cmbCategoria.TabIndex = 20;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(253, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nombre de la Imagen";
            // 
            // txtNombre_Imagen
            // 
            this.txtNombre_Imagen.Location = new System.Drawing.Point(257, 283);
            this.txtNombre_Imagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre_Imagen.Name = "txtNombre_Imagen";
            this.txtNombre_Imagen.Size = new System.Drawing.Size(197, 22);
            this.txtNombre_Imagen.TabIndex = 18;
            this.txtNombre_Imagen.TextChanged += new System.EventHandler(this.txtNombre_Imagen_TextChanged_1);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(55, 210);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(153, 22);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged_1);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(55, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 22);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(55, 80);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(153, 22);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged_1);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(52, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoría";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(52, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(52, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre de Corte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(52, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código de Barra";
            // 
            // picProducto
            // 
            this.picProducto.Location = new System.Drawing.Point(257, 32);
            this.picProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(223, 201);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProducto.TabIndex = 9;
            this.picProducto.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregar.FlatAppearance.BorderSize = 4;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAgregar.Location = new System.Drawing.Point(55, 366);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 34);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(629, 208);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.Size = new System.Drawing.Size(786, 446);
            this.dgvProducto.TabIndex = 7;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Catálogo";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 843);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            this.Load += new System.EventHandler(this.frmPedido_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ErrorProvider errorProvider1;
        private DataGridView dgvProducto;
        private Panel panel2;
        private Button btnModificar;
        private Button btnLimpiar;
        private ComboBox cmbCategoria;
        private Label label7;
        private TextBox txtNombre_Imagen;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox picProducto;
        private Button btnAgregar;
        private Label label1;
    }
}