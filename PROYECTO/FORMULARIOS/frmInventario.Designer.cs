namespace Proyecto_de_desarrolo.Formularios
{
    partial class frmInventario
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnModificar = new Button();
            btnGuardar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblRes = new Label();
            lblCerdo = new Label();
            txtBuscar = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(79, 96);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(806, 476);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 34);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(563, 583);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 31);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Activar Modificación";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(743, 583);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 31);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 588);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad Actual de Res:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 612);
            label3.Name = "label3";
            label3.Size = new Size(183, 20);
            label3.TabIndex = 5;
            label3.Text = "Cantidad Actual de Cerdo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 588);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 6;
            label4.Text = "Libras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 612);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 7;
            label5.Text = "Libras";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(292, 588);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(12, 20);
            lblRes.TabIndex = 8;
            lblRes.Text = ".";
            // 
            // lblCerdo
            // 
            lblCerdo.AutoSize = true;
            lblCerdo.Location = new Point(292, 612);
            lblCerdo.Name = "lblCerdo";
            lblCerdo.Size = new Size(12, 20);
            lblCerdo.TabIndex = 9;
            lblCerdo.Text = ".";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(155, 66);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(730, 27);
            txtBuscar.TabIndex = 10;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 69);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 11;
            label6.Text = "Buscar:";
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 635);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(lblCerdo);
            Controls.Add(lblRes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInventario";
            Text = "frmInventario";
            Load += frmInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnModificar;
        private Button btnGuardar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblRes;
        private Label lblCerdo;
        private TextBox txtBuscar;
        private Label label6;
    }
}