using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp
{
    public partial class ImportForm : Form
    {
        private SqlConnection MyConnection;
        private String accountantID;
        private String accountantName;
        DataTable dataTableDetail = new DataTable();

        public ImportForm(String accountantID, String accountantName)
        {
            InitializeComponent();
            this.accountantID = accountantID;
            this.accountantName = accountantName;
            labelAccountantName.Text = this.accountantName;
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        }

        private void buttonNewInvoice_Click(object sender, EventArgs e)
        {
            showEnterImportDetailTable(textBoxInvoiceID.Text);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataTableDetail.Rows.Count == 0)
            {
                MessageBox.Show("Please Fill Detail");
            } else
            {
                Boolean CreatedInvoice = false;
                MyConnection.Open();
                for (int i = 0; i < dataTableDetail.Rows.Count; i++)
                {
                    int invoiceDetailID = Convert.ToInt32(dataTableDetail.Rows[i]["invoiceDetailID"]);
                    String productID = Convert.ToString(dataTableDetail.Rows[i]["productID"]);
                    int quantity = Convert.ToInt32(dataTableDetail.Rows[i]["quantity"]);
                    int importPrice = Convert.ToInt32(dataTableDetail.Rows[i]["importPrice"]);


                    String querySQL = "SELECT quantity FROM tb_SFProcucts WHERE productID = '" + productID + "'";

                    SqlCommand cmd1 = new SqlCommand(querySQL, MyConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd1);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    int storeQuantity = 0;
                    if (dataTable.Rows.Count > 0)
                    {
                        storeQuantity = Convert.ToInt32(dataTable.Rows[0]["quantity"]);
                    }

                    storeQuantity += quantity;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = MyConnection;
                    cmd.CommandText = "UPDATE tb_SFProcucts SET quantity ='" + storeQuantity + "' WHERE productID = '" + productID + "'";
                    cmd.Parameters.Clear();
                    cmd.ExecuteNonQuery();

                    if(!CreatedInvoice)
                    {
                        cmd.Connection = MyConnection;
                        cmd.CommandText = "INSERT INTO [tb_ImportInvoices](invoiceID,OrderDate,accountantID)" +
                           "Values(@invoiceID,@OrderDate,@accountantID)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@invoiceID", textBoxInvoiceID.Text);
                        cmd.Parameters.AddWithValue("@OrderDate", dateTimePickerImport.Value);
                        cmd.Parameters.AddWithValue("@accountantID", this.accountantID);
                        cmd.ExecuteNonQuery();

                        CreatedInvoice = true;
                    }
                    

                    cmd.Connection = MyConnection;
                    cmd.CommandText = "INSERT INTO [tb_ImportInvoiceDetail](invoiceDetailID,invoiceID,productID,quantity,importPrice)" +
                       "Values(@invoiceDetailID,@invoiceID,@productID,@quantity,@importPrice)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@invoiceDetailID", invoiceDetailID);
                    cmd.Parameters.AddWithValue("@invoiceID", textBoxInvoiceID.Text);
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@importPrice", importPrice);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Successfull");
                MyConnection.Close();
            }
            String InvoiceID = textBoxInvoiceID.Text;
            ImportReport rp = new ImportReport(InvoiceID, accountantName);
            textBoxInvoiceID.Text = "";
            showEnterImportDetailTable(textBoxInvoiceID.Text);
            rp.ShowDialog();
        }

        void showEnterImportDetailTable(string invoiceID)
        {
            MyConnection.Open();

            String querySQL = "SELECT invoiceDetailID, productID, quantity, importPrice, quantity*importPrice as Total FROM [tb_ImportInvoiceDetail] WHERE invoiceID='defaultToShow'";

            SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTableDetail);
            
            dataGridViewImport.DataSource = dataTableDetail;

            MyConnection.Close();
        }

        private void dataGridViewImport_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewImport.Rows[e.RowIndex].Cells["quantity"].Value != null)
                {
                    double count = Convert.ToDouble(dataGridViewImport.Rows[e.RowIndex].Cells["quantity"].Value);
                    double price = Convert.ToDouble(dataGridViewImport.Rows[e.RowIndex].Cells["importPrice"].Value);
                    double total = count * price;
                    dataGridViewImport.Rows[e.RowIndex].Cells["Total"].Value = total;

                    double TotalInvoice = 0;
                    for (int i = 0; i < dataTableDetail.Rows.Count; i++)
                    {
                        double countEachProduct = Convert.ToDouble(dataTableDetail.Rows[i]["quantity"]);
                        double priceEachProduct = Convert.ToDouble(dataTableDetail.Rows[i]["importPrice"]);
                        TotalInvoice += countEachProduct * priceEachProduct;
                    }
                    labelTotalPriceArea.Text = String.Format("{0:C}", TotalInvoice) + " VND";
                }
               
                
            } catch (Exception)
            {

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelTitleImport_Click(object sender, EventArgs e)
        {

        }
    }
}
