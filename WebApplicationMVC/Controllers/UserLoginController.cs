using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models; 

namespace WebApplicationMVC.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginClass lc)
        {
            using (SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                String querySQL = "SELECT agentID, agentName, address, phoneNumber, agentDiscountPercent FROM tb_Agents WHERE username=@username and password=@password";

                MyConnection.Open();
                SqlCommand cmd = new SqlCommand(querySQL, MyConnection);
                cmd.Parameters.Clear();
                Debug.WriteLine("My debug string here");
                cmd.Parameters.AddWithValue("@username", lc.Username);
                cmd.Parameters.AddWithValue("@password", lc.Password);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    Session["agentID"] = (String)sdr["agentID"];
                    Session["agentDiscount"] = (int)sdr["agentDiscountPercent"];
                    Session["address"] = (String)sdr["address"];
                    Session["phoneNumber"] = (String)sdr["phoneNumber"];
                    Session["username"] = lc.Username.ToString();
                    return Redirect("/Home");
                }
                else
                {
                    ViewData["Message"] = "User Login Detail Failed";
                }

                MyConnection.Close();
                return View();
            }
           
        }
    }
}