namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmEspecificacionesInicio
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
            label1 = new Label();
            lblIngrese = new Label();
            txtRespuesta_Recuperacion = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            lblPregunta = new Label();
            btnBuscar = new Button();
            txtUser = new TextBox();
            btnSiguiente = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 121);
            label1.Name = "label1";
            label1.Size = new Size(267, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el usuario que desea recuperar:";
            // 
            // lblIngrese
            // 
            lblIngrese.AutoSize = true;
            lblIngrese.Location = new Point(17, 276);
            lblIngrese.Name = "lblIngrese";
            lblIngrese.Size = new Size(239, 20);
            lblIngrese.TabIndex = 3;
            lblIngrese.Text = " Ingrese la respuesta a la pregunta:";
            lblIngrese.Visible = false;
            // 
            // txtRespuesta_Recuperacion
            // 
            txtRespuesta_Recuperacion.Location = new Point(17, 314);
            txtRespuesta_Recuperacion.Name = "txtRespuesta_Recuperacion";
            txtRespuesta_Recuperacion.Size = new Size(408, 27);
            txtRespuesta_Recuperacion.TabIndex = 4;
            txtRespuesta_Recuperacion.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 30);
            label4.Name = "label4";
            label4.Size = new Size(328, 30);
            label4.TabIndex = 9;
            label4.Text = "Pregunta de Recuperación";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblPregunta);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(btnSiguiente);
            panel1.Controls.Add(txtRespuesta_Recuperacion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblIngrese);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 439);
            panel1.TabIndex = 10;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(17, 239);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(0, 20);
            lblPregunta.TabIndex = 13;
            lblPregunta.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(448, 172);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(17, 172);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(408, 27);
            txtUser.TabIndex = 11;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(448, 314);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 29);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Visible = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // frmEspecificacionesInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(622, 463);
            Controls.Add(panel1);
            Name = "frmEspecificacionesInicio";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private Label lblIngrese;
        private TextBox txtRespuesta_Recuperacion;
        private Label label4;
        private Panel panel1;
        private Button btnSiguiente;
        private Button btnBuscar;
        private Label lblPregunta;
    }
}