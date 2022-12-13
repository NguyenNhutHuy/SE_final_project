namespace WindowsFormsApp
{
    partial class ImportReport
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
            this.supplementFactsCompanyDataSet = new WindowsFormsApp.SupplementFactsCompanyDataSet();
            this.supplementFactsCompanyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ImportInvoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.supplementFactsCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplementFactsCompanyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ImportInvoiceDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supplementFactsCompanyDataSet
            // 
            this.supplementFactsCompanyDataSet.DataSetName = "SupplementFactsCompanyDataSet";
            this.supplementFactsCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplementFactsCompanyDataSetBindingSource
            // 
            this.supplementFactsCompanyDataSetBindingSource.DataSource = this.supplementFactsCompanyDataSet;
            this.supplementFactsCompanyDataSetBindingSource.Position = 0;
            // 
            // tb_ImportInvoiceDetailBindingSource
            // 
            this.tb_ImportInvoiceDetailBindingSource.DataMember = "tb_ImportInvoiceDetail";
            this.tb_ImportInvoiceDetailBindingSource.DataSource = this.supplementFactsCompanyDataSet;
            // 
            // importReportViewer
            // 
            this.importReportViewer.Location = new System.Drawing.Point(12, 12);
            this.importReportViewer.Name = "importReportViewer";
            this.importReportViewer.ServerReport.BearerToken = null;
            this.importReportViewer.Size = new System.Drawing.Size(963, 486);
            this.importReportViewer.TabIndex = 0;
            // 
            // ImportReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 510);
            this.Controls.Add(this.importReportViewer);
            this.Name = "ImportReport";
            this.Text = "Import report";
            this.Load += new System.EventHandler(this.ImportReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplementFactsCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplementFactsCompanyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ImportInvoiceDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource supplementFactsCompanyDataSetBindingSource;
        private SupplementFactsCompanyDataSet supplementFactsCompanyDataSet;
        private System.Windows.Forms.BindingSource tb_ImportInvoiceDetailBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer importReportViewer;
    }
}