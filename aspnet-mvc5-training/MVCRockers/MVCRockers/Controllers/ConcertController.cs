using MVCRockers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    public class ConcertController : Controller
    {
        // Add the object initializer with an instance and its properties.
        Concert concert = new Concert() { Name = "TestData Concert", Price = 1.00, Tickets = 10, City = "New York", ConcertDate = DateTime.UtcNow };

        // GET: Concert
        public ActionResult Index()
        {
            return View(concert);
        }

        // Add Edit method to data.
        public ActionResult Edit()
        {
            return View(concert);
        }
    }
}