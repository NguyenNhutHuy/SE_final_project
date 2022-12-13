using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class ProductClass
    {
        public String productID { get; set; }
        public String productName { get; set; }
        public String productImage { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public String unit { get; set; }
    }
}