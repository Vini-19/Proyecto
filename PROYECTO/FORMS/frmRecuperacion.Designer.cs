using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmRecuperacion
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
            panel1 = new Panel();
            txtNueva_Contraseña2 = new TextBox();
            btnConfirmar = new Button();
            txtNueva_Contraseña1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 78);
            label1.Name = "label1";
            label1.Size = new Size(242, 19);
            label1.TabIndex = 0;
            label1.Text = "Recuperación de Contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtNueva_Contraseña2);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtNueva_Contraseña1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 503);
            panel1.TabIndex = 1;
            // 
            // txtNueva_Contraseña2
            // 
            txtNueva_Contraseña2.Location = new Point(22, 292);
            txtNueva_Contraseña2.Name = "txtNueva_Contraseña2";
            txtNueva_Contraseña2.Size = new Size(242, 27);
            txtNueva_Contraseña2.TabIndex = 5;
            
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(94, 367);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtNueva_Contraseña1
            // 
            txtNueva_Contraseña1.Location = new Point(22, 169);
            txtNueva_Contraseña1.Name = "txtNueva_Contraseña1";
            txtNueva_Contraseña1.Size = new Size(242, 27);
            txtNueva_Contraseña1.TabIndex = 2;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 250);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 1;
            label4.Text = "para verificar:";
            label4.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 233);
            label3.Name = "label3";
            label3.Size = new Size(268, 17);
            label3.TabIndex = 1;
            label3.Text = "Por favor, ingrese la contraseña nuevamente";
            label3.Click += label2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 139);
            label2.Name = "label2";
            label2.Size = new Size(232, 17);
            label2.TabIndex = 1;
            label2.Text = "Por favor, ingrese la nueva contraseña";
            label2.Click += label2_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRecuperacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(307, 516);
            Controls.Add(panel1);
            Name = "frmRecuperacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRecuperacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button btnConfirmar;
        private TextBox txtNueva_Contraseña1;
        private TextBox txtNueva_Contraseña2;
        private Label label4;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}