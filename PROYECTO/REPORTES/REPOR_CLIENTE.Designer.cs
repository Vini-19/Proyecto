﻿namespace PROYECTO.REPORTES
{
    partial class REPOR_CLIENTE
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productos = new PROYECTO.productos();
            this.compraclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compra_clienteTableAdapter = new PROYECTO.productosTableAdapters.Compra_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.compraclienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO.REPORTES.RE_CLIENTE.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // productos
            // 
            this.productos.DataSetName = "productos";
            this.productos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraclienteBindingSource
            // 
            this.compraclienteBindingSource.DataMember = "Compra_cliente";
            this.compraclienteBindingSource.DataSource = this.productos;
            // 
            // compra_clienteTableAdapter
            // 
            this.compra_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // REPOR_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "REPOR_CLIENTE";
            this.Text = "REPOR_CLIENTE";
            this.Load += new System.EventHandler(this.REPOR_CLIENTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraclienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private productos productos;
        private System.Windows.Forms.BindingSource compraclienteBindingSource;
        private productosTableAdapters.Compra_clienteTableAdapter compra_clienteTableAdapter;
    }
}