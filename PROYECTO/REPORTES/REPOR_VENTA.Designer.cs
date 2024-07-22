namespace PROYECTO.REPORTES
{
    partial class REPOR_VENTA
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
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTAS = new PROYECTO.VENTAS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventasTableAdapter = new PROYECTO.VENTASTableAdapters.VentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.vENTAS;
            // 
            // vENTAS
            // 
            this.vENTAS.DataSetName = "VENTAS";
            this.vENTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ventasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO.REPORTES.RE_VENTA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(370, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(628, 845);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // REPOR_VENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 843);
            this.Controls.Add(this.reportViewer1);
            this.Name = "REPOR_VENTA";
            this.RightToLeftLayout = true;
            this.Text = "REPOR_VENTA";
            this.Load += new System.EventHandler(this.REPOR_VENTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VENTAS vENTAS;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private VENTASTableAdapters.VentasTableAdapter ventasTableAdapter;
    }
}