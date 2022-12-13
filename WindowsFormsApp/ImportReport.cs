using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
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
    public partial class ImportReport : Form
    {
        private String invoiceID;
        private String accountantName;
        private SqlConnection MyConnection;
        DataTable dataTableDetail = new DataTable();

        public ImportReport(String invoiceID, String accountantName)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
            this.accountantName = accountantName;
        }

        private void ImportReport_Load(object sender, EventArgs e)
        {
            this.importReportViewer.RefreshReport();

            importReportViewer.LocalReport.ReportEmbeddedResource = "WindowsFormsApp.ReportImport.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "tb_ImportInvoiceDetail";

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("dateImport", "" + DateTime.Now.ToString());
            parameters[1] = new ReportParameter("accountName", accountantName);


            this.importReportViewer.LocalReport.SetParameters(parameters);

            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

            MyConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "SELECT * FROM [tb_ImportInvoiceDetail] WHERE invoiceID=@invoiceID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTableDetail);

            if (dataTableDetail.Rows.Count > 0)
            {
                reportDataSource.Value = dataTableDetail;
                importReportViewer.LocalReport.DataSources.Add(reportDataSource);
            }
            else
            {
                MessageBox.Show("No data");
            }

            this.importReportViewer.RefreshReport();

            MyConnection.Close();

            this.importReportViewer.RefreshReport();
        }

        private void importReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
