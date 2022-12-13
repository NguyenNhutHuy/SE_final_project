namespace WindowsFormsApp
{
    partial class RevenueStatisticsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMonthSearch = new System.Windows.Forms.TextBox();
            this.textBoxYearSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.radioButtonAllTimeSearch = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalRevenueArea = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.btnStopBusiness = new System.Windows.Forms.Button();
            this.btnRebusiness = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(348, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(551, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // textBoxMonthSearch
            // 
            this.textBoxMonthSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxMonthSearch.Location = new System.Drawing.Point(433, 54);
            this.textBoxMonthSearch.Name = "textBoxMonthSearch";
            this.textBoxMonthSearch.Size = new System.Drawing.Size(100, 34);
            this.textBoxMonthSearch.TabIndex = 3;
            // 
            // textBoxYearSearch
            // 
            this.textBoxYearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxYearSearch.Location = new System.Drawing.Point(621, 54);
            this.textBoxYearSearch.Name = "textBoxYearSearch";
            this.textBoxYearSearch.Size = new System.Drawing.Size(100, 34);
            this.textBoxYearSearch.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSearch.Location = new System.Drawing.Point(734, 51);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 41);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // radioButtonAllTimeSearch
            // 
            this.radioButtonAllTimeSearch.AutoSize = true;
            this.radioButtonAllTimeSearch.Location = new System.Drawing.Point(253, 62);
            this.radioButtonAllTimeSearch.Name = "radioButtonAllTimeSearch";
            this.radioButtonAllTimeSearch.Size = new System.Drawing.Size(71, 20);
            this.radioButtonAllTimeSearch.TabIndex = 6;
            this.radioButtonAllTimeSearch.TabStop = true;
            this.radioButtonAllTimeSearch.Text = "All time";
            this.radioButtonAllTimeSearch.UseVisualStyleBackColor = true;
            this.radioButtonAllTimeSearch.CheckedChanged += new System.EventHandler(this.radioButtonAllTimeSearch_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total revenue: ";
            // 
            // labelTotalRevenueArea
            // 
            this.labelTotalRevenueArea.AutoSize = true;
            this.labelTotalRevenueArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTotalRevenueArea.Location = new System.Drawing.Point(182, 117);
            this.labelTotalRevenueArea.Name = "labelTotalRevenueArea";
            this.labelTotalRevenueArea.Size = new System.Drawing.Size(199, 29);
            this.labelTotalRevenueArea.TabIndex = 8;
            this.labelTotalRevenueArea.Text = "1000000000 VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(13, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Product sales figures";
            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(18, 206);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.RowHeadersWidth = 51;
            this.dataGridViewRevenue.RowTemplate.Height = 24;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(824, 315);
            this.dataGridViewRevenue.TabIndex = 10;
            this.dataGridViewRevenue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRevenue_CellClick);
            // 
            // btnStopBusiness
            // 
            this.btnStopBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnStopBusiness.Location = new System.Drawing.Point(398, 527);
            this.btnStopBusiness.Name = "btnStopBusiness";
            this.btnStopBusiness.Size = new System.Drawing.Size(201, 41);
            this.btnStopBusiness.TabIndex = 11;
            this.btnStopBusiness.Text = "Stop business";
            this.btnStopBusiness.UseVisualStyleBackColor = true;
            this.btnStopBusiness.Click += new System.EventHandler(this.btnStopBusiness_Click);
            // 
            // btnRebusiness
            // 
            this.btnRebusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRebusiness.Location = new System.Drawing.Point(616, 527);
            this.btnRebusiness.Name = "btnRebusiness";
            this.btnRebusiness.Size = new System.Drawing.Size(201, 41);
            this.btnRebusiness.TabIndex = 12;
            this.btnRebusiness.Text = "Re-business";
            this.btnRebusiness.UseVisualStyleBackColor = true;
            this.btnRebusiness.Click += new System.EventHandler(this.btnRebusiness_Click);
            // 
            // RevenueStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 580);
            this.Controls.Add(this.btnRebusiness);
            this.Controls.Add(this.btnStopBusiness);
            this.Controls.Add(this.dataGridViewRevenue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTotalRevenueArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonAllTimeSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxYearSearch);
            this.Controls.Add(this.textBoxMonthSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RevenueStatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.RevenueStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMonthSearch;
        private System.Windows.Forms.TextBox textBoxYearSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton radioButtonAllTimeSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalRevenueArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private System.Windows.Forms.Button btnStopBusiness;
        private System.Windows.Forms.Button btnRebusiness;
    }
}