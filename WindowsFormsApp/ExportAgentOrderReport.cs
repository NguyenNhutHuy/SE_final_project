using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ExportAgentOrderReport : Form
    {
        private String invoiceID;
        private String address;
        private String accountantName;
        private String phoneNumberAgent;
        private SqlConnection MyConnection;
        DataTable dataTableDetail = new DataTable();

        public ExportAgentOrderReport(String invoiceID, String address, String accountantName,String phoneNumberAgent)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
            this.address = address;
            this.accountantName = accountantName;
            this.phoneNumberAgent = phoneNumberAgent;
        }

        private void ExportAgentOrderReport_Load(object sender, EventArgs e)
        {
            this.reportViewerAgentOrder.RefreshReport();

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            reportViewerAgentOrder.LocalReport.ReportEmbeddedResource = "WindowsFormsApp.ReportExportAgentOrder.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataTable1";

            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("address", "Address: " + address);
            parameters[1] = new ReportParameter("dateExport", "" + DateTime.Now.ToString());
            parameters[2] = new ReportParameter("accountName", accountantName);
            parameters[3] = new ReportParameter("phoneNumberAgent", "Agent contact: " + phoneNumberAgent);


            this.reportViewerAgentOrder.LocalReport.SetParameters(parameters);

            MyConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "SELECT invoiceID, invoiceDetailID, [tb_AgentInvoiceDetail].productID, [tb_SFProcucts].productName, [tb_AgentInvoiceDetail].quantity, agentPrice FROM[tb_AgentInvoiceDetail] INNER JOIN[tb_SFProcucts] ON[tb_AgentInvoiceDetail].productID =[tb_SFProcucts].productID WHERE invoiceID=@invoiceID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTableDetail);
            if (dataTableDetail.Rows.Count > 0)
            {
                reportDataSource.Value = dataTableDetail;
                reportViewerAgentOrder.LocalReport.DataSources.Add(reportDataSource);
            }
            else
            {
                MessageBox.Show("No data");
            }

            this.reportViewerAgentOrder.RefreshReport();

            MyConnection.Close();

            this.reportViewerAgentOrder.RefreshReport();
        }
    }
}

