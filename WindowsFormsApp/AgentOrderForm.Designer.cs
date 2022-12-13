namespace WindowsFormsApp
{
    partial class AgentOrderForm
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
            this.dataGridViewAgentOrder = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewAgentOrderDetail = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirmPayment = new System.Windows.Forms.Button();
            this.radioButtonDelivering = new System.Windows.Forms.RadioButton();
            this.radioButtonWaiting = new System.Windows.Forms.RadioButton();
            this.radioButtonPaymentSuccess = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonCancel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Detail";
            // 
            // dataGridViewAgentOrder
            // 
            this.dataGridViewAgentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgentOrder.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewAgentOrder.Name = "dataGridViewAgentOrder";
            this.dataGridViewAgentOrder.ReadOnly = true;
            this.dataGridViewAgentOrder.RowHeadersWidth = 51;
            this.dataGridViewAgentOrder.RowTemplate.Height = 24;
            this.dataGridViewAgentOrder.Size = new System.Drawing.Size(1056, 248);
            this.dataGridViewAgentOrder.TabIndex = 2;
            this.dataGridViewAgentOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgentOrder_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(587, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order ID: ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxSearch.Location = new System.Drawing.Point(696, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(239, 34);
            this.textBoxSearch.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSearch.Location = new System.Drawing.Point(828, 46);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 36);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewAgentOrderDetail
            // 
            this.dataGridViewAgentOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgentOrderDetail.Location = new System.Drawing.Point(12, 408);
            this.dataGridViewAgentOrderDetail.Name = "dataGridViewAgentOrderDetail";
            this.dataGridViewAgentOrderDetail.ReadOnly = true;
            this.dataGridViewAgentOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAgentOrderDetail.RowHeadersWidth = 51;
            this.dataGridViewAgentOrderDetail.RowTemplate.Height = 24;
            this.dataGridViewAgentOrderDetail.Size = new System.Drawing.Size(1056, 272);
            this.dataGridViewAgentOrderDetail.TabIndex = 7;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPrint.Location = new System.Drawing.Point(828, 701);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(107, 36);
            this.buttonPrint.TabIndex = 8;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(645, 701);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(177, 36);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel order";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirmPayment
            // 
            this.buttonConfirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonConfirmPayment.Location = new System.Drawing.Point(373, 701);
            this.buttonConfirmPayment.Name = "buttonConfirmPayment";
            this.buttonConfirmPayment.Size = new System.Drawing.Size(266, 36);
            this.buttonConfirmPayment.TabIndex = 10;
            this.buttonConfirmPayment.Text = "Confirm payment";
            this.buttonConfirmPayment.UseVisualStyleBackColor = true;
            this.buttonConfirmPayment.Click += new System.EventHandler(this.buttonConfirmPayment_Click);
            // 
            // radioButtonDelivering
            // 
            this.radioButtonDelivering.AutoSize = true;
            this.radioButtonDelivering.Location = new System.Drawing.Point(112, 30);
            this.radioButtonDelivering.Name = "radioButtonDelivering";
            this.radioButtonDelivering.Size = new System.Drawing.Size(89, 20);
            this.radioButtonDelivering.TabIndex = 11;
            this.radioButtonDelivering.TabStop = true;
            this.radioButtonDelivering.Text = "Delivering";
            this.radioButtonDelivering.UseVisualStyleBackColor = true;
            this.radioButtonDelivering.CheckedChanged += new System.EventHandler(this.radioButtonDelivering_CheckedChanged);
            // 
            // radioButtonWaiting
            // 
            this.radioButtonWaiting.AutoSize = true;
            this.radioButtonWaiting.Location = new System.Drawing.Point(19, 30);
            this.radioButtonWaiting.Name = "radioButtonWaiting";
            this.radioButtonWaiting.Size = new System.Drawing.Size(73, 20);
            this.radioButtonWaiting.TabIndex = 12;
            this.radioButtonWaiting.TabStop = true;
            this.radioButtonWaiting.Text = "Waiting";
            this.radioButtonWaiting.UseVisualStyleBackColor = true;
            this.radioButtonWaiting.CheckedChanged += new System.EventHandler(this.radioButtonWaiting_CheckedChanged);
            // 
            // radioButtonPaymentSuccess
            // 
            this.radioButtonPaymentSuccess.AutoSize = true;
            this.radioButtonPaymentSuccess.Location = new System.Drawing.Point(223, 30);
            this.radioButtonPaymentSuccess.Name = "radioButtonPaymentSuccess";
            this.radioButtonPaymentSuccess.Size = new System.Drawing.Size(134, 20);
            this.radioButtonPaymentSuccess.TabIndex = 13;
            this.radioButtonPaymentSuccess.TabStop = true;
            this.radioButtonPaymentSuccess.Text = "Payment success";
            this.radioButtonPaymentSuccess.UseVisualStyleBackColor = true;
            this.radioButtonPaymentSuccess.CheckedChanged += new System.EventHandler(this.radioButtonPaymentSuccess_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(458, 30);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(43, 20);
            this.radioButtonAll.TabIndex = 14;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonCancel
            // 
            this.radioButtonCancel.AutoSize = true;
            this.radioButtonCancel.Location = new System.Drawing.Point(373, 30);
            this.radioButtonCancel.Name = "radioButtonCancel";
            this.radioButtonCancel.Size = new System.Drawing.Size(70, 20);
            this.radioButtonCancel.TabIndex = 15;
            this.radioButtonCancel.TabStop = true;
            this.radioButtonCancel.Text = "Cancel";
            this.radioButtonCancel.UseVisualStyleBackColor = true;
            this.radioButtonCancel.CheckedChanged += new System.EventHandler(this.radioButtonCancel_CheckedChanged);
            // 
            // AgentOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 749);
            this.Controls.Add(this.radioButtonCancel);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.radioButtonPaymentSuccess);
            this.Controls.Add(this.radioButtonWaiting);
            this.Controls.Add(this.radioButtonDelivering);
            this.Controls.Add(this.buttonConfirmPayment);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewAgentOrderDetail);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewAgentOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgentOrderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AgentOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgentOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAgentOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewAgentOrderDetail;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirmPayment;
        private System.Windows.Forms.RadioButton radioButtonDelivering;
        private System.Windows.Forms.RadioButton radioButtonWaiting;
        private System.Windows.Forms.RadioButton radioButtonPaymentSuccess;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonCancel;
    }
}