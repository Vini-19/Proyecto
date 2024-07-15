using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmRegistro
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
            label2 = new Label();
            panel1 = new Panel();
            cmbPregunta = new ComboBox();
            txtRespuesta = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnSalir = new Button();
            button1 = new Button();
            btnSiguiente = new Button();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 75);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 0;
            label1.Text = "Regístrate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 147);
            label2.Name = "label2";
            label2.Size = new Size(72, 29);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cmbPregunta);
            panel1.Controls.Add(txtRespuesta);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSiguiente);
            panel1.Controls.Add(txtContra);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 551);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // cmbPregunta
            // 
            cmbPregunta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPregunta.FormattingEnabled = true;
            cmbPregunta.Items.AddRange(new object[] { "¿Cuál es el nombre de tu perro?", "¿En que ciudad naciste?", "¿Cuál es tu comida favorita?", "¿Cuál es tu libro favorito?", "¿Cuál es tu pelicula favorita?", "" });
            cmbPregunta.Location = new Point(45, 357);
            cmbPregunta.Name = "cmbPregunta";
            cmbPregunta.Size = new Size(196, 28);
            cmbPregunta.TabIndex = 10;
            
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(45, 420);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(196, 27);
            txtRespuesta.TabIndex = 9;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 388);
            label5.Name = "label5";
            label5.Size = new Size(216, 29);
            label5.TabIndex = 8;
            label5.Text = "Respuesta de recuperación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 325);
            label4.Name = "label4";
            label4.Size = new Size(209, 29);
            label4.TabIndex = 7;
            label4.Text = "Pregunta de recuperación";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Firebrick;
            btnSalir.Location = new Point(244, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 29);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(50, 29);
            button1.TabIndex = 3;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Gold;
            btnSiguiente.Location = new Point(91, 469);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(123, 37);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnRegistrar_Click;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(45, 251);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(196, 27);
            txtContra.TabIndex = 4;
            
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(45, 179);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(196, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 219);
            label3.Name = "label3";
            label3.Size = new Size(99, 29);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(321, 575);
            Controls.Add(panel1);
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnSiguiente;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label3;
        private Button button1;
        private Button btnSalir;
        private Label label4;
        private ComboBox cmbPregunta;
        private TextBox txtRespuesta;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}