using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;
using System.Data;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
       /* SqlConnection MyConnection;*/
        public ActionResult Index()
        {
            if (Session["username"] != null)
            {
                using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                {
                    String querySQL = "SELECT * FROM tb_SFProcucts WHERE quantity>0 AND isBussiness='on'";
                    SqlCommand cmd = new SqlCommand(querySQL, MyConnection);

                    var model = new List<ProductClass>();

                    MyConnection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        var product = new ProductClass();
                        product.productID = (String)rdr["productID"];
                        product.productName = (String)rdr["productName"];
                        product.productImage = (String)rdr["productImage"];
                        product.quantity = (int)rdr["quantity"];
                        product.price = (int)rdr["price"] - (int)rdr["price"]*(int)Session["agentDiscount"]/100;
                        product.unit = (String)rdr["unit"];
                        model.Add(product);
                    }
                    MyConnection.Close();
                    return View(model);
                }
            }
            else
            {
                return Redirect("UserLogin");
            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult getOrder(CartClass cartClass)
        {
            using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {


                MyConnection.Open();
                int numberAgentOrder = cartClass.NumberAgentOrder();
                String invoiceID = "AO" + "#" + (numberAgentOrder + 1);

                Boolean createNewOrder = cartClass.CreateNewOrder(invoiceID, DateTime.Now, Session["agentID"].ToString(), cartClass.paymentMethod, cartClass.address, Session["phoneNumber"].ToString(), "waiting confirm");

                Boolean CreateDetailOrder = cartClass.CreateDetailOrder(invoiceID);

                if (createNewOrder && CreateDetailOrder)
                {
                    Session["orderSuccess"] = true;

                }

                MyConnection.Close();
                return Json(Session["agentID"].ToString(), JsonRequestBehavior.AllowGet);
            } 
           
        }   

        [HttpGet]
        public ActionResult Logout()
        {
            Session["username"] = null;
            return Redirect("/UserLogin");
        }


        public ActionResult orderSuccess()
        {
            if (Session["orderSuccess"] != null)
            {
                Session["orderSuccess"] = null;
                return View();
            }
            else
            {
                return Redirect("/");

            }
        }

        public ActionResult OrderList(OrderClass orderClass)
        {
            if (Session["username"] != null)
            {
                using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                {
                    String querySQL = "SELECT * FROM tb_AgentInvoices WHERE agentID='" + Session["agentID"].ToString() + "' ORDER BY OrderDate DESC";

                    
                    SqlCommand cmd = new SqlCommand(querySQL, MyConnection);

                    var model = new List<OrderClass>();

                    MyConnection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        var order = new OrderClass();
                        order.OrderID = (String)rdr["invoiceID"];
                        order.OrderDate = String.Format("{0:dd/MM/yyyy}", rdr["OrderDate"]);
                        order.NumberOfItems = orderClass.GetNumberOfItems((String)rdr["invoiceID"]);
                        order.Total = orderClass.GetTotal((String)rdr["invoiceID"]);
                        order.State = (String)rdr["status"];
                        model.Add(order);
                    }
                    MyConnection.Close();
                    return View(model);
                }
                

            } 
            else
            {
                return Redirect("/UserLogin");
            }
        }

        [HttpPost]
        public ActionResult GetOrderDetail(String invoiceID)
        {
            if (Session["username"] != null)
            {
                using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                {
                    String querySQL = "SELECT *, tb_AgentInvoiceDetail.quantity as orderQuantity  FROM tb_AgentInvoiceDetail INNER JOIN tb_SFProcucts ON tb_AgentInvoiceDetail.productID=tb_SFProcucts.productID WHERE invoiceID='" + invoiceID + "'";
                    SqlCommand cmd = new SqlCommand(querySQL, MyConnection);

                    var model = new List<OrderDetail>();

                    MyConnection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.productID = (String)rdr["productID"];
                        orderDetail.productName = (String)rdr["productName"];
                        orderDetail.productImage = (String)rdr["productImage"];
                        orderDetail.orderPrice = (int)rdr["agentPrice"];
                        orderDetail.orderQuantity = (int)rdr["orderQuantity"];
                        orderDetail.total = (int)rdr["agentPrice"] * (int)rdr["orderQuantity"];

                        model.Add(orderDetail);

                    }
                    MyConnection.Close();

                    return Json(model.ToList(), JsonRequestBehavior.AllowGet);

                } 
                
            }
            else
            {
                return Json("", JsonRequestBehavior.DenyGet);
            }
        }
    }
}