namespace WindowsFormsApp
{
    partial class ImportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitleImport = new System.Windows.Forms.Label();
            this.dataGridViewImport = new System.Windows.Forms.DataGridView();
            this.textBoxInvoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerImport = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalPriceArea = new System.Windows.Forms.Label();
            this.buttonNewInvoice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAccountantName = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleImport
            // 
            this.labelTitleImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitleImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTitleImport.Location = new System.Drawing.Point(0, 0);
            this.labelTitleImport.Name = "labelTitleImport";
            this.labelTitleImport.Size = new System.Drawing.Size(951, 33);
            this.labelTitleImport.TabIndex = 0;
            this.labelTitleImport.Text = "Import product";
            this.labelTitleImport.Click += new System.EventHandler(this.labelTitleImport_Click);
            // 
            // dataGridViewImport
            // 
            this.dataGridViewImport.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImport.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewImport.Name = "dataGridViewImport";
            this.dataGridViewImport.RowHeadersWidth = 51;
            this.dataGridViewImport.RowTemplate.Height = 24;
            this.dataGridViewImport.Size = new System.Drawing.Size(927, 252);
            this.dataGridViewImport.TabIndex = 1;
            this.dataGridViewImport.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImport_RowValidated);
            // 
            // textBoxInvoiceID
            // 
            this.textBoxInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxInvoiceID.Location = new System.Drawing.Point(153, 313);
            this.textBoxInvoiceID.Name = "textBoxInvoiceID";
            this.textBoxInvoiceID.Size = new System.Drawing.Size(129, 32);
            this.textBoxInvoiceID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(13, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Invoice ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(13, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Import date: ";
            // 
            // dateTimePickerImport
            // 
            this.dateTimePickerImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dateTimePickerImport.Location = new System.Drawing.Point(153, 358);
            this.dateTimePickerImport.Name = "dateTimePickerImport";
            this.dateTimePickerImport.Size = new System.Drawing.Size(355, 32);
            this.dateTimePickerImport.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(495, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total price:";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelTotalPriceArea
            // 
            this.labelTotalPriceArea.AutoSize = true;
            this.labelTotalPriceArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelTotalPriceArea.Location = new System.Drawing.Point(619, 313);
            this.labelTotalPriceArea.Name = "labelTotalPriceArea";
            this.labelTotalPriceArea.Size = new System.Drawing.Size(77, 26);
            this.labelTotalPriceArea.TabIndex = 7;
            this.labelTotalPriceArea.Text = "0 VND";
            // 
            // buttonNewInvoice
            // 
            this.buttonNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonNewInvoice.Location = new System.Drawing.Point(18, 449);
            this.buttonNewInvoice.Name = "buttonNewInvoice";
            this.buttonNewInvoice.Size = new System.Drawing.Size(147, 35);
            this.buttonNewInvoice.TabIndex = 9;
            this.buttonNewInvoice.Text = "New invoice";
            this.buttonNewInvoice.UseVisualStyleBackColor = true;
            this.buttonNewInvoice.Click += new System.EventHandler(this.buttonNewInvoice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(13, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Accountant: ";
            // 
            // labelAccountantName
            // 
            this.labelAccountantName.AutoSize = true;
            this.labelAccountantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelAccountantName.Location = new System.Drawing.Point(152, 397);
            this.labelAccountantName.Name = "labelAccountantName";
            this.labelAccountantName.Size = new System.Drawing.Size(182, 26);
            this.labelAccountantName.TabIndex = 11;
            this.labelAccountantName.Text = "Accountant name";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonPrint.Location = new System.Drawing.Point(171, 449);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(147, 35);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 496);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelAccountantName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonNewInvoice);
            this.Controls.Add(this.labelTotalPriceArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInvoiceID);
            this.Controls.Add(this.dataGridViewImport);
            this.Controls.Add(this.labelTitleImport);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleImport;
        private System.Windows.Forms.DataGridView dataGridViewImport;
        private System.Windows.Forms.TextBox textBoxInvoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalPriceArea;
        private System.Windows.Forms.Button buttonNewInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAccountantName;
        private System.Windows.Forms.Button buttonPrint;
    }
}