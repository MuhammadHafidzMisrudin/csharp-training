﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReactAspx.Models
{
    // Class to create Order table in the backend database table.
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPaid { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
    }
}