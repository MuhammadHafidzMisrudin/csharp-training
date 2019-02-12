using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactAspx.Models
{
    // Class to create OrderDetail table in the backend database table.
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int FoodItemId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Comment { get; set; }
    }
}