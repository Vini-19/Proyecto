namespace Proyecto_de_desarrolo
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            panel1 = new Panel();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            linkLRecuperacion = new LinkLabel();
            linkLRegistro = new LinkLabel();
            label5 = new Label();
            btnIniciar = new Button();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(linkLRecuperacion);
            panel1.Controls.Add(linkLRegistro);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(txtContra);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 529);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(224, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 29);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // linkLRecuperacion
            // 
            linkLRecuperacion.AutoSize = true;
            linkLRecuperacion.Location = new Point(39, 421);
            linkLRecuperacion.Name = "linkLRecuperacion";
            linkLRecuperacion.Size = new Size(205, 20);
            linkLRecuperacion.TabIndex = 10;
            linkLRecuperacion.TabStop = true;
            linkLRecuperacion.Text = "¿Haz olvidado tu contraseña?";
            linkLRecuperacion.LinkClicked += linkLRecuperacion_LinkClicked;
            // 
            // linkLRegistro
            // 
            linkLRegistro.AutoSize = true;
            linkLRegistro.Location = new Point(101, 487);
            linkLRegistro.Name = "linkLRegistro";
            linkLRegistro.Size = new Size(76, 20);
            linkLRegistro.TabIndex = 9;
            linkLRegistro.TabStop = true;
            linkLRegistro.Text = "Regístrate";
            linkLRegistro.LinkClicked += linkLRegistro_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 467);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 8;
            label5.Text = "¿No tienes cuenta?";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Gold;
            btnIniciar.Location = new Point(93, 369);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar Sesión ";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += button1_Click_2;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(51, 319);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(174, 27);
            txtContra.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(51, 257);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(174, 27);
            txtUsuario.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 287);
            label3.Name = "label3";
            label3.Size = new Size(99, 29);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 225);
            label2.Name = "label2";
            label2.Size = new Size(72, 29);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 176);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesión";
            label1.Click += label1_Click;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(299, 553);
            Controls.Add(panel1);
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmInicioSesion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnIniciar;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label3;
        private Label label2;
        private Label label5;
        private LinkLabel linkLRegistro;
        private LinkLabel linkLRecuperacion;
        private Button btnSalir;
    }
}
