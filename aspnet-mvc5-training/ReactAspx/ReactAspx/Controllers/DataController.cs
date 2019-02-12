using ReactAspx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactAspx.Controllers
{
    public class DataController : Controller
    {
        // Variable list to store the Food items.
        public IList<FoodItem> menuItems;
        
        // GET: Data (Food items in the menu list as a JSON data).
        [HttpGet]
        public ActionResult GetMenuList()
        {
            //return View();

            // Create a menu list for the Food items.
            menuItems = new List<FoodItem>();
            using (var db = new AppDbContext())
            {
                // Iterate through the Food items, and add them to menuItems list.
                foreach (var f in db.FoodItems)
                {
                    menuItems.Add(f);
                }
            }

            // Retrieve all menu items in the list, return as a JSON data.
            // Check browser: http://localhost:57805/Data/GetMenuList
            return Json(menuItems, JsonRequestBehavior.AllowGet);
        }

        // Method to get the User Id. Return user id.
        [HttpGet]
        public string GetUserId()
        {
            // Initialise a variable for user id.
            int uid = -1;

            // Check if session user id is null or not.
            // If the user has signed in, the session of user id will not be null. Returns the User id.
            // Otherwise return -1.
            if (Session["UserId"] != null)
            {
                uid = Convert.ToInt32(Session["UserId"].ToString());
            }

            // Check browser: http://localhost:57805/data/GetUserId
            return uid.ToString();
        }

        // Method to place an order.
        [HttpPost]
        public ActionResult PlaceOrder(IList<FoodItem> items, int id)
        {
            // Flag to indicate whether the Order has been place successfully.
            bool dbSuccess = false;
        
            try
            {
                using (var db = new AppDbContext())
                {
                    // Create a new Order.
                    Order order = new Order();
                    order.CustomerId = id;
                    order.OrderDate = DateTime.Now;

                    // Add the Order to the Order tables.
                    db.Orders.Add(order);

                    // Save the Order.
                    db.SaveChanges();

                    // Create variables for OrderDetail.
                    int orderId = order.Id;
                    decimal grandTotalPrice = 0;

                    // Add food items OrderDetail table. 
                    foreach (var food in items)
                    {
                        // Create a new OrderDetail.
                        OrderDetail orderDetail = new OrderDetail
                        {
                            OrderId = orderId,
                            FoodItemId = food.Id,
                            Quantity = food.Quantity,
                            TotalPrice = food.Price * food.Quantity
                        };

                        // Add orderDetail to the OrderDetail table.
                        db.OrderDetails.Add(orderDetail);

                        // The total amount that customer needs to pay.
                        grandTotalPrice += orderDetail.TotalPrice;
                    }

                    // Update the total paid price for the Order.
                    order.TotalPaid = grandTotalPrice;
                    order.Status = 1;
                    order.OrderDate = DateTime.Now;

                    // Save the database.
                    db.SaveChanges();

                    // Order has been placed successfully.
                    dbSuccess = true;
                }
            }
            catch (Exception err)
            {
                // log err.
                dbSuccess = false;
            }

            // If successful, returns json string format.
            if (dbSuccess)
                return Json("success = true", JsonRequestBehavior.AllowGet);
            else
                return Json("success = false", JsonRequestBehavior.AllowGet);
        }
    }
}