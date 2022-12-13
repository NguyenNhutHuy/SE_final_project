namespace WindowsFormsApp
{
    partial class ExportAgentOrderReport
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.reportViewerAgentOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // reportViewerAgentOrder
            // 
            this.reportViewerAgentOrder.Location = new System.Drawing.Point(12, 11);
            this.reportViewerAgentOrder.Name = "reportViewerAgentOrder";
            this.reportViewerAgentOrder.ServerReport.BearerToken = null;
            this.reportViewerAgentOrder.Size = new System.Drawing.Size(963, 487);
            this.reportViewerAgentOrder.TabIndex = 0;
            // 
            // ExportAgentOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 510);
            this.Controls.Add(this.reportViewerAgentOrder);
            this.Name = "ExportAgentOrderReport";
            this.Text = "ExportAgentOrderForm";
            this.Load += new System.EventHandler(this.ExportAgentOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAgentOrder;
    }
}