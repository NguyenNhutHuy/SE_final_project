using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class CartDetail
    {
        public String productID { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
    }
}