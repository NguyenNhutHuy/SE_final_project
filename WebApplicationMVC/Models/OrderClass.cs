using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class OrderClass
    {
        public String OrderID {set; get;}
        public String OrderDate {set; get;}
        public int NumberOfItems { set; get;}
        public int Total { set; get; }
        public String State { set; get; }    

        public int GetTotal(String invoiceID)
        {
            using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                MyConnection.Open();
                String querySQL = "SELECT SUM(quantity*agentPrice) FROM tb_AgentInvoiceDetail WHERE invoiceID=@invoiceID";

                String tesst = invoiceID;

                SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int GetNumberOfItems(String invoiceID)
        {
            using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                MyConnection.Open();
                String querySQL = "SELECT COUNT(invoiceDetailID) FROM tb_AgentInvoiceDetail WHERE invoiceID=@invoiceID";

                SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
           
        }
    }
}