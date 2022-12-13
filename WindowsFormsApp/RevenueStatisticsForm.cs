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
    public partial class RevenueStatisticsForm : Form
    {
        DataTable dataTableRevenue = new DataTable();
        int rowIndex = -1;
        public RevenueStatisticsForm()
        {
            InitializeComponent();
        }

        private void RevenueStatisticsForm_Load(object sender, EventArgs e)
        {
            radioButtonAllTimeSearch.Checked = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String monthSearch = textBoxMonthSearch.Text;
            String yearSearch = textBoxYearSearch.Text;

            SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            MyConnection.Open();

            String sqlQuery = "SELECT SUM(t.totalAmount) as totalBuyedInMonth "
                + "FROM ("
                + "SELECT ISNULL(SUM(tb_AgentInvoiceDetail.quantity*tb_AgentInvoiceDetail.agentPrice),0) as totalAmount "
                + "FROM tb_AgentInvoiceDetail INNER JOIN tb_AgentInvoices "
                + "ON tb_AgentInvoiceDetail.invoiceID = tb_AgentInvoices.invoiceID "
                + "WHERE MONTH(tb_AgentInvoices.OrderDate)=@monthSearch "
                + "AND YEAR(tb_AgentInvoices.OrderDate)=@yearSearch " 
                + "AND tb_AgentInvoices.status='payment success' "
                + "UNION "
                + "SELECT ISNULL(SUM(tb_CustomerInvoiceDetail.quantity*tb_CustomerInvoiceDetail.agentPrice),0) as totalAmount "
                + "FROM tb_CustomerInvoiceDetail INNER JOIN tb_CustomerInvoices "
                + "ON tb_CustomerInvoiceDetail.invoiceID = tb_CustomerInvoices.invoiceID "
                + "WHERE MONTH(tb_CustomerInvoices.OrderDate)=@monthSearch "
                + "AND YEAR(tb_CustomerInvoices.OrderDate)=@yearSearch "
                + "AND tb_CustomerInvoices.status='payment success'"
                + ") t";

            SqlCommand cmd = new SqlCommand(sqlQuery, MyConnection);
            cmd.Parameters.AddWithValue("@monthSearch", monthSearch);
            cmd.Parameters.AddWithValue("@yearSearch", yearSearch);

            labelTotalRevenueArea.Text = cmd.ExecuteScalar().ToString() + "VND";

            radioButtonAllTimeSearch.Checked = false;

            MyConnection.Close();

            dataTableRevenue.Clear();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            MyConnection.Open();


            sqlQuery = "SELECT tb_SFProcucts.productID, tb_SFProcucts.productName, tb_SFProcucts.quantity as available, tb_SFProcucts.isBussiness, ISNULL(thongke.totalBuyedInMonth,0) AS 'Total Buyed' "
                + "FROM tb_SFProcucts LEFT JOIN ("
                + "SELECT t.productID, SUM(t.totalBuyed) as totalBuyedInMonth "
                + "FROM( SELECT tb_AgentInvoiceDetail.productID, ISNULL(SUM(tb_AgentInvoiceDetail.quantity),0) as totalBuyed "
                + "FROM tb_AgentInvoiceDetail INNER JOIN tb_AgentInvoices "
                + "ON tb_AgentInvoiceDetail.invoiceID = tb_AgentInvoices.invoiceID "
                + "WHERE MONTH(tb_AgentInvoices.OrderDate)=@monthSearch AND YEAR(tb_AgentInvoices.OrderDate)=@yearSearch "
                + "AND tb_AgentInvoices.status='payment success' "
                + "GROUP BY tb_AgentInvoiceDetail.productID "
                + "UNION "
                + "SELECT tb_CustomerInvoiceDetail.productID, ISNULL(SUM(tb_CustomerInvoiceDetail.quantity),0) as totalBuyed "
                + "FROM tb_CustomerInvoiceDetail INNER JOIN tb_CustomerInvoices "
                + "ON tb_CustomerInvoiceDetail.invoiceID = tb_CustomerInvoices.invoiceID "
                + "WHERE MONTH(tb_CustomerInvoices.OrderDate)=@monthSearch AND YEAR(tb_CustomerInvoices.OrderDate)=@yearSearch "
                + "AND tb_CustomerInvoices.status='payment success' "
                + "GROUP BY tb_CustomerInvoiceDetail.productID) t "
                + "GROUP BY t.productID) thongke "
                + "ON tb_SFProcucts.productID=thongke.productID "
                + "ORDER BY thongke.totalBuyedInMonth DESC";

            cmd = new SqlCommand(sqlQuery, MyConnection);
            cmd.Parameters.AddWithValue("@monthSearch", monthSearch);
            cmd.Parameters.AddWithValue("@yearSearch", yearSearch);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableRevenue);

            dataGridViewRevenue.DataSource = dataTableRevenue;

            MyConnection.Close();
        }

        private void btnRebusiness_Click(object sender, EventArgs e)
        {
            if(rowIndex>=0)
            {
                String productID = dataGridViewRevenue.Rows[rowIndex].Cells["productID"].Value.ToString();

                SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

                MyConnection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = MyConnection;
                cmd.CommandText = "UPDATE tb_SFProcucts SET tb_SFProcucts.isBussiness='on' WHERE tb_SFProcucts.productID=@productID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.ExecuteNonQuery();

                MyConnection.Close();
            } else
            {
                MessageBox.Show("Please choice item!");
            }

            radioButtonAllTimeSearch.Checked = false;
            radioButtonAllTimeSearch.Checked = true;

        }
        private void btnStopBusiness_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0)
            {
                String productID = dataGridViewRevenue.Rows[rowIndex].Cells["productID"].Value.ToString();

                SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

                MyConnection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = MyConnection;
                cmd.CommandText = "UPDATE tb_SFProcucts SET tb_SFProcucts.isBussiness='stop' WHERE tb_SFProcucts.productID=@productID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.ExecuteNonQuery();

                MyConnection.Close();
            }
            else
            {
                MessageBox.Show("Please choice item!");
            }

            radioButtonAllTimeSearch.Checked = false;
            radioButtonAllTimeSearch.Checked = true;
        }

        private void radioButtonAllTimeSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAllTimeSearch.Checked)
            {
                textBoxMonthSearch.Text = "";
                textBoxYearSearch.Text = "";
                SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                MyConnection.Open();


                String sqlQuery = "SELECT SUM(t.totalAmount) as totalBuyedInMonth "
                    + "FROM ("
                    + "SELECT ISNULL(SUM(tb_AgentInvoiceDetail.quantity*tb_AgentInvoiceDetail.agentPrice),0) as totalAmount "
                    + "FROM tb_AgentInvoiceDetail INNER JOIN tb_AgentInvoices "
                    + "ON tb_AgentInvoiceDetail.invoiceID = tb_AgentInvoices.invoiceID "
                    + "AND tb_AgentInvoices.status='payment success' "
                    + "UNION "
                    + "SELECT ISNULL(SUM(tb_CustomerInvoiceDetail.quantity*tb_CustomerInvoiceDetail.agentPrice),0) as totalAmount "
                    + "FROM tb_CustomerInvoiceDetail INNER JOIN tb_CustomerInvoices "
                    + "ON tb_CustomerInvoiceDetail.invoiceID = tb_CustomerInvoices.invoiceID "
                    + "AND tb_CustomerInvoices.status='payment success' "
                    + ") t";

                SqlCommand cmd = new SqlCommand(sqlQuery, MyConnection);

                labelTotalRevenueArea.Text = cmd.ExecuteScalar().ToString() + "VND";
                MyConnection.Close();

                dataTableRevenue.Clear();

                MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                MyConnection.Open();


                sqlQuery = "SELECT tb_SFProcucts.productID, tb_SFProcucts.productName, tb_SFProcucts.quantity as available, tb_SFProcucts.isBussiness, ISNULL(thongke.totalBuyedInMonth,0) AS 'Total Buyed' "
                    + "FROM tb_SFProcucts LEFT JOIN ("
                    + "SELECT t.productID, SUM(t.totalBuyed) as totalBuyedInMonth "
                    + "FROM(SELECT tb_AgentInvoiceDetail.productID, ISNULL(SUM(tb_AgentInvoiceDetail.quantity),0) as totalBuyed "
                    + "FROM tb_AgentInvoiceDetail INNER JOIN tb_AgentInvoices "
                    + "ON tb_AgentInvoiceDetail.invoiceID = tb_AgentInvoices.invoiceID "
                    + "AND tb_AgentInvoices.status='payment success' "
                    + "GROUP BY tb_AgentInvoiceDetail.productID "
                    + "UNION "
                    + "SELECT tb_CustomerInvoiceDetail.productID, ISNULL(SUM(tb_CustomerInvoiceDetail.quantity),0) as totalBuyed "
                    + "FROM tb_CustomerInvoiceDetail INNER JOIN tb_CustomerInvoices "
                    + "ON tb_CustomerInvoiceDetail.invoiceID = tb_CustomerInvoices.invoiceID "
                    + "AND tb_CustomerInvoices.status='payment success' "
                    + "GROUP BY tb_CustomerInvoiceDetail.productID) t "
                    + "GROUP BY t.productID) thongke "
                    + "ON tb_SFProcucts.productID=thongke.productID "
                    + "ORDER BY thongke.totalBuyedInMonth DESC";

                cmd = new SqlCommand(sqlQuery, MyConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTableRevenue);

                dataGridViewRevenue.DataSource = dataTableRevenue;

                MyConnection.Close();

            } 
        }

        private void dataGridViewRevenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
