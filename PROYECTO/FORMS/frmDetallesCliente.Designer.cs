using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmDetallesCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallesCliente));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviar.Location = new System.Drawing.Point(191, 231);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(139, 34);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar Pedido";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dirección de Entrega:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(228, 149);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(184, 22);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(228, 84);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. de Identidad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(228, 117);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(184, 22);
            this.txtIdentidad.TabIndex = 2;
            this.txtIdentidad.TextChanged += new System.EventHandler(this.txtIdentidad_TextChanged);
            this.txtIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. de Teléfono:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(228, 177);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 22);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "DETALLES DE SU PEDIDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetallesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDetallesCliente";
            this.Text = "frmDetallesCliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnviar;
        private Label label1;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtIdentidad;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}