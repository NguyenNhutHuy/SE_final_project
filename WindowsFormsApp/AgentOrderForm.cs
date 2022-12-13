using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AgentOrderForm : Form
    {
        SqlConnection MyConnection;
        private String accountantID;
        private String accountantName;

        DataTable dataTableAgentOrder = new DataTable();
        DataTable dataTableAgentOrderDetail = new DataTable();

        int rowIndex = -1;

        public AgentOrderForm(String accountantID, String accountantName)
        {
            InitializeComponent();
            this.accountantID = accountantID;
            this.accountantName = accountantName;
        }



        private void AgentOrderForm_Load(object sender, EventArgs e)
        {
            dataTableAgentOrder.Clear();

            radioButtonAll.Checked = true;  

        }

        private void radioButtonWaiting_CheckedChanged(object sender, EventArgs e)
        {
            dataTableAgentOrder.Clear();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            String querySQL = "SELECT * FROM [tb_AgentInvoices] WHERE status='waiting confirm' ORDER BY OrderDate DESC";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableAgentOrder);

            dataGridViewAgentOrder.DataSource = dataTableAgentOrder;

            MyConnection.Close();
        }

        private void radioButtonDelivering_CheckedChanged(object sender, EventArgs e)
        {
            dataTableAgentOrder.Clear();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            String querySQL = "SELECT * FROM [tb_AgentInvoices] WHERE status='delivering' ORDER BY OrderDate DESC";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableAgentOrder);

            dataGridViewAgentOrder.DataSource = dataTableAgentOrder;

            MyConnection.Close();
        }

        private void radioButtonPaymentSuccess_CheckedChanged(object sender, EventArgs e)
        {
            dataTableAgentOrder.Clear();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            String querySQL = "SELECT * FROM [tb_AgentInvoices] WHERE status='payment success' ORDER BY OrderDate DESC";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableAgentOrder);

            dataGridViewAgentOrder.DataSource = dataTableAgentOrder;

            MyConnection.Close();
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            dataTableAgentOrder.Clear();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            String querySQL = "SELECT * FROM [tb_AgentInvoices] ORDER BY OrderDate DESC";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableAgentOrder);

            dataGridViewAgentOrder.DataSource = dataTableAgentOrder;

            MyConnection.Close();
        }

        private void radioButtonCancel_CheckedChanged(object sender, EventArgs e)
        {
            dataTableAgentOrder.Clear();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            String querySQL = "SELECT * FROM [tb_AgentInvoices] WHERE status='cancel' ORDER BY OrderDate DESC";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableAgentOrder);

            dataGridViewAgentOrder.DataSource = dataTableAgentOrder; 

            MyConnection.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String invoiceID = textBoxSearch.Text;

            dataTableAgentOrder.Clear();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            String querySQL = "SELECT * FROM [tb_AgentInvoices] WHERE invoiceID='" + invoiceID + "'";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableAgentOrder);

            dataGridViewAgentOrder.DataSource = dataTableAgentOrder;

            MyConnection.Close();
        }

        private void dataGridViewAgentOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            String invoiceID = dataGridViewAgentOrder.Rows[e.RowIndex].Cells["invoiceID"].Value.ToString();
            showAgentOrderDetail(invoiceID);
        }

        private void showAgentOrderDetail(String invoiceID)
        {
            dataTableAgentOrderDetail.Clear();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            String querySQL = "SELECT invoiceID, invoiceDetailID, [tb_SFProcucts].productID, [tb_SFProcucts].productName, [tb_AgentInvoiceDetail].quantity, [tb_SFProcucts].quantity as AvalabileQuantity, agentPrice FROM [tb_AgentInvoiceDetail] INNER JOIN [tb_SFProcucts] ON [tb_AgentInvoiceDetail].productID=[tb_SFProcucts].productID WHERE invoiceID='" + invoiceID + "'";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableAgentOrderDetail);

            dataGridViewAgentOrderDetail.DataSource = dataTableAgentOrderDetail;

            MyConnection.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Please choice order!");
                return;
            }

            for (int i = 0; i < dataTableAgentOrderDetail.Rows.Count; i++)
            {
                int quantity = (int)dataGridViewAgentOrderDetail.Rows[i].Cells["quantity"].Value;
                String productID = dataGridViewAgentOrderDetail.Rows[i].Cells["productID"].Value.ToString();
                plusProductAgain(productID, quantity);
            }

            String invoiceID = dataGridViewAgentOrder.Rows[rowIndex].Cells["invoiceID"].Value.ToString();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "UPDATE tb_AgentInvoices SET status='cancel' WHERE invoiceID ='" + invoiceID + "'";
            cmd.Parameters.Clear();
            cmd.ExecuteNonQuery();

            MyConnection.Close();

            radioButtonAll.Checked = false;
            radioButtonAll.Checked = true;

            rowIndex = -1;

            MessageBox.Show("Update invoice " + invoiceID + " successfull");
        }

        private void plusProductAgain(String productID, int quantity)
        {
            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "UPDATE tb_SFProcucts SET tb_SFProcucts.quantity=tb_SFProcucts.quantity + @quantity WHERE tb_SFProcucts.productID=@productID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.ExecuteNonQuery();

            MyConnection.Close();
        }

        private void buttonConfirmPayment_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Please choice order!");
                return;
            }

            String invoiceID = dataGridViewAgentOrder.Rows[rowIndex].Cells["invoiceID"].Value.ToString();
            String status = dataGridViewAgentOrder.Rows[rowIndex].Cells["status"].Value.ToString();

            if (status != "delivering" )
            {
                MessageBox.Show("Please check order's status");
                return;
            } 

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "UPDATE tb_AgentInvoices SET status='payment success' WHERE invoiceID ='" + invoiceID + "'";
            cmd.Parameters.Clear();
            cmd.ExecuteNonQuery();

            MyConnection.Close();

            radioButtonAll.Checked = false;
            radioButtonAll.Checked = true;

            rowIndex = -1;

            MessageBox.Show("Update invoice " + invoiceID + " successfull");
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Please choice order!");
                return;
            }

            String invoiceID = dataGridViewAgentOrder.Rows[rowIndex].Cells["invoiceID"].Value.ToString();
            String status = dataGridViewAgentOrder.Rows[rowIndex].Cells["status"].Value.ToString();
            String address = dataGridViewAgentOrder.Rows[rowIndex].Cells["address"].Value.ToString();
            String phoneNumberAgent = dataGridViewAgentOrder.Rows[rowIndex].Cells["phoneNumberAgent"].Value.ToString();

            if (status == "payment success")
            {
                MessageBox.Show("Please check order's status");
                return;
            }

            for (int i = 0; i < dataGridViewAgentOrderDetail.Rows.Count; i++)
            {
                int orderQuantity = Convert.ToInt32(dataGridViewAgentOrderDetail.Rows[i].Cells["quantity"].Value);
                int avalableQuantity = Convert.ToInt32(dataGridViewAgentOrderDetail.Rows[i].Cells["AvalabileQuantity"].Value);

                if(avalableQuantity < orderQuantity)
                {
                    MessageBox.Show("Please check order's quantity");
                    return;
                }
            }

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "UPDATE tb_AgentInvoices SET status='delivering' WHERE invoiceID ='" + invoiceID + "'";
            cmd.Parameters.Clear();
            cmd.ExecuteNonQuery();

            MyConnection.Close();

            MessageBox.Show("Printing...");

            ExportAgentOrderReport rp = new ExportAgentOrderReport(invoiceID, address, accountantName, phoneNumberAgent);
            rp.ShowDialog();

            radioButtonAll.Checked = false;
            radioButtonAll.Checked = true;

            rowIndex = -1;
        }
    }
}
