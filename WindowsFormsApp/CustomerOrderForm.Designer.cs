namespace WindowsFormsApp
{
    partial class CustomerOrderForm
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
            this.radioButtonCancel = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonPaymentSuccess = new System.Windows.Forms.RadioButton();
            this.radioButtonWaiting = new System.Windows.Forms.RadioButton();
            this.radioButtonDelivering = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAgentOrder = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAgentOrderDetail = new System.Windows.Forms.DataGridView();
            this.buttonConfirmPayment = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonCancel
            // 
            this.radioButtonCancel.AutoSize = true;
            this.radioButtonCancel.Location = new System.Drawing.Point(375, 12);
            this.radioButtonCancel.Name = "radioButtonCancel";
            this.radioButtonCancel.Size = new System.Drawing.Size(70, 20);
            this.radioButtonCancel.TabIndex = 21;
            this.radioButtonCancel.TabStop = true;
            this.radioButtonCancel.Text = "Cancel";
            this.radioButtonCancel.UseVisualStyleBackColor = true;
            this.radioButtonCancel.CheckedChanged += new System.EventHandler(this.radioButtonCancel_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(460, 12);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(43, 20);
            this.radioButtonAll.TabIndex = 20;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonPaymentSuccess
            // 
            this.radioButtonPaymentSuccess.AutoSize = true;
            this.radioButtonPaymentSuccess.Location = new System.Drawing.Point(225, 12);
            this.radioButtonPaymentSuccess.Name = "radioButtonPaymentSuccess";
            this.radioButtonPaymentSuccess.Size = new System.Drawing.Size(134, 20);
            this.radioButtonPaymentSuccess.TabIndex = 19;
            this.radioButtonPaymentSuccess.TabStop = true;
            this.radioButtonPaymentSuccess.Text = "Payment success";
            this.radioButtonPaymentSuccess.UseVisualStyleBackColor = true;
            this.radioButtonPaymentSuccess.CheckedChanged += new System.EventHandler(this.radioButtonPaymentSuccess_CheckedChanged);
            // 
            // radioButtonWaiting
            // 
            this.radioButtonWaiting.AutoSize = true;
            this.radioButtonWaiting.Location = new System.Drawing.Point(21, 12);
            this.radioButtonWaiting.Name = "radioButtonWaiting";
            this.radioButtonWaiting.Size = new System.Drawing.Size(73, 20);
            this.radioButtonWaiting.TabIndex = 18;
            this.radioButtonWaiting.TabStop = true;
            this.radioButtonWaiting.Text = "Waiting";
            this.radioButtonWaiting.UseVisualStyleBackColor = true;
            this.radioButtonWaiting.CheckedChanged += new System.EventHandler(this.radioButtonWaiting_CheckedChanged);
            // 
            // radioButtonDelivering
            // 
            this.radioButtonDelivering.AutoSize = true;
            this.radioButtonDelivering.Location = new System.Drawing.Point(114, 12);
            this.radioButtonDelivering.Name = "radioButtonDelivering";
            this.radioButtonDelivering.Size = new System.Drawing.Size(89, 20);
            this.radioButtonDelivering.TabIndex = 17;
            this.radioButtonDelivering.TabStop = true;
            this.radioButtonDelivering.Text = "Delivering";
            this.radioButtonDelivering.UseVisualStyleBackColor = true;
            this.radioButtonDelivering.CheckedChanged += new System.EventHandler(this.radioButtonDelivering_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSearch.Location = new System.Drawing.Point(846, 52);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 36);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxSearch.Location = new System.Drawing.Point(714, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(239, 34);
            this.textBoxSearch.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(605, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Order ID: ";
            // 
            // dataGridViewAgentOrder
            // 
            this.dataGridViewAgentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgentOrder.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewAgentOrder.Name = "dataGridViewAgentOrder";
            this.dataGridViewAgentOrder.ReadOnly = true;
            this.dataGridViewAgentOrder.RowHeadersWidth = 51;
            this.dataGridViewAgentOrder.RowTemplate.Height = 24;
            this.dataGridViewAgentOrder.Size = new System.Drawing.Size(1056, 248);
            this.dataGridViewAgentOrder.TabIndex = 25;
            this.dataGridViewAgentOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgentOrder_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Order Detail";
            // 
            // dataGridViewAgentOrderDetail
            // 
            this.dataGridViewAgentOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgentOrderDetail.Location = new System.Drawing.Point(9, 400);
            this.dataGridViewAgentOrderDetail.Name = "dataGridViewAgentOrderDetail";
            this.dataGridViewAgentOrderDetail.ReadOnly = true;
            this.dataGridViewAgentOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAgentOrderDetail.RowHeadersWidth = 51;
            this.dataGridViewAgentOrderDetail.RowTemplate.Height = 24;
            this.dataGridViewAgentOrderDetail.Size = new System.Drawing.Size(1056, 272);
            this.dataGridViewAgentOrderDetail.TabIndex = 27;
            // 
            // buttonConfirmPayment
            // 
            this.buttonConfirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonConfirmPayment.Location = new System.Drawing.Point(503, 696);
            this.buttonConfirmPayment.Name = "buttonConfirmPayment";
            this.buttonConfirmPayment.Size = new System.Drawing.Size(266, 36);
            this.buttonConfirmPayment.TabIndex = 30;
            this.buttonConfirmPayment.Text = "Confirm payment";
            this.buttonConfirmPayment.UseVisualStyleBackColor = true;
            this.buttonConfirmPayment.Click += new System.EventHandler(this.buttonConfirmPayment_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(775, 696);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(177, 36);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel order";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPrint.Location = new System.Drawing.Point(958, 696);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(107, 36);
            this.buttonPrint.TabIndex = 31;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 828);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonConfirmPayment);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewAgentOrderDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAgentOrder);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonCancel);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.radioButtonPaymentSuccess);
            this.Controls.Add(this.radioButtonWaiting);
            this.Controls.Add(this.radioButtonDelivering);
            this.Controls.Add(this.label1);
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.Load += new System.EventHandler(this.CustomerOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonCancel;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonPaymentSuccess;
        private System.Windows.Forms.RadioButton radioButtonWaiting;
        private System.Windows.Forms.RadioButton radioButtonDelivering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewAgentOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAgentOrderDetail;
        private System.Windows.Forms.Button buttonConfirmPayment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPrint;
    }
}