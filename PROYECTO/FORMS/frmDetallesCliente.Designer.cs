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
            btnEnviar = new Button();
            label1 = new Label();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtIdentidad = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(169, 288);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(139, 43);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar Pedido";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 189);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 1;
            label1.Text = "Direccion de Entrega:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(228, 186);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(184, 27);
            txtDireccion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 111);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre de Cliente:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(228, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 27);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 153);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 3;
            label3.Text = "No. de Identidad:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIdentidad
            // 
            txtIdentidad.Location = new Point(228, 146);
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(184, 27);
            txtIdentidad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 229);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 3;
            label4.Text = "No. de Telefono:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(228, 222);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(184, 27);
            txtTelefono.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 37);
            label5.Name = "label5";
            label5.Size = new Size(370, 34);
            label5.TabIndex = 5;
            label5.Text = "DETALLES DE SU PEDIDO";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmDetallesCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 373);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtIdentidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDireccion);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Name = "frmDetallesCliente";
            Text = "frmDetallesCliente";
            ResumeLayout(false);
            PerformLayout();
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
    }
}