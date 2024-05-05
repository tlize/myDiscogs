using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.WebPages;
using myDiscogs.Data;
using myDiscogs.DiscogsApi;
using myDiscogs.Models.Collection;
using myDiscogs.Models.Orders;
using Newtonsoft.Json;

namespace myDiscogs.Controllers
{
    public class OrdersController : Controller
    {
        private myDiscogsContext db = new myDiscogsContext();
        private DiscogsClient client = new DiscogsClient();

        // GET: Orders
        public ActionResult Index()
        {
            int page = (Request.QueryString["page"] != null && Request.QueryString["page"] != string.Empty) ? Request.QueryString["page"].AsInt() : 1;

            var ordersData = client.GetOrders(page);
            var orders = JsonConvert.DeserializeObject<PaginatedOrders>(ordersData);

            return View(orders);
        }

        // GET: Orders/Details/5
        public ActionResult Details(string id)
        {
            var orderData = client.GetOrder(id);
            var order = JsonConvert.DeserializeObject<Order>(orderData);
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ResourceUrl,Uri,MessagesUrl,Created,LastActivity,Status,Total,Shipping,ShippingAddress,Archived,AdditionalInstructions,Fee,Tracking")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ResourceUrl,Uri,MessagesUrl,Created,LastActivity,Status,Total,Shipping,ShippingAddress,Archived,AdditionalInstructions,Fee,Tracking")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
