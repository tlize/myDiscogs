using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using myDiscogs.Data;
using myDiscogs.DiscogsApi;
using myDiscogs.Models;
using Newtonsoft.Json;

namespace myDiscogs.Controllers
{
    public class CollectionValuesController : Controller
    {
        private myDiscogsContext db = new myDiscogsContext();
        private DiscogsClient client = new DiscogsClient();

        // GET: CollectionValues
        public ActionResult Index()
        {
            var valueData = client.GetCollectionValue();
            var value = JsonConvert.DeserializeObject<CollectionValue>(valueData);

            return View(new List<CollectionValue> { value});
        }

        // GET: CollectionValues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollectionValue collectionValue = db.CollectionValues.Find(id);
            if (collectionValue == null)
            {
                return HttpNotFound();
            }
            return View(collectionValue);
        }

        // GET: CollectionValues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CollectionValues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Maximum,Median,Minimum")] CollectionValue collectionValue)
        {
            if (ModelState.IsValid)
            {
                db.CollectionValues.Add(collectionValue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(collectionValue);
        }

        // GET: CollectionValues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollectionValue collectionValue = db.CollectionValues.Find(id);
            if (collectionValue == null)
            {
                return HttpNotFound();
            }
            return View(collectionValue);
        }

        // POST: CollectionValues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Maximum,Median,Minimum")] CollectionValue collectionValue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(collectionValue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(collectionValue);
        }

        // GET: CollectionValues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollectionValue collectionValue = db.CollectionValues.Find(id);
            if (collectionValue == null)
            {
                return HttpNotFound();
            }
            return View(collectionValue);
        }

        // POST: CollectionValues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CollectionValue collectionValue = db.CollectionValues.Find(id);
            db.CollectionValues.Remove(collectionValue);
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
