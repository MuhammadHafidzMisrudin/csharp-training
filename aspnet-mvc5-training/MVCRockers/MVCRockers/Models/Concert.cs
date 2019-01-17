using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRockers.Models
{
    public class Concert
    {
        // Add properties for Concert model class.
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime ConcertDate { get; set; }
        public int Tickets { get; set; }
        public double Price { get; set; }
    }
}