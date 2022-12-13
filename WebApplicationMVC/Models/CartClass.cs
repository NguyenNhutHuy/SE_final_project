using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Models
{
    public class CartClass
    {
        public String phoneNumber { get; set; }
        public String address { get; set; }
        public String paymentMethod { get; set; }
        public CartDetail[] CartDetails { get; set; }

        public int NumberAgentOrder ()
        {
            using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                MyConnection.Open();

                String querySQL = "SELECT * FROM tb_AgentInvoices";
                SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                MyConnection.Close();

                return dataTable.Rows.Count;
            }

        }

        public Boolean CreateNewOrder(String invoiceID, DateTime OrderDate, String agentID, String payment, String address, String phoneNumber, String status)
        {
            using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                MyConnection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = MyConnection;
                cmd.CommandText = "INSERT INTO [tb_AgentInvoices](invoiceID,OrderDate,agentID,payment,address, phoneNumberAgent, status)" +
                           "VALUES(@invoiceID,@OrderDate,@agentID,@payment,@address, @phoneNumberAgent, @status)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
                cmd.Parameters.AddWithValue("@agentID", agentID);
                cmd.Parameters.AddWithValue("@payment", payment);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNumberAgent", phoneNumber);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();

                MyConnection.Close();
                return true;
            }
                
        }

        public Boolean CreateDetailOrder(String invoiceID)
        {
            using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                MyConnection.Open();

                for (int i = 0; i < CartDetails.Length; i++)
                {

                    UpdateMinusProduct(CartDetails[i].productID, CartDetails[i].quantity);

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = MyConnection;
                    cmd.CommandText = "INSERT INTO [tb_AgentInvoiceDetail](invoiceDetailID,quantity,agentPrice,invoiceID,productID)" +
                          "VALUES(@invoiceDetailID,@quantity,@agentPrice,@invoiceID,@productID)";
                    cmd.Parameters.AddWithValue("@invoiceDetailID", i + 1);
                    cmd.Parameters.AddWithValue("@quantity", CartDetails[i].quantity);
                    cmd.Parameters.AddWithValue("@agentPrice", CartDetails[i].price);
                    cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                    cmd.Parameters.AddWithValue("@productID", CartDetails[i].productID);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                }

                MyConnection.Close();
                return true;
            }
           
        }

        public Boolean UpdateMinusProduct(String productID, int quantity)
        {
            using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                MyConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = MyConnection;
                cmd.CommandText = "UPDATE tb_SFProcucts "
                            + "SET tb_SFProcucts.quantity= tb_SFProcucts.quantity - @quantity "
                            + "WHERE tb_SFProcucts.productID=@productID";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.ExecuteNonQuery();

                MyConnection.Close();
                return true;
            }

        }
    }
}