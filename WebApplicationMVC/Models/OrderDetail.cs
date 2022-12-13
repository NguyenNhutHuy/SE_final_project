using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class OrderDetail
    {
        public String productID { get; set; } 
        public String productName { get; set; }
        public String productImage { get; set; }
        public int orderPrice { get; set; }
        public int orderQuantity { get; set; }
        public int total { get; set; }
    }
}